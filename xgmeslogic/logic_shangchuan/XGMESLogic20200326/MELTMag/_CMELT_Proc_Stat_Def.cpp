// �߼���CMELT_Proc_Stat_DefԴ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����

#include "StdAfx.h"
#include "_CMELT_Proc_Stat_Def.h"

IMPLEMENT_L3CLASS(CMELT_Proc_Stat_Def,CL3Object,1)

BEGIN_L3PROPTABLE(CMELT_Proc_Stat_Def,CL3Object)
	L3PROP_SHORT(Status)
	L3PROP_STRING(Descr)
END_L3PROPTABLE(CMELT_Proc_Stat_Def)

BEGIN_L3METHODMAP(CMELT_Proc_Stat_Def,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CMELT_Proc_Stat_Def,CL3Object)
END_L3EVENTSINK_MAP(CMELT_Proc_Stat_Def)

CMELT_Proc_Stat_Def::CMELT_Proc_Stat_Def(void)
{
}

CMELT_Proc_Stat_Def::~CMELT_Proc_Stat_Def(void)
{
}
