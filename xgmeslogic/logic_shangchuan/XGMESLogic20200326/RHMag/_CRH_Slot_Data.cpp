// �߼���CRH_Slot_DataԴ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����

#include "StdAfx.h"
#include "_CRH_Slot_Data.h"

IMPLEMENT_L3CLASS(CRH_Slot_Data,CL3Object,1)

BEGIN_L3PROPTABLE(CRH_Slot_Data,CL3Object)
	L3PROP_STRING(Slot_No)
	L3PROP_SHORT(Validity)
	L3PROP_SHORT(RHID)
	L3PROP_DATETIME(Create_Time)
	L3PROP_DATETIME(Valid_Time)
	L3PROP_STRING(Operator)
END_L3PROPTABLE(CRH_Slot_Data)

BEGIN_L3METHODMAP(CRH_Slot_Data,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CRH_Slot_Data,CL3Object)
END_L3EVENTSINK_MAP(CRH_Slot_Data)

CRH_Slot_Data::CRH_Slot_Data(void)
{
}

CRH_Slot_Data::~CRH_Slot_Data(void)
{
}
