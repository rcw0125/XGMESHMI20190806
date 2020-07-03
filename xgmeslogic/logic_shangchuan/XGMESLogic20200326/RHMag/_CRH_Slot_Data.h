// 逻辑类CRH_Slot_Data头文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。
#pragma once

class CRH_Slot_Data :
	public CL3Object
{
public:
	CRH_Slot_Data(void);
	virtual ~CRH_Slot_Data(void);

	DECLARE_L3CLASS(CRH_Slot_Data,XGMESLogic\\RHMag, GUID)
	DECLARE_L3PROPTABLE()
	DECLARE_L3METHODMAP(CRH_Slot_Data)
	DECLARE_L3EVENTSINK_MAP()

	//当对象被装载到系统中时，被调用
	virtual void OnLoaded();
	//当对象被卸载时，被调用
	virtual void OnUnloaded();

	/// <Property class="CRH_Slot_Data" name="Slot_No" type="L3STRING">
	/// 槽号
	/// </Property>
	DECLARE_L3PROP_STRING(Slot_No)

	/// <Property class="CRH_Slot_Data" name="Validity" type="L3SHORT">
	/// 
	/// 有效性
	/// (1-有效
	///  0-无效)
	/// </Property>
	DECLARE_L3PROP_SHORT(Validity)

	/// <Property class="CRH_Slot_Data" name="RHID" type="L3SHORT">
	/// RH炉座
	/// </Property>
	DECLARE_L3PROP_SHORT(RHID)

	/// <Property class="CRH_Slot_Data" name="Create_Time" type="L3DATETIME">
	/// 创建时刻
	/// </Property>
	DECLARE_L3PROP_DATETIME(Create_Time)

	/// <Property class="CRH_Slot_Data" name="Valid_Time" type="L3DATETIME">
	/// 有效性设置时刻
	/// </Property>
	DECLARE_L3PROP_DATETIME(Valid_Time)

	/// <Property class="CRH_Slot_Data" name="Operator" type="L3STRING">
	/// 操作员
	/// </Property>
	DECLARE_L3PROP_STRING(Operator)

};
