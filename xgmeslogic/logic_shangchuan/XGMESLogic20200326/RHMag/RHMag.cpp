// RHMag.cpp : ���� DLL �ĳ�ʼ�����̡�
//

#include "stdafx.h"
#include "RHMag.h"
#include "_CRH_Process_Satus.h"
#include "_CRH_Equipment_Status.h"
#include "_CRH_Oxygen_Data.h"
#include "_CRH_Process_Data.h"
#include "_CRH_Temp_Data.h"
#include "_CRH_Addition_Data.h"
#include "_CRH_Wire_Data.h"
#include "_CRH_HeatRemark.h"
#include "_CRH_Unit_Mag.h"
#include "_CRH_Prod_Area.h"
#include "_CRH_Communicator.h"
#include "_CRH_Slot_Data.h"
#include "_CRH_Base_Data.h"
#include "_CRH_BlowAr_Data.h"
#include "_CRH_Ladle_Info.h"
#include "_CRH_BlowO_Status_Data.h"

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

// CRHMagApp

BEGIN_MESSAGE_MAP(CRHMagApp, CWinApp)
END_MESSAGE_MAP()


// CRHMagApp ����

CRHMagApp::CRHMagApp()
{
	// TODO: �ڴ˴���ӹ�����룬
	// ��������Ҫ�ĳ�ʼ�������� InitInstance ��
}


// Ψһ��һ�� CRHMagApp ����

CRHMagApp theApp;


// CRHMagApp ��ʼ��

BOOL CRHMagApp::InitInstance()
{
	CWinApp::InitInstance();

	return TRUE;
}

BEGIN_L3COMP_CLASSTABLE(RHMag)
L3CLASS(CRH_Process_Satus,XGMESLogic\\RHMag\\CRH_Process_Satus)
L3CLASS(CRH_Equipment_Status,XGMESLogic\\RHMag\\CRH_Equipment_Status)
L3CLASS(CRH_Oxygen_Data,XGMESLogic\\RHMag\\CRH_Oxygen_Data)
L3CLASS(CRH_Process_Data,XGMESLogic\\RHMag\\CRH_Process_Data)
L3CLASS(CRH_Temp_Data,XGMESLogic\\RHMag\\CRH_Temp_Data)
L3CLASS(CRH_Addition_Data,XGMESLogic\\RHMag\\CRH_Addition_Data)
L3CLASS(CRH_Wire_Data,XGMESLogic\\RHMag\\CRH_Wire_Data)
L3CLASS(CRH_HeatRemark,XGMESLogic\\RHMag\\CRH_HeatRemark)
L3CLASS(CRH_Unit_Mag,XGMESLogic\\RHMag\\CRH_Unit_Mag)
L3CLASS(CRH_Prod_Area,XGMESLogic\\RHMag\\CRH_Prod_Area)
//L3CLASS(CRH_Communicator,XGMESLogic\\RHMag\\CRH_Communicator)
L3CLASS(CRH_Slot_Data,XGMESLogic\\RHMag\\CRH_Slot_Data)
L3CLASS(CRH_Base_Data,XGMESLogic\\RHMag\\CRH_Base_Data)
L3CLASS(CRH_BlowAr_Data,XGMESLogic\\RHMag\\CRH_BlowAr_Data)
L3CLASS(CRH_Ladle_Info,XGMESLogic\\RHMag\\CRH_Ladle_Info)
L3CLASS(CRH_BlowO_Status_Data,XGMESLogic\\RHMag\\CRH_BlowO_Status_Data)
END_L3COMP_CLASSTABLE(RHMag)

BEGIN_L3COMP_EVENTTABLE(RHMag)
END_L3COMP_EVENTTABLE(RHMag)

