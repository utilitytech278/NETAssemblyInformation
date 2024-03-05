// stdafx.h : include file for standard system include files,
//      or project specific include files that are used frequently,
//      but are changed infrequently

#if !defined(AFX_STDAFX_H__5E2121E4_0300_11D4_8D3B_444553540000__INCLUDED_)
#define AFX_STDAFX_H__5E2121E4_0300_11D4_8D3B_444553540000__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#define STRICT
#define WINVER          0x0400
#define _WIN32_WINNT    0x0400
//#define _WIN32_IE       0x0501

#define _ATL_APARTMENT_THREADED

#include <atlbase.h>
//You may derive a class from CComModule and use it if you want to override
//something, but do not change the name of _Module
extern CComModule _Module;
#include <atlcom.h>
#include <atlconv.h>

#include <shlobj.h>
#include <comdef.h>

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

// Utility macros
#define countof(x) (sizeof(x)/sizeof((x)[0]))

// GetModuleHandleEx
#define GET_MODULE_HANDLE_EX_FLAG_FROM_ADDRESS 0x00000004
#define GET_MODULE_HANDLE_EX_FLAG_PIN 0x00000001
#define GET_MODULE_HANDLE_EX_FLAG_UNCHANGED_REFCOUNT 0x00000002
BOOL WINAPI GetModuleHandleExA_new(DWORD dwFlags, LPCSTR lpModuleName, HMODULE* phModule);
//BOOL WINAPI GetModuleHandleExW_new(DWORD dwFlags, LPCWSTR lpModuleNameW, HMODULE* phModule);
//HMODULE WINAPI GetModuleHandleW_new(LPCWSTR lpModuleNameW);

// MakeBitmapTransparent
HBITMAP MakeBitmapTransparent(HBITMAP hbmSrc);

// IContextMenu
struct __declspec(uuid("000214e4-0000-0000-c000-000000000046"))
IContextMenu;
_COM_SMARTPTR_TYPEDEF(IContextMenu, __uuidof(IContextMenu));

#endif // !defined(AFX_STDAFX_H__5E2121E4_0300_11D4_8D3B_444553540000__INCLUDED)
