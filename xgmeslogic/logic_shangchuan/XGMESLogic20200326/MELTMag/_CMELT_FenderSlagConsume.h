// �߼���CMELT_FenderSlagConsumeͷ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����
#pragma once

class CMELT_FenderSlagConsume :
	public CL3Object
{
public:
	CMELT_FenderSlagConsume(void);
	virtual ~CMELT_FenderSlagConsume(void);

	DECLARE_L3CLASS(CMELT_FenderSlagConsume,XGMESLogic\\MELTMag, GUID)
	DECLARE_L3PROPTABLE()
	DECLARE_L3METHODMAP(CMELT_FenderSlagConsume)
	DECLARE_L3EVENTSINK_MAP()

	//������װ�ص�ϵͳ��ʱ��������
	virtual void OnLoaded();
	//������ж��ʱ��������
	virtual void OnUnloaded();

	/// <Property class="CMELT_FenderSlagConsume" name="HeatID" type="L3STRING">
	/// ¯��
	/// </Property>
	DECLARE_L3PROP_STRING(HeatID)

	/// <Property class="CMELT_FenderSlagConsume" name="FenderSlag" type="L3SHORT">
	/// 
	/// ��������
	/// (1:������
	///  2:����׶
	///  3:������)
	/// </Property>
	DECLARE_L3PROP_SHORT(FenderSlag)

	/// <Property class="CMELT_FenderSlagConsume" name="Consume" type="L3FLOAT">
	/// ����
	/// </Property>
	DECLARE_L3PROP_FLOAT(Consume)

};
