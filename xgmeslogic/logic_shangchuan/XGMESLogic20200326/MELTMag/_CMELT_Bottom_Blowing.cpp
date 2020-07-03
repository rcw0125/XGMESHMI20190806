// �߼���CMELT_Bottom_BlowingԴ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����

#include "StdAfx.h"
#include "_CMELT_Bottom_Blowing.h"

IMPLEMENT_L3CLASS(CMELT_Bottom_Blowing,CL3Object,1)

BEGIN_L3PROPTABLE(CMELT_Bottom_Blowing,CL3Object)
	L3PROP_STRING(HeatID)
	L3PROP_DOUBLE(Flow1)
	L3PROP_DOUBLE(Pressure1)
	L3PROP_DOUBLE(Flow2)
	L3PROP_DOUBLE(Pressure2)
	L3PROP_DOUBLE(Flow3)
	L3PROP_DOUBLE(Pressure3)
	L3PROP_DOUBLE(Flow4)
	L3PROP_DOUBLE(Pressure4)
	L3PROP_DOUBLE(Flow5)
	L3PROP_DOUBLE(Pressure5)
	L3PROP_DOUBLE(Flow6)
	L3PROP_DOUBLE(Pressure6)
	L3PROP_STRING(Gas_Type)
	L3PROP_DATETIME(Catch_Time)
	L3PROP_STRING(ObjectID)
END_L3PROPTABLE(CMELT_Bottom_Blowing)

BEGIN_L3METHODMAP(CMELT_Bottom_Blowing,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CMELT_Bottom_Blowing,CL3Object)
END_L3EVENTSINK_MAP(CMELT_Bottom_Blowing)

CMELT_Bottom_Blowing::CMELT_Bottom_Blowing(void)
{
}

CMELT_Bottom_Blowing::~CMELT_Bottom_Blowing(void)
{
}
