// �߼���CMELT_ChangeLanceReasonԴ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����

#include "StdAfx.h"
#include "_CMELT_ChangeLanceReason.h"

IMPLEMENT_L3CLASS(CMELT_ChangeLanceReason,CL3Object,1)

BEGIN_L3PROPTABLE(CMELT_ChangeLanceReason,CL3Object)
	L3PROP_SHORT(BOFID)
	L3PROP_DATETIME(ChangeLance_Time)
	L3PROP_STRING(Reason)
END_L3PROPTABLE(CMELT_ChangeLanceReason)

BEGIN_L3METHODMAP(CMELT_ChangeLanceReason,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CMELT_ChangeLanceReason,CL3Object)
END_L3EVENTSINK_MAP(CMELT_ChangeLanceReason)

CMELT_ChangeLanceReason::CMELT_ChangeLanceReason(void)
{
}

CMELT_ChangeLanceReason::~CMELT_ChangeLanceReason(void)
{
}
