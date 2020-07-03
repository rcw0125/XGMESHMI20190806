// �߼���CIron_Dataͷ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����
#pragma once
#include "Material.h"

class CIron_Data :
	public Material
{
public:
	CIron_Data(void);
	virtual ~CIron_Data(void);

	DECLARE_L3CLASS(CIron_Data, MES\\MaterialData, MaterialID)
	DECLARE_L3PROPTABLE()
	DECLARE_L3METHODMAP(CIron_Data)
	DECLARE_L3EVENTSINK_MAP()

	//������װ�ص�ϵͳ��ʱ��������
	virtual void OnLoaded();
	//������ж��ʱ��������
	virtual void OnUnloaded();

public:

	enum _IronSource
	{
		DirectMixed = 0,	// ֱ��
		FromMix1 = 1,		// 1�Ż���¯����
		FromMix2 = 2,		// 2�Ż���¯����
		FromMix3 = 3		// 3�Ż���¯����
	};

	/// <Property class="CIron_Data" name="Weight" type="L3DOUBLE">
	/// ��ˮ����
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Weight)

	/// <Property class="CIron_Data" name="C" type="L3FLOAT">
	/// ̼�ɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(C)

	/// <Property class="CIron_Data" name="Si" type="L3FLOAT">
	/// ��ɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(Si)

	/// <Property class="CIron_Data" name="Mn" type="L3FLOAT">
	/// �̳ɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(Mn)

	/// <Property class="CIron_Data" name="P" type="L3FLOAT">
	/// �׳ɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(P)

	/// <Property class="CIron_Data" name="S" type="L3FLOAT">
	/// ��ɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(S)

	//modify by hyh 2012-04-10
	/// <Property class="CIron_Data" name="Ti" type="L3FLOAT">
	/// �ѳɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(Ti)

	/// <Property class="CIron_Data" name="Sn" type="L3FLOAT">
	/// add by hyh 20120331
	/// </Property>
	DECLARE_L3PROP_FLOAT(Sn)

	/// <Property class="CIron_Data" name="Sb" type="L3FLOAT">
	/// add by hyh 20120331
	/// </Property>
	DECLARE_L3PROP_FLOAT(Sb)

	/// <Property class="CIron_Data" name="As" type="L3FLOAT">
	/// add by hyh 20120331
	/// </Property>
	DECLARE_L3PROP_FLOAT(As)

	/// <Property class="CIron_Data" name="Pb" type="L3FLOAT">
	/// add by hyh 20120331
	/// </Property>
	DECLARE_L3PROP_FLOAT(Pb)
	//end

	//add by hyh 2012-08-09 Ӧҵ��Ҫ��������Ni(��)��Mo(��)��Cu(ͭ) ��Cr(��)��B(��)��V(��)��Al(��)��Nb(��)��Zn(п)��W(��)
	/// <Property class="CIron_Data" name="Ni" type="L3FLOAT">
	/// ���ɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(Ni)

	/// <Property class="CIron_Data" name="Mo" type="L3FLOAT">
	/// ��ɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(Mo)

	/// <Property class="CIron_Data" name="Cu" type="L3FLOAT">
	/// ͭ�ɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(Cu)

	/// <Property class="CIron_Data" name="Cr" type="L3FLOAT">
	/// ���ɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(Cr)

	/// <Property class="CIron_Data" name="B" type="L3FLOAT">
	/// ��ɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(B)

	/// <Property class="CIron_Data" name="V" type="L3FLOAT">
	/// ���ɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(V)

	/// <Property class="CIron_Data" name="Al" type="L3FLOAT">
	/// ���ɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(Al)

	/// <Property class="CIron_Data" name="Nb" type="L3FLOAT">
	/// ��ɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(Nb)

	/// <Property class="CIron_Data" name="Zn" type="L3FLOAT">
	/// п�ɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(Zn)

	/// <Property class="CIron_Data" name="W type="L3FLOAT">
	/// �ٳɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(W)
	//end

	/// <Property class="CIron_Data" name="IronTemp" type="L3LONG">
	/// ��ˮ�¶�
	/// </Property>
	DECLARE_L3PROP_LONG(IronTemp)

	/// <Property class="CIron_Data" name="HeatID" type="L3STRING">
	/// ¯��
	/// </Property>
	DECLARE_L3PROP_STRING(HeatID)

	/// <Property class="CIron_Data" name="Source" type="L3SHORT">
	/// 
	/// ������ʽ(0:ֱ��;
	///          1:1#����¯����;
	///          2:2#����¯����)
	/// </Property>
	DECLARE_L3PROP_SHORT(Source)

	/// <Property class="CIron_Data" name="Shift" type="L3SHORT">
	///���
	/// </Property>
	DECLARE_L3PROP_SHORT(Shift)

	/// <Property class="CIron_Data" name="Team" type="L3SHORT">
	///���
	/// </Property>
	DECLARE_L3PROP_SHORT(Team)

	/// <Property class="CIron_Data" name="Operator" type="L3STRING">
	///����Ա
	/// </Property>
	DECLARE_L3PROP_STRING(Operator)

	/// <Property class="CIron_Data" name="Tare" type="L3DOUBLE">
	/// Ƥ��
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Tare)

	/// <Property class="CIron_Data" name="Gross_Weight" type="L3DOUBLE">
	/// ë��
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Gross_Weight)

	/// <Property class="CIron_Data" name="Tap_Time" type="L3DATETIME">
	/// ����ʱ��
	/// </Property>
	DECLARE_L3PROP_DATETIME(Tap_Time)

	/// <Property class="CIron_Data" name="IronLadleNo" type="L3STRING">
	/// ������
	/// </Property>
	DECLARE_L3PROP_STRING(IronLadleNo)

	/// <Property class="CIron_Data" name="Object1" type="L3STRING">
	/// �������1
	/// </Property>
	DECLARE_L3PROP_STRING(Object1)

	/// <Property class="CIron_Data" name="Weight1" type="L3DOUBLE">
	///�������1
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Weight1)

	/// <Property class="CIron_Data" name="Object2" type="L3STRING">
	/// �������2
	/// </Property>
	DECLARE_L3PROP_STRING(Object2)

	/// <Property class="CIron_Data" name="Weight2" type="L3DOUBLE">
	///�������2
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Weight2)

	/// <Property class="CIron_Data" name="Object3" type="L3STRING">
	/// �������3
	/// </Property>
	DECLARE_L3PROP_STRING(Object3)

	/// <Property class="CIron_Data" name="Weight3" type="L3DOUBLE">
	///�������3
	/// </Property>
	DECLARE_L3PROP_DOUBLE(Weight3)

	/// <Property class="CIron_Data" name="Return_Steel_Weight" type="L3FLOAT">
	/// 
	/// ��¯����
	/// 
	/// </Property>
	DECLARE_L3PROP_FLOAT(Return_Steel_Weight)

	//Modify begin by llj 2011-04-06 �����Ƿ��������
	
	
	/// <Property class="CIron_Data" name="IsDes" type="L3FLOAT">
	/// 
	/// �Ƿ����� 0:���� -1��������
	/// 
	/// </Property>
	DECLARE_L3PROP_FLOAT(IsDes)
	//modify end

	/*///add by yuan 2018-06-21
	/// <Property class="CIron_Data" name="C_1" type="L3FLOAT">
	/// ¯ǰ�����̼�ɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(C_1)

	/// <Property class="CIron_Data" name="Si_1" type="L3FLOAT">
	/// ¯ǰ����Ĺ�ɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(Si_1)

	/// <Property class="CIron_Data" name="Mn_1" type="L3FLOAT">
	/// ¯ǰ������̳ɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(Mn_1)

	/// <Property class="CIron_Data" name="P_1" type="L3FLOAT">
	/// ¯ǰ������׳ɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(P_1)

	/// <Property class="CIron_Data" name="S_1" type="L3FLOAT">
	/// ¯ǰ�������ɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(S_1)

	
	/// <Property class="CIron_Data" name="Ti_1" type="L3FLOAT">
	/// ¯ǰ������ѳɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(Ti_1)

	/// <Property class="CIron_Data" name="Sn_1" type="L3FLOAT">
	/// ¯ǰ�����Sn
	/// </Property>
	DECLARE_L3PROP_FLOAT(Sn_1)

	/// <Property class="CIron_Data" name="Sb_1" type="L3FLOAT">
	/// ¯ǰ�����Sb
	/// </Property>
	DECLARE_L3PROP_FLOAT(Sb_1)

	/// <Property class="CIron_Data" name="As_1" type="L3FLOAT">
	///¯ǰ�����As
	/// </Property>
	DECLARE_L3PROP_FLOAT(As_1)

	/// <Property class="CIron_Data" name="Pb_1" type="L3FLOAT">
	///¯ǰ�����Pb
	/// </Property>
	DECLARE_L3PROP_FLOAT(Pb_1)
	

	
	/// <Property class="CIron_Data" name="Ni_1" type="L3FLOAT">
	/// ¯ǰ��������ɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(Ni_1)

	/// <Property class="CIron_Data" name="Mo_1" type="L3FLOAT">
	/// ¯ǰ�������ɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(Mo_1)

	/// <Property class="CIron_Data" name="Cu_1" type="L3FLOAT">
	/// ¯ǰ�����ͭ�ɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(Cu_1)

	/// <Property class="CIron_Data" name="Cr_1" type="L3FLOAT">
	/// ¯ǰ����ĸ��ɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(Cr_1)

	/// <Property class="CIron_Data" name="B_1" type="L3FLOAT">
	///¯ǰ�������ɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(B_1)

	/// <Property class="CIron_Data" name="V_1" type="L3FLOAT">
	/// ¯ǰ����ķ��ɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(V_1)

	/// <Property class="CIron_Data" name="Al_1" type="L3FLOAT">
	/// ¯ǰ��������ɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(Al_1)

	/// <Property class="CIron_Data" name="Nb" type="L3FLOAT">
	/// ¯ǰ�������ɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(Nb_1)

	/// <Property class="CIron_Data" name="Zn_1" type="L3FLOAT">
	/// ¯ǰ�����п�ɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(Zn_1)

	/// <Property class="CIron_Data" name="W_1" type="L3FLOAT">
	/// ¯ǰ������ٳɷ�ֵ
	/// </Property>
	DECLARE_L3PROP_FLOAT(W_1)
	///add end;*/
};
