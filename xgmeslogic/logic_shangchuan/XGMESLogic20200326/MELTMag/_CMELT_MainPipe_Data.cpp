// �߼���CMELT_MainPipe_DataԴ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����

#include "StdAfx.h"
#include "_CMELT_MainPipe_Data.h"

IMPLEMENT_L3CLASS(CMELT_MainPipe_Data,CL3Object,1)

BEGIN_L3PROPTABLE(CMELT_MainPipe_Data,CL3Object)
	L3PROP_FLOAT(Flow)
	L3PROP_FLOAT(Pressure)
	L3PROP_DATETIME(Catch_Time)
END_L3PROPTABLE(CMELT_MainPipe_Data)

BEGIN_L3METHODMAP(CMELT_MainPipe_Data,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CMELT_MainPipe_Data,CL3Object)
END_L3EVENTSINK_MAP(CMELT_MainPipe_Data)

CMELT_MainPipe_Data::CMELT_MainPipe_Data(void)
{
}

CMELT_MainPipe_Data::~CMELT_MainPipe_Data(void)
{
}
