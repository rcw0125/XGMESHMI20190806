// �߼���CDutyDefinitionԴ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����

#include "StdAfx.h"
#include "_CMELT_Duty_Definition.h"

IMPLEMENT_L3CLASS(CMELT_Duty_Definition,CL3Object,1)

BEGIN_L3PROPTABLE(CMELT_Duty_Definition,CL3Object)
    L3PROP_STRING(ObjectID)
	L3PROP_STRING(UnitID)
	L3PROP_STRING(Team)
	L3PROP_STRING(HeadFurnace)
	L3PROP_STRING(Assistant)
	L3PROP_STRING(SecondHand)
END_L3PROPTABLE(CMELT_Duty_Definition)

BEGIN_L3METHODMAP(CMELT_Duty_Definition,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CMELT_Duty_Definition,CL3Object)
END_L3EVENTSINK_MAP(CMELT_Duty_Definition)

CMELT_Duty_Definition::CMELT_Duty_Definition(void)
{
}

CMELT_Duty_Definition::~CMELT_Duty_Definition(void)
{
}
