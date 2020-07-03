// 逻辑类CLF_Ladle_Weight源文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。

#include "StdAfx.h"
#include "_CLF_Ladle_Weight.h"

IMPLEMENT_L3CLASS(CLF_Ladle_Weight,CL3Object,1)

BEGIN_L3PROPTABLE(CLF_Ladle_Weight,CL3Object)
	L3PROP_SHORT(LFID)
	L3PROP_DOUBLE(Weight)
	L3PROP_DOUBLE(GrossWeight)
	L3PROP_DOUBLE(TareWeight)
	L3PROP_DOUBLE(KzWeight)
	L3PROP_SHORT(Status)
	L3PROP_STRING(LadleNo)
	L3PROP_DATETIME(Log_Time)
	L3PROP_STRING(HeatID)
END_L3PROPTABLE(CLF_Ladle_Weight)

BEGIN_L3METHODMAP(CLF_Ladle_Weight,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CLF_Ladle_Weight,CL3Object)
END_L3EVENTSINK_MAP(CLF_Ladle_Weight)

CLF_Ladle_Weight::CLF_Ladle_Weight(void)
{
}

CLF_Ladle_Weight::~CLF_Ladle_Weight(void)
{
}
