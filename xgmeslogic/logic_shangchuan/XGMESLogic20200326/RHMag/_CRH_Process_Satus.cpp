// �߼���CRH_Process_SatusԴ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����

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
