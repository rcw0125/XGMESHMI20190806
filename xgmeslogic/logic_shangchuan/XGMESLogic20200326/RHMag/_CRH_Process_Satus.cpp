// 逻辑类CRH_Process_Satus源文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。

#include "StdAfx.h"
#include "_CRH_Process_Satus.h"

IMPLEMENT_L3CLASS(CRH_Process_Satus,CL3Object,1)

BEGIN_L3PROPTABLE(CRH_Process_Satus,CL3Object)
	L3PROP_STRING(TreatNo)
	L3PROP_STRING(HeatID)
	L3PROP_LONG(Status)
	L3PROP_DATETIME(Change_Time)
END_L3PROPTABLE(CRH_Process_Satus)

BEGIN_L3METHODMAP(CRH_Process_Satus,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CRH_Process_Satus,CL3Object)
END_L3EVENTSINK_MAP(CRH_Process_Satus)

CRH_Process_Satus::CRH_Process_Satus(void)
{
}

CRH_Process_Satus::~CRH_Process_Satus(void)
{
}
