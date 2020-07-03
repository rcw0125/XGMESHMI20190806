// ShiftTeamMag.h : ShiftTeamMag DLL 的主头文件
//

#pragma once

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// 主符号


// CShiftTeamMagApp
// 有关此类实现的信息，请参阅 ShiftTeamMag.cpp
//

class CShiftTeamMagApp : public CWinApp
{
public:
	CShiftTeamMagApp();

// 重写
public:
	virtual BOOL InitInstance();

	DECLARE_MESSAGE_MAP()
};


DECLARE_L3COMPONENT(ShiftTeamMag,{c5dcf682-1a11-400f-b133-d72c9f62deda})

