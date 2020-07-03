// �߼���CRH_Process_Dataͷ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����
#pragma once

class CRH_Process_Data :
	public CL3Object
{
public:
	CRH_Process_Data(void);
	virtual ~CRH_Process_Data(void);

	DECLARE_L3CLASS(CRH_Process_Data,XGMESLogic\\RHMag, TreatNo)
	DECLARE_L3PROPTABLE()
	DECLARE_L3METHODMAP(CRH_Process_Data)
	DECLARE_L3EVENTSINK_MAP()

	//������װ�ص�ϵͳ��ʱ��������
	virtual void OnLoaded();
	//������ж��ʱ��������
	virtual void OnUnloaded();

	/// <Property class="CRH_Process_Data" name="TreatNo" type="L3STRING">
	/// �����
	/// </Property>
	DECLARE_L3PROP_STRING(TreatNo)

	/// <Property class="CRH_Process_Data" name="HeatID" type="L3STRING">
	/// ¯��
	/// </Property>
	DECLARE_L3PROP_STRING(HeatID)

	/// <Property class="CRH_Process_Data" name="Arrival_Time" type="L3DATETIME">
	/// ����ʱ��
	/// </Property>
	DECLARE_L3PROP_DATETIME(Arrival_Time)

	
	
	/// <Property class="CRH_Process_Data" name="Arrival_Temp" type="L3SHORT">
	/// ��վ�¶�
	/// </Property>
	DECLARE_L3PROP_SHORT(Arrival_Temp)

	
	
	/// <Property class="CRH_Process_Data" name="Arrival_Temp_Quality" type="L3SHORT">
	/// 
	/// ��վ�¶Ⱥϸ��
	/// (1:�ϸ�;0:���ϸ�)
	/// </Property>
	DECLARE_L3PROP_SHORT(Arrival_Temp_Quality)

	/// <Property class="CRH_Process_Data" name="Slag_Thick" type="L3FLOAT">
	/// ����
	/// </Property>
	DECLARE_L3PROP_FLOAT(Slag_Thick)

	/// <Property class="CRH_Process_Data" name="Process_Location" type="L3STRING">
	/// ����λ
	/// </Property>
	DECLARE_L3PROP_STRING(Process_Location)

	/// <Property class="CRH_Process_Data" name="Slot_No" type="L3STRING">
	/// �ۺ�
	/// </Property>
	DECLARE_L3PROP_STRING(Slot_No)

	/// <Property class="CRH_Process_Data" name="Process_Mode" type="L3SHORT">
	/// 
	/// ����ģʽ
	/// (1:�ᴦ��;
	///  2:������)
	/// </Property>
	DECLARE_L3PROP_SHORT(Process_Mode)

	/// <Property class="CRH_Process_Data" name="Start_Time" type="L3DATETIME">
	/// ��մ���ʼʱ��
	/// </Property>
	DECLARE_L3PROP_DATETIME(Start_Time)

	/// <Property class="CRH_Process_Data" name="End_Time" type="L3DATETIME">
	/// ��մ������ʱ��
	/// </Property>
	DECLARE_L3PROP_DATETIME(End_Time)

	/// <Property class="CRH_Process_Data" name="Process_Time" type="L3LONG">
	/// ��ҵʱ��
	/// </Property>
	DECLARE_L3PROP_LONG(Process_Time)

	/// <Property class="CRH_Process_Data" name="Loop_Time" type="L3LONG">
	/// ��ѭ��ʱ��
	/// </Property>
	DECLARE_L3PROP_LONG(Loop_Time)

	
	/// <Property class="CRH_Process_Data" name="Vac_Min" type="L3FLOAT">
	/// �����ն�
	/// </Property>
	DECLARE_L3PROP_FLOAT(Vac_Min)

	
	
	/// <Property class="CRH_Process_Data" name="OB_Count" type="L3SHORT">
	/// OB����
	/// </Property>
	DECLARE_L3PROP_SHORT(OB_Count)

	/// <Property class="CRH_Process_Data" name="O2_CONS" type="L3FLOAT">
	/// ��������
	/// </Property>
	DECLARE_L3PROP_FLOAT(O2_CONS)

	/// <Property class="CRH_Process_Data" name="Al_CONS" type="L3FLOAT">
	/// ��������
	/// </Property>
	DECLARE_L3PROP_FLOAT(Al_CONS)

	/// <Property class="CRH_Process_Data" name="OB_Cycle_Time" type="L3LONG">
	/// OB����ʱ��
	/// </Property>
	DECLARE_L3PROP_LONG(OB_Cycle_Time)

	/// <Property class="CRH_Process_Data" name="Probe_Vonder" type="L3STRING">
	/// 
	/// ʹ�ö���̽ͷ����
	/// (�����ϡ�����������)
	/// </Property>
	DECLARE_L3PROP_STRING(Probe_Vonder)

	/// <Property class="CRH_Process_Data" name="Wire_End_Time" type="L3DATETIME">
	/// �ƴ������ʱ��
	/// </Property>
	DECLARE_L3PROP_DATETIME(Wire_End_Time)

	
	
	/// <Property class="CRH_Process_Data" name="Wire_End_Temp" type="L3SHORT">
	/// �ƴ�������¶�
	/// </Property>
	DECLARE_L3PROP_SHORT(Wire_End_Temp)

	/// <Property class="CRH_Process_Data" name="SoftBlow_StartTime" type="L3DATETIME">
	/// ����ʼʱ��
	/// </Property>
	DECLARE_L3PROP_DATETIME(SoftBlow_StartTime)

	/// <Property class="CRH_Process_Data" name="SoftBlow_EndTime" type="L3DATETIME">
	/// ������ʱ��
	/// </Property>
	DECLARE_L3PROP_DATETIME(SoftBlow_EndTime)

	/// <Property class="CRH_Process_Data" name="SoftBlow_Time" type="L3LONG">
	/// ��ʱ��
	/// </Property>
	DECLARE_L3PROP_LONG(SoftBlow_Time)

	
	/// <Property class="CRH_Process_Data" name="Departure_Temp" type="L3LONG">
	/// ��վ�¶�
	/// </Property>
	DECLARE_L3PROP_LONG(Departure_Temp)

	
	
	/// <Property class="CRH_Process_Data" name="CircsOfRhythm" type="L3SHORT">
	/// 
	/// �������
	/// (0:����
	/// 1:����)
	/// </Property>
	DECLARE_L3PROP_SHORT(CircsOfRhythm)

	/// <Property class="CRH_Process_Data" name="VacDownTo35000_Time" type="L3LONG">
	/// ��նȽ���35Kpaʱ��
	/// </Property>
	DECLARE_L3PROP_LONG(VacDownTo35000_Time)

	/// <Property class="CRH_Process_Data" name="VacDownTo11500_Time" type="L3LONG">
	/// ��նȽ���11.5Kpaʱ��
	/// </Property>
	DECLARE_L3PROP_LONG(VacDownTo11500_Time)

	/// <Property class="CRH_Process_Data" name="VacDownTo2500_Time" type="L3LONG">
	/// ��նȽ���2.5Kpaʱ��
	/// </Property>
	DECLARE_L3PROP_LONG(VacDownTo2500_Time)

	/// <Property class="CRH_Process_Data" name="VacDownTo500_Time" type="L3LONG">
	/// ��նȽ���0.5Kpaʱ��
	/// </Property>
	DECLARE_L3PROP_LONG(VacDownTo500_Time)

	/// <Property class="CRH_Process_Data" name="CCM_Ladle_Weight" type="L3DOUBLE">
	/// RH��վʱ�����������
	/// </Property>
	DECLARE_L3PROP_DOUBLE(CCM_Ladle_Weight)

	//2009-03-30
	/// <Property class="CRH_Process_Data" name="LadleNo" type="L3STRING">
	/// �ְ���
	/// </Property>
	DECLARE_L3PROP_STRING(LadleNo)
	
	/// <Property class="CRH_Process_Data" name="LadleGrade" type="L3STRING">
	/// �ְ�����
	/// </Property>
	DECLARE_L3PROP_STRING(LadleGrade)

	/// <Property class="CRH_Process_Data" name="WholePump_Time" type="L3LONG">
	/// ȫ��Ͷ��ʱ��
	/// </Property>
	DECLARE_L3PROP_LONG(WholePump_Time)

};
