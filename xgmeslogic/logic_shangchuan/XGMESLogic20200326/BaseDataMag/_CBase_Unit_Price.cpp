// 逻辑类CBase_Unit_Price源文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。

#include "StdAfx.h"
#include "_CBase_Unit_Price.h"

IMPLEMENT_L3CLASS(CBase_Unit_Price,CL3Object,1)

BEGIN_L3PROPTABLE(CBase_Unit_Price,CL3Object)
	L3PROP_STRING(Ele_Code)
	L3PROP_STRING(Ele_Des)
	L3PROP_FLOAT(Ele_Price)
END_L3PROPTABLE(CBase_Unit_Price)

BEGIN_L3METHODMAP(CBase_Unit_Price,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CBase_Unit_Price,CL3Object)
END_L3EVENTSINK_MAP(CBase_Unit_Price)

CBase_Unit_Price::CBase_Unit_Price(void)
{
}

CBase_Unit_Price::~CBase_Unit_Price(void)
{
}
