// SimpleShlExt.h : Declaration of the CSimpleShlExt

#ifndef __SIMPLESHLEXT_H_
#define __SIMPLESHLEXT_H_

/////////////////////////////////////////////////////////////////////////////
// CSimpleShlExt

class ATL_NO_VTABLE CSimpleShlExt : 
    public CComObjectRootEx<CComSingleThreadModel>,
    public CComCoClass<CSimpleShlExt, &CLSID_SimpleShlExt>,
    public IShellExtInit,
    public IContextMenu
{
public:
    CSimpleShlExt();
    ~CSimpleShlExt();

    DECLARE_REGISTRY_RESOURCEID(IDR_SIMPLESHLEXT)

    BEGIN_COM_MAP(CSimpleShlExt)
        COM_INTERFACE_ENTRY(IShellExtInit)
        COM_INTERFACE_ENTRY(IContextMenu)
    END_COM_MAP()

public:
    // IShellExtInit
    STDMETHODIMP Initialize(LPCITEMIDLIST, LPDATAOBJECT, HKEY);

    // IContextMenu
    STDMETHODIMP GetCommandString(UINT_PTR, UINT, UINT*, LPSTR, UINT);
    STDMETHODIMP InvokeCommand(LPCMINVOKECOMMANDINFO);
    STDMETHODIMP QueryContextMenu(HMENU, UINT, UINT, UINT, UINT);

protected:
    TCHAR m_szFile [MAX_PATH];
    HBITMAP m_hIconBmp;
};

/////////////////////////////////////////////////////////////////////////////
// Strings

#define ExtensionName                   _T(".NET Assembly Information Shell Extension")
#define MenuItemText                    _T(".NET Assembly Information")
#define HelpText                        _T("Displays information on how the selected file was built, if it is a .NET assembly.")
#ifdef _M_X64
#define ExecutableToRun                 _T("AssemblyInformationx64.exe")
#else
#define ExecutableToRun                 _T("AssemblyInformation.exe")
#endif

#endif //__SIMPLESHLEXT_H_
