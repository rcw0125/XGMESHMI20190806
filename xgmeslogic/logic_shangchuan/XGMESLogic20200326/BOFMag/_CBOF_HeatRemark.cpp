// 逻辑类CBOF_HeatRemark源文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。

#include "StdAfx.h"
#include "_CBOF_HeatRemark.h"

IMPLEMENT_L3CLASS(CBOF_HeatRemark,CL3Object,1)

BEGIN_L3PROPTABLE(CBOF_HeatRemark,CL3Object)
	L3PROP_STRING(HeatID)
	L3PROP_SHORT(TypeID)
	L3PROP_STRING(Remark)
	L3PROP_DATETIME(Log_Time)
END_L3PROPTABLE(CBOF_HeatRemark)

BEGIN_L3METHODMAP(CBOF_HeatRemark,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CBOF_HeatRemark,CL3Object)
END_L3EVENTSINK_MAP(CBOF_HeatRemark)

CBOF_HeatRemark::CBOF_HeatRemark(void)
{
}

CBOF_HeatRemark::~CBOF_HeatRemark(void)
{
}
