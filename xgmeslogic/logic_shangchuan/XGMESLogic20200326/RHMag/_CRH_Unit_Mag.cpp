// 逻辑类CRH_Unit_Mag源文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。

#include "StdAfx.h"
#include "_CRH_Unit_Mag.h"

IMPLEMENT_L3CLASS(CRH_Unit_Mag,ProduceUnit,1)

BEGIN_L3PROPTABLE(CRH_Unit_Mag,ProduceUnit)
	L3PROP_STRING(TreatNo)
	L3PROP_STRING(NextTreatNo)
	L3PROP_LONG(Status)
	L3PROP_STRING(Slot_No)
	L3PROP_STRING(NextSteel)
	L3PROP_STRING(CurArea)
	L3PROP_DATETIME(ProcStartTime)
	L3PROP_DATETIME(ProcStopTime)
	L3PROP_DATETIME(OBStartTime)
	L3PROP_DATETIME(AlloyStartTime)
	L3PROP_LONG(ProcTime)
	L3PROP_DOUBLE(CurTemp)
	L3PROP_STRING(ReSampleHeatID)
	L3PROP_STRING(StartProcessTime)
	L3PROP_LONG(Equip_Status)
	L3PROP_STRING(Probe_Vendor)
	L3PROP_STRING(PrevArea)
END_L3PROPTABLE(CRH_Unit_Mag)

