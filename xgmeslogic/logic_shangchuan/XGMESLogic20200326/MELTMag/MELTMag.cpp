// MELTMag.cpp : ���� DLL �ĳ�ʼ�����̡�
//

#include "stdafx.h"
#include "MELTMag.h"
#include "MELTMag.h"
#include "_CMELT_Communicator.h"
#include "_CMELT_Prod_Area.h"
#include "_CMELT_Unit_Mag.h"
#include "_CMELT_Temp_Data.h"
#include "_CMELT_Oxygen_Data.h"
#include "_CMELT_Addition_Data.h"
#include "_CMELT_Process_Status.h"
#include "_CMELT_Bottom_Blowing.h"
#include "_CMELT_Top_Blowing.h"
#include "_CMELT_MainPipe_Data.h"
#include "_CMELT_Base_Data.h"
#include "_CMELT_Feed_Data.h"
#include "_CMELT_Process_Data.h"
#include "_CMELT_Equipment_Status.h"
#include "_CMELT_Proc_Stat_Def.h"
#include "_CMELT_Equip_Stat_Def.h"
#include "_CMELT_Duty_Definition.h"
#include "_CMELT_ChangeLanceReason.h"
#include "_CMELT_FenderSlagConsume.h"
#include "_CMELT_HeatRemark.h"
#include "_CMELT_Remark_Type.h"
#include "_CMELT_Stack_Maintenance.h"
#include "_CMELT_ReturnSteel.h"


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

// CMELTMagApp

BEGIN_MESSAGE_MAP(CMELTMagApp, CWinApp)
END_MESSAGE_MAP()


// CMELTMagApp ����

CMELTMagApp::CMELTMagApp()
{
	// TODO: �ڴ˴���ӹ�����룬
	// ��������Ҫ�ĳ�ʼ�������� InitInstance ��
}


// Ψһ��һ�� CMELTMagApp ����

CMELTMagApp theApp;


// CMELTMagApp ��ʼ��

BOOL CMELTMagApp::InitInstance()
{
	CWinApp::InitInstance();

	return TRUE;
}

BEGIN_L3COMP_CLASSTABLE(MELTMag)
L3CLASS(CMELT_Prod_Area,XGMESLogic\\MELTMag\\CMELT_Prod_Area)
L3CLASS(CMELT_Unit_Mag,XGMESLogic\\MELTMag\\CMELT_Unit_Mag)
L3CLASS(CMELT_Temp_Data,XGMESLogic\\MELTMag\\CMELT_Temp_Data)
L3CLASS(CMELT_Oxygen_Data,XGMESLogic\\MELTMag\\CMELT_Oxygen_Data)
L3CLASS(CMELT_Addition_Data,XGMESLogic\\MELTMag\\CMELT_Addition_Data)
L3CLASS(CMELT_Process_Status,XGMESLogic\\MELTMag\\CMELT_Process_Status)
L3CLASS(CMELT_Bottom_Blowing,XGMESLogic\\MELTMag\\CMELT_Bottom_Blowing)
L3CLASS(CMELT_Top_Blowing,XGMESLogic\\MELTMag\\CMELT_Top_Blowing)
//L3CLASS(CMELT_MainPipe_Data,XGMESLogic\\MELTMag\\CMELT_MainPipe_Data)
L3CLASS(CMELT_Base_Data,XGMESLogic\\MELTMag\\CMELT_Base_Data)
L3CLASS(CMELT_Feed_Data,XGMESLogic\\MELTMag\\CMELT_Feed_Data)
L3CLASS(CMELT_Process_Data,XGMESLogic\\MELTMag\\CMELT_Process_Data)
L3CLASS(CMELT_Equipment_Status,XGMESLogic\\MELTMag\\CMELT_Equipment_Status)
//L3CLASS(CMELT_Proc_Stat_Def,XGMESLogic\\MELTMag\\CMELT_Proc_Stat_Def)
//L3CLASS(CMELT_Equip_Stat_Def,XGMESLogic\\MELTMag\\CMELT_Equip_Stat_Def)
L3CLASS(CMELT_Duty_Definition,XGMESLogic\\MELTMag\\CMELT_Duty_Definition)
//L3CLASS(CMELT_ChangeLanceReason,XGMESLogic\\MELTMag\\CMELT_ChangeLanceReason)
//L3CLASS(CMELT_FenderSlagConsume,XGMESLogic\\MELTMag\\CMELT_FenderSlagConsume)
L3CLASS(CMELT_HeatRemark,XGMESLogic\\MELTMag\\CMELT_HeatRemark)
//L3CLASS(CMELT_Remark_Type,XGMESLogic\\MELTMag\\CMELT_Remark_Type)
L3CLASS(CMELT_Stack_Maintenance,XGMESLogic\\MELTMag\\CMELT_Stack_Maintenance)
END_L3COMP_CLASSTABLE(MELTMag)

BEGIN_L3COMP_EVENTTABLE(MELTMag)
END_L3COMP_EVENTTABLE(MELTMag)

