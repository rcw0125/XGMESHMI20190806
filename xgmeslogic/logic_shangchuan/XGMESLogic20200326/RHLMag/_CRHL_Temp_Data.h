// 逻辑类CRHL_Temp_Data头文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。
#pragma once

class CRHL_Temp_Data :
	public CL3Object
{
public:
	CRHL_Temp_Data(void);
	virtual ~CRHL_Temp_Data(void);

	DECLARE_L3CLASS(CRHL_Temp_Data,XGMESLogic\\RHLMag, GUID)
	DECLARE_L3PROPTABLE()
	DECLARE_L3METHODMAP(CRHL_Temp_Data)
	DECLARE_L3EVENTSINK_MAP()

	//当对象被装载到系统中时，被调用
	virtual void OnLoaded();
	//当对象被卸载时，被调用
	virtual void OnUnloaded();

	/// <Property class="CRHL_Temp_Data" name="TreatNo" type="L3STRING">
	/// 处理号
	/// </Property>
	DECLARE_L3PROP_STRING(TreatNo)

	/// <Property class="CRHL_Temp_Data" name="HeatID" type="L3STRING">
	/// 炉号
	/// </Property>
	DECLARE_L3PROP_STRING(HeatID)

	/// <Property class="CRHL_Temp_Data" name="Temperature" type="L3LONG">
	/// 测温值
	/// </Property>
	DECLARE_L3PROP_LONG(Temperature)

	/// <Property class="CRHL_Temp_Data" name="MeasureTime" type="L3DATETIME">
	/// 测温时刻
	/// </Property>
	DECLARE_L3PROP_DATETIME(MeasureTime)

	/// <Property class="CRHL_Temp_Data" name="Mode" type="L3SHORT">
	/// 测温模式(1-测温枪测温;2-定氧仪测温)
	/// </Property>
	DECLARE_L3PROP_SHORT(Mode)

};
