// MELTMag.h : MELTMag DLL ����ͷ�ļ�
//

#pragma once

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// ������


// CMELTMagApp
// �йش���ʵ�ֵ���Ϣ������� MELTMag.cpp
//

class CMELTMagApp : public CWinApp
{
public:
	CMELTMagApp();

// ��д
public:
	virtual BOOL InitInstance();

	DECLARE_MESSAGE_MAP()
};


DECLARE_L3COMPONENT(MELTMag,{3c08245a-0d57-4a93-ada2-b5c3ff979304})

