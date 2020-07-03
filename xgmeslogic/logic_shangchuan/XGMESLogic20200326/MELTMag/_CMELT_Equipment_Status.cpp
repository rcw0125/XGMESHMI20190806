// 逻辑类CMELT_Equipment_Status源文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。

#include "StdAfx.h"
#include "_CMELT_Equipment_Status.h"

IMPLEMENT_L3CLASS(CMELT_Equipment_Status,CL3Object,1)

BEGIN_L3PROPTABLE(CMELT_Equipment_Status,CL3Object)
	L3PROP_SHORT(BOFID)
	L3PROP_SHORT(Status)
	L3PROP_DATETIME(Log_Time)
	L3PROP_STRING(Reason)
END_L3PROPTABLE(CMELT_Equipment_Status)

BEGIN_L3METHODMAP(CMELT_Equipment_Status,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CMELT_Equipment_Status,CL3Object)
END_L3EVENTSINK_MAP(CMELT_Equipment_Status)

CMELT_Equipment_Status::CMELT_Equipment_Status(void)
{
}

CMELT_Equipment_Status::~CMELT_Equipment_Status(void)
{
}
