// 逻辑类CCCM_ProdArea源文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。

#include "StdAfx.h"
#include "_CCCM_ProdArea.h"

IMPLEMENT_L3CLASS(CCCM_ProdArea,CL3Object,1)

BEGIN_L3PROPTABLE(CCCM_ProdArea,CL3Object)
END_L3PROPTABLE(CCCM_ProdArea)

BEGIN_L3METHODMAP(CCCM_ProdArea,CL3Object)
	L3_METHOD(CCCM_ProdArea,"ProcessMaterials",0,ProcessMaterials,L3VT_BOOL,L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_LONG L3VTS_RECORDSET L3VTS_RECORDSET)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CCCM_ProdArea,CL3Object)
END_L3EVENTSINK_MAP(CCCM_ProdArea)

CCCM_ProdArea::CCCM_ProdArea(void)
{
}

CCCM_ProdArea::~CCCM_ProdArea(void)
{
}
