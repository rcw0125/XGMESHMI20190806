// 逻辑类CRH_Slot_Data源文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。

#include "StdAfx.h"
#include "_CRH_Slot_Data.h"

IMPLEMENT_L3CLASS(CRH_Slot_Data,CL3Object,1)

BEGIN_L3PROPTABLE(CRH_Slot_Data,CL3Object)
	L3PROP_STRING(Slot_No)
	L3PROP_SHORT(Validity)
	L3PROP_SHORT(RHID)
	L3PROP_DATETIME(Create_Time)
	L3PROP_DATETIME(Valid_Time)
	L3PROP_STRING(Operator)
END_L3PROPTABLE(CRH_Slot_Data)

BEGIN_L3METHODMAP(CRH_Slot_Data,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CRH_Slot_Data,CL3Object)
END_L3EVENTSINK_MAP(CRH_Slot_Data)

CRH_Slot_Data::CRH_Slot_Data(void)
{
}

CRH_Slot_Data::~CRH_Slot_Data(void)
{
}
