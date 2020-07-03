// �߼���CQA_Bloom_CoolJudge_Dataͷ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����
#pragma once

class CQA_Bloom_FinJudge_Data :
	public CL3Object
{
public:
	CQA_Bloom_FinJudge_Data(void);
	virtual ~CQA_Bloom_FinJudge_Data(void);

	DECLARE_L3CLASS(CQA_Bloom_FinJudge_Data,XGMESLogic\\QualityMag, GUID)
	DECLARE_L3PROPTABLE()
	DECLARE_L3METHODMAP(CQA_Bloom_FinJudge_Data)
	DECLARE_L3EVENTSINK_MAP()

	//������װ�ص�ϵͳ��ʱ��������
	virtual void OnLoaded();
	//������ж��ʱ��������
	virtual void OnUnloaded();

	/// <Property class="CQA_Bloom_FinJudge_Data" name="HeatID" type="L3STRING">
	/// ¯��
	/// </Property>
	DECLARE_L3PROP_STRING(HeatID)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="CasterID" type="L3STRING">
	/// ������
	/// </Property>
	DECLARE_L3PROP_STRING(CasterID)

/// <Property class="CQA_Bloom_FinJudge_Data" name="Pre_SteelGradeIndex" type="L3STRING">
	/// Ԥ�����ּǺ�
	/// </Property>
	DECLARE_L3PROP_STRING(Pre_SteelGradeIndex)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="SteelGradeIndex" type="L3STRING">
	/// ���ּǺ�
	/// </Property>
	DECLARE_L3PROP_STRING(SteelGradeIndex)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Cut_SteelGradeIndex" type="L3STRING">
	/// �ж����ּǺ�
	/// </Property>
	DECLARE_L3PROP_STRING(Cut_SteelGradeIndex)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Final_SteelGradeIndex" type="L3STRING">
	/// �������ּǺ�
	/// </Property>
	DECLARE_L3PROP_STRING(Final_SteelGradeIndex)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Length" type="L3LONG">
	/// ����
	/// </Property>
	DECLARE_L3PROP_LONG(Length)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Width" type="L3LONG">
	/// ����
	/// </Property>
	DECLARE_L3PROP_LONG(Width)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Thickness" type="L3LONG">
	/// ���
	/// </Property>
	DECLARE_L3PROP_LONG(Thickness)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Bloom_Count" type="L3SHORT">
	/// ����֧��
	/// </Property>
	DECLARE_L3PROP_LONG(Bloom_Count)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Cal_Weight" type="L3DOUBLE">
	/// ��������
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Cal_Weight)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Right_Count" type="L3SHORT">
	/// �ϸ�֧��
	/// </Property>
	DECLARE_L3PROP_LONG(Right_Count)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Right_Weight" type="L3DOUBLE">
	/// �ϸ�����
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Right_Weight)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Waster_Count" type="L3DOUBLE">
	/// ˦���ܳ���
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Waster_Count)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Waster_Weight" type="L3DOUBLE">
	/// ˦��������
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Waster_Weight)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Waster_Count1" type="L3DOUBLE">
	/// ˦�ϳ���1
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Waster_Count1)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Waster_Weight1" type="L3DOUBLE">
	/// ˦������1
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Waster_Weight1)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Waster_Reason1" type="L3STRING">
	/// ˦��ԭ��1
	/// </Property>
	DECLARE_L3PROP_STRING(Waster_Reason1)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Waster_Count2" type="L3DOUBLE">
	/// ˦�ϳ���2
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Waster_Count2)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Waster_Weight2" type="L3DOUBLE">
	/// ˦������2
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Waster_Weight2)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Waster_Reason2" type="L3STRING">
	/// ˦��ԭ��2
	/// </Property>
	DECLARE_L3PROP_STRING(Waster_Reason2)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Waster_Count3" type="L3DOUBLE">
	/// ˦�ϳ���3
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Waster_Count3)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Waster_Weight3" type="L3DOUBLE">
	/// ˦������3
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Waster_Weight3)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Waster_Reason3" type="L3STRING">
	/// ˦��ԭ��3
	/// </Property>
	DECLARE_L3PROP_STRING(Waster_Reason3)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Wrong_Count" type="L3SHORT">
	/// ���ϸ���֧��
	/// </Property>
	DECLARE_L3PROP_LONG(Wrong_Count)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Wrong_Weight" type="L3DOUBLE">
	/// ���ϸ�������
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Wrong_Weight)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Wrong_Count1" type="L3SHORT">
	/// ���ϸ�֧��1
	/// </Property>
	DECLARE_L3PROP_LONG(Wrong_Count1)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Wrong_Weight1" type="L3DOUBLE">
	/// ���ϸ�����1
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Wrong_Weight1)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Wrong_Reason1" type="L3STRING">
	/// ���ϸ�ԭ��1
	/// </Property>
	DECLARE_L3PROP_STRING(Wrong_Reason1)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Wrong_Count2" type="L3SHORT">
	/// ���ϸ�֧��2
	/// </Property>
	DECLARE_L3PROP_LONG(Wrong_Count2)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Wrong_Weight2" type="L3DOUBLE">
	/// ���ϸ�����2
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Wrong_Weight2)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Wrong_Reason2" type="L3STRING">
	/// ���ϸ�ԭ��2
	/// </Property>
	DECLARE_L3PROP_STRING(Wrong_Reason2)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Wrong_Count3" type="L3SHORT">
	/// ���ϸ�֧��3
	/// </Property>
	DECLARE_L3PROP_LONG(Wrong_Count3)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Wrong_Weight3" type="L3DOUBLE">
	/// ���ϸ�����3
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Wrong_Weight3)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Wrong_Reason3" type="L3STRING">
	/// ���ϸ�ԭ��3
	/// </Property>
	DECLARE_L3PROP_STRING(Wrong_Reason3)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="SufaceDefactDes" type="L3STRING">
	/// ����ȱ������
	/// </Property>
	DECLARE_L3PROP_STRING(SufaceDefactDes)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="FinishedTime" type="L3DATETIME">
	/// ����ʱ��
	/// </Property>
	DECLARE_L3PROP_DATETIME(FinishedTime)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="FinalJudge_Time" type="L3DATETIME">
	/// ����ʱ��
	/// </Property>
	DECLARE_L3PROP_DATETIME(FinalJudge_Time)


	/// <Property class="CQA_Bloom_FinJudge_Data" name="Process_Type" type="L3LONG">
	/// ���÷�ʽ
	/// </Property>
	DECLARE_L3PROP_LONG(Process_Type)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Exceptional_Code" type="L3STRING">
	/// �쳣����
	/// </Property>
	DECLARE_L3PROP_STRING(Exceptional_Code)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Decide_Code" type="L3STRING">
	/// ���ô���
	/// </Property>
	DECLARE_L3PROP_STRING(Decide_Code)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Team" type="L3STRING">
	/// ���
	/// </Property>
	DECLARE_L3PROP_STRING(Team)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Shift" type="L3STRING">
	/// ���
	/// </Property>
	DECLARE_L3PROP_STRING(Shift)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Operator" type="L3STRING">
	/// ����Ա
	/// </Property>
	DECLARE_L3PROP_STRING(Operator)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Test_Roll_Count" type="L3SHORT">
	/// ��������֧��
	/// </Property>
	DECLARE_L3PROP_LONG(Test_Roll_Count)

	/// <Property class="CQA_Bloom_FinJudge_Data" name="Test_Roll_Weight" type="L3DOUBLE">
	/// ������������
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Test_Roll_Weight)

	/// <Property class="CBOF_Base_Data" name="NC_Confirm_Flag" type="L3LONG">
	/// NCȷ�ϱ�־
	/// </Property>
	///2009-02-25
	DECLARE_L3PROP_LONG(NC_Confirm_Flag)

	/// <Property class="CBOF_Base_Data" name="Store_ChangeJudge_Flag" type="L3LONG">
	/// ���ڸ��б�־
	/// </Property>
	///2009-02-25
	DECLARE_L3PROP_LONG(Store_ChangeJudge_Flag)


};