// �߼���CMELT_FenderSlagConsumeԴ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����

#include "StdAfx.h"
#include "_CMELT_FenderSlagConsume.h"

IMPLEMENT_L3CLASS(CMELT_FenderSlagConsume,CL3Object,1)

BEGIN_L3PROPTABLE(CMELT_FenderSlagConsume,CL3Object)
	L3PROP_STRING(HeatID)
	L3PROP_SHORT(FenderSlag)
	L3PROP_FLOAT(Consume)
END_L3PROPTABLE(CMELT_FenderSlagConsume)

BEGIN_L3METHODMAP(CMELT_FenderSlagConsume,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CMELT_FenderSlagConsume,CL3Object)
END_L3EVENTSINK_MAP(CMELT_FenderSlagConsume)

CMELT_FenderSlagConsume::CMELT_FenderSlagConsume(void)
{
}

CMELT_FenderSlagConsume::~CMELT_FenderSlagConsume(void)
{
}
