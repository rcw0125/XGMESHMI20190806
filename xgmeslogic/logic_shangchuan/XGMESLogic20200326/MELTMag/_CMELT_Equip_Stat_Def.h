// �߼���CMELT_Equip_Stat_Defͷ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����
#pragma once

class CMELT_Equip_Stat_Def :
	public CL3Object
{
public:
	CMELT_Equip_Stat_Def(void);
	virtual ~CMELT_Equip_Stat_Def(void);

	DECLARE_L3CLASS(CMELT_Equip_Stat_Def,XGMESLogic\\MELTMag, GUID)
	DECLARE_L3PROPTABLE()
	DECLARE_L3METHODMAP(CMELT_Equip_Stat_Def)
	DECLARE_L3EVENTSINK_MAP()

	//������װ�ص�ϵͳ��ʱ��������
	virtual void OnLoaded();
	//������ж��ʱ��������
	virtual void OnUnloaded();

	/// <Property class="CMELT_Equip_Stat_Def" name="Status" type="L3SHORT">
	/// ״̬
	/// </Property>
	DECLARE_L3PROP_SHORT(Status)

	/// <Property class="CMELT_Equip_Stat_Def" name="Descr" type="L3STRING">
	/// 
	/// �豸״̬
	/// (1:����
	///  2:����
	///  3:�׹�
	///  4:��¯
	///  5:����)
	/// </Property>
	DECLARE_L3PROP_STRING(Descr)

};