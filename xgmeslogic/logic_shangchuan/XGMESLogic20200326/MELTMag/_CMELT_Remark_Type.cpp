// �߼���CMELT_Remark_TypeԴ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����

#include "StdAfx.h"
#include "_CMELT_Remark_Type.h"

IMPLEMENT_L3CLASS(CMELT_Remark_Type,CL3Object,1)

BEGIN_L3PROPTABLE(CMELT_Remark_Type,CL3Object)
	L3PROP_SHORT(TypeID)
	L3PROP_STRING(TypeDes)
END_L3PROPTABLE(CMELT_Remark_Type)

BEGIN_L3METHODMAP(CMELT_Remark_Type,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CMELT_Remark_Type,CL3Object)
END_L3EVENTSINK_MAP(CMELT_Remark_Type)

CMELT_Remark_Type::CMELT_Remark_Type(void)
{
}

CMELT_Remark_Type::~CMELT_Remark_Type(void)
{
}
