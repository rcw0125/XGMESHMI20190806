// MELTMag.h : MELTMag DLL 的主头文件
//

#pragma once

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// 主符号


// CMELTMagApp
// 有关此类实现的信息，请参阅 MELTMag.cpp
//

class CMELTMagApp : public CWinApp
{
public:
	CMELTMagApp();

// 重写
public:
	virtual BOOL InitInstance();

	DECLARE_MESSAGE_MAP()
};


DECLARE_L3COMPONENT(MELTMag,{3c08245a-0d57-4a93-ada2-b5c3ff979304})

