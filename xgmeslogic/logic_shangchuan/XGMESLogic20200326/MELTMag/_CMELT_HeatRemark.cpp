// �߼���CMELT_HeatRemarkԴ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����

#include "StdAfx.h"
#include "_CMELT_HeatRemark.h"

IMPLEMENT_L3CLASS(CMELT_HeatRemark,CL3Object,1)

BEGIN_L3PROPTABLE(CMELT_HeatRemark,CL3Object)
	L3PROP_STRING(HeatID)
	L3PROP_SHORT(TypeID)
	L3PROP_STRING(Remark)
	L3PROP_DATETIME(Log_Time)
END_L3PROPTABLE(CMELT_HeatRemark)

BEGIN_L3METHODMAP(CMELT_HeatRemark,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CMELT_HeatRemark,CL3Object)
END_L3EVENTSINK_MAP(CMELT_HeatRemark)

CMELT_HeatRemark::CMELT_HeatRemark(void)
{
}

CMELT_HeatRemark::~CMELT_HeatRemark(void)
{
}
