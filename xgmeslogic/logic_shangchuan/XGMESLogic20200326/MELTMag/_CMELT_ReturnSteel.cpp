// �߼���CMELT_ReturnSteelԴ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����

#include "StdAfx.h"
#include "_CMELT_ReturnSteel.h"

IMPLEMENT_L3CLASS(CMELT_ReturnSteel,CL3Object,1)

BEGIN_L3PROPTABLE(CMELT_ReturnSteel,CL3Object)
	L3PROP_STRING(HeatID)
	L3PROP_DOUBLE(Return_Steel_Weight)
END_L3PROPTABLE(CMELT_ReturnSteel)

BEGIN_L3METHODMAP(CMELT_ReturnSteel,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CMELT_ReturnSteel,CL3Object)
END_L3EVENTSINK_MAP(CMELT_ReturnSteel)

CMELT_ReturnSteel::CMELT_ReturnSteel(void)
{
}

CMELT_ReturnSteel::~CMELT_ReturnSteel(void)
{
}
