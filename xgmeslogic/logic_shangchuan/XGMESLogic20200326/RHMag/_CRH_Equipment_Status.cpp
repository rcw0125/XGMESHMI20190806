// �߼���CRH_Equipment_StatusԴ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����

#include "StdAfx.h"
#include "_CRH_Equipment_Status.h"

IMPLEMENT_L3CLASS(CRH_Equipment_Status,CL3Object,1)

BEGIN_L3PROPTABLE(CRH_Equipment_Status,CL3Object)
	L3PROP_SHORT(RHID)
	L3PROP_SHORT(Status)
	L3PROP_DATETIME(Log_Time)
	L3PROP_STRING(Reason)
END_L3PROPTABLE(CRH_Equipment_Status)

BEGIN_L3METHODMAP(CRH_Equipment_Status,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CRH_Equipment_Status,CL3Object)
END_L3EVENTSINK_MAP(CRH_Equipment_Status)

CRH_Equipment_Status::CRH_Equipment_Status(void)
{
}

CRH_Equipment_Status::~CRH_Equipment_Status(void)
{
}
