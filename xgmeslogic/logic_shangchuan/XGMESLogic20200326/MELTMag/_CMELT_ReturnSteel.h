// 逻辑类CMELT_ReturnSteel头文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。
#pragma once

class CMELT_ReturnSteel :
	public CL3Object
{
public:
	CMELT_ReturnSteel(void);
	virtual ~CMELT_ReturnSteel(void);

	DECLARE_L3CLASS(CMELT_ReturnSteel,XGMESLogic\\MELTMag, HeatID)
	DECLARE_L3PROPTABLE()
	DECLARE_L3METHODMAP(CMELT_ReturnSteel)
	DECLARE_L3EVENTSINK_MAP()

	//当对象被装载到系统中时，被调用
	virtual void OnLoaded();
	//当对象被卸载时，被调用
	virtual void OnUnloaded();

	/// <Property class="CMELT_ReturnSteel" name="HeatID" type="L3STRING">
	/// 炉号
	/// </Property>
	DECLARE_L3PROP_STRING(HeatID)

	/// <Property class="CMELT_ReturnSteel" name="Return_Steel_Weight" type="L3DOUBLE">
	/// 回炉钢水量
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Return_Steel_Weight)

};
