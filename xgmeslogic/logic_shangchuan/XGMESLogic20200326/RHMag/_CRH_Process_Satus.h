// �߼���CRH_Process_Satusͷ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����
#pragma once

class CRH_Process_Satus :
	public CL3Object
{
public:
	CRH_Process_Satus(void);
	virtual ~CRH_Process_Satus(void);

	DECLARE_L3CLASS(CRH_Process_Satus,XGMESLogic\\RHMag, GUID)
	DECLARE_L3PROPTABLE()
	DECLARE_L3METHODMAP(CRH_Process_Satus)
	DECLARE_L3EVENTSINK_MAP()

	//������װ�ص�ϵͳ��ʱ��������
	virtual void OnLoaded();
	//������ж��ʱ��������
	virtual void OnUnloaded();

	/// <Property class="CRH_Process_Satus" name="TreatNo" type="L3STRING">
	/// �����
	/// </Property>
	DECLARE_L3PROP_STRING(TreatNo)

	/// <Property class="CRH_Process_Satus" name="HeatID" type="L3STRING">
	/// ¯��
	/// </Property>
	DECLARE_L3PROP_STRING(HeatID)

	/// <Property class="CRH_Process_Satus" name="Status" type="L3LONG">
	/// 
	/// ״̬(1:��վ;
	///          2:����ʼ;
	///          3:OB;
	///          4:��մ���;
	///          5:�����Ͻ�;
	///          6:�������;
	///          7:ι˿;
	///          8:��վ)
	/// </Property>
	DECLARE_L3PROP_LONG(Status)

	/// <Property class="CRH_Process_Satus" name="Change_Time" type="L3DATETIME">
	/// ״̬�仯ʱ��
	/// </Property>
	DECLARE_L3PROP_DATETIME(Change_Time)

};
