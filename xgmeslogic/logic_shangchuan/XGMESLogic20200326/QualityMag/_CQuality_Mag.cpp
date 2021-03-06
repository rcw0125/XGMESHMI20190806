// 逻辑类CQuality_Mag源文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。

#include "StdAfx.h"
#include "_CQuality_Mag.h"

IMPLEMENT_L3CLASS(CQuality_Mag,CL3Object,1)

BEGIN_L3PROPTABLE(CQuality_Mag,CL3Object)
END_L3PROPTABLE(CQuality_Mag)

BEGIN_L3METHODMAP(CQuality_Mag,CL3Object)
	L3_METHOD(CQuality_Mag,"GetSampleApplyData",0,GetSampleApplyData,L3VT_RECORDSET,L3VTS_STRING)
	L3_METHOD(CQuality_Mag,"GetHeatIDByAddr",1,GetHeatIDByAddr,L3VT_RECORDSET,L3VTS_STRING)
	L3_METHOD(CQuality_Mag,"CreateHeatGradeQAData",2,CreateHeatGradeQAData,L3VT_LONG,L3VTS_LONG L3VTS_RECORDSET)
	L3_METHOD(CQuality_Mag,"GetCurrentHeatGradeQAData",3,GetCurrentHeatGradeQAData,L3VT_RECORDSET,L3VTS_STRING L3VTS_STRING)
	L3_METHOD(CQuality_Mag,"UpdateCurrentHeatGradeData",4,UpdateCurrentHeatGradeData,L3VT_LONG,L3VTS_RECORDSET)
	L3_METHOD(CQuality_Mag,"GetQACalWeightData",5,GetQACalWeightData,L3VT_RECORDSET,L3VTS_LONG)
	L3_METHOD(CQuality_Mag,"GetJudgedSteelGrade",6,GetJudgedSteelGrade,L3VT_RECORDSET,L3VTS_STRING L3VTS_STRING)
	//L3_METHOD(CQuality_Mag,"GetDeSSampleApplyData",7,GetDeSSampleApplyData,L3VT_RECORDSET,L3VTS_NONE)
	

    //L3_METHOD(CQuality_Mag,"BloomWaster",0,BloomWaster,L3VT_BOOL,L3VTS_RECORDSET)
	//L3_METHOD(CQuality_Mag,"BloomWasterDutySpecify",1,BloomWasterDutySpecify,L3VT_BOOL,L3VTS_RECORDSET)
	//L3_METHOD(CQuality_Mag,"GetUnspecifyDutyWasterData",2,GetUnspecifyDutyWasterData,L3VT_RECORDSET,L3VTS_STRING)
	//L3_METHOD(CQuality_Mag,"AddBOFQAStdData",3,AddBOFQAStdData,L3VT_LONG,L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET)
	//L3_METHOD(CQuality_Mag,"DelBOFQAStdData",4,DelBOFQAStdData,L3VT_LONG,L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET)
	//L3_METHOD(CQuality_Mag,"ModBOFQAStdData",5,ModBOFQAStdData,L3VT_LONG,L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET)
	//L3_METHOD(CQuality_Mag,"AddLFQAStdData",6,AddLFQAStdData,L3VT_LONG,L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET)
	//L3_METHOD(CQuality_Mag,"DelLFQAStdData",7,DelLFQAStdData,L3VT_LONG,L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET)
	//L3_METHOD(CQuality_Mag,"ModLFQAStdData",8,ModLFQAStdData,L3VT_LONG,L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET)
	//L3_METHOD(CQuality_Mag,"AddRHQAStdData",9,AddRHQAStdData,L3VT_LONG,L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET)
	//L3_METHOD(CQuality_Mag,"DelRHQAStdData",10,DelRHQAStdData,L3VT_LONG,L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET)
	//L3_METHOD(CQuality_Mag,"ModRHQAStdData",11,ModRHQAStdData,L3VT_LONG,L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET)
	//L3_METHOD(CQuality_Mag,"AddCCMQAStdData",12,AddCCMQAStdData,L3VT_LONG,L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET)
	//L3_METHOD(CQuality_Mag,"DelCCMQAStdData",13,DelCCMQAStdData,L3VT_LONG,L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET)
	//L3_METHOD(CQuality_Mag,"ModCCMQAStdData",14,ModCCMQAStdData,L3VT_LONG,L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET L3VTS_RECORDSET)
	//L3_METHOD(CQuality_Mag,"GetQAStdData",6,GetQAStdData,L3VT_RECORDSET,L3VTS_RECORDSET)
	L3_METHOD(CQuality_Mag,"SteelGradeIndexCopy",7,SteelGradeIndexCopy,L3VT_LONG,L3VTS_STRING L3VTS_STRING)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CQuality_Mag,CL3Object)
END_L3EVENTSINK_MAP(CQuality_Mag)

CQuality_Mag::CQuality_Mag(void)
{
}

CQuality_Mag::~CQuality_Mag(void)
{
}
