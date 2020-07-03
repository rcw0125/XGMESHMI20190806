// 逻辑类CMELT_MainPipe_Data源文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。

#include "StdAfx.h"
#include "_CMELT_MainPipe_Data.h"

IMPLEMENT_L3CLASS(CMELT_MainPipe_Data,CL3Object,1)

BEGIN_L3PROPTABLE(CMELT_MainPipe_Data,CL3Object)
	L3PROP_FLOAT(Flow)
	L3PROP_FLOAT(Pressure)
	L3PROP_DATETIME(Catch_Time)
END_L3PROPTABLE(CMELT_MainPipe_Data)

BEGIN_L3METHODMAP(CMELT_MainPipe_Data,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CMELT_MainPipe_Data,CL3Object)
END_L3EVENTSINK_MAP(CMELT_MainPipe_Data)

CMELT_MainPipe_Data::CMELT_MainPipe_Data(void)
{
}

CMELT_MainPipe_Data::~CMELT_MainPipe_Data(void)
{
}
