// �߼���CMELT_Communicatorͷ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����
#pragma once

class CMELT_Communicator :
	public CL3Object
{
public:
	CMELT_Communicator(void);
	virtual ~CMELT_Communicator(void);

	DECLARE_L3CLASS(CMELT_Communicator,XGMESLogic\\MELTMag, GUID)
	DECLARE_L3PROPTABLE()
	DECLARE_L3METHODMAP(CMELT_Communicator)
	DECLARE_L3EVENTSINK_MAP()

	//������װ�ص�ϵͳ��ʱ��������
	virtual void OnLoaded();
	//������ж��ʱ��������
	virtual void OnUnloaded();

	/// <Method class="CMELT_Communicator" name="OnFeedIron" type="L3BOOL">
	/// ��Ӧ�����ӷϸ��¼�����
	/// <Param name="rsData" type="L3RECORDSET">��������</Param>
	/// </Method>
	L3BOOL OnFeedIron(L3RECORDSET rsData);
	/// <Method class="CMELT_Communicator" name="OnChangeStatus" type="L3BOOL">
	/// <Param name="rsData" type="L3RECORDSET">
	/// ״̬����
	/// (BOFID,Status,Change_Time)</Param>
	/// </Method>
	L3BOOL OnChangeStatus(L3RECORDSET rsData);
	/// <Method class="CMELT_Communicator" name="OnDischarge" type="L3BOOL">
	/// <Param name="rsData" type="L3RECORDSET">
	/// ���ϼ�¼��
	/// (Element,Weight,Discharge_Time,Type)</Param>
	/// </Method>
	L3BOOL OnDischarge(L3RECORDSET rsData);
	/// <Method class="CMELT_Communicator" name="OnMeasureTemp" type="L3BOOL">
	/// �����¼���Ӧ����
	/// <Param name="rsData" type="L3RECORDSET">
	/// ��������
	/// (Temp,Temp_Time,Mode)</Param>
	/// </Method>
	L3BOOL OnMeasureTemp(L3RECORDSET rsData);
	/// <Method class="CMELT_Communicator" name="OnMeasureO2" type="L3BOOL">
	/// <Param name="rsData" type="L3RECORDSET">
	/// ��������
	/// (O2,Measure_Time)</Param>
	/// </Method>
	L3BOOL OnMeasureO2(L3RECORDSET rsData);
	/// <Method class="CMELT_Communicator" name="OnTapped" type="L3BOOL">
	/// <Param name="rsData" type="L3RECORDSET"></Param>
	/// </Method>
	L3BOOL OnTapped(L3RECORDSET rsData);
	/// <Method class="CMELT_Communicator" name="OnBottomBlow" type="L3BOOL">
	/// <Param name="rsData" type="L3RECORDSET">
	/// �״�����
	/// (BOFID,Flow1...Flow6,Pressure1...Pressure6,Gas_Type)</Param>
	/// </Method>
	L3BOOL OnBottomBlow(L3RECORDSET rsData);
	/// <Method class="CMELT_Communicator" name="OnTopBlow" type="L3BOOL">
	/// <Param name="rsData" type="L3RECORDSET">
	/// ��������
	/// (BFID,Flow,Pressure,Catch_Time)</Param>
	/// </Method>
	L3BOOL OnTopBlow(L3RECORDSET rsData);
	/// <Method class="CMELT_Communicator" name="OnSauceEvent" type="L3BOOL">
	/// <Param name="rsData" type="L3RECORDSET"></Param>
	/// </Method>
	L3BOOL OnSauceEvent(L3RECORDSET rsData);
	/// <Method class="CMELT_Communicator" name="OnTapStart" type="L3BOOL">
	/// <Param name="rsData" type="L3RECORDSET"></Param>
	/// </Method>
	L3BOOL OnTapStart(L3RECORDSET rsData);
};
