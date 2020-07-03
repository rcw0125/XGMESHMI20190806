// RHMag.h : RHMag DLL 的主头文件
//

#pragma once

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// 主符号


// CRHMagApp
// 有关此类实现的信息，请参阅 RHMag.cpp
//

class CRHMagApp : public CWinApp
{
public:
	CRHMagApp();

// 重写
public:
	virtual BOOL InitInstance();

	DECLARE_MESSAGE_MAP()
};


DECLARE_L3COMPONENT(RHMag,{39e41f19-4e01-413e-856b-867351a3c346})

