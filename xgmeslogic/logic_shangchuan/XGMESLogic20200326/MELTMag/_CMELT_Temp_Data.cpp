// �߼���CMELT_Temp_DataԴ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����

#include "StdAfx.h"
#include "_CMELT_Temp_Data.h"

IMPLEMENT_L3CLASS(CMELT_Temp_Data,CL3Object,1)

BEGIN_L3PROPTABLE(CMELT_Temp_Data,CL3Object)
	L3PROP_STRING(HeatID)
	L3PROP_LONG(Temp)
	L3PROP_DATETIME(Temp_Time)
	L3PROP_SHORT(Mode)
END_L3PROPTABLE(CMELT_Temp_Data)

BEGIN_L3METHODMAP(CMELT_Temp_Data,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CMELT_Temp_Data,CL3Object)
END_L3EVENTSINK_MAP(CMELT_Temp_Data)

CMELT_Temp_Data::CMELT_Temp_Data(void)
{
}

CMELT_Temp_Data::~CMELT_Temp_Data(void)
{
}
