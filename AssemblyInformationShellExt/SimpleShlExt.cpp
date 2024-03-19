// SimpleShlExt.cpp : Implementation of CSimpleShlExt

#include <windows.h>
#include "stdafx.h"
#include "resource.h"
#include "SimpleExt.h"
#include "SimpleShlExt.h"

/////////////////////////////////////////////////////////////////////////////
// CSimpleShlExt

// CSimpleShlExt construction/destruction
CSimpleShlExt::CSimpleShlExt()
{
    OSVERSIONINFO OSVersionInfo;
    OSVersionInfo.dwOSVersionInfoSize = sizeof(OSVERSIONINFO);
    GetVersionEx(&OSVersionInfo);

    m_hIconBmp = LoadBitmap ( _Module.GetModuleInstance(),
        MAKEINTRESOURCE(OSVersionInfo.dwMajorVersion < 6 ? IDB_ICONSMALLBMP : IDB_ICONLARGEBMP) );
    m_hIconBmp = MakeBitmapTransparent(m_hIconBmp);
}

CSimpleShlExt::~CSimpleShlExt()
{
    DeleteObject(m_hIconBmp);
}

STDMETHODIMP CSimpleShlExt::Initialize (
    LPCITEMIDLIST pidlFolder, LPDATAOBJECT pDataObj, HKEY hProgID )
{
    FORMATETC fmt = { CF_HDROP, NULL, DVASPECT_CONTENT, -1, TYMED_HGLOBAL };
    STGMEDIUM stg = { TYMED_HGLOBAL };
    HDROP     hDrop;

    // Look for CF_HDROP data in the data object.
    if ( FAILED( pDataObj->GetData ( &fmt, &stg ) ))
    {
        // Nope! Return an "invalid argument" error back to Explorer.
        return E_INVALIDARG;
    }

    // Get a pointer to the actual data.
    hDrop = (HDROP) GlobalLock ( stg.hGlobal );

    // Make sure it worked.
    if ( NULL == hDrop )
        return E_INVALIDARG;

    // Sanity check - make sure there is at least one filename.
    UINT uNumFiles = DragQueryFile ( hDrop, 0xFFFFFFFF, NULL, 0 );
    HRESULT hr = S_OK;

    if ( 0 == uNumFiles )
    {
        GlobalUnlock ( stg.hGlobal );
        ReleaseStgMedium ( &stg );
        return E_INVALIDARG;
    }

    // Get the name of the first file and store it in our member variable m_szFile.
    if ( 0 == DragQueryFile ( hDrop, 0, m_szFile, MAX_PATH ) )
        hr = E_INVALIDARG;

    GlobalUnlock ( stg.hGlobal );
    ReleaseStgMedium ( &stg );

    return hr;
}

STDMETHODIMP CSimpleShlExt::QueryContextMenu (
    HMENU hmenu, UINT uMenuIndex, UINT uidFirstCmd,
    UINT uidLastCmd, UINT uFlags )
{
    // If the flags include CMF_DEFAULTONLY then we shouldn't do anything.
    if ( uFlags & CMF_DEFAULTONLY )
        return MAKE_HRESULT ( SEVERITY_SUCCESS, FACILITY_NULL, 0 );

    InsertMenu ( hmenu, uMenuIndex, MF_BYPOSITION, uidFirstCmd, MenuItemText );

    // Set the menu item's icon.
    SetMenuItemBitmaps ( hmenu, uMenuIndex, MF_BYPOSITION, m_hIconBmp, NULL );

    return MAKE_HRESULT ( SEVERITY_SUCCESS, FACILITY_NULL, 1 );
}

STDMETHODIMP CSimpleShlExt::GetCommandString (
    UINT_PTR idCmd, UINT uFlags, UINT* pwReserved, LPSTR pszName, UINT cchMax )
{
    USES_CONVERSION;

    // Check idCmd, it must be 0 since we have only one menu item.
    if ( 0 != idCmd )
        return E_INVALIDARG;

    // If Explorer is asking for a help string, copy our string into the
    // supplied buffer.
    if ( uFlags & GCS_HELPTEXT )
    {
        if ( uFlags & GCS_UNICODE )
        {
            // We need to cast pszName to a Unicode string, and then use the
            // Unicode string copy API.
            lstrcpynW ( (LPWSTR) pszName, T2CW(HelpText), cchMax );
        }
        else
        {
            // Use the ANSI string copy API to return the help string.
            lstrcpynA ( pszName, T2CA(HelpText), cchMax );
        }

        return S_OK;
    }

    return E_INVALIDARG;
}

HMODULE GetCurrentModule()
{
    HMODULE hModule;
    GetModuleHandleExA_new(GET_MODULE_HANDLE_EX_FLAG_FROM_ADDRESS, (LPCSTR)GetCurrentModule, &hModule);
    return hModule;
}

STDMETHODIMP CSimpleShlExt::InvokeCommand ( LPCMINVOKECOMMANDINFO pCmdInfo )
{
    // If lpVerb really points to a string, ignore this function call and bail out.
    if ( 0 != HIWORD( pCmdInfo->lpVerb ) )
        return E_INVALIDARG;

    // Get the command index - the only valid one is 0.
    switch ( LOWORD( pCmdInfo->lpVerb) )
    {
        case 0:
        {
            // Get the path of the shell extension DLL.
            TCHAR dllPath[MAX_PATH];
            GetModuleFileName(GetCurrentModule(), dllPath, countof(dllPath));
            PathRemoveFileSpec(dllPath);

            // Set the path to the main executable.
            TCHAR exePath[MAX_PATH];
            PathCombine(exePath, dllPath, ExecutableToRun);

            // Add quotes to the path of the main executable so that it can be passed to ShellExecute.
            TCHAR exePathQuotes[MAX_PATH + 4] = _T("\"");
            #ifdef _UNICODE
            wcscat_s(exePathQuotes, exePath);
            wcscat_s(exePathQuotes, _T("\""));
            #else
            strcat_s(exePathQuotes, exePath);
            strcat_s(exePathQuotes, _T("\""));
            #endif

            // Add quotes to the path of the right-clicked file so it can be passed to ShellExecute.
            TCHAR parameters[MAX_PATH + 4] = _T("\"");
            #ifdef _UNICODE
            wcscat_s(parameters, m_szFile);
            wcscat_s(parameters, _T("\""));
            #else
            strcat_s(parameters, m_szFile);
            strcat_s(parameters, _T("\""));
            #endif

            // Launch Executable
            ShellExecute(NULL, _T("open"), exePath, parameters, NULL, SW_SHOW);

            return S_OK;
            break;
        }
        default:
        {
            return E_INVALIDARG;
            break;
        }
    }
}
