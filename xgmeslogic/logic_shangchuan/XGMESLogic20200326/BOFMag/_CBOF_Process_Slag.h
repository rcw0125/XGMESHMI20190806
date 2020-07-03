// 逻辑类CBOF_Process_Slag头文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。
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

	//当对象被装载到系统中时，被调用
	virtual void OnLoaded();
	//当对象被卸载时，被调用
	virtual void OnUnloaded();

	/// <Property class="CBOF_Process_Slag" name="HeatID" type="L3STRING">
	/// 炉号
	/// </Property>
	DECLARE_L3PROP_STRING(HeatID)

	/// <Property class="CBOF_Process_Slag" name="Status" type="L3SHORT">
	/// 
	/// 状态(1:不留渣
	///          -1:留渣;
	
	/// </Property>
	DECLARE_L3PROP_SHORT(Status)

	/*DECLARE_L3PROP_STRING(Type)*/

	/// <Property class="CBOF_Process_Slag" name="Change_Time" type="L3DATETIME">
	/// 状态变化时刻
	/// </Property>
	DECLARE_L3PROP_DATETIME(Change_Time)

};
