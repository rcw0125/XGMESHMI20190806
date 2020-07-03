// �߼���CRH_HeatRemarkͷ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����
#pragma once

class CRH_HeatRemark :
	public CL3Object
{
public:
	CRH_HeatRemark(void);
	virtual ~CRH_HeatRemark(void);

	DECLARE_L3CLASS(CRH_HeatRemark,XGMESLogic\\RHMag, GUID)
	DECLARE_L3PROPTABLE()
	DECLARE_L3METHODMAP(CRH_HeatRemark)
	DECLARE_L3EVENTSINK_MAP()

	//������װ�ص�ϵͳ��ʱ��������
	virtual void OnLoaded();
	//������ж��ʱ��������
	virtual void OnUnloaded();

	/// <Property class="CRH_HeatRemark" name="TreatNo" type="L3STRING">
	/// �����
	/// </Property>
	DECLARE_L3PROP_STRING(TreatNo)

	/// <Property class="CRH_HeatRemark" name="HeatID" type="L3STRING">
	/// ¯��
	/// </Property>
	DECLARE_L3PROP_STRING(HeatID)

	/// <Property class="CRH_HeatRemark" name="Type" type="L3SHORT">
	/// 
	/// ����
	/// (1:��ȫ
	///  2:�豸
	///  3:����
	///  4:����)
	/// </Property>
	DECLARE_L3PROP_SHORT(Type)

	/// <Property class="CRH_HeatRemark" name="Remark" type="L3STRING">
	/// ��ע
	/// </Property>
	DECLARE_L3PROP_STRING(Remark)

	/// <Property class="CRH_HeatRemark" name="LogTime" type="L3DATETIME">
	/// ��¼ʱ��
	/// </Property>
	DECLARE_L3PROP_DATETIME(LogTime)

};
