// �߼���CRH_Feed_Dataͷ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����
#pragma once
#include "UnitFeedingLog.h"
class CRH_Feed_Data :
	public UnitFeedingLog
{
public:
	CRH_Feed_Data(void);
	virtual ~CRH_Feed_Data(void);

	DECLARE_L3CLASS(CRH_Feed_Data,XGMESLogic\\RHMag, GUID)
	DECLARE_L3PROPTABLE()
	DECLARE_L3METHODMAP(CRH_Feed_Data)
	DECLARE_L3EVENTSINK_MAP()

	//������װ�ص�ϵͳ��ʱ��������
	virtual void OnLoaded();
	//������ж��ʱ��������
	virtual void OnUnloaded();

	/// <Property class="CRH_Feed_Data" name="TreatNo" type="L3STRING">
	/// �����
	/// </Property>
	DECLARE_L3PROP_STRING(TreatNo)

	/// <Property class="CRH_Feed_Data" name="HeatID" type="L3STRING">
	/// ¯��
	/// </Property>
	DECLARE_L3PROP_STRING(HeatID)

	/// <Property class="CRH_Feed_Data" name="SteelGradeIndex" type="L3STRING">
	/// ���ּǺ�
	/// </Property>
	DECLARE_L3PROP_STRING(SteelGradeIndex)

	/// <Property class="CRH_Feed_Data" name="SteelGrade" type="L3STRING">
	/// ����
	/// </Property>
	DECLARE_L3PROP_STRING(SteelGrade)

	/// <Property class="CRH_Feed_Data" name="LadleNo" type="L3STRING">
	/// �ְ���
	/// </Property>
	DECLARE_L3PROP_STRING(LadleNo)


};
