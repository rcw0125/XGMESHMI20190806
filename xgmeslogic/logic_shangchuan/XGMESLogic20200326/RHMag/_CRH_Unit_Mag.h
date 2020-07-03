// 逻辑类CRH_Unit_Mag头文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。
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

	//当对象被装载到系统中时，被调用
	virtual void OnLoaded();
	//当对象被卸载时，被调用
	virtual void OnUnloaded();

public:
	enum _RHStatus
	{
		// 正常状态
		RHWaiting = 0,		// 等待
		RHProcBegin = 1,	// 处理开始
		RHVacBegin = 2,		// 开始真空处理
		RHOB = 3,			// 下管吹氧
		RHAlloy = 4,		// 脱氧合金化
		RHProcEnd = 5,		// 处理结束
		RHBlowBegin = 6,	// 软吹开始
		RHBlowEnd = 7,		// 软吹结束

	};

	//20098-03-02
	enum _RHEquipStatus
	{
		// 异常状态
		RHNormal = 0,       //正常
		RHRepair = -1,		// 检修
		RHFailure = -2,		// 故障
	};

protected:

	CString csDischargeUnit;
	CString csWireUnit;

	/// <summary>
	/// 返回机组的加工区域
	/// ARG << lstURIs : 接收所有加工区对象的URI
	/// </summary>
	virtual BOOL GetProduceAreas(CStringList& lstURIs);

	/// <summary>
	/// 获取指定生产区域的后续区域的URI
	/// ARG >> lpcszCurArea : 当前生产区域的URI。
	///		>> rsMaterialInfo : 材料信息，用于辅助判断。包含MaterialType,MaterialID,Amount,等材料信息。
	///							注意：应该只用该记录集的当前行进行判断！！！
	/// RET << 返回后续生产区域的URI。返回空表示当前生产区域已经是机组的出口了。
	/// </summary>
	virtual CString GetNextProduceArea(LPCTSTR lpcszCurArea,L3RECORDSET rsMaterialInfo) { return _T(""); };

	/// <summary>
	/// 获取指定生产区域的前导区域的URI
	/// ARG >> lpcszCurArea : 当前生产区域的URI。
	///		>> rsMaterialInfo : 材料信息，用于辅助判断。包含MaterialType,MaterialID,Amount,等材料信息。
	///							注意：应该只用该记录集的当前行进行判断！！！
	/// RET << 返回前导生产区域的URI。返回空表示当前生产区域已经是机组的入口了。
	/// </summary>
	virtual CString GetPrevProduceArea(LPCTSTR lpcszCurArea,L3RECORDSET rsMaterialInfo) { return _T(""); };

	/// <summary>
	/// 得到机组前序材料缓冲区的URI
	/// </summary>
	virtual CString GetInputCache();

	/// <summary>
	/// 得到机组后继材料缓冲区的URI
	/// </summary>
	virtual CString GetOutputCache();

	/// <summary>
	/// 机组上料前预处理。在机组上料前调用，继承类可重载此方法进行预先数据准备和处理。
	/// ARG >> rsMaterialInfo : 材料信息记录集。
	/// RET << 返回TRUE继续上料；返回FALSE中断上料。
	/// </summary>
	virtual BOOL OnBeforeFeedMaterials(L3RECORDSET rsMaterialInfo);

	/// <summary>
	/// 机组上料后续处理。在机组上料后调用，继承类可重载此方法进行额外处理。
	/// ARG >> rsMaterialInfo : 材料信息记录集。
	/// RET << 成功返回TRUE；失败返回FALSE。
	/// </summary>
	virtual BOOL OnAfterMaterialsFeeded(L3RECORDSET rsMaterialInfo);

	/// <summary>
	/// 返回机组上料记录的类型URI
	/// </summary>
	virtual CString GetFeedingLogType();

	/// <summary>
	/// 准备上料记录数据。继承类可重载此函数进行额外的数据处理。
	/// ARG >> rsFeedingLogs : 上料记录信息。
	/// RET << void
	/// </summary>
	virtual void PrepareFeedingLogs(L3RECORDSET rsFeedingLogs);

	/// <summary>
	/// 加工参数预处理。在调用加工区域的加工方法前调用，继承类可重载此函数对加工参数进行修改和配置。
	/// ARG >> lpcszArea : 加工区域的URI
	///		>> rsParameters : 加工参数记录集。
	/// RET << 返回TRUE继续加工；返回FALSE中断加工。
	/// </summary>
	virtual BOOL PrepareProcessParameters(LPCTSTR lpcszArea,L3RECORDSET rsParameters);

	/// <summary>
	/// 加工完成后续处理。在加工完成后调用，继承类可重载此函数进行额外逻辑处理
	/// ARG >> lpcszArea : 加工区域的URI
	///		>> nProcessType : 加工的类型。
	///		>> rsProducts : 加工产生的产品的信息记录。
	/// RET << 成功返回TRUE；失败返回FALSE。
	/// </summary>
	virtual BOOL OnAfterProcessCompleted(LPCTSTR lpcszArea,LONG nProcessType,L3RECORDSET rsProducts);

	/// <summary>
	/// 下线前预处理。在执行下线操作前调用，继承类可重载此函数进行预先的数据准备和处理。
	/// ARG >> rsMaterialInfo : 下线材料信息。包含MaterialType,MaterialID,Amount,Area字段。
	/// RET << 返回TRUE继续下线；返回FALSE中断下线。
	/// </summary>
	virtual BOOL OnBeforeDeliverMaterials(L3RECORDSET rsMaterialInfo);

	/// <summary>
	/// 下线后续处理。在执行下线操作后调用，继承类可重载此函数进行额外处理。
	/// ARG >> rsMaterialInfo : 下线材料信息。包含MaterialType,MaterialID,Amount,Area字段。
	/// RET << 成功返回TRUE；失败返回FALSE。
	/// </summary>
	virtual BOOL OnAfterMaterialsDelivered(L3RECORDSET rsMaterialInfo);

	/// <summary>
	/// 返回机组产出记录的类型URI
	/// </summary>
	virtual CString GetDeliveryLogType();

	/// <summary>
	/// 准备下料记录数据。
	/// ARG >> rsDeliveryLog : 下料记录数据。
	/// RET <<void
	/// </summary>
	virtual void PrepareDeliveryLogs(L3RECORDSET rsDeliveryLog);

	/// <summary>
	/// 返回本机组的通讯器对象的URI
	/// </summary>
	virtual CString GetCommunicator();

	/// <summary>
	/// 准备计划数据，以便向机组下位系统发送。
	/// ARG >> lpcszPlanType : 计划类型。
	///		>> rsPlan : 计划数据。包括PlanID字段。
	///		<< rsSend : 接收准备好的计划发送数据。
	/// RET << 成功返回TRUE；失败返回FALSE。
	/// </summary>
	virtual BOOL PreparePlanForSending(LPCTSTR lpcszPlanType,L3RECORDSET rsPlan,L3RECORDSET* pprsSend);

	/// <summary>
	/// 计划下达后续处理。在向下位系统发送计划后调用，继承类可重载此函数进行后续处理。
	/// ARG >> rsSend : 下发下位系统的计划数据。
	/// RET << 成功返回TRUE；失败返回FALSE。
	/// </summary>
	virtual BOOL OnAfterPlansSent(L3RECORDSET rsSend);

	/// <summary>
	/// 准备计划数据，以便通知机组下位系统取消计划。
	/// ARG >> lpcszPlanType : 计划类型。
	///		>> rsPlan : 计划数据。包括PlanID字段。
	///		<< rsSend : 接收准备好的计划取消数据。
	/// RET << 成功返回TRUE；失败返回FALSE。
	/// </summary>
	virtual BOOL PreparePlanForCancel(LPCTSTR lpcszPlanType,L3RECORDSET rsPlan,L3RECORDSET* pprsCancel);

	/// <summary>
	/// 计划取消后续处理。在向下位系统发送取消计划后调用，继承类可重载此函数进行后续处理。
	/// ARG >> rsCancel : 下发下位系统的计划取消数据。
	/// RET << 成功返回TRUE；失败返回FALSE。
	/// </summary>
	virtual BOOL OnAfterPlansCanceled(L3RECORDSET rsCancel);

	/// <summary>
	/// 处理材料上线的事件
	/// ARG >> pEvt : 事件对象
	/// RET << 返回TRUE表示已经成功处理。返回FALSE表示使用系统缺省处理方式。
	/// </summary>
	virtual BOOL HandleMaterialFeedingEvent(MatEnterArea *pEvt);
	/// <summary>
	/// 处理材料进入加工区域的事件
	/// ARG >> pEvt : 事件对象
	/// RET << 返回TRUE表示已经成功处理。返回FALSE表示使用系统缺省处理方式。
	/// </summary>
	virtual BOOL HandleMaterialEnterAreaEvent(MatEnterArea *pEvt);
	/// <summary>
	/// 处理材料离开加工区域事件
	/// ARG >> pEvt : 事件对象
	/// RET << 返回TRUE表示已经成功处理。返回FALSE表示使用系统缺省处理方式。
	/// </summary>
	virtual BOOL HandleMaterialLeaveAreaEvent(MatLeaveArea *pEvt);
	/// <summary>
	/// 处理材料生产完毕事件
	/// ARG >> pEvt : 事件对象
	/// RET << 返回TRUE表示已经成功处理。返回FALSE表示使用系统缺省处理方式。
	/// </summary>
	virtual BOOL HandleMaterialProducedEvent(MatProduced *pEvt);
	/// <summary>
	/// 处理机组测量数据变更事件
	/// ARG >> pEvt : 事件对象
	/// RET << 返回TRUE表示已经成功处理。返回FALSE表示使用系统缺省处理方式。
	/// </summary>
	virtual BOOL HandleUnitMeasureChangedEvent(UnitMeasure *pEvt);

	/// <Property class="CRH_Unit_Mag" name="TreatNo" type="L3STRING">
	/// 当前处理号
	/// </Property>
	DECLARE_L3PROP_STRING(TreatNo)

	/// <Property class="CRH_Unit_Mag" name="NextTreatNo" type="L3STRING">
	/// 下一处理号
	/// </Property>
	DECLARE_L3PROP_STRING(NextTreatNo)

	/// <Property class="CRH_Unit_Mag" name="Status" type="L3LONG">
	/// 机组状态
	/// </Property>
	DECLARE_L3PROP_LONG(Status)

	/// <Property class="CRH_Unit_Mag" name="Slot_No" type="L3STRING">
	/// 槽号
	/// </Property>
	DECLARE_L3PROP_STRING(Slot_No)

	/// <Property class="CRH_Unit_Mag" name="NextSteel" type="L3STRING">
	/// 下一个上线的钢水
	/// </Property>
	DECLARE_L3PROP_STRING(NextSteel)

	/// <Property class="CRH_Unit_Mag" name="CurArea" type="L3STRING">
	/// 当前正在处理的工位
	/// </Property>
	DECLARE_L3PROP_STRING(CurArea)

	/// <Property class="CRH_Unit_Mag" name="ProcStartTime" type="L3DATETIME">
	/// 开始处理时间
	/// </Property>
	DECLARE_L3PROP_DATETIME(ProcStartTime)

	/// <Property class="CRH_Unit_Mag" name="ProcStopTime" type="L3DATETIME">
	/// 结束处理时间
	/// </Property>
	DECLARE_L3PROP_DATETIME(ProcStopTime)

	/// <Property class="CRH_Unit_Mag" name="OBStartTime" type="L3DATETIME">
	/// 开始OB时间
	/// </Property>
	DECLARE_L3PROP_DATETIME(OBStartTime)

	/// <Property class="CRH_Unit_Mag" name="AlloyStartTime" type="L3DATETIME">
	/// 开始合金化时间
	/// </Property>
	DECLARE_L3PROP_DATETIME(AlloyStartTime)

	/// <Property class="CRH_Unit_Mag" name="ProcTime" type="L3LONG">
	/// 已处理时间
	/// </Property>
	DECLARE_L3PROP_LONG(ProcTime)

	/// <Property class="CRH_Unit_Mag" name="CurTemp" type="L3DOUBLE">
	/// 当前温度
	/// </Property>
	DECLARE_L3PROP_DOUBLE(CurTemp)

	/// <Property class="CRH_Unit_Mag" name="ReSampleHeatID" type="L3STRING">
	/// 重取样通知炉号
	/// </Property>
	DECLARE_L3PROP_STRING(ReSampleHeatID)

	/// <Property class="CRH_Unit_Mag" name="StartProcessTime" type="L3STRING">
	/// 处理开始时间
	/// </Property>
	DECLARE_L3PROP_STRING(StartProcessTime)


	/// <Property class="CRH_Unit_Mag" name="Equip_Status" type="L3LONG">
	/// 设备状态
	/// </Property>2009-03-02
	DECLARE_L3PROP_LONG(Equip_Status)

	/// <Property class="CRH_Unit_Mag" name="Probe_Vendor" type="L3STRING">
	/// 探头厂家
	/// </Property> 2009-03-19
	DECLARE_L3PROP_STRING(Probe_Vendor)

	/// <Property class="CRH_Unit_Mag" name="PrevArea" type="L3STRING">
	/// 当前正在处理的工位
	/// </Property>
	DECLARE_L3PROP_STRING(PrevArea)

	/// 计算下一处理号
	CString CalculateNextTreatNo(LPCTSTR lpcszTreatNo);
	
	/// 通用过程状态修改函数
	BOOL ChangeStatus(LONG nStatus);

	/// 通用计划状态修改函数
	BOOL ChangePlanStatus(LPCTSTR lpcszHeatID,LPCTSTR lpcszTreatNo,LPCTSTR Status);

	/// <Method class="CRH_Unit_Mag" name="GetInputSteels" type="L3RECORDSET">
	/// 返回入口区域的待处理钢水信息。
	/// </Method>
	L3RECORDSET GetInputSteels();
	/// <Method class="CRH_Unit_Mag" name="DesignateLadle" type="L3BOOL">
	/// 为A、B工位指定即将到达的钢水。
	/// <Param name="Area" type="L3STRING">工位码：A，B</Param>
	/// <Param name="MaterialID" type="L3STRING">钢水炉号</Param>
	/// </Method>
	L3BOOL DesignateLadle(L3STRING Area, L3STRING MaterialID);
	/// <Method class="CRH_Unit_Mag" name="SteelArrived" type="L3BOOL">
	/// 处理钢包到达事件。
	/// <Param name="AreaID" type="L3STRING">钢包到达的工位</Param>
	/// </Method>
	L3BOOL SteelArrived(L3STRING AreaID);
	/// <Method class="CRH_Unit_Mag" name="OBStarted" type="L3BOOL">
	/// 处理OB开始事件
	/// </Method>
	L3BOOL OBStarted();
	/// <Method class="CRH_Unit_Mag" name="OBStopped" type="L3BOOL">
	/// 处理OB结束事件
	/// </Method>
	L3BOOL OBStopped();
	/// <Method class="CRH_Unit_Mag" name="VacuumStarted" type="L3BOOL">
	/// 处理真空开始事件
	/// </Method>
	L3BOOL VacuumStarted();
	/// <Method class="CRH_Unit_Mag" name="VacuumStopped" type="L3BOOL">
	/// 处理真空结束事件
	/// </Method>
	L3BOOL VacuumStopped();
	/// <Method class="CRH_Unit_Mag" name="FeedElement" type="L3BOOL">
	/// 向RH炉加料
	/// <Param name="rsElem" type="L3RECORDSET">加料数据</Param>
	/// </Method>
	L3BOOL FeedElement(L3RECORDSET rsElem);
	/// <Method class="CRH_Unit_Mag" name="SetTemperature" type="L3BOOL">
	/// 处理并记录测温事件
	/// <Param name="rsTemp" type="L3RECORDSET">测温事件数据</Param>
	/// </Method>
	L3BOOL SetTemperature(L3RECORDSET rsTemp);
	/// <Method class="CRH_Prod_Area" name="SetOxygen" type="L3BOOL">
	/// 处理并记录RH炉定氧事件。
	/// <Param name="rsOxygen" type="L3RECORDSET">定氧数据</Param>
	/// </Method>
	L3BOOL SetOxygen(L3RECORDSET rsOxygen);
	/// <Method class="CRH_Unit_Mag" name="FeedWire" type="L3BOOL">
	/// 处理并记录喂丝事件
	/// <Param name="Area" type="L3STRING">进行喂丝的工位</Param>
	/// <Param name="rsWire" type="L3RECORDSET">喂丝数据记录</Param>
	/// </Method>
	L3BOOL FeedWire(L3STRING Area,L3RECORDSET rsWire);
	/// <Method class="CRH_Unit_Mag" name="StartProcess" type="L3BOOL">
	/// 开始处理A、B两个之一工位上的钢水。
	/// <Param name="Area" type="L3STRING">要开始处理的工位</Param>
	/// </Method>
	L3BOOL StartProcess(L3STRING Area);
	/// <Method class="CRH_Unit_Mag" name="StopProcess" type="BOOL">
	/// 结束处理
	/// </Method>
	BOOL StopProcess();
	/// <Method class="CRH_Unit_Mag" name="ChangeDeviceStatus" type="L3BOOL">
	/// 修改设备状态
	/// <Param name="nStatus" type="L3LONG">新设备状态</Param>
	/// <Param name="reason" type="L3STRING">原因</Param>
	/// </Method>
	L3BOOL ChangeDeviceStatus(L3LONG nStatus, L3STRING reason);
	/// <Method class="CRH_Unit_Mag" name="OnTimer" type="L3BOOL">
	/// 处理定时器事件
	/// <Param name="nEventID" type="L3ULONG">事件ID</Param>
	/// </Method>
	L3BOOL OnTimer(L3ULONG nEventID);
	/// <Method class="CRH_Unit_Mag" name="StartBlowing" type="BOOL">
	/// 处理软吹开始事件
	/// <Param name="Area" type="L3STRING">开始软吹的工位</Param>
	/// </Method>
	BOOL StartBlowing(L3STRING Area);
	/// <Method class="CRH_Unit_Mag" name="StopBlowing" type="L3BOOL">
	/// 处理软吹结束事件
	/// <Param name="Area" type="L3STRING">结束软吹的工位</Param>
	/// </Method>
	L3BOOL StopBlowing(L3STRING Area);
	/// <Method class="CRH_Unit_Mag" name="SteelLeave" type="L3BOOL">
	/// 处理钢水离站事件
	/// <Param name="Area" type="L3STRING">离站钢水工位</Param>
	/// </Method>
	L3BOOL SteelLeave(L3STRING Area);


	/// <Method class="CRH_Unit_Mag" name="ChangeSteelGradeApp" type="L3BOOL">
	/// 申请改钢
	/// <Param name="Reason" type="L3STRING">原因</Param>
	/// </Method>
	L3BOOL ChangeSteelGradeApp(L3STRING Reason);


	/// <Method class="CRH_Unit_Mag" name="SteelReturnApp" type="L3BOOL">
	///  钢水回炉申请
	/// <Param name="Reason" type="L3STRING">原因</Param>
	/// </Method>
	L3BOOL SteelReturnApp(L3STRING Reason,L3STRING strHeatID);


	/// <Method class="CRH_Unit_Mag" name="SteelBackApp" type="L3BOOL">
	///  钢水返送申请
	/// <Param name="Reason" type="L3STRING">原因</Param>
	/// </Method>
	L3BOOL SteelBackApp(L3STRING Reason,L3STRING strHeatID);


	/// <Method class="CRH_Unit_Mag" name="AcceptAlloyDischargeData" type="L3RECORDSET">
	/// 合金料仓加料数据采集
	/// <Param name="HeatID" type="L3STRING">炉号</Param>
	/// </Method>
	L3BOOL AcceptMaterialDischargeData(L3RECORDSET rsMaterialData);



	/// <Method class="CRH_Unit_Mag" name="MaterialGroundDischargeData" type="L3RECORDSET">
	/// 袋装合金散状料消耗
	/// <Param name="HeatID" type="L3STRING">炉号</Param>
	/// </Method>
	L3BOOL MaterialGroundDischargeData(L3RECORDSET rsMaterialData);

	/// <Method class="CRH_Unit_Mag" name="AcceptRHStatus" type="L3BOOL">
	/// 接收RH炉过程状态数据 2009-01-06
	/// <Param name="rsData" type="L3RECORDSET">状态数据</Param>
	/// </Method>
	L3BOOL AcceptRHStatus(L3RECORDSET rsData);

	/// <Method class="CRH_Unit_Mag" name="AcceptRHTempData" type="L3BOOL">
	/// 接收RH炉测温数据 2009-01-06
	/// <Param name="rsData" type="L3RECORDSET">测温数据</Param>
	/// </Method>
	L3BOOL AcceptRHTempData(L3RECORDSET rsData);

	/// <Method class="CRH_Unit_Mag" name="AcceptRHWireData" type="L3BOOL">
	/// 接收RH炉喂线数据 2009-01-06
	/// <Param name="rsData" type="L3RECORDSET">喂线数据</Param>
	/// </Method>
	L3BOOL AcceptRHWireData(L3RECORDSET rsData);

	/// <Method class="CRH_Unit_Mag" name="AcceptRHOxygenData" type="L3BOOL">
	/// 接收RH炉定氧数据 2009-01-06
	/// <Param name="rsData" type="L3RECORDSET">定氧数据</Param>
	/// </Method>
	L3BOOL AcceptRHOxygenData(L3RECORDSET rsData);

	/// <Method class="CRH_Unit_Mag" name="AcceptRHProcessData" type="L3BOOL">
	/// 接收RH炉作业数据 2009-01-06
	/// <Param name="rsData" type="L3RECORDSET">喂线数据</Param>
	/// </Method>
	L3BOOL AcceptRHProcessData(L3RECORDSET rsData);

	/// <Method class="CLF_Unit_Mag" name="SetDepartureTemp" type="L3BOOL">
	/// 设置离站温度 2009-01-02
	/// <Param name="csTreatNo" type="LPCTSTR">处理号</Param>
	/// </Method>
	L3BOOL SetDepartureTemp(LPCTSTR csTreatNo);

	/// <Method class="CRH_Unit_Mag" name="AcceptRHVacTime" type="L3BOOL">
	/// 接收RH炉真空度时间 2009-02-11
	/// <Param name="rsData" type="L3RECORDSET">喂线数据</Param>
	/// </Method>
	L3BOOL AcceptRHVacTime(L3RECORDSET rsData);


	/// <Method class="CBOF_Unit_Mag" name="SteelReturn" type="L3BOOL">
	///  获取最近炉号 2009-02-28 增加炉号
	/// <Param name="Reason" type="L3STRING">原因</Param>
	/// </Method>
	L3RECORDSET GetPreThreeHeatID();

	/// <Method class="CRH_Unit_Mag" name="AcceptRHBlowArData" type="L3BOOL">
	/// 接收RH炉吹氩流量数据 2009-03-23
	/// <Param name="rsData" type="L3RECORDSET">吹氩流量数据</Param>
	/// </Method>
	L3BOOL AcceptRHBlowArData(L3RECORDSET rsData);

	/// <Method class="CRH_Unit_Mag" name="SetTreatNoForBlowArData" type="L3BOOL">
	/// 对处理开始前吹氩数据设置处理号数据项 2009-03-23
	/// <Param name="csHeatID" type="LPCTSTR">炉号</Param>
	/// <Param name="csTreatNo" type="LPCTSTR">处理号</Param>
	/// </Method>
	L3BOOL SetTreatNoForBlowArData(LPCTSTR csHeatID,LPCTSTR csTreatNo);

	/// <Method class="CRH_Unit_Mag" name="ModifyLadleGrade" type="L3LONG">
	/// 修改包况//2009-03-30 Liao
	/// <Param name="strTreatNo" type="L3STRING">处理号</Param>
	/// <Param name="strLadleGrade" type="L3STRING">包况</Param>
	/// </Method>
	L3LONG ModifyLadleGrade(L3STRING strTreatNo, L3STRING strLadleGrade);

	/// <Method class="CRH_Unit_Mag" name="SetTreatNoForTempDataBeforeProcess" type="L3BOOL">
	/// 对处理开始前测温设置处理号数据项 2008-12-30
	/// <Param name="csHeatID" type="LPCTSTR">炉号</Param>
	/// <Param name="csTreatNo" type="LPCTSTR">处理号</Param>
	/// </Method>
	L3BOOL SetTreatNoForTempDataBeforeProcess(LPCTSTR csHeatID,LPCTSTR csTreatNo);

	/// <Method class="CRH_Unit_Mag" name="SetWireTemp" type="L3BOOL">
	/// 设置钙处理结束温度 2009-04-01
	/// <Param name="csTreatNo" type="LPCTSTR">处理号</Param>
	/// </Method>
	L3BOOL SetWireTemp(LPCTSTR csTreatNo);

	/// <Method class="CRH_Unit_Mag" name="SetWeight" type="L3BOOL">
	/// 处理称重信号。
	/// <Param name="fWeight" type="L3DOUBLE">重量</Param>
	/// <Param name="strHeatID" type="L3STRING">炉号</Param>
	/// </Method>
	L3BOOL SetWeight(L3DOUBLE fWeight,L3STRING strHeatID);

	/// <Method class="CRH_Unit_Mag" name="AcceptBlowStatusData" type="L3BOOL">
	/// 接收ＲＨ顶枪吹氧状态数据 2009-07-03
	/// <Param name="csHeatID" type="LPCTSTR">炉号</Param>
	/// <Param name="csTreatNo" type="LPCTSTR">处理号</Param>
	/// </Method>
	L3BOOL AcceptBlowO2StatusData(L3RECORDSET rsData);

	//Modify begin by llj 2011-04-10 计算最近炉次的元素比值
	/// <Method class="CRH_Unit_Mag" name="CalEleRateValue" type="L3LONG">
	/// 计算最进化验结果比值
	/// <Param name="strHeatID" type="L3STRING">炉次号</Param>
	/// <Param name="strEleName1" type="L3STRING">元素1</Param>
	/// <Param name="strEleName2" type="L3STRING">元素2</Param>
	/// </Method>
	L3FLOAT CalEleRateValue(L3STRING strHeatID, L3STRING strEleName1,L3STRING strEleName2);
};
