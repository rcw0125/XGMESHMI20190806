// 逻辑类CRH_BlowO_Status_Data头文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。
#pragma once

class CRH_BlowO_Status_Data :
	public CL3Object
{
public:
	CRH_BlowO_Status_Data(void);
	virtual ~CRH_BlowO_Status_Data(void);

	DECLARE_L3CLASS(CRH_BlowO_Status_Data,XGMESLogic\\RHMag, GUID)
	DECLARE_L3PROPTABLE()
	DECLARE_L3METHODMAP(CRH_BlowO_Status_Data)
	DECLARE_L3EVENTSINK_MAP()

	//当对象被装载到系统中时，被调用
	virtual void OnLoaded();
	//当对象被卸载时，被调用
	virtual void OnUnloaded();

	/// <Property class="CRH_BlowO_Status_Data" name="TreatNo" type="L3STRING">
	/// 处理号
	/// </Property>
	DECLARE_L3PROP_STRING(TreatNo)

	/// <Property class="CRH_BlowO_Status_Data" name="HeatID" type="L3STRING">
	/// 炉号
	/// </Property>
	DECLARE_L3PROP_STRING(HeatID)

	/// <Property class="CRH_BlowO_Status_Data" name="Status" type="L3LONG">
	/// 顶枪吹氧状态
	/// </Property>
	DECLARE_L3PROP_LONG(Status)

	/// <Property class="CRH_BlowO_Status_Data" name="MeasureTime" type="L3DATETIME">
	/// 状态变化时间
	/// </Property>
	DECLARE_L3PROP_DATETIME(MeasureTime)

};
