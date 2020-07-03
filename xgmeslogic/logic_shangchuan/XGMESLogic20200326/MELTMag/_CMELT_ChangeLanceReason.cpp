// 逻辑类CMELT_ChangeLanceReason源文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。

#include "StdAfx.h"
#include "_CMELT_ChangeLanceReason.h"

IMPLEMENT_L3CLASS(CMELT_ChangeLanceReason,CL3Object,1)

BEGIN_L3PROPTABLE(CMELT_ChangeLanceReason,CL3Object)
	L3PROP_SHORT(BOFID)
	L3PROP_DATETIME(ChangeLance_Time)
	L3PROP_STRING(Reason)
END_L3PROPTABLE(CMELT_ChangeLanceReason)

BEGIN_L3METHODMAP(CMELT_ChangeLanceReason,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CMELT_ChangeLanceReason,CL3Object)
END_L3EVENTSINK_MAP(CMELT_ChangeLanceReason)

CMELT_ChangeLanceReason::CMELT_ChangeLanceReason(void)
{
}

CMELT_ChangeLanceReason::~CMELT_ChangeLanceReason(void)
{
}
