// 逻辑类CRH_Equipment_Status头文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。
#pragma once

class CRH_Equipment_Status :
	public CL3Object
{
public:
	CRH_Equipment_Status(void);
	virtual ~CRH_Equipment_Status(void);

	DECLARE_L3CLASS(CRH_Equipment_Status,XGMESLogic\\RHMag, GUID)
	DECLARE_L3PROPTABLE()
	DECLARE_L3METHODMAP(CRH_Equipment_Status)
	DECLARE_L3EVENTSINK_MAP()

	//当对象被装载到系统中时，被调用
	virtual void OnLoaded();
	//当对象被卸载时，被调用
	virtual void OnUnloaded();

	/// <Property class="CRH_Equipment_Status" name="RHID" type="L3SHORT">
	/// RH炉炉座号(1:RH1)
	/// </Property>
	DECLARE_L3PROP_SHORT(RHID)

	/// <Property class="CRH_Equipment_Status" name="Status" type="L3SHORT">
	/// 
	/// 设备状态
	/// (1:正常
	///  2:检修
	///  3:故障
	///  4:等待)
	/// </Property>
	DECLARE_L3PROP_SHORT(Status)

	/// <Property class="CRH_Equipment_Status" name="Log_Time" type="L3DATETIME">
	/// 记录时刻
	/// </Property>
	DECLARE_L3PROP_DATETIME(Log_Time)

	/// <Property class="CRH_Equipment_Status" name="Reason" type="L3STRING">
	/// 原因
	/// </Property>
	DECLARE_L3PROP_STRING(Reason)

};
