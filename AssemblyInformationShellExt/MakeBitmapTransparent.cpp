// Adapted from https://www.codeproject.com/Answers/1228266/Windows-shell-extension

#include "stdafx.h"

HBITMAP MakeBitmapTransparent(HBITMAP hbmSrc)
{
    HDC hdcSrc, hdcDst;
    HBITMAP hbmOld, hbmNew;
    BITMAP bm;
    COLORREF clrTP, clrBK;

    hdcSrc = CreateCompatibleDC(NULL);
    hdcDst = CreateCompatibleDC(NULL);

    int nRow, nCol;
    GetObject(hbmSrc, sizeof(bm), &bm);
    hbmOld = (HBITMAP)SelectObject(hdcSrc, hbmSrc);
    hbmNew = CreateBitmap(bm.bmWidth, bm.bmHeight, bm.bmPlanes, bm.bmBitsPixel, NULL);
    SelectObject(hdcDst, hbmNew);

    BitBlt(hdcDst,0,0,bm.bmWidth, bm.bmHeight,hdcSrc,0,0,SRCCOPY);

    clrTP = RGB(255, 0, 255); // Use magenta as the color to make transparent
    clrBK = GetSysColor(COLOR_MENU); // Get the current background color of the menu

    for (nRow = 0; nRow < bm.bmHeight; nRow++) // Work our way through all the pixels changing their color
        for (nCol = 0; nCol < bm.bmWidth; nCol++) // When we hit the set transparency color
            if (GetPixel(hdcDst, nCol, nRow) == clrTP)
                SetPixel(hdcDst, nCol, nRow, clrBK);

    DeleteObject(hbmOld);
    DeleteObject(hbmSrc);
    DeleteDC(hdcDst);
    DeleteDC(hdcSrc);

    return hbmNew; // Return the transformed bitmap
}