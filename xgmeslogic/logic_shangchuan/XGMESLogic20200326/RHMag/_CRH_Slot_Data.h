// �߼���CRH_Slot_Dataͷ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����
#pragma once

class CRH_Slot_Data :
	public CL3Object
{
public:
	CRH_Slot_Data(void);
	virtual ~CRH_Slot_Data(void);

	DECLARE_L3CLASS(CRH_Slot_Data,XGMESLogic\\RHMag, GUID)
	DECLARE_L3PROPTABLE()
	DECLARE_L3METHODMAP(CRH_Slot_Data)
	DECLARE_L3EVENTSINK_MAP()

	//������װ�ص�ϵͳ��ʱ��������
	virtual void OnLoaded();
	//������ж��ʱ��������
	virtual void OnUnloaded();

	/// <Property class="CRH_Slot_Data" name="Slot_No" type="L3STRING">
	/// �ۺ�
	/// </Property>
	DECLARE_L3PROP_STRING(Slot_No)

	/// <Property class="CRH_Slot_Data" name="Validity" type="L3SHORT">
	/// 
	/// ��Ч��
	/// (1-��Ч
	///  0-��Ч)
	/// </Property>
	DECLARE_L3PROP_SHORT(Validity)

	/// <Property class="CRH_Slot_Data" name="RHID" type="L3SHORT">
	/// RH¯��
	/// </Property>
	DECLARE_L3PROP_SHORT(RHID)

	/// <Property class="CRH_Slot_Data" name="Create_Time" type="L3DATETIME">
	/// ����ʱ��
	/// </Property>
	DECLARE_L3PROP_DATETIME(Create_Time)

	/// <Property class="CRH_Slot_Data" name="Valid_Time" type="L3DATETIME">
	/// ��Ч������ʱ��
	/// </Property>
	DECLARE_L3PROP_DATETIME(Valid_Time)

	/// <Property class="CRH_Slot_Data" name="Operator" type="L3STRING">
	/// ����Ա
	/// </Property>
	DECLARE_L3PROP_STRING(Operator)

};
