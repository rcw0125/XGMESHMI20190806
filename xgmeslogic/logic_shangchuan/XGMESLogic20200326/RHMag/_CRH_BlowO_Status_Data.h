// �߼���CRH_BlowO_Status_Dataͷ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����
#pragma once

class CRH_BlowO_Status_Data :
	public CL3Object
{
public:
	CRH_BlowO_Status_Data(void);
	virtual ~CRH_BlowO_Status_Data(void);

	DECLARE_L3CLASS(CRH_BlowO_Status_Data,XGMESLogic\\RHMag, GUID)
	DECLARE_L3PROPTABLE()
	DECLARE_L3METHODMAP(CRH_BlowO_Status_Data)
	DECLARE_L3EVENTSINK_MAP()

	//������װ�ص�ϵͳ��ʱ��������
	virtual void OnLoaded();
	//������ж��ʱ��������
	virtual void OnUnloaded();

	/// <Property class="CRH_BlowO_Status_Data" name="TreatNo" type="L3STRING">
	/// �����
	/// </Property>
	DECLARE_L3PROP_STRING(TreatNo)

	/// <Property class="CRH_BlowO_Status_Data" name="HeatID" type="L3STRING">
	/// ¯��
	/// </Property>
	DECLARE_L3PROP_STRING(HeatID)

	/// <Property class="CRH_BlowO_Status_Data" name="Status" type="L3LONG">
	/// ��ǹ����״̬
	/// </Property>
	DECLARE_L3PROP_LONG(Status)

	/// <Property class="CRH_BlowO_Status_Data" name="MeasureTime" type="L3DATETIME">
	/// ״̬�仯ʱ��
	/// </Property>
	DECLARE_L3PROP_DATETIME(MeasureTime)

};
