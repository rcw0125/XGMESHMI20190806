// 逻辑类CLadle_Com_Lad_Rep_Info源文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。

#include "StdAfx.h"
#include "_CLadle_Com_Lad_Rep_Info.h"

IMPLEMENT_L3CLASS(CLadle_Com_Lad_Rep_Info,CL3Object,1)

BEGIN_L3PROPTABLE(CLadle_Com_Lad_Rep_Info,CL3Object)
	L3PROP_DATETIME(Input_Time)
	L3PROP_SHORT(Number)
	L3PROP_STRING(Ladle_ID)
	L3PROP_STRING(Water_gap_Bri_Fac)
	L3PROP_DOUBLE(Water_gap_Bri_Wast)
	L3PROP_STRING(Breathe_Bri_Fac)
	L3PROP_DOUBLE(Breathe_Bri_Wast)
	L3PROP_STRING(Cast_Fac)
	L3PROP_DOUBLE(Cast_Wast)
	L3PROP_DATETIME(Fire_Start_Time)
	L3PROP_DATETIME(Fire_End_Time)
	L3PROP_STRING(Rep_Ladle_Operator)
	L3PROP_STRING(TeamID)
	L3PROP_STRING(ShiftID)
	L3PROP_STRING(Operator)
	L3PROP_STRING(Note)
END_L3PROPTABLE(CLadle_Com_Lad_Rep_Info)

BEGIN_L3METHODMAP(CLadle_Com_Lad_Rep_Info,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CLadle_Com_Lad_Rep_Info,CL3Object)
END_L3EVENTSINK_MAP(CLadle_Com_Lad_Rep_Info)

CLadle_Com_Lad_Rep_Info::CLadle_Com_Lad_Rep_Info(void)
{
}

CLadle_Com_Lad_Rep_Info::~CLadle_Com_Lad_Rep_Info(void)
{
}
