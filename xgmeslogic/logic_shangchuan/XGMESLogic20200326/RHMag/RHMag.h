// RHMag.h : RHMag DLL ����ͷ�ļ�
//

#pragma once

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// ������


// CRHMagApp
// �йش���ʵ�ֵ���Ϣ������� RHMag.cpp
//

class CRHMagApp : public CWinApp
{
public:
	CRHMagApp();

// ��д
public:
	virtual BOOL InitInstance();

	DECLARE_MESSAGE_MAP()
};


DECLARE_L3COMPONENT(RHMag,{39e41f19-4e01-413e-856b-867351a3c346})

