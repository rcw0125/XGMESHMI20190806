// 逻辑类CMIF_Temp_Data源文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。

#include "StdAfx.h"
#include "_CMIF_Temp_Data.h"

IMPLEMENT_L3CLASS(CMIF_Temp_Data,CL3Object,1)

BEGIN_L3PROPTABLE(CMIF_Temp_Data,CL3Object)
	L3PROP_STRING(MIFID)
	L3PROP_LONG(Temp)
	L3PROP_DATETIME(Temp_Time)
	L3PROP_STRING(Shift)
	L3PROP_STRING(Team)
END_L3PROPTABLE(CMIF_Temp_Data)

BEGIN_L3METHODMAP(CMIF_Temp_Data,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CMIF_Temp_Data,CL3Object)
END_L3EVENTSINK_MAP(CMIF_Temp_Data)

CMIF_Temp_Data::CMIF_Temp_Data(void)
{
}

CMIF_Temp_Data::~CMIF_Temp_Data(void)
{
}
