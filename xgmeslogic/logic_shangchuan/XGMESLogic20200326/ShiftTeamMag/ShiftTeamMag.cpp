// ShiftTeamMag.cpp : ���� DLL �ĳ�ʼ�����̡�
//

#include "stdafx.h"
#include "ShiftTeamMag.h"
#include "_CCurrentShiftInfo.h"
#include "_CShiftMag.h"
#include "_CShiftTeamOrder.h"
#include "_CUnitOperator.h"
#include "_CUnitTimeInfo.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

//
//	ע�⣡
//
//		����� DLL ��̬���ӵ� MFC
//		DLL���Ӵ� DLL ������
//		���� MFC ���κκ����ں�������ǰ��
//		��������� AFX_MANAGE_STATE �ꡣ
//
//		����:
//
//		extern "C" BOOL PASCAL EXPORT AccessedFunction()
//		{
//			AFX_MANAGE_STATE(AfxGetStaticModuleState());
//			// �˴�Ϊ��ͨ������
//		}
//
//		�˺������κ� MFC ����
//		������ÿ��������ʮ����Ҫ������ζ��
//		��������Ϊ�����еĵ�һ�����
//		���֣������������ж������������
//		������Ϊ���ǵĹ��캯���������� MFC
//		DLL ���á�

//
//		�й�������ϸ��Ϣ��
//		����� MFC ����˵�� 33 �� 58��
//

// CShiftTeamMagApp

BEGIN_MESSAGE_MAP(CShiftTeamMagApp, CWinApp)
END_MESSAGE_MAP()


// CShiftTeamMagApp ����

CShiftTeamMagApp::CShiftTeamMagApp()
{
	// TODO: �ڴ˴���ӹ�����룬
	// ��������Ҫ�ĳ�ʼ�������� InitInstance ��
}


// Ψһ��һ�� CShiftTeamMagApp ����

CShiftTeamMagApp theApp;


// CShiftTeamMagApp ��ʼ��

BOOL CShiftTeamMagApp::InitInstance()
{
	CWinApp::InitInstance();

	return TRUE;
}

BEGIN_L3COMP_CLASSTABLE(ShiftTeamMag)
L3CLASS(CCurrentShiftInfo,XGMESLogic\\ShiftTeamMag\\CCurrentShiftInfo)
L3CLASS(CShiftMag,XGMESLogic\\ShiftTeamMag\\CShiftMag)
L3CLASS(CShiftTeamOrder,XGMESLogic\\ShiftTeamMag\\CShiftTeamOrder)
//L3CLASS(CUnitOperator,XGMESLogic\\ShiftTeamMag\\CUnitOperator) 2009-04-26
L3CLASS(CUnitTimeInfo,XGMESLogic\\ShiftTeamMag\\CUnitTimeInfo)
END_L3COMP_CLASSTABLE(ShiftTeamMag)

BEGIN_L3COMP_EVENTTABLE(ShiftTeamMag)
END_L3COMP_EVENTTABLE(ShiftTeamMag)

