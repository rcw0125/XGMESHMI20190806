// �߼���CMELT_Remark_Typeͷ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����
#pragma once

class CMELT_Remark_Type :
	public CL3Object
{
public:
	CMELT_Remark_Type(void);
	virtual ~CMELT_Remark_Type(void);

	DECLARE_L3CLASS(CMELT_Remark_Type,XGMESLogic\\MELTMag, GUID)
	DECLARE_L3PROPTABLE()
	DECLARE_L3METHODMAP(CMELT_Remark_Type)
	DECLARE_L3EVENTSINK_MAP()

	//������װ�ص�ϵͳ��ʱ��������
	virtual void OnLoaded();
	//������ж��ʱ��������
	virtual void OnUnloaded();

	/// <Property class="CMELT_Remark_Type" name="TypeID" type="L3SHORT">
	/// 
	/// ����
	/// (1:��ȫ
	///  2:�豸
	///  3:����
	///  4:����)
	/// </Property>
	DECLARE_L3PROP_SHORT(TypeID)

	/// <Property class="CMELT_Remark_Type" name="TypeDes" type="L3STRING">
	/// 
	/// ����
	/// (1:��ȫ
	///  2:�豸
	///  3:����
	///  4:����)
	/// </Property>
	DECLARE_L3PROP_STRING(TypeDes)

};
