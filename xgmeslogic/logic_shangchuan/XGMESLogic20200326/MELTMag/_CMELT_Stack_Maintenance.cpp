// �߼���CMELT_Stack_MaintenanceԴ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����

#include "StdAfx.h"
#include "_CMELT_Stack_Maintenance.h"

IMPLEMENT_L3CLASS(CMELT_Stack_Maintenance,CL3Object,1)

BEGIN_L3PROPTABLE(CMELT_Stack_Maintenance,CL3Object)
	L3PROP_DATETIME(ProductionDate)
	L3PROP_STRING(Team)
	L3PROP_STRING(Content)
	L3PROP_STRING(Materiel)
	L3PROP_STRING(Taphole_Vendor)
	L3PROP_STRING(Materiel_Vendor)
	L3PROP_FLOAT(Wastage)
	L3PROP_STRING(BOFID)
	L3PROP_LONG(Sintering_Time)
END_L3PROPTABLE(CMELT_Stack_Maintenance)

BEGIN_L3METHODMAP(CMELT_Stack_Maintenance,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CMELT_Stack_Maintenance,CL3Object)
END_L3EVENTSINK_MAP(CMELT_Stack_Maintenance)

CMELT_Stack_Maintenance::CMELT_Stack_Maintenance(void)
{
}

CMELT_Stack_Maintenance::~CMELT_Stack_Maintenance(void)
{
}
