// 逻辑类CScrap_Output_Log头文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。
#pragma once
#include "MaterialOutputLog.h"

class CScrap_Output_Log :
	public MaterialOutputLog
{
public:
	CScrap_Output_Log(void);
	virtual ~CScrap_Output_Log(void);

	DECLARE_L3CLASS(CScrap_Output_Log,XGMESLogic\\ScrapStoreMag, GUID)
	DECLARE_L3PROPTABLE()
	DECLARE_L3METHODMAP(CScrap_Output_Log)
	DECLARE_L3EVENTSINK_MAP()

	/// <summary>
	/// 兑铁状态枚举
	/// </summary>
	enum IronFlag
	{
		UnSpecified = 0,		// 未指定
		Specified = 1,		    // 已指定。
		InputIron = 2,			// 已兑铁。
	};

	//当对象被装载到系统中时，被调用
	virtual void OnLoaded();
	//当对象被卸载时，被调用
	virtual void OnUnloaded();

	/// <Property class="CScrap_Output_Log" name="Scrap_Slot_ID" type="L3STRING">
	/// 废钢斗号
	/// </Property>
	DECLARE_L3PROP_STRING(Scrap_Slot_ID)

	/// <Property class="CScrap_Output_Log" name="MaterialType" type="L3STRING">
	/// 物料类型
	/// </Property>
	DECLARE_L3PROP_STRING(MaterialType)

	/// <Property class="CScrap_Output_Log" name="MaterialID" type="L3STRING">
	/// 物料ID
	/// </Property>
	DECLARE_L3PROP_STRING(MaterialID)

	/// <Property class="CScrap_Output_Log" name="AreaID" type="L3STRING">
	/// 物仓
	/// </Property>
	DECLARE_L3PROP_STRING(AreaID)

	/// <Property class="CScrap_Output_Log" name="Shift" type="L3STRING">
	/// 班次
	/// </Property>
	DECLARE_L3PROP_STRING(Shift)

	/// <Property class="CScrap_Output_Log" name="Team" type="L3STRING">
	/// 班组
	/// </Property>
	DECLARE_L3PROP_STRING(Team)

	/// <Property class="CScrap_Output_Log" name="Operator" type="L3STRING">
	/// 操作员
	/// </Property>
	DECLARE_L3PROP_STRING(Operator)

	/// <Property class="CScrap_Output_Log" name="LogDate" type="L3DATETIME">
	/// 时间
	/// </Property>
	DECLARE_L3PROP_DATETIME(LogDate)

	/// <Property class="CScrap_Output_Log" name="Amount" type="L3DOUBLE">
	/// 重量
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Amount)

	/// <Property class="CScrap_Output_Log" name="Car_ID" type="L3STRING">
	/// 车号
	/// </Property>
	DECLARE_L3PROP_STRING(Car_ID)

	/// <Property class="CScrap_Output_Log" name="Car_Type" type="L3STRING">
	/// 拖车类型
	/// </Property>
	DECLARE_L3PROP_STRING(Car_Type)

	/// <Property class="CScrap_Output_Log" name="Net_Weight" type="L3DOUBLE">
	/// 净重
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Net_Weight)

	/// <Property class="CScrap_Output_Log" name="Gross_Weight" type="L3DOUBLE">
	/// 毛重
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Gross_Weight)

	/// <Property class="CScrap_Output_Log" name="Tare_Weight" type="L3DOUBLE">
	/// 皮重
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Tare_Weight)

	/// <Property class="CScrap_Output_Log" name="Iron_Flag" type="L3LONG">
	/// 兑铁标志,0:未指定,1:已指定，2:已兑铁
	/// </Property>
	DECLARE_L3PROP_LONG(Iron_Flag)

	/// <Property class="CScrap_Output_Log" name="HeatID" type="STRING">
	/// 炉号
	/// </Property>
	DECLARE_L3PROP_STRING(HeatID)

	/// <Property class="CScrap_Output_Log" name="ScrapType" type="L3STRING">
	/// 物料类型
	/// </Property>
	DECLARE_L3PROP_STRING(ScrapType)

    /// <Property class="CScrap_Output_Log" name="StoreAreaID" type="L3STRING">
	/// 物料料位
	/// </Property>
	DECLARE_L3PROP_STRING(StoreAreaID)

};
