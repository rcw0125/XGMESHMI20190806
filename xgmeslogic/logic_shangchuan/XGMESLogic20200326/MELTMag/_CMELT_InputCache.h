// �߼���CMELT_InputCacheͷ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����
#pragma once

class CMELT_InputCache :
	public CL3Object
{
public:
	CMELT_InputCache(void);
	virtual ~CMELT_InputCache(void);

	DECLARE_L3CLASS(CMELT_InputCache,XGMESLogic\\MELTMag, GUID)
	DECLARE_L3PROPTABLE()
	DECLARE_L3METHODMAP(CMELT_InputCache)
	DECLARE_L3EVENTSINK_MAP()

	//������װ�ص�ϵͳ��ʱ��������
	virtual void OnLoaded();
	//������ж��ʱ��������
	virtual void OnUnloaded();

};
