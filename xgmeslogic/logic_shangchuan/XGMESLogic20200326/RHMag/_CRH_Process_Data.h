// 逻辑类CRH_Process_Data头文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。
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

	//当对象被装载到系统中时，被调用
	virtual void OnLoaded();
	//当对象被卸载时，被调用
	virtual void OnUnloaded();

	/// <Property class="CRH_Process_Data" name="TreatNo" type="L3STRING">
	/// 处理号
	/// </Property>
	DECLARE_L3PROP_STRING(TreatNo)

	/// <Property class="CRH_Process_Data" name="HeatID" type="L3STRING">
	/// 炉号
	/// </Property>
	DECLARE_L3PROP_STRING(HeatID)

	/// <Property class="CRH_Process_Data" name="Arrival_Time" type="L3DATETIME">
	/// 到达时刻
	/// </Property>
	DECLARE_L3PROP_DATETIME(Arrival_Time)

	
	
	/// <Property class="CRH_Process_Data" name="Arrival_Temp" type="L3SHORT">
	/// 进站温度
	/// </Property>
	DECLARE_L3PROP_SHORT(Arrival_Temp)

	
	
	/// <Property class="CRH_Process_Data" name="Arrival_Temp_Quality" type="L3SHORT">
	/// 
	/// 进站温度合格否
	/// (1:合格;0:不合格)
	/// </Property>
	DECLARE_L3PROP_SHORT(Arrival_Temp_Quality)

	/// <Property class="CRH_Process_Data" name="Slag_Thick" type="L3FLOAT">
	/// 渣厚
	/// </Property>
	DECLARE_L3PROP_FLOAT(Slag_Thick)

	/// <Property class="CRH_Process_Data" name="Process_Location" type="L3STRING">
	/// 处理位
	/// </Property>
	DECLARE_L3PROP_STRING(Process_Location)

	/// <Property class="CRH_Process_Data" name="Slot_No" type="L3STRING">
	/// 槽号
	/// </Property>
	DECLARE_L3PROP_STRING(Slot_No)

	/// <Property class="CRH_Process_Data" name="Process_Mode" type="L3SHORT">
	/// 
	/// 处理模式
	/// (1:轻处理;
	///  2:本处理)
	/// </Property>
	DECLARE_L3PROP_SHORT(Process_Mode)

	/// <Property class="CRH_Process_Data" name="Start_Time" type="L3DATETIME">
	/// 真空处理开始时刻
	/// </Property>
	DECLARE_L3PROP_DATETIME(Start_Time)

	/// <Property class="CRH_Process_Data" name="End_Time" type="L3DATETIME">
	/// 真空处理结束时刻
	/// </Property>
	DECLARE_L3PROP_DATETIME(End_Time)

	/// <Property class="CRH_Process_Data" name="Process_Time" type="L3LONG">
	/// 作业时间
	/// </Property>
	DECLARE_L3PROP_LONG(Process_Time)

	/// <Property class="CRH_Process_Data" name="Loop_Time" type="L3LONG">
	/// 纯循环时间
	/// </Property>
	DECLARE_L3PROP_LONG(Loop_Time)

	
	/// <Property class="CRH_Process_Data" name="Vac_Min" type="L3FLOAT">
	/// 最高真空度
	/// </Property>
	DECLARE_L3PROP_FLOAT(Vac_Min)

	
	
	/// <Property class="CRH_Process_Data" name="OB_Count" type="L3SHORT">
	/// OB次数
	/// </Property>
	DECLARE_L3PROP_SHORT(OB_Count)

	/// <Property class="CRH_Process_Data" name="O2_CONS" type="L3FLOAT">
	/// 消耗氧量
	/// </Property>
	DECLARE_L3PROP_FLOAT(O2_CONS)

	/// <Property class="CRH_Process_Data" name="Al_CONS" type="L3FLOAT">
	/// 消耗铝量
	/// </Property>
	DECLARE_L3PROP_FLOAT(Al_CONS)

	/// <Property class="CRH_Process_Data" name="OB_Cycle_Time" type="L3LONG">
	/// OB后环流时间
	/// </Property>
	DECLARE_L3PROP_LONG(OB_Cycle_Time)

	/// <Property class="CRH_Process_Data" name="Probe_Vonder" type="L3STRING">
	/// 
	/// 使用定氧探头厂家
	/// (贺利氏、北京、方舟)
	/// </Property>
	DECLARE_L3PROP_STRING(Probe_Vonder)

	/// <Property class="CRH_Process_Data" name="Wire_End_Time" type="L3DATETIME">
	/// 钙处理完毕时刻
	/// </Property>
	DECLARE_L3PROP_DATETIME(Wire_End_Time)

	
	
	/// <Property class="CRH_Process_Data" name="Wire_End_Temp" type="L3SHORT">
	/// 钙处理完毕温度
	/// </Property>
	DECLARE_L3PROP_SHORT(Wire_End_Temp)

	/// <Property class="CRH_Process_Data" name="SoftBlow_StartTime" type="L3DATETIME">
	/// 软吹开始时刻
	/// </Property>
	DECLARE_L3PROP_DATETIME(SoftBlow_StartTime)

	/// <Property class="CRH_Process_Data" name="SoftBlow_EndTime" type="L3DATETIME">
	/// 软吹结束时刻
	/// </Property>
	DECLARE_L3PROP_DATETIME(SoftBlow_EndTime)

	/// <Property class="CRH_Process_Data" name="SoftBlow_Time" type="L3LONG">
	/// 软吹时间
	/// </Property>
	DECLARE_L3PROP_LONG(SoftBlow_Time)

	
	/// <Property class="CRH_Process_Data" name="Departure_Temp" type="L3LONG">
	/// 离站温度
	/// </Property>
	DECLARE_L3PROP_LONG(Departure_Temp)

	
	
	/// <Property class="CRH_Process_Data" name="CircsOfRhythm" type="L3SHORT">
	/// 
	/// 节奏情况
	/// (0:正常
	/// 1:紧张)
	/// </Property>
	DECLARE_L3PROP_SHORT(CircsOfRhythm)

	/// <Property class="CRH_Process_Data" name="VacDownTo35000_Time" type="L3LONG">
	/// 真空度降至35Kpa时间
	/// </Property>
	DECLARE_L3PROP_LONG(VacDownTo35000_Time)

	/// <Property class="CRH_Process_Data" name="VacDownTo11500_Time" type="L3LONG">
	/// 真空度降至11.5Kpa时间
	/// </Property>
	DECLARE_L3PROP_LONG(VacDownTo11500_Time)

	/// <Property class="CRH_Process_Data" name="VacDownTo2500_Time" type="L3LONG">
	/// 真空度降至2.5Kpa时间
	/// </Property>
	DECLARE_L3PROP_LONG(VacDownTo2500_Time)

	/// <Property class="CRH_Process_Data" name="VacDownTo500_Time" type="L3LONG">
	/// 真空度降至0.5Kpa时间
	/// </Property>
	DECLARE_L3PROP_LONG(VacDownTo500_Time)

	/// <Property class="CRH_Process_Data" name="CCM_Ladle_Weight" type="L3DOUBLE">
	/// RH出站时铸机大包重量
	/// </Property>
	DECLARE_L3PROP_DOUBLE(CCM_Ladle_Weight)

	//2009-03-30
	/// <Property class="CRH_Process_Data" name="LadleNo" type="L3STRING">
	/// 钢包号
	/// </Property>
	DECLARE_L3PROP_STRING(LadleNo)
	
	/// <Property class="CRH_Process_Data" name="LadleGrade" type="L3STRING">
	/// 钢包包况
	/// </Property>
	DECLARE_L3PROP_STRING(LadleGrade)

	/// <Property class="CRH_Process_Data" name="WholePump_Time" type="L3LONG">
	/// 全泵投用时间
	/// </Property>
	DECLARE_L3PROP_LONG(WholePump_Time)

};
