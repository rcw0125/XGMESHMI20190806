// 逻辑类CTap_Ladle_Weight头文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。
#pragma once

class CTap_Ladle_Weight :
	public CL3Object
{
public:
	CTap_Ladle_Weight(void);
	virtual ~CTap_Ladle_Weight(void);

	DECLARE_L3CLASS(CTap_Ladle_Weight,XGMESLogic\\TapSideMag, GUID)
	DECLARE_L3PROPTABLE()
	DECLARE_L3METHODMAP(CTap_Ladle_Weight)
	DECLARE_L3EVENTSINK_MAP()

	//当对象被装载到系统中时，被调用
	virtual void OnLoaded();
	//当对象被卸载时，被调用
	virtual void OnUnloaded();

	/// <Property class="CTap_Ladle_Weight" name="TAPID" type="L3SHORT">
	/// 炉后座号
	/// </Property>
	DECLARE_L3PROP_SHORT(TAPID)

	/// <Property class="CTap_Ladle_Weight" name="Weight" type="L3DOUBLE">
	/// 钢水重量
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Weight)

	/// <Property class="CTap_Ladle_Weight" name="Status" type="L3SHORT">
	/// 
	/// 状态
	/// (0:未使用
	///  1:已使用)
	/// </Property>
	DECLARE_L3PROP_SHORT(Status)

	/// <Property class="CTap_Ladle_Weight" name="LadleNo" type="L3STRING">
	/// 钢包号
	/// </Property>
	DECLARE_L3PROP_STRING(LadleNo)

	/// <Property class="CTap_Ladle_Weight" name="HeatID" type="L3STRING">
	/// 当前炉号
	/// </Property>
	DECLARE_L3PROP_STRING(HeatID)

	/// <Property class="CTap_Ladle_Weight" name="Log_Time" type="L3DATETIME">
	/// 记录时刻
	/// </Property>
	DECLARE_L3PROP_DATETIME(Log_Time)

};
