// �߼���CDutyDefinitionͷ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����
#pragma once

class CMELT_Duty_Definition :
	public CL3Object
{
public:
	CMELT_Duty_Definition(void);
	virtual ~CMELT_Duty_Definition(void);

	DECLARE_L3CLASS(CMELT_Duty_Definition,XGMESLogic\\MELTMag, ObjectID)
	DECLARE_L3PROPTABLE()
	DECLARE_L3METHODMAP(CMELT_Duty_Definition)
	DECLARE_L3EVENTSINK_MAP()

	//������װ�ص�ϵͳ��ʱ��������
	virtual void OnLoaded();
	//������ж��ʱ��������
	virtual void OnUnloaded();

	/// <Property class="CMELT_Duty_Definition" name="ObjectID" type="L3STRING">
	/// ����
	/// </Property>
	DECLARE_L3PROP_STRING(ObjectID)

	/// <Property class="CMELT_Duty_Definition" name="UnitID" type="L3STRING">
	/// </Property>
	DECLARE_L3PROP_STRING(UnitID)


	/// <Property class="CMELT_Duty_Definition" name="Team" type="L3STRING">
	/// 
	/// ���
	/// (1:��
	/// 2:��
	/// 3:��
	/// 4:��)
	/// </Property>
	DECLARE_L3PROP_STRING(Team)

	/// <Property class="CMELT_Duty_Definition" name="HeadFurnace" type="L3STRING">
	/// ¯��
	/// </Property>
	DECLARE_L3PROP_STRING(HeadFurnace)

	/// <Property class="CMELT_Duty_Definition" name="Assistant" type="L3STRING">
	/// һ����
	/// </Property>
	DECLARE_L3PROP_STRING(Assistant)

	/// <Property class="CMELT_Duty_Definition" name="SecondHand" type="L3STRING">
	/// ������
	/// </Property>
	DECLARE_L3PROP_STRING(SecondHand)

};
