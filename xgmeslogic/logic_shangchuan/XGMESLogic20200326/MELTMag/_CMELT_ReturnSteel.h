// �߼���CMELT_ReturnSteelͷ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����
#pragma once

class CMELT_ReturnSteel :
	public CL3Object
{
public:
	CMELT_ReturnSteel(void);
	virtual ~CMELT_ReturnSteel(void);

	DECLARE_L3CLASS(CMELT_ReturnSteel,XGMESLogic\\MELTMag, HeatID)
	DECLARE_L3PROPTABLE()
	DECLARE_L3METHODMAP(CMELT_ReturnSteel)
	DECLARE_L3EVENTSINK_MAP()

	//������װ�ص�ϵͳ��ʱ��������
	virtual void OnLoaded();
	//������ж��ʱ��������
	virtual void OnUnloaded();

	/// <Property class="CMELT_ReturnSteel" name="HeatID" type="L3STRING">
	/// ¯��
	/// </Property>
	DECLARE_L3PROP_STRING(HeatID)

	/// <Property class="CMELT_ReturnSteel" name="Return_Steel_Weight" type="L3DOUBLE">
	/// ��¯��ˮ��
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Return_Steel_Weight)

};
