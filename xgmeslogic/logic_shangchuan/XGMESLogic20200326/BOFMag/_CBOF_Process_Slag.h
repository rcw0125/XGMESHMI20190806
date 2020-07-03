// �߼���CBOF_Process_Slagͷ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����
#pragma once

class CBOF_Process_Slag :
	public CL3Object
{
public:
	CBOF_Process_Slag(void);
	virtual ~CBOF_Process_Slag(void);

	DECLARE_L3CLASS(CBOF_Process_Slag,XGMESLogic\\BOFMag, GUID)
	DECLARE_L3PROPTABLE()
	DECLARE_L3METHODMAP(CBOF_Process_Slag)
	DECLARE_L3EVENTSINK_MAP()

	//������װ�ص�ϵͳ��ʱ��������
	virtual void OnLoaded();
	//������ж��ʱ��������
	virtual void OnUnloaded();

	/// <Property class="CBOF_Process_Slag" name="HeatID" type="L3STRING">
	/// ¯��
	/// </Property>
	DECLARE_L3PROP_STRING(HeatID)

	/// <Property class="CBOF_Process_Slag" name="Status" type="L3SHORT">
	/// 
	/// ״̬(1:������
	///          -1:����;
	
	/// </Property>
	DECLARE_L3PROP_SHORT(Status)

	/*DECLARE_L3PROP_STRING(Type)*/

	/// <Property class="CBOF_Process_Slag" name="Change_Time" type="L3DATETIME">
	/// ״̬�仯ʱ��
	/// </Property>
	DECLARE_L3PROP_DATETIME(Change_Time)

};
