// 逻辑类CMELT_Communicator源文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。

#include "StdAfx.h"
#include "_CMELT_Communicator.h"

IMPLEMENT_L3CLASS(CMELT_Communicator,CL3Object,1)

BEGIN_L3PROPTABLE(CMELT_Communicator,CL3Object)
END_L3PROPTABLE(CMELT_Communicator)

BEGIN_L3METHODMAP(CMELT_Communicator,CL3Object)
	L3_METHOD(CMELT_Communicator,"OnFeedIron",0,OnFeedIron,L3VT_BOOL,L3VTS_RECORDSET)
	L3_METHOD(CMELT_Communicator,"OnChangeStatus",0,OnChangeStatus,L3VT_BOOL,L3VTS_RECORDSET)
	L3_METHOD(CMELT_Communicator,"OnDischarge",0,OnDischarge,L3VT_BOOL,L3VTS_RECORDSET)
	L3_METHOD(CMELT_Communicator,"OnMeasureTemp",0,OnMeasureTemp,L3VT_BOOL,L3VTS_RECORDSET)
	L3_METHOD(CMELT_Communicator,"OnMeasureO2",0,OnMeasureO2,L3VT_BOOL,L3VTS_RECORDSET)
	L3_METHOD(CMELT_Communicator,"OnTapped",0,OnTapped,L3VT_BOOL,L3VTS_RECORDSET)
	L3_METHOD(CMELT_Communicator,"OnBottomBlow",0,OnBottomBlow,L3VT_BOOL,L3VTS_RECORDSET)
	L3_METHOD(CMELT_Communicator,"OnTopBlow",0,OnTopBlow,L3VT_BOOL,L3VTS_RECORDSET)
	L3_METHOD(CMELT_Communicator,"OnSauceEvent",0,OnSauceEvent,L3VT_BOOL,L3VTS_RECORDSET)
	L3_METHOD(CMELT_Communicator,"OnTapStart",0,OnTapStart,L3VT_BOOL,L3VTS_RECORDSET)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CMELT_Communicator,CL3Object)
END_L3EVENTSINK_MAP(CMELT_Communicator)

CMELT_Communicator::CMELT_Communicator(void)
{
}

CMELT_Communicator::~CMELT_Communicator(void)
{
}
