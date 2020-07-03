// �߼���CRH_Unit_Magͷ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����
#pragma once
#include "ProduceUnit.h"

class CRH_Unit_Mag :
	public ProduceUnit
{
public:
	CRH_Unit_Mag(void);
	virtual ~CRH_Unit_Mag(void);

	DECLARE_L3CLASS(CRH_Unit_Mag,XGMESLogic\\RHMag, Name)
	DECLARE_L3PROPTABLE()
	DECLARE_L3METHODMAP(CRH_Unit_Mag)
	DECLARE_L3EVENTSINK_MAP()

	//������װ�ص�ϵͳ��ʱ��������
	virtual void OnLoaded();
	//������ж��ʱ��������
	virtual void OnUnloaded();

public:
	enum _RHStatus
	{
		// ����״̬
		RHWaiting = 0,		// �ȴ�
		RHProcBegin = 1,	// ����ʼ
		RHVacBegin = 2,		// ��ʼ��մ���
		RHOB = 3,			// �¹ܴ���
		RHAlloy = 4,		// �����Ͻ�
		RHProcEnd = 5,		// �������
		RHBlowBegin = 6,	// ����ʼ
		RHBlowEnd = 7,		// ������

	};

	//20098-03-02
	enum _RHEquipStatus
	{
		// �쳣״̬
		RHNormal = 0,       //����
		RHRepair = -1,		// ����
		RHFailure = -2,		// ����
	};

protected:

	CString csDischargeUnit;
	CString csWireUnit;

	/// <summary>
	/// ���ػ���ļӹ�����
	/// ARG << lstURIs : �������мӹ��������URI
	/// </summary>
	virtual BOOL GetProduceAreas(CStringList& lstURIs);

	/// <summary>
	/// ��ȡָ����������ĺ��������URI
	/// ARG >> lpcszCurArea : ��ǰ���������URI��
	///		>> rsMaterialInfo : ������Ϣ�����ڸ����жϡ�����MaterialType,MaterialID,Amount,�Ȳ�����Ϣ��
	///							ע�⣺Ӧ��ֻ�øü�¼���ĵ�ǰ�н����жϣ�����
	/// RET << ���غ������������URI�����ؿձ�ʾ��ǰ���������Ѿ��ǻ���ĳ����ˡ�
	/// </summary>
	virtual CString GetNextProduceArea(LPCTSTR lpcszCurArea,L3RECORDSET rsMaterialInfo) { return _T(""); };

	/// <summary>
	/// ��ȡָ�����������ǰ�������URI
	/// ARG >> lpcszCurArea : ��ǰ���������URI��
	///		>> rsMaterialInfo : ������Ϣ�����ڸ����жϡ�����MaterialType,MaterialID,Amount,�Ȳ�����Ϣ��
	///							ע�⣺Ӧ��ֻ�øü�¼���ĵ�ǰ�н����жϣ�����
	/// RET << ����ǰ�����������URI�����ؿձ�ʾ��ǰ���������Ѿ��ǻ��������ˡ�
	/// </summary>
	virtual CString GetPrevProduceArea(LPCTSTR lpcszCurArea,L3RECORDSET rsMaterialInfo) { return _T(""); };

	/// <summary>
	/// �õ�����ǰ����ϻ�������URI
	/// </summary>
	virtual CString GetInputCache();

	/// <summary>
	/// �õ������̲��ϻ�������URI
	/// </summary>
	virtual CString GetOutputCache();

	/// <summary>
	/// ��������ǰԤ�����ڻ�������ǰ���ã��̳�������ش˷�������Ԥ������׼���ʹ���
	/// ARG >> rsMaterialInfo : ������Ϣ��¼����
	/// RET << ����TRUE�������ϣ�����FALSE�ж����ϡ�
	/// </summary>
	virtual BOOL OnBeforeFeedMaterials(L3RECORDSET rsMaterialInfo);

	/// <summary>
	/// �������Ϻ��������ڻ������Ϻ���ã��̳�������ش˷������ж��⴦��
	/// ARG >> rsMaterialInfo : ������Ϣ��¼����
	/// RET << �ɹ�����TRUE��ʧ�ܷ���FALSE��
	/// </summary>
	virtual BOOL OnAfterMaterialsFeeded(L3RECORDSET rsMaterialInfo);

	/// <summary>
	/// ���ػ������ϼ�¼������URI
	/// </summary>
	virtual CString GetFeedingLogType();

	/// <summary>
	/// ׼�����ϼ�¼���ݡ��̳�������ش˺������ж�������ݴ���
	/// ARG >> rsFeedingLogs : ���ϼ�¼��Ϣ��
	/// RET << void
	/// </summary>
	virtual void PrepareFeedingLogs(L3RECORDSET rsFeedingLogs);

	/// <summary>
	/// �ӹ�����Ԥ�����ڵ��üӹ�����ļӹ�����ǰ���ã��̳�������ش˺����Լӹ����������޸ĺ����á�
	/// ARG >> lpcszArea : �ӹ������URI
	///		>> rsParameters : �ӹ�������¼����
	/// RET << ����TRUE�����ӹ�������FALSE�жϼӹ���
	/// </summary>
	virtual BOOL PrepareProcessParameters(LPCTSTR lpcszArea,L3RECORDSET rsParameters);

	/// <summary>
	/// �ӹ���ɺ��������ڼӹ���ɺ���ã��̳�������ش˺������ж����߼�����
	/// ARG >> lpcszArea : �ӹ������URI
	///		>> nProcessType : �ӹ������͡�
	///		>> rsProducts : �ӹ������Ĳ�Ʒ����Ϣ��¼��
	/// RET << �ɹ�����TRUE��ʧ�ܷ���FALSE��
	/// </summary>
	virtual BOOL OnAfterProcessCompleted(LPCTSTR lpcszArea,LONG nProcessType,L3RECORDSET rsProducts);

	/// <summary>
	/// ����ǰԤ������ִ�����߲���ǰ���ã��̳�������ش˺�������Ԥ�ȵ�����׼���ʹ���
	/// ARG >> rsMaterialInfo : ���߲�����Ϣ������MaterialType,MaterialID,Amount,Area�ֶΡ�
	/// RET << ����TRUE�������ߣ�����FALSE�ж����ߡ�
	/// </summary>
	virtual BOOL OnBeforeDeliverMaterials(L3RECORDSET rsMaterialInfo);

	/// <summary>
	/// ���ߺ���������ִ�����߲�������ã��̳�������ش˺������ж��⴦��
	/// ARG >> rsMaterialInfo : ���߲�����Ϣ������MaterialType,MaterialID,Amount,Area�ֶΡ�
	/// RET << �ɹ�����TRUE��ʧ�ܷ���FALSE��
	/// </summary>
	virtual BOOL OnAfterMaterialsDelivered(L3RECORDSET rsMaterialInfo);

	/// <summary>
	/// ���ػ��������¼������URI
	/// </summary>
	virtual CString GetDeliveryLogType();

	/// <summary>
	/// ׼�����ϼ�¼���ݡ�
	/// ARG >> rsDeliveryLog : ���ϼ�¼���ݡ�
	/// RET <<void
	/// </summary>
	virtual void PrepareDeliveryLogs(L3RECORDSET rsDeliveryLog);

	/// <summary>
	/// ���ر������ͨѶ�������URI
	/// </summary>
	virtual CString GetCommunicator();

	/// <summary>
	/// ׼���ƻ����ݣ��Ա��������λϵͳ���͡�
	/// ARG >> lpcszPlanType : �ƻ����͡�
	///		>> rsPlan : �ƻ����ݡ�����PlanID�ֶΡ�
	///		<< rsSend : ����׼���õļƻ��������ݡ�
	/// RET << �ɹ�����TRUE��ʧ�ܷ���FALSE��
	/// </summary>
	virtual BOOL PreparePlanForSending(LPCTSTR lpcszPlanType,L3RECORDSET rsPlan,L3RECORDSET* pprsSend);

	/// <summary>
	/// �ƻ��´��������������λϵͳ���ͼƻ�����ã��̳�������ش˺������к�������
	/// ARG >> rsSend : �·���λϵͳ�ļƻ����ݡ�
	/// RET << �ɹ�����TRUE��ʧ�ܷ���FALSE��
	/// </summary>
	virtual BOOL OnAfterPlansSent(L3RECORDSET rsSend);

	/// <summary>
	/// ׼���ƻ����ݣ��Ա�֪ͨ������λϵͳȡ���ƻ���
	/// ARG >> lpcszPlanType : �ƻ����͡�
	///		>> rsPlan : �ƻ����ݡ�����PlanID�ֶΡ�
	///		<< rsSend : ����׼���õļƻ�ȡ�����ݡ�
	/// RET << �ɹ�����TRUE��ʧ�ܷ���FALSE��
	/// </summary>
	virtual BOOL PreparePlanForCancel(LPCTSTR lpcszPlanType,L3RECORDSET rsPlan,L3RECORDSET* pprsCancel);

	/// <summary>
	/// �ƻ�ȡ����������������λϵͳ����ȡ���ƻ�����ã��̳�������ش˺������к�������
	/// ARG >> rsCancel : �·���λϵͳ�ļƻ�ȡ�����ݡ�
	/// RET << �ɹ�����TRUE��ʧ�ܷ���FALSE��
	/// </summary>
	virtual BOOL OnAfterPlansCanceled(L3RECORDSET rsCancel);

	/// <summary>
	/// ����������ߵ��¼�
	/// ARG >> pEvt : �¼�����
	/// RET << ����TRUE��ʾ�Ѿ��ɹ���������FALSE��ʾʹ��ϵͳȱʡ����ʽ��
	/// </summary>
	virtual BOOL HandleMaterialFeedingEvent(MatEnterArea *pEvt);
	/// <summary>
	/// ������Ͻ���ӹ�������¼�
	/// ARG >> pEvt : �¼�����
	/// RET << ����TRUE��ʾ�Ѿ��ɹ���������FALSE��ʾʹ��ϵͳȱʡ����ʽ��
	/// </summary>
	virtual BOOL HandleMaterialEnterAreaEvent(MatEnterArea *pEvt);
	/// <summary>
	/// ��������뿪�ӹ������¼�
	/// ARG >> pEvt : �¼�����
	/// RET << ����TRUE��ʾ�Ѿ��ɹ���������FALSE��ʾʹ��ϵͳȱʡ����ʽ��
	/// </summary>
	virtual BOOL HandleMaterialLeaveAreaEvent(MatLeaveArea *pEvt);
	/// <summary>
	/// ���������������¼�
	/// ARG >> pEvt : �¼�����
	/// RET << ����TRUE��ʾ�Ѿ��ɹ���������FALSE��ʾʹ��ϵͳȱʡ����ʽ��
	/// </summary>
	virtual BOOL HandleMaterialProducedEvent(MatProduced *pEvt);
	/// <summary>
	/// �������������ݱ���¼�
	/// ARG >> pEvt : �¼�����
	/// RET << ����TRUE��ʾ�Ѿ��ɹ���������FALSE��ʾʹ��ϵͳȱʡ����ʽ��
	/// </summary>
	virtual BOOL HandleUnitMeasureChangedEvent(UnitMeasure *pEvt);

	/// <Property class="CRH_Unit_Mag" name="TreatNo" type="L3STRING">
	/// ��ǰ�����
	/// </Property>
	DECLARE_L3PROP_STRING(TreatNo)

	/// <Property class="CRH_Unit_Mag" name="NextTreatNo" type="L3STRING">
	/// ��һ�����
	/// </Property>
	DECLARE_L3PROP_STRING(NextTreatNo)

	/// <Property class="CRH_Unit_Mag" name="Status" type="L3LONG">
	/// ����״̬
	/// </Property>
	DECLARE_L3PROP_LONG(Status)

	/// <Property class="CRH_Unit_Mag" name="Slot_No" type="L3STRING">
	/// �ۺ�
	/// </Property>
	DECLARE_L3PROP_STRING(Slot_No)

	/// <Property class="CRH_Unit_Mag" name="NextSteel" type="L3STRING">
	/// ��һ�����ߵĸ�ˮ
	/// </Property>
	DECLARE_L3PROP_STRING(NextSteel)

	/// <Property class="CRH_Unit_Mag" name="CurArea" type="L3STRING">
	/// ��ǰ���ڴ���Ĺ�λ
	/// </Property>
	DECLARE_L3PROP_STRING(CurArea)

	/// <Property class="CRH_Unit_Mag" name="ProcStartTime" type="L3DATETIME">
	/// ��ʼ����ʱ��
	/// </Property>
	DECLARE_L3PROP_DATETIME(ProcStartTime)

	/// <Property class="CRH_Unit_Mag" name="ProcStopTime" type="L3DATETIME">
	/// ��������ʱ��
	/// </Property>
	DECLARE_L3PROP_DATETIME(ProcStopTime)

	/// <Property class="CRH_Unit_Mag" name="OBStartTime" type="L3DATETIME">
	/// ��ʼOBʱ��
	/// </Property>
	DECLARE_L3PROP_DATETIME(OBStartTime)

	/// <Property class="CRH_Unit_Mag" name="AlloyStartTime" type="L3DATETIME">
	/// ��ʼ�Ͻ�ʱ��
	/// </Property>
	DECLARE_L3PROP_DATETIME(AlloyStartTime)

	/// <Property class="CRH_Unit_Mag" name="ProcTime" type="L3LONG">
	/// �Ѵ���ʱ��
	/// </Property>
	DECLARE_L3PROP_LONG(ProcTime)

	/// <Property class="CRH_Unit_Mag" name="CurTemp" type="L3DOUBLE">
	/// ��ǰ�¶�
	/// </Property>
	DECLARE_L3PROP_DOUBLE(CurTemp)

	/// <Property class="CRH_Unit_Mag" name="ReSampleHeatID" type="L3STRING">
	/// ��ȡ��֪ͨ¯��
	/// </Property>
	DECLARE_L3PROP_STRING(ReSampleHeatID)

	/// <Property class="CRH_Unit_Mag" name="StartProcessTime" type="L3STRING">
	/// ����ʼʱ��
	/// </Property>
	DECLARE_L3PROP_STRING(StartProcessTime)


	/// <Property class="CRH_Unit_Mag" name="Equip_Status" type="L3LONG">
	/// �豸״̬
	/// </Property>2009-03-02
	DECLARE_L3PROP_LONG(Equip_Status)

	/// <Property class="CRH_Unit_Mag" name="Probe_Vendor" type="L3STRING">
	/// ̽ͷ����
	/// </Property> 2009-03-19
	DECLARE_L3PROP_STRING(Probe_Vendor)

	/// <Property class="CRH_Unit_Mag" name="PrevArea" type="L3STRING">
	/// ��ǰ���ڴ���Ĺ�λ
	/// </Property>
	DECLARE_L3PROP_STRING(PrevArea)

	/// ������һ�����
	CString CalculateNextTreatNo(LPCTSTR lpcszTreatNo);
	
	/// ͨ�ù���״̬�޸ĺ���
	BOOL ChangeStatus(LONG nStatus);

	/// ͨ�üƻ�״̬�޸ĺ���
	BOOL ChangePlanStatus(LPCTSTR lpcszHeatID,LPCTSTR lpcszTreatNo,LPCTSTR Status);

	/// <Method class="CRH_Unit_Mag" name="GetInputSteels" type="L3RECORDSET">
	/// �����������Ĵ������ˮ��Ϣ��
	/// </Method>
	L3RECORDSET GetInputSteels();
	/// <Method class="CRH_Unit_Mag" name="DesignateLadle" type="L3BOOL">
	/// ΪA��B��λָ����������ĸ�ˮ��
	/// <Param name="Area" type="L3STRING">��λ�룺A��B</Param>
	/// <Param name="MaterialID" type="L3STRING">��ˮ¯��</Param>
	/// </Method>
	L3BOOL DesignateLadle(L3STRING Area, L3STRING MaterialID);
	/// <Method class="CRH_Unit_Mag" name="SteelArrived" type="L3BOOL">
	/// ����ְ������¼���
	/// <Param name="AreaID" type="L3STRING">�ְ�����Ĺ�λ</Param>
	/// </Method>
	L3BOOL SteelArrived(L3STRING AreaID);
	/// <Method class="CRH_Unit_Mag" name="OBStarted" type="L3BOOL">
	/// ����OB��ʼ�¼�
	/// </Method>
	L3BOOL OBStarted();
	/// <Method class="CRH_Unit_Mag" name="OBStopped" type="L3BOOL">
	/// ����OB�����¼�
	/// </Method>
	L3BOOL OBStopped();
	/// <Method class="CRH_Unit_Mag" name="VacuumStarted" type="L3BOOL">
	/// ������տ�ʼ�¼�
	/// </Method>
	L3BOOL VacuumStarted();
	/// <Method class="CRH_Unit_Mag" name="VacuumStopped" type="L3BOOL">
	/// ������ս����¼�
	/// </Method>
	L3BOOL VacuumStopped();
	/// <Method class="CRH_Unit_Mag" name="FeedElement" type="L3BOOL">
	/// ��RH¯����
	/// <Param name="rsElem" type="L3RECORDSET">��������</Param>
	/// </Method>
	L3BOOL FeedElement(L3RECORDSET rsElem);
	/// <Method class="CRH_Unit_Mag" name="SetTemperature" type="L3BOOL">
	/// ������¼�����¼�
	/// <Param name="rsTemp" type="L3RECORDSET">�����¼�����</Param>
	/// </Method>
	L3BOOL SetTemperature(L3RECORDSET rsTemp);
	/// <Method class="CRH_Prod_Area" name="SetOxygen" type="L3BOOL">
	/// ������¼RH¯�����¼���
	/// <Param name="rsOxygen" type="L3RECORDSET">��������</Param>
	/// </Method>
	L3BOOL SetOxygen(L3RECORDSET rsOxygen);
	/// <Method class="CRH_Unit_Mag" name="FeedWire" type="L3BOOL">
	/// ������¼ι˿�¼�
	/// <Param name="Area" type="L3STRING">����ι˿�Ĺ�λ</Param>
	/// <Param name="rsWire" type="L3RECORDSET">ι˿���ݼ�¼</Param>
	/// </Method>
	L3BOOL FeedWire(L3STRING Area,L3RECORDSET rsWire);
	/// <Method class="CRH_Unit_Mag" name="StartProcess" type="L3BOOL">
	/// ��ʼ����A��B����֮һ��λ�ϵĸ�ˮ��
	/// <Param name="Area" type="L3STRING">Ҫ��ʼ����Ĺ�λ</Param>
	/// </Method>
	L3BOOL StartProcess(L3STRING Area);
	/// <Method class="CRH_Unit_Mag" name="StopProcess" type="BOOL">
	/// ��������
	/// </Method>
	BOOL StopProcess();
	/// <Method class="CRH_Unit_Mag" name="ChangeDeviceStatus" type="L3BOOL">
	/// �޸��豸״̬
	/// <Param name="nStatus" type="L3LONG">���豸״̬</Param>
	/// <Param name="reason" type="L3STRING">ԭ��</Param>
	/// </Method>
	L3BOOL ChangeDeviceStatus(L3LONG nStatus, L3STRING reason);
	/// <Method class="CRH_Unit_Mag" name="OnTimer" type="L3BOOL">
	/// ����ʱ���¼�
	/// <Param name="nEventID" type="L3ULONG">�¼�ID</Param>
	/// </Method>
	L3BOOL OnTimer(L3ULONG nEventID);
	/// <Method class="CRH_Unit_Mag" name="StartBlowing" type="BOOL">
	/// ��������ʼ�¼�
	/// <Param name="Area" type="L3STRING">��ʼ���Ĺ�λ</Param>
	/// </Method>
	BOOL StartBlowing(L3STRING Area);
	/// <Method class="CRH_Unit_Mag" name="StopBlowing" type="L3BOOL">
	/// �����������¼�
	/// <Param name="Area" type="L3STRING">�������Ĺ�λ</Param>
	/// </Method>
	L3BOOL StopBlowing(L3STRING Area);
	/// <Method class="CRH_Unit_Mag" name="SteelLeave" type="L3BOOL">
	/// �����ˮ��վ�¼�
	/// <Param name="Area" type="L3STRING">��վ��ˮ��λ</Param>
	/// </Method>
	L3BOOL SteelLeave(L3STRING Area);


	/// <Method class="CRH_Unit_Mag" name="ChangeSteelGradeApp" type="L3BOOL">
	/// ����ĸ�
	/// <Param name="Reason" type="L3STRING">ԭ��</Param>
	/// </Method>
	L3BOOL ChangeSteelGradeApp(L3STRING Reason);


	/// <Method class="CRH_Unit_Mag" name="SteelReturnApp" type="L3BOOL">
	///  ��ˮ��¯����
	/// <Param name="Reason" type="L3STRING">ԭ��</Param>
	/// </Method>
	L3BOOL SteelReturnApp(L3STRING Reason,L3STRING strHeatID);


	/// <Method class="CRH_Unit_Mag" name="SteelBackApp" type="L3BOOL">
	///  ��ˮ��������
	/// <Param name="Reason" type="L3STRING">ԭ��</Param>
	/// </Method>
	L3BOOL SteelBackApp(L3STRING Reason,L3STRING strHeatID);


	/// <Method class="CRH_Unit_Mag" name="AcceptAlloyDischargeData" type="L3RECORDSET">
	/// �Ͻ��ϲּ������ݲɼ�
	/// <Param name="HeatID" type="L3STRING">¯��</Param>
	/// </Method>
	L3BOOL AcceptMaterialDischargeData(L3RECORDSET rsMaterialData);



	/// <Method class="CRH_Unit_Mag" name="MaterialGroundDischargeData" type="L3RECORDSET">
	/// ��װ�Ͻ�ɢ״������
	/// <Param name="HeatID" type="L3STRING">¯��</Param>
	/// </Method>
	L3BOOL MaterialGroundDischargeData(L3RECORDSET rsMaterialData);

	/// <Method class="CRH_Unit_Mag" name="AcceptRHStatus" type="L3BOOL">
	/// ����RH¯����״̬���� 2009-01-06
	/// <Param name="rsData" type="L3RECORDSET">״̬����</Param>
	/// </Method>
	L3BOOL AcceptRHStatus(L3RECORDSET rsData);

	/// <Method class="CRH_Unit_Mag" name="AcceptRHTempData" type="L3BOOL">
	/// ����RH¯�������� 2009-01-06
	/// <Param name="rsData" type="L3RECORDSET">��������</Param>
	/// </Method>
	L3BOOL AcceptRHTempData(L3RECORDSET rsData);

	/// <Method class="CRH_Unit_Mag" name="AcceptRHWireData" type="L3BOOL">
	/// ����RH¯ι������ 2009-01-06
	/// <Param name="rsData" type="L3RECORDSET">ι������</Param>
	/// </Method>
	L3BOOL AcceptRHWireData(L3RECORDSET rsData);

	/// <Method class="CRH_Unit_Mag" name="AcceptRHOxygenData" type="L3BOOL">
	/// ����RH¯�������� 2009-01-06
	/// <Param name="rsData" type="L3RECORDSET">��������</Param>
	/// </Method>
	L3BOOL AcceptRHOxygenData(L3RECORDSET rsData);

	/// <Method class="CRH_Unit_Mag" name="AcceptRHProcessData" type="L3BOOL">
	/// ����RH¯��ҵ���� 2009-01-06
	/// <Param name="rsData" type="L3RECORDSET">ι������</Param>
	/// </Method>
	L3BOOL AcceptRHProcessData(L3RECORDSET rsData);

	/// <Method class="CLF_Unit_Mag" name="SetDepartureTemp" type="L3BOOL">
	/// ������վ�¶� 2009-01-02
	/// <Param name="csTreatNo" type="LPCTSTR">�����</Param>
	/// </Method>
	L3BOOL SetDepartureTemp(LPCTSTR csTreatNo);

	/// <Method class="CRH_Unit_Mag" name="AcceptRHVacTime" type="L3BOOL">
	/// ����RH¯��ն�ʱ�� 2009-02-11
	/// <Param name="rsData" type="L3RECORDSET">ι������</Param>
	/// </Method>
	L3BOOL AcceptRHVacTime(L3RECORDSET rsData);


	/// <Method class="CBOF_Unit_Mag" name="SteelReturn" type="L3BOOL">
	///  ��ȡ���¯�� 2009-02-28 ����¯��
	/// <Param name="Reason" type="L3STRING">ԭ��</Param>
	/// </Method>
	L3RECORDSET GetPreThreeHeatID();

	/// <Method class="CRH_Unit_Mag" name="AcceptRHBlowArData" type="L3BOOL">
	/// ����RH¯����������� 2009-03-23
	/// <Param name="rsData" type="L3RECORDSET">�����������</Param>
	/// </Method>
	L3BOOL AcceptRHBlowArData(L3RECORDSET rsData);

	/// <Method class="CRH_Unit_Mag" name="SetTreatNoForBlowArData" type="L3BOOL">
	/// �Դ���ʼǰ����������ô���������� 2009-03-23
	/// <Param name="csHeatID" type="LPCTSTR">¯��</Param>
	/// <Param name="csTreatNo" type="LPCTSTR">�����</Param>
	/// </Method>
	L3BOOL SetTreatNoForBlowArData(LPCTSTR csHeatID,LPCTSTR csTreatNo);

	/// <Method class="CRH_Unit_Mag" name="ModifyLadleGrade" type="L3LONG">
	/// �޸İ���//2009-03-30 Liao
	/// <Param name="strTreatNo" type="L3STRING">�����</Param>
	/// <Param name="strLadleGrade" type="L3STRING">����</Param>
	/// </Method>
	L3LONG ModifyLadleGrade(L3STRING strTreatNo, L3STRING strLadleGrade);

	/// <Method class="CRH_Unit_Mag" name="SetTreatNoForTempDataBeforeProcess" type="L3BOOL">
	/// �Դ���ʼǰ�������ô���������� 2008-12-30
	/// <Param name="csHeatID" type="LPCTSTR">¯��</Param>
	/// <Param name="csTreatNo" type="LPCTSTR">�����</Param>
	/// </Method>
	L3BOOL SetTreatNoForTempDataBeforeProcess(LPCTSTR csHeatID,LPCTSTR csTreatNo);

	/// <Method class="CRH_Unit_Mag" name="SetWireTemp" type="L3BOOL">
	/// ���øƴ�������¶� 2009-04-01
	/// <Param name="csTreatNo" type="LPCTSTR">�����</Param>
	/// </Method>
	L3BOOL SetWireTemp(LPCTSTR csTreatNo);

	/// <Method class="CRH_Unit_Mag" name="SetWeight" type="L3BOOL">
	/// ��������źš�
	/// <Param name="fWeight" type="L3DOUBLE">����</Param>
	/// <Param name="strHeatID" type="L3STRING">¯��</Param>
	/// </Method>
	L3BOOL SetWeight(L3DOUBLE fWeight,L3STRING strHeatID);

	/// <Method class="CRH_Unit_Mag" name="AcceptBlowStatusData" type="L3BOOL">
	/// ���գңȶ�ǹ����״̬���� 2009-07-03
	/// <Param name="csHeatID" type="LPCTSTR">¯��</Param>
	/// <Param name="csTreatNo" type="LPCTSTR">�����</Param>
	/// </Method>
	L3BOOL AcceptBlowO2StatusData(L3RECORDSET rsData);

	//Modify begin by llj 2011-04-10 �������¯�ε�Ԫ�ر�ֵ
	/// <Method class="CRH_Unit_Mag" name="CalEleRateValue" type="L3LONG">
	/// ���������������ֵ
	/// <Param name="strHeatID" type="L3STRING">¯�κ�</Param>
	/// <Param name="strEleName1" type="L3STRING">Ԫ��1</Param>
	/// <Param name="strEleName2" type="L3STRING">Ԫ��2</Param>
	/// </Method>
	L3FLOAT CalEleRateValue(L3STRING strHeatID, L3STRING strEleName1,L3STRING strEleName2);
};
