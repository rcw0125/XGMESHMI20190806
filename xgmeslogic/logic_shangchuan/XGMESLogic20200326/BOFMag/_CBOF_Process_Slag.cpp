// �߼���CBOF_Process_SlagԴ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����

#include "StdAfx.h"
#include "_CBOF_Process_Slag.h"

IMPLEMENT_L3CLASS(CBOF_Process_Slag,CL3Object,1)

BEGIN_L3PROPTABLE(CBOF_Process_Slag,CL3Object)
	L3PROP_STRING(HeatID)
	L3PROP_SHORT(Status)
	/*L3PROP_STRING(Type)*/
	L3PROP_DATETIME(Change_Time)
END_L3PROPTABLE(CBOF_Process_Slag)

BEGIN_L3METHODMAP(CBOF_Process_Slag,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CBOF_Process_Slag,CL3Object)
END_L3EVENTSINK_MAP(CBOF_Process_Slag)

CBOF_Process_Slag::CBOF_Process_Slag(void)
{
}

CBOF_Process_Slag::~CBOF_Process_Slag(void)
{
}
