// ShiftTeamMag.h : ShiftTeamMag DLL ����ͷ�ļ�
//

#pragma once

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// ������


// CShiftTeamMagApp
// �йش���ʵ�ֵ���Ϣ������� ShiftTeamMag.cpp
//

class CShiftTeamMagApp : public CWinApp
{
public:
	CShiftTeamMagApp();

// ��д
public:
	virtual BOOL InitInstance();

	DECLARE_MESSAGE_MAP()
};


DECLARE_L3COMPONENT(ShiftTeamMag,{c5dcf682-1a11-400f-b133-d72c9f62deda})

