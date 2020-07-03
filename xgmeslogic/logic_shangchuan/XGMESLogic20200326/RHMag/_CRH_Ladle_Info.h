// 逻辑类CRH_Ladle_Info头文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。
#pragma once

class CRH_Ladle_Info :
	public CL3Object
{
public:
	CRH_Ladle_Info(void);
	virtual ~CRH_Ladle_Info(void);

	DECLARE_L3CLASS(CRH_Ladle_Info,XGMESLogic\\RHMag, TreatNo)
	DECLARE_L3PROPTABLE()
	DECLARE_L3METHODMAP(CRH_Ladle_Info)
	DECLARE_L3EVENTSINK_MAP()

	//当对象被装载到系统中时，被调用
	virtual void OnLoaded();
	//当对象被卸载时，被调用
	virtual void OnUnloaded();

	/// <Property class="CRH_Ladle_Info" name="TreatNo" type="L3STRING">
	/// 处理号
	/// </Property>
	DECLARE_L3PROP_STRING(TreatNo)

	/// <Property class="CRH_Ladle_Info" name="HeatID" type="L3STRING">
	/// 炉号
	/// </Property>
	DECLARE_L3PROP_STRING(HeatID)

	/// <Property class="CRH_Ladle_Info" name="LadleID" type="L3STRING">
	/// 钢包号
	/// </Property>
	DECLARE_L3PROP_STRING(LadleID)

	/// <Property class="CRH_Ladle_Info" name="Last_Ladle_Grade" type="L3STRING">
	/// 上次包况
	/// </Property>
	DECLARE_L3PROP_STRING(Last_Ladle_Grade)

	
	/// <Property class="CRH_Ladle_Info" name="Temp" type="L3LONG">
	/// 上次20'温降
	/// </Property>
	DECLARE_L3PROP_LONG(Temp)

	/// <Property class="CRH_Ladle_Info" name="Last_SteelGrade" type="L3STRING">
	/// 上次使用钢种
	/// </Property>
	DECLARE_L3PROP_STRING(Last_SteelGrade)

	/// <Property class="CRH_Ladle_Info" name="Act_Ladle_Grade" type="L3STRING">
	/// 当前包况
	/// </Property>
	DECLARE_L3PROP_STRING(Act_Ladle_Grade)

	/// <Property class="CRH_Ladle_Info" name="Cur_SteelGrade" type="L3STRING">
	/// 当前使用钢种
	/// </Property>
	DECLARE_L3PROP_STRING(Cur_SteelGrade)

	/// <Property class="CRH_Ladle_Info" name="In_Ladle_Grade" type="L3STRING">
	/// 进站包况
	/// </Property>
	DECLARE_L3PROP_STRING(In_Ladle_Grade)

	/// <Property class="CRH_Ladle_Info" name="Stop_Time_Len" type="L3LONG">
	/// 停用时长[min]
	/// </Property>
	DECLARE_L3PROP_LONG(Stop_Time_Len)

	/// <Property class="CRH_Ladle_Info" name="Ladle_Age" type="L3LONG">
	/// 包龄
	/// </Property>
	DECLARE_L3PROP_LONG(Ladle_Age)

	/// <Property class="CRH_Ladle_Info" name="Small_Fire" type="L3LONG">
	/// 小火时间[min]
	/// </Property>
	DECLARE_L3PROP_LONG(Small_Fire)

	/// <Property class="CRH_Ladle_Info" name="Middle_Fire" type="L3LONG">
	/// 中火时间[min]
	/// </Property>
	DECLARE_L3PROP_LONG(Middle_Fire)

	/// <Property class="CRH_Ladle_Info" name="Big_Fire" type="L3LONG">
	/// 大火时间[min]
	/// </Property>
	DECLARE_L3PROP_LONG(Big_Fire)

	/// <Property class="CRH_Ladle_Info" name="Note" type="L3STRING">
	/// 备注
	/// </Property>
	DECLARE_L3PROP_STRING(Note)

	/// <Property class="CRH_Ladle_Info" name="Other1" type="L3STRING">
	/// 预留1
	/// </Property>
	DECLARE_L3PROP_STRING(Other1)

	/// <Property class="CRH_Ladle_Info" name="Other2" type="L3STRING">
	/// </Property>
	DECLARE_L3PROP_STRING(Other2)

	/// <Property class="CRH_Ladle_Info" name="Other3" type="L3STRING">
	/// </Property>
	DECLARE_L3PROP_STRING(Other3)

	/// <Property class="CRH_Ladle_Info" name="MaxTemp" type="L3LONG">
	/// 上次转包温降
	/// </Property>
	DECLARE_L3PROP_LONG(MaxTemp)

};
