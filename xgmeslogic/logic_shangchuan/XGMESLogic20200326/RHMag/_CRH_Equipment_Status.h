// �߼���CRH_Equipment_Statusͷ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����
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

	//������װ�ص�ϵͳ��ʱ��������
	virtual void OnLoaded();
	//������ж��ʱ��������
	virtual void OnUnloaded();

	/// <Property class="CRH_Equipment_Status" name="RHID" type="L3SHORT">
	/// RH¯¯����(1:RH1)
	/// </Property>
	DECLARE_L3PROP_SHORT(RHID)

	/// <Property class="CRH_Equipment_Status" name="Status" type="L3SHORT">
	/// 
	/// �豸״̬
	/// (1:����
	///  2:����
	///  3:����
	///  4:�ȴ�)
	/// </Property>
	DECLARE_L3PROP_SHORT(Status)

	/// <Property class="CRH_Equipment_Status" name="Log_Time" type="L3DATETIME">
	/// ��¼ʱ��
	/// </Property>
	DECLARE_L3PROP_DATETIME(Log_Time)

	/// <Property class="CRH_Equipment_Status" name="Reason" type="L3STRING">
	/// ԭ��
	/// </Property>
	DECLARE_L3PROP_STRING(Reason)

};
