// �߼���CScrap_Output_Logͷ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����
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
	/// ����״̬ö��
	/// </summary>
	enum IronFlag
	{
		UnSpecified = 0,		// δָ��
		Specified = 1,		    // ��ָ����
		InputIron = 2,			// �Ѷ�����
	};

	//������װ�ص�ϵͳ��ʱ��������
	virtual void OnLoaded();
	//������ж��ʱ��������
	virtual void OnUnloaded();

	/// <Property class="CScrap_Output_Log" name="Scrap_Slot_ID" type="L3STRING">
	/// �ϸֶ���
	/// </Property>
	DECLARE_L3PROP_STRING(Scrap_Slot_ID)

	/// <Property class="CScrap_Output_Log" name="MaterialType" type="L3STRING">
	/// ��������
	/// </Property>
	DECLARE_L3PROP_STRING(MaterialType)

	/// <Property class="CScrap_Output_Log" name="MaterialID" type="L3STRING">
	/// ����ID
	/// </Property>
	DECLARE_L3PROP_STRING(MaterialID)

	/// <Property class="CScrap_Output_Log" name="AreaID" type="L3STRING">
	/// ���
	/// </Property>
	DECLARE_L3PROP_STRING(AreaID)

	/// <Property class="CScrap_Output_Log" name="Shift" type="L3STRING">
	/// ���
	/// </Property>
	DECLARE_L3PROP_STRING(Shift)

	/// <Property class="CScrap_Output_Log" name="Team" type="L3STRING">
	/// ����
	/// </Property>
	DECLARE_L3PROP_STRING(Team)

	/// <Property class="CScrap_Output_Log" name="Operator" type="L3STRING">
	/// ����Ա
	/// </Property>
	DECLARE_L3PROP_STRING(Operator)

	/// <Property class="CScrap_Output_Log" name="LogDate" type="L3DATETIME">
	/// ʱ��
	/// </Property>
	DECLARE_L3PROP_DATETIME(LogDate)

	/// <Property class="CScrap_Output_Log" name="Amount" type="L3DOUBLE">
	/// ����
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Amount)

	/// <Property class="CScrap_Output_Log" name="Car_ID" type="L3STRING">
	/// ����
	/// </Property>
	DECLARE_L3PROP_STRING(Car_ID)

	/// <Property class="CScrap_Output_Log" name="Car_Type" type="L3STRING">
	/// �ϳ�����
	/// </Property>
	DECLARE_L3PROP_STRING(Car_Type)

	/// <Property class="CScrap_Output_Log" name="Net_Weight" type="L3DOUBLE">
	/// ����
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Net_Weight)

	/// <Property class="CScrap_Output_Log" name="Gross_Weight" type="L3DOUBLE">
	/// ë��
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Gross_Weight)

	/// <Property class="CScrap_Output_Log" name="Tare_Weight" type="L3DOUBLE">
	/// Ƥ��
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Tare_Weight)

	/// <Property class="CScrap_Output_Log" name="Iron_Flag" type="L3LONG">
	/// ������־,0:δָ��,1:��ָ����2:�Ѷ���
	/// </Property>
	DECLARE_L3PROP_LONG(Iron_Flag)

	/// <Property class="CScrap_Output_Log" name="HeatID" type="STRING">
	/// ¯��
	/// </Property>
	DECLARE_L3PROP_STRING(HeatID)

	/// <Property class="CScrap_Output_Log" name="ScrapType" type="L3STRING">
	/// ��������
	/// </Property>
	DECLARE_L3PROP_STRING(ScrapType)

    /// <Property class="CScrap_Output_Log" name="StoreAreaID" type="L3STRING">
	/// ������λ
	/// </Property>
	DECLARE_L3PROP_STRING(StoreAreaID)

};
