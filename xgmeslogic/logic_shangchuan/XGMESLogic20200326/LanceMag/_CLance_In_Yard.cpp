// 逻辑类CLance_In_Yard源文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。

#include "StdAfx.h"
#include "_CLance_In_Yard.h"

IMPLEMENT_L3CLASS(CLance_In_Yard,CL3Object,1)

BEGIN_L3PROPTABLE(CLance_In_Yard,CL3Object)
	L3PROP_DATETIME(Input_Time)
	L3PROP_STRING(Lance_Head_Type)
	L3PROP_STRING(Nozzle_Factury)
	L3PROP_DOUBLE(Nozzle_Throat_Dia)
	L3PROP_DOUBLE(Nozzle_Angle)
	L3PROP_LONG(IN_Yard)
	L3PROP_LONG(IN_Total)
	L3PROP_STRING(In_Confirm)
	L3PROP_STRING(TeamID)
	L3PROP_STRING(ShiftID)
	L3PROP_STRING(Note)
END_L3PROPTABLE(CLance_In_Yard)

BEGIN_L3METHODMAP(CLance_In_Yard,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CLance_In_Yard,CL3Object)
END_L3EVENTSINK_MAP(CLance_In_Yard)

CLance_In_Yard::CLance_In_Yard(void)
{
}

CLance_In_Yard::~CLance_In_Yard(void)
{
}