BEGIN_L3METHODMAP(CRH_Unit_Mag,ProduceUnit)
	L3_METHOD(CRH_Unit_Mag,"GetInputSteels",0,GetInputSteels,L3VT_RECORDSET,L3VTS_NONE)
	L3_METHOD(CRH_Unit_Mag,"DesignateLadle",0,DesignateLadle,L3VT_BOOL,L3VTS_STRING L3VTS_STRING)
	L3_METHOD(CRH_Unit_Mag,"SteelArrived",0,SteelArrived,L3VT_BOOL,L3VTS_STRING)
	L3_METHOD(CRH_Unit_Mag,"OBStarted",0,OBStarted,L3VT_BOOL,L3VTS_NONE)
	L3_METHOD(CRH_Unit_Mag,"OBStopped",0,OBStopped,L3VT_BOOL,L3VTS_NONE)
	L3_METHOD(CRH_Unit_Mag,"VacuumStarted",0,VacuumStarted,L3VT_BOOL,L3VTS_NONE)
	L3_METHOD(CRH_Unit_Mag,"VacuumStopped",0,VacuumStopped,L3VT_BOOL,L3VTS_NONE)
	L3_METHOD(CRH_Unit_Mag,"FeedElement",0,FeedElement,L3VT_BOOL,L3VTS_RECORDSET)
	L3_METHOD(CRH_Unit_Mag,"SetTemperature",0,SetTemperature,L3VT_BOOL,L3VTS_RECORDSET)
	L3_METHOD(CRH_Unit_Mag,"SetOxygen",0,SetOxygen,L3VT_BOOL,L3VTS_RECORDSET)
	L3_METHOD(CRH_Unit_Mag,"FeedWire",0,FeedWire,L3VT_BOOL,L3VTS_STRING L3VTS_RECORDSET)
	L3_METHOD(CRH_Unit_Mag,"StartProcess",0,StartProcess,L3VT_BOOL,L3VTS_STRING)
	L3_METHOD(CRH_Unit_Mag,"StopProcess",0,StopProcess,L3VT_BOOL,L3VTS_NONE)
	L3_METHOD(CRH_Unit_Mag,"ChangeDeviceStatus",0,ChangeDeviceStatus,L3VT_BOOL,L3VTS_LONG L3VTS_STRING)
	L3_METHOD(CRH_Unit_Mag,"OnTimer",0,OnTimer,L3VT_BOOL,L3VTS_ULONG)
	L3_METHOD(CRH_Unit_Mag,"StartBlowing",0,StartBlowing,L3VT_BOOL,L3VTS_STRING)
	L3_METHOD(CRH_Unit_Mag,"StopBlowing",0,StopBlowing,L3VT_BOOL,L3VTS_STRING)
	L3_METHOD(CRH_Unit_Mag,"SteelLeave",0,SteelLeave,L3VT_BOOL,L3VTS_STRING)
	L3_METHOD(CRH_Unit_Mag,"ChangeSteelGradeApp",0,ChangeSteelGradeApp,L3VT_BOOL,L3VTS_STRING)
	L3_METHOD(CRH_Unit_Mag,"SteelReturnApp",0,SteelReturnApp,L3VT_BOOL,L3VTS_STRING L3VTS_STRING)
	L3_METHOD(CRH_Unit_Mag,"SteelBackApp",0,SteelBackApp,L3VT_BOOL,L3VTS_STRING L3VTS_STRING)
	L3_METHOD(CRH_Unit_Mag,"AcceptMaterialDischargeData",0,AcceptMaterialDischargeData,L3VT_BOOL,L3VTS_RECORDSET)
	L3_METHOD(CRH_Unit_Mag,"MaterialGroundDischargeData",0,MaterialGroundDischargeData,L3VT_BOOL,L3VTS_RECORDSET)
	L3_METHOD(CRH_Unit_Mag,"AcceptRHStatus",0,AcceptRHStatus,L3VT_BOOL,L3VTS_RECORDSET)
	L3_METHOD(CRH_Unit_Mag,"AcceptRHTempData",0,AcceptRHTempData,L3VT_BOOL,L3VTS_RECORDSET)
	L3_METHOD(CRH_Unit_Mag,"AcceptRHWireData",0,AcceptRHWireData,L3VT_BOOL,L3VTS_RECORDSET)
	L3_METHOD(CRH_Unit_Mag,"AcceptRHOxygenData",0,AcceptRHOxygenData,L3VT_BOOL,L3VTS_RECORDSET)
	L3_METHOD(CRH_Unit_Mag,"AcceptRHProcessData",0,AcceptRHProcessData,L3VT_BOOL,L3VTS_RECORDSET)
	L3_METHOD(CRH_Unit_Mag,"AcceptRHVacTime",0,AcceptRHVacTime,L3VT_BOOL,L3VTS_RECORDSET)
	L3_METHOD(CRH_Unit_Mag,"GetPreThreeHeatID",0,GetPreThreeHeatID,L3VT_RECORDSET,L3VTS_NONE)
	L3_METHOD(CRH_Unit_Mag,"AcceptRHBlowArData",0,AcceptRHBlowArData,L3VT_BOOL,L3VTS_RECORDSET)
	L3_METHOD(CRH_Unit_Mag,"ModifyLadleGrade",0,ModifyLadleGrade,L3VT_LONG,L3VTS_STRING L3VTS_STRING)//2009-03-30 Liao
	L3_METHOD(CRH_Unit_Mag,"SetWeight",0,SetWeight,L3VT_BOOL,L3VTS_DOUBLE L3VTS_STRING)//2009-04-09
	L3_METHOD(CRH_Unit_Mag,"AcceptBlowO2StatusData",0,AcceptBlowO2StatusData,L3VT_BOOL,L3VTS_RECORDSET)//2009-07-03

	L3_METHOD(CRH_Unit_Mag,"CalEleRateValue",0,CalEleRateValue,L3VT_FLOAT,L3VTS_STRING L3VTS_STRING L3VTS_STRING)
	
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CRH_Unit_Mag,ProduceUnit)
END_L3EVENTSINK_MAP(CRH_Unit_Mag)

CRH_Unit_Mag::CRH_Unit_Mag(void)
{
	csDischargeUnit = _T("");
	csWireUnit = _T("");
}

CRH_Unit_Mag::~CRH_Unit_Mag(void)
{
}
