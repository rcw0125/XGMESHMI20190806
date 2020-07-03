// 逻辑类CRH_Addition_Data源文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。

#include "StdAfx.h"
#include "_CRH_Addition_Data.h"

IMPLEMENT_L3CLASS(CRH_Addition_Data,CL3Object,1)

BEGIN_L3PROPTABLE(CRH_Addition_Data,CL3Object)
	L3PROP_STRING(TreatNo)
	L3PROP_STRING(HeatID)
	L3PROP_STRING(Element)
	L3PROP_FLOAT(Weight)
	L3PROP_DATETIME(Discharge_Time)
	L3PROP_SHORT(Type)
	L3PROP_STRING(Area)
	L3PROP_STRING(Batch_ID)
END_L3PROPTABLE(CRH_Addition_Data)

BEGIN_L3METHODMAP(CRH_Addition_Data,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CRH_Addition_Data,CL3Object)
END_L3EVENTSINK_MAP(CRH_Addition_Data)

CRH_Addition_Data::CRH_Addition_Data(void)
{
}

CRH_Addition_Data::~CRH_Addition_Data(void)
{
}
