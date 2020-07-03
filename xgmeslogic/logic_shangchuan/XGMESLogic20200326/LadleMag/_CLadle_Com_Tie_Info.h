// 逻辑类CLadle_Com_Tie_Info头文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。
#pragma once

class CLadle_Com_Tie_Info :
	public CL3Object
{
public:
	CLadle_Com_Tie_Info(void);
	virtual ~CLadle_Com_Tie_Info(void);

	DECLARE_L3CLASS(CLadle_Com_Tie_Info,XGMESLogic\\LadleMag, GUID)
	DECLARE_L3PROPTABLE()
	DECLARE_L3METHODMAP(CLadle_Com_Tie_Info)
	DECLARE_L3EVENTSINK_MAP()

	//当对象被装载到系统中时，被调用
	virtual void OnLoaded();
	//当对象被卸载时，被调用
	virtual void OnUnloaded();

	/// <Property class="CLadle_Com_Tie_Info" name="Input_Time" type="L3DATETIME">
	/// 录入时间
	/// </Property>
	DECLARE_L3PROP_DATETIME(Input_Time)

	/// <Property class="CLadle_Com_Tie_Info" name="Number" type="L3SHORT">
	/// 编号
	/// </Property>
	DECLARE_L3PROP_SHORT(Number)

	/// <Property class="CLadle_Com_Tie_Info" name="Ladle_ID" type="L3STRING">
	/// 包号
	/// </Property>
	DECLARE_L3PROP_STRING(Ladle_ID)

	/// <Property class="CLadle_Com_Tie_Info" name="Tie_Start_Time" type="L3DATETIME">
	/// 打结开始时间
	/// </Property>
	DECLARE_L3PROP_DATETIME(Tie_Start_Time)

	/// <Property class="CLadle_Com_Tie_Info" name="Tie_End_Time" type="L3DATETIME">
	/// 打结结束时间
	/// </Property>
	DECLARE_L3PROP_DATETIME(Tie_End_Time)

	/// <Property class="CLadle_Com_Tie_Info" name="Water_gap_Bri_Fac" type="L3STRING">
	/// 水口座砖厂家
	/// </Property>
	DECLARE_L3PROP_STRING(Water_gap_Bri_Fac)

	/// <Property class="CLadle_Com_Tie_Info" name="Water_gap_Bri_Wast" type="L3DOUBLE">
	/// 水口座砖消耗量[t]
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Water_gap_Bri_Wast)

	/// <Property class="CLadle_Com_Tie_Info" name="Breathe_Bri_Fac" type="L3STRING">
	/// 透气座砖厂家
	/// </Property>
	DECLARE_L3PROP_STRING(Breathe_Bri_Fac)

	/// <Property class="CLadle_Com_Tie_Info" name="Breathe_Bri_Wast" type="L3DOUBLE">
	/// 透气座砖消耗量[t]
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Breathe_Bri_Wast)

	/// <Property class="CLadle_Com_Tie_Info" name="Cast_Fac" type="L3STRING">
	/// 浇铸料厂家
	/// </Property>
	DECLARE_L3PROP_STRING(Cast_Fac)

	/// <Property class="CLadle_Com_Tie_Info" name="Cast_Wast" type="L3DOUBLE">
	/// 浇注料消耗量[t]
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Cast_Wast)

	/// <Property class="CLadle_Com_Tie_Info" name="Squ_Lead_Fac" type="L3STRING">
	/// 鳞片状石墨粉厂家
	/// </Property>
	DECLARE_L3PROP_STRING(Squ_Lead_Fac)

	/// <Property class="CLadle_Com_Tie_Info" name="Squ_Lead_Wast" type="L3DOUBLE">
	/// 鳞片状石墨粉消耗量[Kg]
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Squ_Lead_Wast)

	/// <Property class="CLadle_Com_Tie_Info" name="Half_Boa_Fac" type="L3STRING">
	/// 半板片厂家
	/// </Property>
	DECLARE_L3PROP_STRING(Half_Boa_Fac)

	/// <Property class="CLadle_Com_Tie_Info" name="Half_Boa_Wast" type="L3DOUBLE">
	/// 半板片消耗量[t]
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Half_Boa_Wast)

	/// <Property class="CLadle_Com_Tie_Info" name="Crust_Checker" type="L3STRING">
	/// 外壳检查
	/// </Property>
	DECLARE_L3PROP_STRING(Crust_Checker)

	/// <Property class="CLadle_Com_Tie_Info" name="Ladle_Inner_Checker" type="L3STRING">
	/// 永久层检查
	/// </Property>
	DECLARE_L3PROP_STRING(Ladle_Inner_Checker)

	/// <Property class="CLadle_Com_Tie_Info" name="Seat_Bri_Installer" type="L3STRING">
	/// 座砖安装
	/// </Property>
	DECLARE_L3PROP_STRING(Seat_Bri_Installer)

	/// <Property class="CLadle_Com_Tie_Info" name="Bre_Bri_Installer" type="L3STRING">
	/// 透气砖安装
	/// </Property>
	DECLARE_L3PROP_STRING(Bre_Bri_Installer)

	/// <Property class="CLadle_Com_Tie_Info" name="Sepa_Dose_Operator" type="L3STRING">
	/// 隔离剂操作
	/// </Property>
	DECLARE_L3PROP_STRING(Sepa_Dose_Operator)

	/// <Property class="CLadle_Com_Tie_Info" name="Whip_Operator" type="L3STRING">
	/// 搅拌操作
	/// </Property>
	DECLARE_L3PROP_STRING(Whip_Operator)

	/// <Property class="CLadle_Com_Tie_Info" name="Ladle_Bot_Quiver" type="L3STRING">
	/// 包底振动
	/// </Property>
	DECLARE_L3PROP_STRING(Ladle_Bot_Quiver)

	/// <Property class="CLadle_Com_Tie_Info" name="Seat_Tyre_Operator" type="L3STRING">
	/// 座包胎操作
	/// </Property>
	DECLARE_L3PROP_STRING(Seat_Tyre_Operator)

	/// <Property class="CLadle_Com_Tie_Info" name="Face_A__Quiver" type="L3STRING">
	/// A面振动
	/// </Property>
	DECLARE_L3PROP_STRING(Face_A__Quiver)

	/// <Property class="CLadle_Com_Tie_Info" name="Face_B__Quiver" type="L3STRING">
	/// B面振动
	/// </Property>
	DECLARE_L3PROP_STRING(Face_B__Quiver)

	/// <Property class="CLadle_Com_Tie_Info" name="Doff_Mod_Time" type="L3DATETIME">
	/// 脱模时间
	/// </Property>
	DECLARE_L3PROP_DATETIME(Doff_Mod_Time)

	/// <Property class="CLadle_Com_Tie_Info" name="Rep_Ladle_Builder" type="L3STRING">
	/// 补包底
	/// </Property>
	DECLARE_L3PROP_STRING(Rep_Ladle_Builder)

	/// <Property class="CLadle_Com_Tie_Info" name="Fire_Start_Time" type="L3DATETIME">
	/// 烘烤开始时间
	/// </Property>
	DECLARE_L3PROP_DATETIME(Fire_Start_Time)

	/// <Property class="CLadle_Com_Tie_Info" name="Fire_End_Time" type="L3DATETIME">
	/// 烘烤结束时间
	/// </Property>
	DECLARE_L3PROP_DATETIME(Fire_End_Time)

	/// <Property class="CLadle_Com_Tie_Info" name="Thr_Ladle_Time" type="L3DATETIME">
	/// 甩包时间
	/// </Property>
	DECLARE_L3PROP_DATETIME(Thr_Ladle_Time)

	/// <Property class="CLadle_Com_Tie_Info" name="Ladle_Inner_Use_Count" type="L3SHORT">
	/// 永久层使用次数
	/// </Property>
	DECLARE_L3PROP_SHORT(Ladle_Inner_Use_Count)

	/// <Property class="CLadle_Com_Tie_Info" name="TeamID" type="L3STRING">
	/// 班别
	/// </Property>
	DECLARE_L3PROP_STRING(TeamID)

	/// <Property class="CLadle_Com_Tie_Info" name="ShiftID" type="L3STRING">
	/// 班次
	/// </Property>
	DECLARE_L3PROP_STRING(ShiftID)

	/// <Property class="CLadle_Com_Tie_Info" name="Operator" type="L3STRING">
	/// 责任人
	/// </Property>
	DECLARE_L3PROP_STRING(Operator)

	/// <Property class="CLadle_Com_Tie_Info" name="Note" type="L3STRING">
	/// 备注
	/// </Property>
	DECLARE_L3PROP_STRING(Note)

};
