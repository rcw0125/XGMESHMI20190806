// 逻辑类CRH_Process_Data源文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。

#include "StdAfx.h"
#include "_CRH_Process_Data.h"

IMPLEMENT_L3CLASS(CRH_Process_Data,CL3Object,1)

BEGIN_L3PROPTABLE(CRH_Process_Data,CL3Object)
	L3PROP_STRING(TreatNo)
	L3PROP_STRING(HeatID)
	L3PROP_DATETIME(Arrival_Time)
	L3PROP_SHORT(Arrival_Temp)
	L3PROP_SHORT(Arrival_Temp_Quality)
	L3PROP_FLOAT(Slag_Thick)
	L3PROP_STRING(Process_Location)
	L3PROP_STRING(Slot_No)
	L3PROP_SHORT(Process_Mode)
	L3PROP_DATETIME(Start_Time)
	L3PROP_DATETIME(End_Time)
	L3PROP_LONG(Process_Time)
	L3PROP_LONG(Loop_Time)
	L3PROP_FLOAT(Vac_Min)
	L3PROP_SHORT(OB_Count)
	L3PROP_FLOAT(O2_CONS)
	L3PROP_FLOAT(Al_CONS)
	L3PROP_LONG(OB_Cycle_Time)
	L3PROP_STRING(Probe_Vonder)
	L3PROP_DATETIME(Wire_End_Time)
	L3PROP_SHORT(Wire_End_Temp)
	L3PROP_DATETIME(SoftBlow_StartTime)
	L3PROP_DATETIME(SoftBlow_EndTime)
	L3PROP_LONG(SoftBlow_Time)
	L3PROP_LONG(Departure_Temp)
	L3PROP_SHORT(CircsOfRhythm)
	L3PROP_LONG(VacDownTo35000_Time)
	L3PROP_LONG(VacDownTo11500_Time)
	L3PROP_LONG(VacDownTo2500_Time)
	L3PROP_LONG(VacDownTo500_Time)
	L3PROP_DOUBLE(CCM_Ladle_Weight)//2009-02-21
	L3PROP_STRING(LadleNo)//2009-03-30
	L3PROP_STRING(LadleGrade)
	L3PROP_LONG(WholePump_Time)
END_L3PROPTABLE(CRH_Process_Data)

BEGIN_L3METHODMAP(CRH_Process_Data,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CRH_Process_Data,CL3Object)
END_L3EVENTSINK_MAP(CRH_Process_Data)

CRH_Process_Data::CRH_Process_Data(void)
{
}

CRH_Process_Data::~CRH_Process_Data(void)
{
}
