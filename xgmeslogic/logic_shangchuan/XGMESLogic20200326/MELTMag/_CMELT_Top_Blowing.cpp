// �߼���CMELT_Top_BlowingԴ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����

#include "StdAfx.h"
#include "_CMELT_Top_Blowing.h"

IMPLEMENT_L3CLASS(CMELT_Top_Blowing,CL3Object,1)

BEGIN_L3PROPTABLE(CMELT_Top_Blowing,CL3Object)
	L3PROP_STRING(HeatID)
	L3PROP_FLOAT(Flow)
	L3PROP_FLOAT(Pressure)
	L3PROP_DATETIME(Catch_Time)
	L3PROP_DOUBLE(Flow_MainPipe)
	L3PROP_DOUBLE(Press_MainPipe)
END_L3PROPTABLE(CMELT_Top_Blowing)

BEGIN_L3METHODMAP(CMELT_Top_Blowing,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CMELT_Top_Blowing,CL3Object)
END_L3EVENTSINK_MAP(CMELT_Top_Blowing)

CMELT_Top_Blowing::CMELT_Top_Blowing(void)
{
}

CMELT_Top_Blowing::~CMELT_Top_Blowing(void)
{
}
