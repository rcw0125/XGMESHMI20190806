// 逻辑类CMIF_Mag源文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。

#include "StdAfx.h"
#include "_CMIF_Mag.h"

IMPLEMENT_L3CLASS(CMIF_Mag,CL3Object,1)

BEGIN_L3PROPTABLE(CMIF_Mag,CL3Object)
END_L3PROPTABLE(CMIF_Mag)

BEGIN_L3METHODMAP(CMIF_Mag,CL3Object)
	L3_METHOD(CMIF_Mag,"DirectFeedIron",0,DirectFeedIron,L3VT_STRING,L3VTS_STRING L3VTS_RECORDSET)
	L3_METHOD(CMIF_Mag,"GetUnArrivedIrons",0,GetUnArrivedIrons,L3VT_RECORDSET,L3VTS_NONE)
	L3_METHOD(CMIF_Mag,"GetIncomingIrons",0,GetIncomingIrons,L3VT_RECORDSET,L3VTS_NONE)
	L3_METHOD(CMIF_Mag,"GetOutgoingIrons",0,GetOutgoingIrons,L3VT_RECORDSET,L3VTS_NONE)
	L3_METHOD(CMIF_Mag,"GetOutgoingIrons2",0,GetOutgoingIrons2,L3VT_RECORDSET,L3VTS_NONE)
	L3_METHOD(CMIF_Mag,"GetHotIronLadles",0,GetHotIronLadles,L3VT_RECORDSET,L3VTS_NONE)
	L3_METHOD(CMIF_Mag,"BackBFIron",0,BackBFIron,L3VT_LONG,L3VTS_RECORDSET)
	L3_METHOD(CMIF_Mag,"OutputIronCancel",0,OutputIronCancel,L3VT_LONG,L3VTS_RECORDSET)
	L3_METHOD(CMIF_Mag,"SetIsDes",0,SetIsDes,L3VT_LONG,L3VTS_RECORDSET)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CMIF_Mag,CL3Object)
END_L3EVENTSINK_MAP(CMIF_Mag)

CMIF_Mag::CMIF_Mag(void)
{
}

CMIF_Mag::~CMIF_Mag(void)
{
}
