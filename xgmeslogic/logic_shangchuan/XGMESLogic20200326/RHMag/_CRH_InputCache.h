// �߼���CRH_InputCacheͷ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����
#pragma once

class CRH_InputCache :
	public CL3Object
{
public:
	CRH_InputCache(void);
	virtual ~CRH_InputCache(void);

	DECLARE_L3CLASS(CRH_InputCache,XGMESLogic\\RHMag, GUID)
	DECLARE_L3PROPTABLE()
	DECLARE_L3METHODMAP(CRH_InputCache)
	DECLARE_L3EVENTSINK_MAP()

	//������װ�ص�ϵͳ��ʱ��������
	virtual void OnLoaded();
	//������ж��ʱ��������
	virtual void OnUnloaded();

};
