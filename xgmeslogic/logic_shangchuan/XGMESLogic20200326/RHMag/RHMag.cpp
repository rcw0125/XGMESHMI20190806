// RHMag.cpp : 定义 DLL 的初始化例程。
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
//	注意！
//
//		如果此 DLL 动态链接到 MFC
//		DLL，从此 DLL 导出并
//		调入 MFC 的任何函数在函数的最前面
//		都必须添加 AFX_MANAGE_STATE 宏。
//
//		例如:
//
//		extern "C" BOOL PASCAL EXPORT AccessedFunction()
//		{
//			AFX_MANAGE_STATE(AfxGetStaticModuleState());
//			// 此处为普通函数体
//		}
//
//		此宏先于任何 MFC 调用
//		出现在每个函数中十分重要。这意味着
//		它必须作为函数中的第一个语句
//		出现，甚至先于所有对象变量声明，
//		这是因为它们的构造函数可能生成 MFC
//		DLL 调用。

//
//		有关其他详细信息，
//		请参阅 MFC 技术说明 33 和 58。
//

// CRHMagApp

BEGIN_MESSAGE_MAP(CRHMagApp, CWinApp)
END_MESSAGE_MAP()


// CRHMagApp 构造

CRHMagApp::CRHMagApp()
{
	// TODO: 在此处添加构造代码，
	// 将所有重要的初始化放置在 InitInstance 中
}


// 唯一的一个 CRHMagApp 对象

CRHMagApp theApp;


// CRHMagApp 初始化

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

