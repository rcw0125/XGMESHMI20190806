// �߼���CRH_BlowAr_DataԴ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����

#include "StdAfx.h"
#include "_CRH_BlowAr_Data.h"

IMPLEMENT_L3CLASS(CRH_BlowAr_Data,CL3Object,1)

BEGIN_L3PROPTABLE(CRH_BlowAr_Data,CL3Object)
	L3PROP_STRING(TreatNo)
	L3PROP_STRING(HeatID)
	L3PROP_DOUBLE(Flow_BlowAr)
	L3PROP_DATETIME(LogTime)
END_L3PROPTABLE(CRH_BlowAr_Data)

BEGIN_L3METHODMAP(CRH_BlowAr_Data,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CRH_BlowAr_Data,CL3Object)
END_L3EVENTSINK_MAP(CRH_BlowAr_Data)

CRH_BlowAr_Data::CRH_BlowAr_Data(void)
{
}

CRH_BlowAr_Data::~CRH_BlowAr_Data(void)
{
}
