// �߼���CMELT_Communicator���û��߼�����Դ�ļ�
// �û�ϵͳ���߼�����Ӧ���ڱ��ļ���ʵ�֣��߼������Ķ���Ӧ����_CMELT_Communicator.h�С�
// ���ڱ��ļ��ж���ĺ�����ΪL3���ɿ��������Զ����ɣ�����_CMELT_Communicator.h��
// �в�������صĴ��룬����벻Ҫɾ�����޸ı��ļ��еĺ������塣�û�ϵͳ����ԱӦ��ֻ�޸ĺ����ľ���
// ʵ�ִ��롣��Ҫ��ӡ�ɾ�����޸��߼������Ķ��壬��ʹ�ü��ɿ���������ɡ�

#include "StdAfx.h"
#include "_CMELT_Communicator.h"

//������װ�ص�ϵͳ��ʱ��������
void CMELT_Communicator::OnLoaded()
{
	__super::OnLoaded();

	// TODO: �ڴ˴���Ӷ���װ��ʱ�Ĵ������
}

//������ж��ʱ��������
void CMELT_Communicator::OnUnloaded()
{
	__super::OnUnloaded();

	// TODO: �ڴ˴���Ӷ���ж��ʱ�Ĵ������
}


/// <Method class="CMELT_Communicator" name="OnFeedIron" type="L3BOOL">
/// ��Ӧ�����ӷϸ��¼�����
/// <Param name="rsData" type="L3RECORDSET">��������</Param>
/// </Method>
L3BOOL CMELT_Communicator::OnFeedIron(L3RECORDSET rsData)
{
    return true;
	// TODO : ���ڴ�����߼�����
}

/// <Method class="CMELT_Communicator" name="OnChangeStatus" type="L3BOOL">
/// <Param name="rsData" type="L3RECORDSET">
/// ״̬����
/// (BOFID,Status,Change_Time)</Param>
/// </Method>
L3BOOL CMELT_Communicator::OnChangeStatus(L3RECORDSET rsData)
{
    return true;
	// TODO : ���ڴ�����߼�����
}

/// <Method class="CMELT_Communicator" name="OnDischarge" type="L3BOOL">
/// <Param name="rsData" type="L3RECORDSET">
/// ���ϼ�¼��
/// (Element,Weight,Discharge_Time,Type)</Param>
/// </Method>
L3BOOL CMELT_Communicator::OnDischarge(L3RECORDSET rsData)
{
    return true;
	// TODO : ���ڴ�����߼�����
}

/// <Method class="CMELT_Communicator" name="OnMeasureTemp" type="L3BOOL">
/// �����¼���Ӧ����
/// <Param name="rsData" type="L3RECORDSET">
/// ��������
/// (Temp,Temp_Time,Mode)</Param>
/// </Method>
L3BOOL CMELT_Communicator::OnMeasureTemp(L3RECORDSET rsData)
{
    return true;
	// TODO : ���ڴ�����߼�����
}

/// <Method class="CMELT_Communicator" name="OnMeasureO2" type="L3BOOL">
/// <Param name="rsData" type="L3RECORDSET">
/// ��������
/// (O2,Measure_Time)</Param>
/// </Method>
L3BOOL CMELT_Communicator::OnMeasureO2(L3RECORDSET rsData)
{
    return true;
	// TODO : ���ڴ�����߼�����
}

/// <Method class="CMELT_Communicator" name="OnTapped" type="L3BOOL">
/// <Param name="rsData" type="L3RECORDSET"></Param>
/// </Method>
L3BOOL CMELT_Communicator::OnTapped(L3RECORDSET rsData)
{
    return true;
	// TODO : ���ڴ�����߼�����
}

/// <Method class="CMELT_Communicator" name="OnBottomBlow" type="L3BOOL">
/// <Param name="rsData" type="L3RECORDSET">
/// �״�����
/// (BOFID,Flow1...Flow6,Pressure1...Pressure6,Gas_Type)</Param>
/// </Method>
L3BOOL CMELT_Communicator::OnBottomBlow(L3RECORDSET rsData)
{
	CString strID = GetIdentity().ToCString();
	CString strBOFURI = _T("XGMESLogic\\MELTMag\\CMELT_Unit_Mag\\") + strID;

	CL3Variant valRet = InvokeObjectMethod(strBOFURI,_T("BottomBlowing"),(L3RECORDSET)rsData);
	if(valRet.IsError())
		return false;
	else
		return valRet.ToBOOL();

// TODO : ���ڴ�����߼�����
}

/// <Method class="CMELT_Communicator" name="OnTopBlow" type="L3BOOL">
/// <Param name="rsData" type="L3RECORDSET">
/// ��������
/// (BFID,Flow,Pressure,Catch_Time)</Param>
/// </Method>
L3BOOL CMELT_Communicator::OnTopBlow(L3RECORDSET rsData)
{
    return true;
	// TODO : ���ڴ�����߼�����
}

/// <Method class="CMELT_Communicator" name="OnSauceEvent" type="L3BOOL">
/// <Param name="rsData" type="L3RECORDSET"></Param>
/// </Method>
L3BOOL CMELT_Communicator::OnSauceEvent(L3RECORDSET rsData)
{
    return true;
	// TODO : ���ڴ�����߼�����
}

/// <Method class="CMELT_Communicator" name="OnTapStart" type="L3BOOL">
/// <Param name="rsData" type="L3RECORDSET"></Param>
/// </Method>
L3BOOL CMELT_Communicator::OnTapStart(L3RECORDSET rsData)
{
    return true;
	// TODO : ���ڴ�����߼�����
}
