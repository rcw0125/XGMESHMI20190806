// �߼���CRH_Unit_Mag���û��߼�����Դ�ļ�
// �û�ϵͳ���߼�����Ӧ���ڱ��ļ���ʵ�֣��߼������Ķ���Ӧ����_CRH_Unit_Mag.h�С�
// ���ڱ��ļ��ж���ĺ�����ΪL3���ɿ��������Զ����ɣ�����_CRH_Unit_Mag.h��
// �в�������صĴ��룬����벻Ҫɾ�����޸ı��ļ��еĺ������塣�û�ϵͳ����ԱӦ��ֻ�޸ĺ����ľ���
// ʵ�ִ��롣��Ҫ��ӡ�ɾ�����޸��߼������Ķ��壬��ʹ�ü��ɿ���������ɡ�

#include "StdAfx.h"
#include "_CRH_Unit_Mag.h"
#include "L3NameParser.h"

//������װ�ص�ϵͳ��ʱ��������
void CRH_Unit_Mag::OnLoaded()
{
	__super::OnLoaded();

	// TODO: �ڴ˴���Ӷ���װ��ʱ�Ĵ������
}

//������ж��ʱ��������
void CRH_Unit_Mag::OnUnloaded()
{
	__super::OnUnloaded();

	// TODO: �ڴ˴���Ӷ���ж��ʱ�Ĵ������
}

/// <summary>
/// ���ػ���ļӹ�����
/// ARG << lstURIs : �������мӹ��������URI
/// </summary>
BOOL CRH_Unit_Mag::GetProduceAreas(CStringList& lstURIs)
{
	CString strID = GetIdentity().ToCString();
	CString strAreaA = CL3NameParser::MergeClassDomainName(LF_AREA_CLASS_URI,strID + _T("A"));
	CString strAreaB = CL3NameParser::MergeClassDomainName(LF_AREA_CLASS_URI,strID + _T("B"));
	lstURIs.AddTail(strAreaA);
	lstURIs.AddTail(strAreaB);
	return TRUE;
}

/// <summary>
/// �õ�����ǰ����ϻ�������URI
/// </summary>
CString CRH_Unit_Mag::GetInputCache()
{
	CString strID = GetIdentity().ToCString();
	CString strCache;
	strCache.Format(_T("XGMESLogic\\BaseDataMag\\XGInterCache\\%sP01"),strID);
	return strCache;
}

/// <summary>
/// �õ������̲��ϻ�������URI
/// </summary>
CString CRH_Unit_Mag::GetOutputCache()
{
	// ���ݼƻ�ת�˲��ϣ��޹̶����ڻ���
	return _T("");
}

/// <summary>
/// ��������ǰԤ�����ڻ�������ǰ���ã��̳�������ش˷�������Ԥ������׼���ʹ���
/// ARG >> rsMaterialInfo : ������Ϣ��¼����
/// RET << ����TRUE�������ϣ�����FALSE�ж����ϡ�
/// </summary>
BOOL CRH_Unit_Mag::OnBeforeFeedMaterials(L3RECORDSET rsMaterialInfo)
{
	// TODO: �ڴ˴��༭��ع��ܵĴ������

	return __super::OnBeforeFeedMaterials( rsMaterialInfo);
}


/// <summary>
/// �������Ϻ��������ڻ������Ϻ���ã��̳�������ش˷������ж��⴦��
/// ARG >> rsMaterialInfo : ������Ϣ��¼����
/// RET << �ɹ�����TRUE��ʧ�ܷ���FALSE��
/// </summary>
BOOL CRH_Unit_Mag::OnAfterMaterialsFeeded(L3RECORDSET rsMaterialInfo)
{
	// TODO: �ڴ˴��༭��ع��ܵĴ������

	return __super::OnAfterMaterialsFeeded( rsMaterialInfo);
}


/// <summary>
/// ���ػ������ϼ�¼������URI
/// </summary>
CString CRH_Unit_Mag::GetFeedingLogType()
{
	// TODO: �ڴ˴��༭��ع��ܵĴ������

	return __super::GetFeedingLogType();
}


/// <summary>
/// ׼�����ϼ�¼���ݡ��̳�������ش˺������ж�������ݴ���
/// ARG >> rsFeedingLogs : ���ϼ�¼��Ϣ��
/// RET << void
/// </summary>
void CRH_Unit_Mag::PrepareFeedingLogs(L3RECORDSET rsFeedingLogs)
{
	// TODO: �ڴ˴��༭��ع��ܵĴ������

	__super::PrepareFeedingLogs( rsFeedingLogs);
}


/// <summary>
/// �ӹ�����Ԥ�����ڵ��üӹ�����ļӹ�����ǰ���ã��̳�������ش˺����Լӹ����������޸ĺ����á�
/// ARG >> lpcszArea : �ӹ������URI
///		>> rsParameters : �ӹ�������¼����
/// RET << ����TRUE�����ӹ�������FALSE�жϼӹ���
/// </summary>
BOOL CRH_Unit_Mag::PrepareProcessParameters(LPCTSTR lpcszArea,L3RECORDSET rsParameters)
{
	// TODO: �ڴ˴��༭��ع��ܵĴ������

	return __super::PrepareProcessParameters( lpcszArea, rsParameters);
}


/// <summary>
/// �ӹ���ɺ��������ڼӹ���ɺ���ã��̳�������ش˺������ж����߼�����
/// ARG >> lpcszArea : �ӹ������URI
///		>> nProcessType : �ӹ������͡�
///		>> rsProducts : �ӹ������Ĳ�Ʒ����Ϣ��¼��
/// RET << �ɹ�����TRUE��ʧ�ܷ���FALSE��
/// </summary>
BOOL CRH_Unit_Mag::OnAfterProcessCompleted(LPCTSTR lpcszArea,LONG nProcessType,L3RECORDSET rsProducts)
{
	// TODO: �ڴ˴��༭��ع��ܵĴ������

	return __super::OnAfterProcessCompleted( lpcszArea, nProcessType, rsProducts);
}


/// <summary>
/// ����ǰԤ������ִ�����߲���ǰ���ã��̳�������ش˺�������Ԥ�ȵ�����׼���ʹ���
/// ARG >> rsMaterialInfo : ���߲�����Ϣ������MaterialType,MaterialID,Amount,Area�ֶΡ�
/// RET << ����TRUE�������ߣ�����FALSE�ж����ߡ�
/// </summary>
BOOL CRH_Unit_Mag::OnBeforeDeliverMaterials(L3RECORDSET rsMaterialInfo)
{
	// TODO: �ڴ˴��༭��ع��ܵĴ������

	return __super::OnBeforeDeliverMaterials( rsMaterialInfo);
}

/// <summary>
/// ���ߺ���������ִ�����߲�������ã��̳�������ش˺������ж��⴦��
/// ARG >> rsMaterialInfo : ���߲�����Ϣ������MaterialType,MaterialID,Amount,Area�ֶΡ�
/// RET << �ɹ�����TRUE��ʧ�ܷ���FALSE��
/// </summary>
BOOL CRH_Unit_Mag::OnAfterMaterialsDelivered(L3RECORDSET rsMaterialInfo)
{
	// TODO: �ڴ˴��༭��ع��ܵĴ������

	return __super::OnAfterMaterialsDelivered( rsMaterialInfo);
}


/// <summary>
/// ���ػ��������¼������URI
/// </summary>
CString CRH_Unit_Mag::GetDeliveryLogType()
{
	// TODO: �ڴ˴��༭��ع��ܵĴ������

	return __super::GetDeliveryLogType();
}


/// <summary>
/// ׼�����ϼ�¼���ݡ�
/// ARG >> rsDeliveryLog : ���ϼ�¼���ݡ�
/// RET <<void
/// </summary>
void CRH_Unit_Mag::PrepareDeliveryLogs(L3RECORDSET rsDeliveryLog)
{
	// TODO: �ڴ˴��༭��ع��ܵĴ������

	__super::PrepareDeliveryLogs( rsDeliveryLog);
}


/// <summary>
/// ���ر������ͨѶ�������URI
/// </summary>
CString CRH_Unit_Mag::GetCommunicator()
{
	// TODO: �ڴ˴��༭��ع��ܵĴ������

	return __super::GetCommunicator();
}


/// <summary>
/// ׼���ƻ����ݣ��Ա��������λϵͳ���͡�
/// ARG >> lpcszPlanType : �ƻ����͡�
///		>> rsPlan : �ƻ����ݡ�����PlanID�ֶΡ�
///		<< rsSend : ����׼���õļƻ��������ݡ�
/// RET << �ɹ�����TRUE��ʧ�ܷ���FALSE��
/// </summary>
BOOL CRH_Unit_Mag::PreparePlanForSending(LPCTSTR lpcszPlanType,L3RECORDSET rsPlan,L3RECORDSET* pprsSend)
{
	// TODO: �ڴ˴��༭��ع��ܵĴ������

	return __super::PreparePlanForSending( lpcszPlanType, rsPlan, pprsSend);
}


/// <summary>
/// �ƻ��´��������������λϵͳ���ͼƻ�����ã��̳�������ش˺������к�������
/// ARG >> rsSend : �·���λϵͳ�ļƻ����ݡ�
/// RET << �ɹ�����TRUE��ʧ�ܷ���FALSE��
/// </summary>
BOOL CRH_Unit_Mag::OnAfterPlansSent(L3RECORDSET rsSend)
{
	// TODO: �ڴ˴��༭��ع��ܵĴ������

	return __super::OnAfterPlansSent( rsSend);
}


/// <summary>
/// ׼���ƻ����ݣ��Ա�֪ͨ������λϵͳȡ���ƻ���
/// ARG >> lpcszPlanType : �ƻ����͡�
///		>> rsPlan : �ƻ����ݡ�����PlanID�ֶΡ�
///		<< rsSend : ����׼���õļƻ�ȡ�����ݡ�
/// RET << �ɹ�����TRUE��ʧ�ܷ���FALSE��
/// </summary>
BOOL CRH_Unit_Mag::PreparePlanForCancel(LPCTSTR lpcszPlanType,L3RECORDSET rsPlan,L3RECORDSET* pprsCancel)
{
	// TODO: �ڴ˴��༭��ع��ܵĴ������

	return __super::PreparePlanForCancel( lpcszPlanType, rsPlan, pprsCancel);
}


/// <summary>
/// �ƻ�ȡ����������������λϵͳ����ȡ���ƻ�����ã��̳�������ش˺������к�������
/// ARG >> rsCancel : �·���λϵͳ�ļƻ�ȡ�����ݡ�
/// RET << �ɹ�����TRUE��ʧ�ܷ���FALSE��
/// </summary>
BOOL CRH_Unit_Mag::OnAfterPlansCanceled(L3RECORDSET rsCancel)
{
	// TODO: �ڴ˴��༭��ع��ܵĴ������

	return __super::OnAfterPlansCanceled( rsCancel);
}


/// <summary>
/// ����������ߵ��¼�
/// ARG >> pEvt : �¼�����
/// RET << ����TRUE��ʾ�Ѿ��ɹ���������FALSE��ʾʹ��ϵͳȱʡ����ʽ��
/// </summary>
BOOL CRH_Unit_Mag::HandleMaterialFeedingEvent(MatEnterArea *pEvt)
{
	// TODO: �ڴ˴��༭��ع��ܵĴ������

	return __super::HandleMaterialFeedingEvent(pEvt);
}

/// <summary>
/// ������Ͻ���ӹ�������¼�
/// ARG >> pEvt : �¼�����
/// RET << ����TRUE��ʾ�Ѿ��ɹ���������FALSE��ʾʹ��ϵͳȱʡ����ʽ��
/// </summary>
BOOL CRH_Unit_Mag::HandleMaterialEnterAreaEvent(MatEnterArea *pEvt)
{
	// TODO: �ڴ˴��༭��ع��ܵĴ������

	return __super::HandleMaterialEnterAreaEvent(pEvt);
}

/// <summary>
/// ��������뿪�ӹ������¼�
/// ARG >> pEvt : �¼�����
/// RET << ����TRUE��ʾ�Ѿ��ɹ���������FALSE��ʾʹ��ϵͳȱʡ����ʽ��
/// </summary>
BOOL CRH_Unit_Mag::HandleMaterialLeaveAreaEvent(MatLeaveArea *pEvt)
{
	// TODO: �ڴ˴��༭��ع��ܵĴ������

	return __super::HandleMaterialLeaveAreaEvent(pEvt);
}

/// <summary>
/// ���������������¼�
/// ARG >> pEvt : �¼�����
/// RET << ����TRUE��ʾ�Ѿ��ɹ���������FALSE��ʾʹ��ϵͳȱʡ����ʽ��
/// </summary>
BOOL CRH_Unit_Mag::HandleMaterialProducedEvent(MatProduced *pEvt)
{
	// TODO: �ڴ˴��༭��ع��ܵĴ������

	return __super::HandleMaterialProducedEvent(pEvt);
}

/// <summary>
/// �������������ݱ���¼�
/// ARG >> pEvt : �¼�����
/// RET << ����TRUE��ʾ�Ѿ��ɹ���������FALSE��ʾʹ��ϵͳȱʡ����ʽ��
/// </summary>
BOOL CRH_Unit_Mag::HandleUnitMeasureChangedEvent(UnitMeasure *pEvt)
{
	// TODO: �ڴ˴��༭��ع��ܵĴ������

	return __super::HandleUnitMeasureChangedEvent(pEvt);
}

/// ������һ�����
CString CRH_Unit_Mag::CalculateNextTreatNo(LPCTSTR lpcszTreatNo)
{
	COleDateTime curTime = COleDateTime::GetCurrentTime();
	CString strTreatNo(lpcszTreatNo); strTreatNo.Trim();
	CString strNextID; 	
	CString strID = GetIdentity().ToCString();
	strID = strID.Mid(2,1);
	if(strTreatNo.IsEmpty())
	{
		LONG nYear = curTime.GetYear();
		nYear = nYear - (nYear / 100) * 100;
		strNextID.Format(_T("%s%02d%05d"),(LPCTSTR)strID,nYear,(INT)1);
	}
	else
	{
		CString strIDYear = strTreatNo.Mid(1,2);
		CString strIDSeq = strTreatNo.Mid(3,strTreatNo.GetLength()-3);
		LONG nYear = 0, nSeq = 0;
		_stscanf_s(strIDYear,_T("%d"),&nYear);
		_stscanf_s(strIDSeq,_T("%d"),&nSeq);
		LONG nCurYear = curTime.GetYear();
		nCurYear = nCurYear - (nCurYear / 100) * 100;
		if(nYear != nCurYear)
		{
			nYear = nCurYear;
			nSeq = 1;
		}
		else
			nSeq ++;
		strNextID.Format(_T("%s%02d%05d"),strID,nYear,nSeq);
	}
	return strNextID;
}

/// ͨ�ù���״̬�޸ĺ���
BOOL CRH_Unit_Mag::ChangeStatus(LONG nStatus)
{
	LONG nTrans = 0;
	if(!IsInTrans())
	{
		nTrans = BeginTrans();
		if(nTrans < 1)
			return FALSE;
	}

	// �޸�ת¯״̬
	if(!SetPropValue(_T("Status"),CL3Variant(nStatus)))
	{
		if(nTrans > 0)
			Rollback(nTrans);
		return FALSE;
	}

	CString strArea = CurArea;
	CString strAreaID = strArea.IsEmpty() ? _T("") : GetIdentity().ToCString() + strArea;
	CString strAreaURI = strArea.IsEmpty() ? _T("") : CL3NameParser::MergeClassDomainName(RH_AREA_CLASS_URI,strAreaID);

	CString strHeatID = strArea.IsEmpty() ? _T("") : GetObjectPropValue(strAreaURI,_T("HeatID")).ToCString();
	CString strTreatNo = TreatNo;
	
	if(!strAreaURI.IsEmpty())
	{
		if(!SetObjectPropValue(strAreaURI,_T("Status"),CL3Variant(nStatus)))
		{
			if(nTrans > 0) Rollback(nTrans);
			return FALSE;
		}
	}

	// ��¼�¼���־
	CL3RecordSetWrap rsStatus;
	if(!CreateClassPropSet(RH_PROCESS_STATUS_CLASS_URI,rsStatus))
	{
		if(nTrans > 0)
			Rollback(nTrans);
		return FALSE;
	}
	rsStatus.AppendRecord();
	rsStatus.SetFieldByName(_T("TreatNo"),CL3Variant(strTreatNo));
	rsStatus.SetFieldByName(_T("HeatID"),CL3Variant(strHeatID));
	rsStatus.SetFieldByName(_T("Status"),CL3Variant(nStatus));
	rsStatus.SetFieldByName(_T("Change_Time"),CL3Variant(COleDateTime::GetCurrentTime()));
	if(CreateNewObjects(RH_PROCESS_STATUS_CLASS_URI,rsStatus) < 1)
	{
		if(nTrans > 0)
			Rollback(nTrans);
		return FALSE;
	}

	if(nTrans > 0)
		Commit(nTrans);

	return TRUE;
}

/// ͨ�üƻ�״̬�޸ĺ���
BOOL CRH_Unit_Mag::ChangePlanStatus(LPCTSTR lpcszHeatID,LPCTSTR lpcszTreatNo,LPCTSTR Status)
{
	CL3RecordSet *pRS = new CL3RecordSet();
	CL3RecordSetWrap rsPlanStatus; pRS->QueryInterface(IID_IL3RecordSet,rsPlanStatus); pRS->Release();
	rsPlanStatus.AddField(_T("HeatID"),VT_BSTR);
	rsPlanStatus.AddField(_T("UnitType"),VT_I4);
	rsPlanStatus.AddField(_T("TreatNo"),VT_BSTR);
	rsPlanStatus.AddField(_T("UnitStatus"),VT_BSTR);
	rsPlanStatus.AddField(_T("StatusChangeTime"),VT_DATE);
	rsPlanStatus.AppendRecord();
	rsPlanStatus.SetFieldByName(_T("HeatID"),CL3Variant(lpcszHeatID));
	rsPlanStatus.SetFieldByName(_T("UnitType"),CL3Variant(_T("5")));
	rsPlanStatus.SetFieldByName(_T("TreatNo"),CL3Variant(lpcszTreatNo));
	rsPlanStatus.SetFieldByName(_T("UnitStatus"),CL3Variant(Status));
	rsPlanStatus.SetFieldByName(_T("StatusChangeTime"),CL3Variant(COleDateTime::GetCurrentTime()));
	CL3Variant valRet = InvokeObjectMethod(PLAN_OBJ_URI,_T("ModifyPlanExecutionStatus"),(L3RECORDSET)rsPlanStatus);
	return valRet.ToBOOL();
}

/// <Method class="CRH_Unit_Mag" name="GetInputSteels" type="L3RECORDSET">
/// �����������Ĵ������ˮ��Ϣ��
/// </Method>
L3RECORDSET CRH_Unit_Mag::GetInputSteels()
{
	CString strCache = GetInputCache();
	CL3Variant val = InvokeObjectMethod(strCache,_T("GetMaterialDetails"),_T("CSteel_Data"),_T(""));
	if(!val.IsValid())
		return NULL;
	CL3RecordSetWrap rs;
	if(FAILED(val.QueryInterface(IID_IL3RecordSet,rs)))
		return NULL;
	rs.MoveFirst();
	CL3RecordSetWrap rsSteels;
	if(!CreateClassPropSet(MATERIAL_STEEL_URI,rsSteels))
		return NULL;
	rsSteels.CopyFrom(rs);
	return rsSteels.Detach();
}

/// <Method class="CRH_Unit_Mag" name="DesignateLadle" type="L3BOOL">
/// ΪA��B��λָ����������ĸ�ˮ��
/// <Param name="Area" type="L3STRING">��λ�룺A��B</Param>
/// <Param name="MaterialID" type="L3STRING">��ˮ¯��</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::DesignateLadle(L3STRING Area, L3STRING MaterialID)
{
	CString strArea = String_BSTR2TChar(Area);
	strArea.Trim();
	if(strArea !=_T("A") && strArea !=_T("B")) return FALSE;

	CString strAreaID = GetIdentity().ToCString() + strArea;
	CString strAreaURI = CL3NameParser::MergeClassDomainName(RH_AREA_CLASS_URI,strAreaID);

	if(!SetObjectPropValue(strAreaURI,_T("NextSteel"),CL3Variant(MaterialID)))
		return FALSE;

	return TRUE;
}


/// <Method class="CRH_Unit_Mag" name="SteelArrived" type="L3BOOL">
/// ����ְ������¼���
/// <Param name="AreaID" type="L3STRING">�ְ�����Ĺ�λ</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::SteelArrived(L3STRING AreaID)
{
	CString strArea = String_BSTR2TChar(AreaID);
	strArea.Trim();
	if(strArea !=_T("A") && strArea !=_T("B")) return FALSE;

	CString strAreaID = GetIdentity().ToCString() + strArea;
	CString strAreaURI = CL3NameParser::MergeClassDomainName(RH_AREA_CLASS_URI,strAreaID);

	LONG nTrans = 0;
	if(!IsInTrans())
	{
		nTrans = BeginTrans();
		if(nTrans < 1)
			return FALSE;
	}

	// ��������
	if(!PutObjectIntoTrans(GetURI()))
	{
		if(nTrans > 0) Rollback(nTrans);
		return FALSE;
	}
	// ������λ
	if(!PutObjectIntoTrans(strAreaURI))
	{
		if(nTrans > 0) Rollback(nTrans);
		return FALSE;
	}

	// ��ȡ�¸����߸ְ�
	CL3Variant val = GetObjectPropValue(strAreaURI,_T("NextSteel"));
	CString strSteel = val.ToCString();
	strSteel.Trim();
	if(strSteel.IsEmpty())
	{
		if(nTrans > 0) Rollback(nTrans);
		SetL3LastError(XGMES_ERR_RH_NEEDSTEEL);
		return FALSE;
	}

	// �ְ�����
	CString strInputCache = GetInputCache();
	val = InvokeObjectMethod(strInputCache,_T("FindMaterial"),_T("CSteel_Data"),(LPCTSTR)strSteel);
	CL3RecordSetWrap rsSteel;
	if(FAILED(val.QueryInterface(IID_IL3RecordSet,rsSteel)) || rsSteel.GetRowCount() < 1)
	{
		if(nTrans > 0) Rollback(nTrans);
		SetL3LastError(XGMES_ERR_RH_NEEDSTEEL);
		return FALSE;
	}
	rsSteel.AddField(_T("TargetArea"),VT_BSTR); // ָ������Ŀ�깤λURI
	rsSteel.MoveFirst();
	rsSteel.SetFieldByName(_T("TargetArea"),CL3Variant(strAreaURI));
	if(!FeedMaterials(rsSteel))
	{
		if(nTrans > 0) Rollback(nTrans);
		return FALSE;
	}
	
	//2009-01-13 tangyi
	if(!SetObjectPropValue(strAreaURI,_T("NextSteel"),CL3Variant(_T(""))))
	{
		if(nTrans > 0) Rollback(nTrans);
		return FALSE;
	}

	//2009-04-04
	if(!SetObjectPropValue(strAreaURI,_T("Status"),CL3Variant(CRH_Unit_Mag::RHWaiting)))
	{
		if(nTrans > 0) Rollback(nTrans);
		return FALSE;
	}

	if(nTrans > 0) Commit(nTrans);

	
	// �޸ļƻ�״̬2008-12-11 tangyi
	ChangePlanStatus(strSteel,_T(""),TAPPING_PLAN_RH_STATUS_ARR);

	return TRUE;
}

/// <Method class="CRH_Unit_Mag" name="OBStarted" type="L3BOOL">
/// ����OB��ʼ�¼�
/// </Method>
L3BOOL CRH_Unit_Mag::OBStarted()
{
	return ChangeStatus(CRH_Unit_Mag::RHOB);
}

/// <Method class="CRH_Unit_Mag" name="OBStopped" type="L3BOOL">
/// ����OB�����¼�
/// </Method>
L3BOOL CRH_Unit_Mag::OBStopped()
{
	return ChangeStatus(CRH_Unit_Mag::RHProcBegin);
}

/// <Method class="CRH_Unit_Mag" name="VacuumStarted" type="L3BOOL">
/// ������տ�ʼ�¼�
/// </Method>
L3BOOL CRH_Unit_Mag::VacuumStarted()
{
	return ChangeStatus(CRH_Unit_Mag::RHVacBegin);
}

/// <Method class="CRH_Unit_Mag" name="VacuumStopped" type="L3BOOL">
/// ������ս����¼�
/// </Method>
L3BOOL CRH_Unit_Mag::VacuumStopped()
{
	return ChangeStatus(CRH_Unit_Mag::RHProcBegin);
}

/// <Method class="CRH_Unit_Mag" name="FeedElement" type="L3BOOL">
/// ��RH¯����
/// <Param name="rsElem" type="L3RECORDSET">��������</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::FeedElement(L3RECORDSET rsElem)
{
	CL3RecordSetWrap rs = rsElem;
	if(rs.GetRowCount() < 1)
	{
		SetL3LastError(L3ERR_WRONG_PARAMETER);
		return FALSE;
	}


	CL3RecordSetWrap rsLog;
	if(!CreateClassPropSet(RH_ADDITION_DATA_CLASS_URI,rsLog))
	{
		return FALSE;
	}

	CString strArea = CurArea;
	strArea.Trim();
	if(strArea !=_T("A") && strArea !=_T("B")) return FALSE;

	CString strAreaID = GetIdentity().ToCString() + strArea;
	CString strAreaURI = CL3NameParser::MergeClassDomainName(RH_AREA_CLASS_URI,strAreaID);
	CString strHeatID = GetObjectPropValue(strAreaURI,_T("HeatID")).ToCString();
	CString strTreatNo = TreatNo;

	rs.MoveFirst();
	rsLog.CopyFrom(rs);
	rsLog.MoveFirst();
	while(!rsLog.IsEOF())
	{
		rsLog.SetFieldByName(_T("TreatNo"),CL3Variant(strTreatNo));
		rsLog.SetFieldByName(_T("HeatID"),CL3Variant(strHeatID));
		rsLog.MoveNext();
	}

	rsLog.MoveFirst();
	if(CreateNewObjects(RH_ADDITION_DATA_CLASS_URI,rsLog) < 1)
		return FALSE;

	// ��RH¯״̬��Ϊ�Ͻ�
	ChangeStatus(CRH_Unit_Mag::RHAlloy);

	return TRUE;
}

/// <Method class="CRH_Unit_Mag" name="SetTemperature" type="L3BOOL">
/// ������¼�����¼�
/// <Param name="rsTemp" type="L3RECORDSET">�����¼�����</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::SetTemperature(L3RECORDSET rsTemp)
{
	CL3RecordSetWrap rs = rsTemp;
	if(rs.GetRowCount() < 1)
		return FALSE;

	// �������
	if(rs.GetFieldIndex(_T("Temperature")) < 0)
	{
		SetL3LastError(L3ERR_WRONG_PARAMETER);
		return FALSE;
	}

	BOOL bUseTimeNow = FALSE;
	if(rs.GetFieldIndex(_T("MeasureTime")) < 0)
	{
		bUseTimeNow = TRUE;
	}

	LONG nTrans = 0;
	if(!IsInTrans())
	{
		nTrans = BeginTrans();
		if(nTrans < 1)
			return FALSE;
	}

	// ������¯
	if(!PutObjectIntoTrans(GetURI()))
	{
		if(nTrans > 0)
			Rollback(nTrans);
		return FALSE;
	}

	// ��ȡ¯�źʹ����
	CString strArea = CurArea;
		strArea.Trim();
	if(strArea !=_T("A") && strArea !=_T("B")) 
	{
		if(nTrans > 0)
			Rollback(nTrans);
		return FALSE;
	}

	CString strAreaID = GetIdentity().ToCString() + strArea;
	CString strAreaURI = CL3NameParser::MergeClassDomainName(RH_AREA_CLASS_URI,strAreaID);
	CString strHeatID = GetObjectPropValue(strAreaURI,_T("HeatID")).ToCString();
	CString strTreatNo = TreatNo;

	COleDateTime curTime = COleDateTime::GetCurrentTime();
	// ��¼���¼�¼
	CL3RecordSetWrap rsLog;
	if(!CreateClassPropSet(RH_TEMP_DATA_CLASS_URI,rsLog))
	{
		if(nTrans > 0)
			Rollback(nTrans);
		return FALSE;
	}
	rs.MoveFirst();
	rsLog.CopyFrom(rs);
	rsLog.MoveFirst();
	L3DOUBLE fTemp = 0;
	DATE dtTime = 0;
	while(!rsLog.IsEOF())
	{
		rsLog.SetFieldByName(_T("TreatNo"),CL3Variant(strTreatNo));
		rsLog.SetFieldByName(_T("HeatID"),CL3Variant(strHeatID));
		if(bUseTimeNow)
			rsLog.SetFieldByName(_T("MeasureTime"),CL3Variant(curTime));
		DATE dtTimeThis = rsLog.GetFieldByName(_T("MeasureTime")).ToDateTime();
		if(dtTimeThis > dtTime)
		{
			fTemp = rsLog.GetFieldByName(_T("Temperature")).ToDouble();
			dtTime = dtTimeThis;
		}
		rsLog.MoveNext();
	}
	rsLog.MoveFirst();
	if(CreateNewObjects(RH_TEMP_DATA_CLASS_URI,rsLog) < 1)
	{
		if(nTrans > 0)
			Rollback(nTrans);
		return FALSE;
	}

	CurTemp = fTemp;

	if(nTrans > 0)
		Commit(nTrans);

	return TRUE;	
}

/// <Method class="CRH_Prod_Area" name="SetOxygen" type="L3BOOL">
/// ������¼RH¯�����¼���
/// <Param name="rsOxygen" type="L3RECORDSET">��������</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::SetOxygen(L3RECORDSET rsOxygen)
{
	CL3RecordSetWrap rs = rsOxygen;
	if(rs.GetRowCount() < 1)
		return FALSE;

	// �������
	if(rs.GetFieldIndex(_T("Oxygen_Content")) < 0)
	{
		SetL3LastError(L3ERR_WRONG_PARAMETER);
		return FALSE;
	}

	BOOL bUseTimeNow = FALSE;
	if(rs.GetFieldIndex(_T("Measure_Time")) < 0)
	{
		bUseTimeNow = TRUE;
	}

	LONG nTrans = 0;
	if(!IsInTrans())
	{
		nTrans = BeginTrans();
		if(nTrans < 1)
			return FALSE;
	}

	// ������¯
	if(!PutObjectIntoTrans(GetURI()))
	{
		if(nTrans > 0)
			Rollback(nTrans);
		return FALSE;
	}

	// ��ȡ¯�źʹ����
	CString strArea = CurArea;
	strArea.Trim();
	if(strArea !=_T("A") && strArea !=_T("B")) 
	{
		if(nTrans > 0)
			Rollback(nTrans);
		return FALSE;
	}
	CString strAreaID = GetIdentity().ToCString() + strArea;
	CString strAreaURI = CL3NameParser::MergeClassDomainName(RH_AREA_CLASS_URI,strAreaID);
	CString strHeatID = GetObjectPropValue(strAreaURI,_T("HeatID")).ToCString();
	CString strTreatNo = TreatNo;

	COleDateTime curTime = COleDateTime::GetCurrentTime();

	// ��¼������¼
	CL3RecordSetWrap rsLog;
	if(!CreateClassPropSet(RH_OXYGEN_DATA_CLASS_URI,rsLog))
	{
		if(nTrans > 0)
			Rollback(nTrans);
		return FALSE;
	}
	rs.MoveFirst();
	rsLog.CopyFrom(rs);
	rsLog.MoveFirst();
	while(!rsLog.IsEOF())
	{
		rsLog.SetFieldByName(_T("TreatNo"),CL3Variant(strTreatNo));
		rsLog.SetFieldByName(_T("HeatID"),CL3Variant(strHeatID));
		if(bUseTimeNow)
			rsLog.SetFieldByName(_T("Measure_Time"),CL3Variant(curTime));
		rsLog.MoveNext();
	}
	rsLog.MoveFirst();
	if(CreateNewObjects(RH_OXYGEN_DATA_CLASS_URI,rsLog) < 1)
	{
		if(nTrans > 0)
			Rollback(nTrans);
		return FALSE;
	}

	if(nTrans > 0)
		Commit(nTrans);

	return TRUE;
}

/// <Method class="CRH_Unit_Mag" name="FeedWire" type="L3BOOL">
/// ������¼ι˿�¼�
/// <Param name="Area" type="L3STRING">����ι˿�Ĺ�λ</Param>
/// <Param name="rsWire" type="L3RECORDSET">ι˿���ݼ�¼</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::FeedWire(L3STRING Area,L3RECORDSET rsWire)
{
	CL3RecordSetWrap rs = rsWire;
	if(rs.GetRowCount() < 1)
	{
		SetL3LastError(L3ERR_WRONG_PARAMETER);
		return FALSE;
	}


	CL3RecordSetWrap rsLog;
	if(!CreateClassPropSet(RH_WIRE_DATA_CLASS_URI,rsLog))
	{
		return FALSE;
	}

	CString strArea = Area;
			strArea.Trim();
	if(strArea !=_T("A") && strArea !=_T("B")) 
		return FALSE;

	CString strAreaID = GetIdentity().ToCString() + strArea;
	CString strAreaURI = CL3NameParser::MergeClassDomainName(RH_AREA_CLASS_URI,strAreaID);
	CString strHeatID = GetObjectPropValue(strAreaURI,_T("HeatID")).ToCString();
	CString strTreatNo = GetObjectPropValue(strAreaURI,_T("TreatNo")).ToCString();

	rs.MoveFirst();
	rsLog.CopyFrom(rs);
	rsLog.MoveFirst();
	while(!rsLog.IsEOF())
	{
		rsLog.SetFieldByName(_T("TreatNo"),CL3Variant(strTreatNo));
		rsLog.SetFieldByName(_T("HeatID"),CL3Variant(strHeatID));
		rsLog.MoveNext();
	}

	rsLog.MoveFirst();
	if(CreateNewObjects(RH_WIRE_DATA_CLASS_URI,rsLog) < 1)
		return FALSE;

	return TRUE;
}

/// <Method class="CRH_Unit_Mag" name="StartProcess" type="L3BOOL">
/// ��ʼ����A��B����֮һ��λ�ϵĸ�ˮ��
/// <Param name="Area" type="L3STRING">Ҫ��ʼ����Ĺ�λ</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::StartProcess(L3STRING Area)
{
	CString strArea = String_BSTR2TChar(Area);

	strArea.Trim();
	if(strArea !=_T("A") && strArea !=_T("B")) 
		return FALSE;

	CString strAreaID = GetIdentity().ToCString() + strArea;
	CString strAreaURI = CL3NameParser::MergeClassDomainName(RH_AREA_CLASS_URI,strAreaID);

	LONG nTrans = 0;
	if(!IsInTrans())
	{
		nTrans = BeginTrans();
		if(nTrans < 1)
			return FALSE;
	}

	if(!PutObjectIntoTrans(GetURI()))
	{
		if(nTrans > 0) Rollback(nTrans);
		return FALSE;
	}
	if(!PutObjectIntoTrans(strAreaURI))
	{
		if(nTrans > 0) Rollback(nTrans);
		return FALSE;
	}

	// ����ˮ
	CString strHeatID = GetObjectPropValue(strAreaURI,_T("HeatID")).ToCString(); strHeatID.Trim();
	CL3Variant valSteel = InvokeObjectMethod(strAreaURI,_T("GetMaterialDetails"),_T("CSteel_Data"),_T(""));
	CL3RecordSetWrap rsSteel;
	if(FAILED(valSteel.QueryInterface(IID_IL3RecordSet,rsSteel)) || rsSteel.GetRowCount() < 1)
	{
		if(nTrans > 0) Rollback(nTrans);
		SetL3LastError(XGMES_ERR_RH_NEEDSTEEL);
		return FALSE;
	}

	// ���״̬ 2009-01-08 ����,2009-03-03 �ָ�
	if(Status != CRH_Unit_Mag::RHWaiting)
	{
		if(nTrans > 0) Rollback(nTrans);
		SetL3LastError(XGMES_ERR_RH_WRONGSTATUS);
		return FALSE;
	}

	// �޸Ĵ����
	TreatNo = NextTreatNo;
	if(TreatNo == _T(""))
		TreatNo = CalculateNextTreatNo(NULL);
	NextTreatNo = CalculateNextTreatNo(TreatNo);
	
	// ��ѯ��Ӧ���ּƻ�����
	CString strSQLPlan; strSQLPlan.Format(_T("select * from %s where HeatID = '%s'"),PLAN_TAPPING_CLASS_URI,GetRealHeatID(strHeatID));
	CL3RecordSetWrap rsPlan;
	Query(strSQLPlan,rsPlan);
	if(rsPlan.GetRowCount() > 0)
	{
		// ����¯��������ʼ�ȼ�
		rsPlan.MoveFirst();
		InvokeObjectMethod(_T("XGMESLogic\\QualityMag\\CQuality_Mag\\Quality_Mag"),_T("CreateHeatGradeQAData"),(LPCTSTR)GetName(),(L3RECORDSET)rsPlan);
	}

	COleDateTime curTime = COleDateTime::GetCurrentTime();
	ProcStartTime = curTime;
	ProcTime = (LONG)0;
	CurArea = strArea;
	csWireUnit = CurArea;//2009-04-03
	if(!SetObjectPropValue(strAreaURI,_T("TreatNo"),GetPropValue(_T("TreatNo"))))
	{
		if(nTrans > 0) Rollback(nTrans);
		return FALSE;
	}

	// ���ɻ������ݼ�¼
	CL3RecordSetWrap rsBaseData;
	if(!CreateClassPropSet(RH_BASE_DATA_CLASS_URI,rsBaseData))
	{
		if(nTrans > 0) Rollback(nTrans);
		return FALSE;
	}
	rsBaseData.AppendRecord();
	rsBaseData.CopyCurRowFrom(rsPlan);
	rsBaseData.SetFieldByName(_T("TreatNo"),GetPropValue(_T("TreatNo")));
	rsBaseData.SetFieldByName(_T("HeatID"),GetObjectPropValue(strAreaURI,_T("HeatID")));
	rsBaseData.SetFieldByName(_T("LadleNo"),GetObjectPropValue(strAreaURI,_T("LadleID")));
	CString csSteelGradeIndex = GetObjectPropValue(strAreaURI,_T("SteelGradeIndex")).ToCString();
	rsBaseData.SetFieldByName(_T("SteelGradeIndex"),CL3Variant(csSteelGradeIndex));
	rsBaseData.SetFieldByName(_T("SteelGrade"),GetObjectPropValue(QA_STG_RELATION_CLASS_URI + _T("\\") + csSteelGradeIndex,_T("SteelGrade")));//2009-01-11 tangyi
	rsBaseData.SetFieldByName(_T("ProductionDate"),CL3Variant(curTime));
	rsBaseData.SetFieldByName(_T("Locked"),CL3Variant((LONG)0));
	CL3Variant valR = InvokeObjectMethod(SHIFT_MAG_URI,_T("GetSessionShiftTeam"));
	CL3RecordSetWrap rpSysInfo;
	SUCCEEDED(valR.QueryInterface(IID_IL3RecordSet,rpSysInfo));
	rpSysInfo.MoveFirst();
	rsBaseData.SetFieldByName(_T("Shift"),rpSysInfo.GetFieldByName(_T("ShiftID")));
	rsBaseData.SetFieldByName(_T("Team"),rpSysInfo.GetFieldByName(_T("TeamID")));
	CString csObj = GetName() + rpSysInfo.GetFieldByName(_T("TeamID")).ToCString();
	CString csUri = CL3NameParser::MergeClassDomainName(UNIT_DUTY_CLASS_URI,csObj);
	rsBaseData.SetFieldByName(_T("HeatFurnace"),GetObjectPropValue(csUri,_T("HeadFurnace")));
	rsBaseData.SetFieldByName(_T("Assistant"),GetObjectPropValue(csUri,_T("Assistant")));
	rsBaseData.SetFieldByName(_T("SecondHand"),GetObjectPropValue(csUri,_T("SecondHand")));
	if(CreateNewObjects(RH_BASE_DATA_CLASS_URI,rsBaseData) < 1)
	{
		if(nTrans > 0) Rollback(nTrans);
		return FALSE;
	}

	// ���ɹ������ݼ�¼
	CL3RecordSetWrap rsProcData;
	if(!CreateClassPropSet(RH_PROCESS_DATA_CLASS_URI,rsProcData))
	{
		if(nTrans > 0) Rollback(nTrans);
		return FALSE;
	}
	rsProcData.AppendRecord();
	rsProcData.SetFieldByName(_T("TreatNo"),GetPropValue(_T("TreatNo")));
	rsProcData.SetFieldByName(_T("HeatID"),GetObjectPropValue(strAreaURI,_T("HeatID")));
	rsProcData.SetFieldByName(_T("LadleNo"),GetObjectPropValue(strAreaURI,_T("LadleID")));
	rsProcData.SetFieldByName(_T("SteelGradeIndex"),GetObjectPropValue(strAreaURI,_T("SteelGradeIndex")));
	rsProcData.SetFieldByName(_T("Steel_Weight"),GetObjectPropValue(strAreaURI,_T("Weight")));
	rsProcData.SetFieldByName(_T("Arrival_Time"),GetObjectPropValue(strAreaURI,_T("Arrive_Time")));
	rsProcData.SetFieldByName(_T("Start_Time"),CL3Variant(curTime));
	rsProcData.SetFieldByName(_T("Process_Location"),CL3Variant(strArea)); //2009-03-31
	rsProcData.SetFieldByName(_T("Slot_No"),CL3Variant(Slot_No)); //2009-03-31

	/***********�ְ�����******2009-03-31 Liao ***************/
	CString csLaldeID = GetObjectPropValue(strAreaURI,_T("LadleID")).ToCString();
	CString csLadleBaseUri;
	CString csLadleGrade;
	L3LONG lLadleAge = 0;
	if(csLaldeID.Trim() != _T(""))
	{
		csLadleBaseUri =  CL3NameParser::MergeClassDomainName(CLADLE_BASE_URI,csLaldeID);
		csLadleGrade = GetObjectPropValue(csLadleBaseUri,_T("Ladle_Grade")).ToCString();
		lLadleAge = GetObjectPropValue(csLadleBaseUri,_T("Ladle_Age")).ToLong();
	}
	rsProcData.SetFieldByName(_T("LadleGrade"),CL3Variant(csLadleGrade));
	/***********************2009-03-31 Liao ***************/

	//Modify begin by llj 2011-04-10 ���õ���ʱ��֮��ĵ�һ�β���ΪRH��վ�¶�
	
	CString csArriveTime=GetObjectPropValue(strAreaURI,_T("Arrive_Time")).ToCString();
	CString csSQL;
	if(strArea==_T("A"))
	{
		csSQL.Format(_T("select MeasureTime,Temp from CRH_Temp_Data where  MeasureTime > to_date('%s','YYYY-MM-DD HH24:MI:SS') and (MeasureMode=1 or MeasureMode=3 ) order by MeasureTime asc "),csArriveTime);
	}
	else
	{
		csSQL.Format(_T("select MeasureTime,Temp from CRH_Temp_Data where  MeasureTime > to_date('%s','YYYY-MM-DD HH24:MI:SS') and (MeasureMode=2 or MeasureMode=4 ) order by MeasureTime asc "),csArriveTime);
	}
	::L3Log(3,_T("XGMES"),csSQL);
	CL3RecordSetWrap rs;
	if(Query(csSQL,rs)&&!rs.IsNull()&&rs.GetRowCount()>0)
	{
		rs.MoveFirst();
		L3LONG lTemp=rs.GetFieldByName(_T("Temp")).ToLong();
		::L3Log(3,_T("XGMES"),_T("RH��վ�¶�:")+rs.GetFieldByName(_T("Temp")).ToCString());
		rsProcData.SetFieldByName(_T("Arrival_Temp"),CL3Variant(lTemp));

	}
	//Modify end

	// TODO : ���������Ϣ
	if(CreateNewObjects(RH_PROCESS_DATA_CLASS_URI,rsProcData) < 1)
	{
		if(nTrans > 0) Rollback(nTrans);
		return FALSE;
	}

	// �޸�״̬
	if(!ChangeStatus(CRH_Unit_Mag::RHProcBegin))
	{
		if(nTrans > 0) Rollback(nTrans);
		return FALSE;
	}

	StartProcessTime = curTime.Format(_T("%H:%M:%S"));//2008-12-26

    //���ô���ǰ�������ݵĴ����2009-03-31
    SetTreatNoForTempDataBeforeProcess(strHeatID,TreatNo);
	//���ô���ǰ������ݵĴ����2009-03-23 yao
    SetTreatNoForBlowArData(strHeatID,TreatNo);

	//�����ְ���Ϣ 2009-05-20 Liao 
	CL3RecordSetWrap rsLadleInfo;
	if(!CreateClassPropSet(RH_LADLE_INFO_CLASS_URI,rsLadleInfo))
	{
		if(nTrans > 0) Rollback(nTrans);
		return FALSE;
	}
	CString csTreatNo = GetPropValue(_T("TreatNo")).ToCString();
	CString csHeatID = GetObjectPropValue(strAreaURI,_T("HeatID")).ToCString();
	CString csLadleID = GetObjectPropValue(strAreaURI,_T("LadleID")).ToCString();

	rsLadleInfo.AppendRecord();
	rsLadleInfo.SetFieldByName(_T("TreatNo"),CL3Variant(csTreatNo));
	rsLadleInfo.SetFieldByName(_T("HeatID"),CL3Variant(csHeatID));
	rsLadleInfo.SetFieldByName(_T("LadleID"),CL3Variant(csLadleID));

	CString csCurSteelGradeIndex = GetObjectPropValue(strAreaURI,_T("SteelGradeIndex")).ToCString();
	CString csCurSteelGrade = GetObjectPropValue(_T("XGMESLogic\\QualityMag\\CQA_SteelGradeIndex_R\\") + csCurSteelGradeIndex,_T("SteelGrade")).ToCString();

	rsLadleInfo.SetFieldByName(_T("Cur_SteelGrade"),CL3Variant(csCurSteelGrade));
	
	rsLadleInfo.SetFieldByName(_T("Act_Ladle_Grade"),CL3Variant(csLadleGrade));
	rsLadleInfo.SetFieldByName(_T("In_Ladle_Grade"),CL3Variant(csLadleGrade));
	rsLadleInfo.SetFieldByName(_T("Ladle_Age"),CL3Variant(lLadleAge));


	CString csTemp;
	//CString csSQL; 
	CL3RecordSetWrap rsResult;
	if(csLadleID != _T(""))
	{
		/**********************************************20090902 liao********************************************************************/
		csTemp =  _T("SELECT stop_time_len, note			");
		csTemp += _T("  FROM cladle_use						");
		csTemp += _T(" WHERE heatid = '%s'					");
		csSQL.Format(csTemp,csHeatID);
		rsResult.DeleteAll();
		Query(csSQL,rsResult);
		if(!(rsResult.IsNull()) && rsResult.GetRowCount() > 0)
		{
			rsResult.MoveFirst();
			rsLadleInfo.SetFieldByName(_T("Stop_Time_Len"),rsResult.GetFieldByName(_T("stop_time_len")));
			rsLadleInfo.SetFieldByName(_T("Note"),rsResult.GetFieldByName(_T("note")));
		}
		/*--------------------------------------------------------------------------------------------------------------*/
		/* --�˸ְ����һ�κ濾ʱ�� - �˸ְ��ϴ�¼��ְ��ϼ�ʹ��ʱ�� */
		csTemp =  _T("SELECT fireid, ROUND ((b.input_time - a.input_time) * 24 * 60) AS minlength			");
		csTemp += _T("  FROM (SELECT input_time																");
		csTemp += _T("          FROM (SELECT   a.input_time													");
		csTemp += _T("                    FROM cladle_use a,												");
		csTemp += _T("                         (SELECT input_time, ladleid									");
		csTemp += _T("                            FROM cladle_use											");
		csTemp += _T("                           WHERE heatid = '%s') b								");
		csTemp += _T("                   WHERE a.ladleid = b.ladleid AND a.input_time < b.input_time		");
		csTemp += _T("                ORDER BY a.input_time DESC)											");
		csTemp += _T("         WHERE ROWNUM < 2) a,															");
		csTemp += _T("       (SELECT input_time, fireid														");
		csTemp += _T("          FROM (SELECT   input_time, fireid											");
		csTemp += _T("                    FROM cladle_fire													");
		csTemp += _T("                   WHERE fire_type = '2'												");
		csTemp += _T("                     AND ladleid = '%s'												");
		csTemp += _T("                ORDER BY fireid DESC)													");
		csTemp += _T("         WHERE ROWNUM < 2) b															");
		csSQL.Format(csTemp,csHeatID,csLadleID);
		rsResult.DeleteAll();
		Query(csSQL,rsResult);
		if(!(rsResult.IsNull()) && rsResult.GetRowCount() > 0)
		{
			rsResult.MoveFirst();
			/* ��ʱ�����������0 �����ʾ���ں濾 */
			//if(rsResult.GetFieldByName(_T("minlength")).ToDouble() > 0)
			//2009-09-08
			CL3Variant vsTemp = rsResult.GetFieldByName(_T("minlength"));
			L3DOUBLE nTemp = -1;
			if(!vsTemp.IsValid() || vsTemp.IsError() || vsTemp.IsNull() || vsTemp.IsEmpty())
				nTemp = 0;
			else
				nTemp=vsTemp.ToDouble();
			
			if(nTemp > 0.0000001)
			{
				CString csFireID = rsResult.GetFieldByName(_T("fireid")).ToCString();
				
				csTemp =  _T("SELECT CASE																		");
				csTemp += _T("          WHEN b.small_fire > 32678 OR b.small_fire < 0							");
				csTemp += _T("             THEN 0																");
				csTemp += _T("          ELSE b.small_fire														");
				csTemp += _T("       END AS small_fire,															");
				csTemp += _T("       CASE																		");
				csTemp += _T("          WHEN b.middle_fire > 32678 OR b.middle_fire < 0							");
				csTemp += _T("             THEN 0																");
				csTemp += _T("          ELSE b.middle_fire														");
				csTemp += _T("       END AS middle_fire,														");
				csTemp += _T("       CASE																		");
				csTemp += _T("          WHEN b.big_fire > 32678 OR b.big_fire < 0								");
				csTemp += _T("             THEN 0																");
				csTemp += _T("          ELSE b.big_fire															");
				csTemp += _T("       END AS big_fire															");
				csTemp += _T("  FROM (SELECT ROUND ((set_three_time - set_one_time) * 24 * 60)					");
				csTemp += _T("                                                                AS small_fire,	");
				csTemp += _T("               ROUND ((set_four_time - set_three_time) * 24 * 60					");
				csTemp += _T("                     ) AS middle_fire,											");
				csTemp += _T("               ROUND ((end_time - set_four_time) * 24 * 60) AS big_fire			");
				csTemp += _T("          FROM cladle_fire														");
				csTemp += _T("         WHERE fireid = '%s') b													");
																									
				csSQL.Format(csTemp,csFireID);	
				rsResult.DeleteAll();													
				Query(csSQL,rsResult);																	
				if(!(rsResult.IsNull()) && rsResult.GetRowCount() > 0)															
				{																						
					rsResult.MoveFirst();
					rsLadleInfo.SetFieldByName(_T("Small_Fire"),rsResult.GetFieldByName(_T("small_fire")));
					rsLadleInfo.SetFieldByName(_T("Middle_Fire"),rsResult.GetFieldByName(_T("middle_fire")));
					rsLadleInfo.SetFieldByName(_T("Big_Fire"),rsResult.GetFieldByName(_T("big_fire")));
				}
			}
		}
	}
    /**********************************************20090902 liao********************************************************************/
	if(lLadleAge > 1 )
	{
		CString csCCMTreatNo;
		CString csCCMHeatID;
		CString csTempTime;
		CString csCastingNo;

		csTemp =  _T("SELECT a.temptime, a.heatid, a.treatno, a.steelgrade, b.castingno				");
		csTemp += _T("  FROM (SELECT TO_CHAR (productiondate + INTERVAL '20' MINUTE,				");
		csTemp += _T("                        'yyyy-mm-dd hh24:mi:ss'								");
		csTemp += _T("                       ) AS temptime,											");
		csTemp += _T("               heatid, treatno, steelgrade									");
		csTemp += _T("          FROM (SELECT   productiondate, heatid, treatno, steelgrade			");
		csTemp += _T("                    FROM cccm_base_data										");
		csTemp += _T("                   WHERE ladleno = '%s'										");
		csTemp += _T("                ORDER BY productiondate DESC)									");
		csTemp += _T("         WHERE ROWNUM < 2) a,													");
		csTemp += _T("       cccm_process_data b													");
		csTemp += _T(" WHERE a.treatno = b.treatno													");

		csSQL.Format(csTemp,csLadleID);
		rsResult.DeleteAll();
		Query(csSQL,rsResult);
		if(!(rsResult.IsNull()) && rsResult.GetRowCount() > 0)
		{
			rsResult.MoveFirst();
			csCCMHeatID = rsResult.GetFieldByName(_T("heatid")).ToCString();
			csCCMTreatNo = rsResult.GetFieldByName(_T("treatno")).ToCString();
			csTempTime =  rsResult.GetFieldByName(_T("temptime")).ToCString();
			csCastingNo =  rsResult.GetFieldByName(_T("castingno")).ToCString();

			rsLadleInfo.SetFieldByName(_T("Last_SteelGrade"),rsResult.GetFieldByName(_T("steelgrade")));
			
			L3LONG lupTemp = 0;
			
			//���(�ϻ�)�¶�,�ϴΰ���
			csTemp =  _T("SELECT temp AS up_temp, ladletype AS ladlegrade				");
			csTemp += _T("  FROM cccm_heat_ladle										");
			csTemp += _T(" WHERE treatno = '%s'											");
			
			csSQL.Format(csTemp,csCCMTreatNo);
			rsResult.DeleteAll();
			Query(csSQL,rsResult);

			if(!(rsResult.IsNull()) && rsResult.GetRowCount() > 0)
			{
				rsResult.MoveFirst();
				lupTemp  =  rsResult.GetFieldByName(_T("up_temp")).ToLong();
				rsLadleInfo.SetFieldByName(_T("Last_Ladle_Grade"),rsResult.GetFieldByName(_T("ladlegrade")));
			}
			
			//20'�¶�
			L3LONG lMeasureTemp = 0;
			csTemp =  _T("  SELECT   Temp												 ");
			csTemp += _T("    FROM cccm_heat_tundishtemp								 ");
			csTemp += _T("   WHERE heatid = '%s' AND invalidflag <> 1					 ");
			csTemp += _T("ORDER BY ABS (  measure_time									 ");
			csTemp += _T("              - TO_DATE ('%s', 'yyyy-mm-dd hh24:mi:ss') )		 ");
			csSQL.Format(csTemp,csCCMHeatID,csTempTime);
			rsResult.DeleteAll();
			Query(csSQL,rsResult);

			if(!(rsResult.IsNull()) && rsResult.GetRowCount() > 0)
			{
				rsResult.MoveFirst();
				lMeasureTemp  =  rsResult.GetFieldByName(_T("Temp")).ToLong();
			}
			
			//20'ʱ�½�
			L3LONG lTemp = lupTemp - lMeasureTemp;

			rsLadleInfo.SetFieldByName(_T("Temp"),lTemp);

			//�а�2'�¶�[�ְ��ϴ�ʹ��������Ӧ¯�ŵ���һ¯��Ӧ��2'�¶�  ��ͬһ�����ڵ�]
			L3LONG lTwoMinMeasureTemp = 0;
			csTemp =  _T("SELECT temp											");
			csTemp += _T("  FROM (SELECT   temp									");
			csTemp += _T("            FROM cccm_tundishtemp_twominute			");
			csTemp += _T("           WHERE treatno > '%s' AND castingno = '%s'	");
			csTemp += _T("        ORDER BY treatno ASC)							");
			csTemp += _T(" WHERE ROWNUM < 2										");
			csSQL.Format(csTemp,csCCMTreatNo,csCastingNo);
			rsResult.DeleteAll();
			Query(csSQL,rsResult);
			
			if(!(rsResult.IsNull()) && rsResult.GetRowCount() > 0)
			{
				rsResult.MoveFirst();
				lTwoMinMeasureTemp  =  rsResult.GetFieldByName(_T("temp")).ToLong();
			}

			L3LONG lTwoMinTemp = 0;

			//�ϴ�ת���½�
			lTwoMinTemp = lupTemp - lTwoMinMeasureTemp;//�ϻ��¶� - 2'�¶�
			rsLadleInfo.SetFieldByName(_T("MaxTemp"),lTwoMinTemp);
		}
	}

	rsLadleInfo.MoveFirst();
	CreateNewObjects(RH_LADLE_INFO_CLASS_URI,rsLadleInfo);

	if(nTrans > 0) Commit(nTrans);
	//Modify begin by llj 2011-04-11 ���4#BOF-3#LF-1#RH����·���ĸְ��Զ�����
	CString csSqlTapping;
	csSqlTapping.Format(_T("select * from CPLAN_TAPPING where HeatID='%s'"),csHeatID);
	CL3RecordSetWrap rsTapping;
	if(Query(csSqlTapping,rsTapping)&&!rsTapping.IsNull()&&rsTapping.GetRowCount()>0)
	{
		rsTapping.MoveFirst();
		CString csBofID=rsTapping.GetFieldByName(_T("BOFID")).ToCString();
		CString csLfID=rsTapping.GetFieldByName(_T("LFID")).ToCString();
		if(csBofID==_T("S24")&&csLfID==_T("S43"))
		{
			//CString csLadleInfoUri =  CL3NameParser::MergeClassDomainName(LF_LADLE_INFO_CLASS_URI,csLaldeID);
			//csLadleGrade = GetObjectPropValue(csLadleInfoUri,_T("Ladle_Grade")).ToCString();
			CString csNewLadleGrade;
            CString csSubLadleGrade = csLadleGrade.Mid (0,1);
			
			if(csSubLadleGrade==_T("D"))
				csNewLadleGrade=_T("C2");
			if(csSubLadleGrade==_T("C"))
				csNewLadleGrade=_T("B3");
			if(csSubLadleGrade==_T("B"))
				csNewLadleGrade=_T("A2");
			L3STRING strNewLadleGrade=csNewLadleGrade.AllocSysString();
			L3STRING strTreatNo=csTreatNo.AllocSysString();
			ModifyLadleGrade(strTreatNo,strNewLadleGrade);
			L3SysFreeString(strTreatNo);
			L3SysFreeString(strNewLadleGrade);
		}
	}

	//Modify end

	// �޸ļƻ�״̬
	ChangePlanStatus(strHeatID,TreatNo,TAPPING_PLAN_RH_STATUS_BEGIN);

	//m_iTimer = SetTimer(GetURI(),PROCTIME_PERIOD);
	//��ղ۴���ʼ2009-05-15 Liao
	L3STRING RHRrea = strArea.AllocSysString();
	InvokeObjectMethod(CVACTUBE_MAG_URI + _T("\\VacTubeMag"),_T("VactubeOnLine"),RHRrea);
	L3SysFreeString(RHRrea);

	return TRUE;
}

/// <Method class="CRH_Unit_Mag" name="StopProcess" type="BOOL">
/// ��������
/// </Method>
BOOL CRH_Unit_Mag::StopProcess()
{
	LONG nTrans = 0;
	if(!IsInTrans())
	{
		nTrans = BeginTrans();
		if(nTrans < 1)
			return FALSE;
	}

	if(!PutObjectIntoTrans(GetURI()))
	{
		if(nTrans > 0) Rollback(nTrans);
		return FALSE;
	}

	// ���״̬
	if(Status >= CRH_Unit_Mag::RHProcEnd || Status <= CRH_Unit_Mag::RHWaiting)
	{
		if(nTrans > 0) Rollback(nTrans);
		SetL3LastError(XGMES_ERR_RH_WRONGSTATUS);
		return FALSE;
	}
	
	CString strArea = CurArea; strArea.Trim();
	if(strArea !=_T("A") && strArea !=_T("B"))
	{
		if(nTrans > 0) Rollback(nTrans);
		SetL3LastError(XGMES_ERR_RH_WRONGSTATUS);
		return FALSE;
	}
	CString strAreaID = GetIdentity().ToCString() + strArea;

	CString strAreaURI = CL3NameParser::MergeClassDomainName(RH_AREA_CLASS_URI,strAreaID);
	CString strHeatID = GetObjectPropValue(strAreaURI,_T("HeatID")).ToCString();
	CString strTreatNo = TreatNo;

	COleDateTime curTime = COleDateTime::GetCurrentTime();
	// ��¼����ʵ��
	CString strProcData = CL3NameParser::MergeClassDomainName(RH_PROCESS_DATA_CLASS_URI,strTreatNo);
	SetObjectPropValue(strProcData,_T("End_Time"),CL3Variant(curTime));
	//2009-04-01 begin
	COleDateTime start = GetObjectPropValue(strProcData,_T("Start_Time")).ToDateTime();
	COleDateTimeSpan span = curTime - start;
	SetObjectPropValue(strProcData,_T("Process_Time"),CL3Variant(span.GetTotalSeconds()));
	SetObjectPropValue(strProcData,_T("Probe_Vonder"),CL3Variant(Probe_Vendor));
	
	//2009-04-01 end

	// �޸�״̬
	if(!ChangeStatus(CRH_Unit_Mag::RHProcEnd))
	{
		if(nTrans > 0) Rollback(nTrans);
		return FALSE;
	}

	// �޸�״̬
	ProcStopTime = curTime;
	csWireUnit = CurArea;//2009-04-03
	csDischargeUnit = CurArea;//2009-04-03
	PrevArea = CurArea;
	CurArea = _T("");
	//TreatNo = _T("");2008-12-28�ڴ��������ɹ����쳣���룬��Ҫ����Ź�����
	ProcTime = 0;//2008-12-23 tangyi
	StartProcessTime =_T("");//2008-12-26
	//SetObjectPropValue(strAreaURI,_T("TreatNo"),CL3Variant(_T("")));2008-12-23 tangyi����

	if(!ChangeStatus(CRH_Unit_Mag::RHWaiting))
	{
		if(nTrans > 0) Rollback(nTrans);
		return FALSE;
	}

	if(nTrans > 0) Commit(nTrans);

	// �޸ļƻ�״̬
	ChangePlanStatus(strHeatID,strTreatNo,TAPPING_PLAN_RH_STATUS_END);

	L3STRING RHRrea = strArea.AllocSysString();
	InvokeObjectMethod(CVACTUBE_MAG_URI + _T("\\VacTubeMag"),_T("VactubeOffLine"),RHRrea);
	L3SysFreeString(RHRrea);
	//if(m_iTimer != 0)
	//	KillTimer(GetURI(),m_iTimer);
	//m_iTimer = 0;

	return TRUE;
}

/// <Method class="CRH_Unit_Mag" name="ChangeDeviceStatus" type="L3BOOL">
/// �޸��豸״̬
/// <Param name="nStatus" type="L3LONG">���豸״̬</Param>
/// <Param name="reason" type="L3STRING">ԭ��</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::ChangeDeviceStatus(L3LONG nStatus, L3STRING reason)
{
	LONG nTrans = 0;
	if(!IsInTrans())
	{
		nTrans = BeginTrans();
		if(nTrans < 1)
			return FALSE;
	}

	// �޸��豸״̬
	if(!SetPropValue(_T("Equip_Status"),CL3Variant(nStatus)))
	{
		if(nTrans > 0)
			Rollback(nTrans);
		return FALSE;
	}

	// ��¼�豸״̬�����־
	CL3RecordSetWrap rsLog;
	if(!CreateClassPropSet(RH_EQUIPMENT_STATUS_CLASS_URI,rsLog))
	{
		if(nTrans > 0)
			Rollback(nTrans);
		return FALSE;
	}
	rsLog.AppendRecord();
	CString cstrUnitID = (GetIdentity().ToCString()).Right(1);
	rsLog.SetFieldByName(_T("RHID"),(L3LONG)_ttoi(cstrUnitID));
	rsLog.SetFieldByName(_T("Status"),CL3Variant(nStatus));
	rsLog.SetFieldByName(_T("Log_Time"),CL3Variant(COleDateTime::GetCurrentTime()));
	rsLog.SetFieldByName(_T("Reason"),CL3Variant(reason));
	if(CreateNewObjects(RH_EQUIPMENT_STATUS_CLASS_URI,rsLog) < 1)
	{
		if(nTrans > 0)
			Rollback(nTrans);
		return FALSE;
	}

	if(nTrans > 0)
		Commit(nTrans);
	return TRUE;
}

/// <Method class="CRH_Unit_Mag" name="OnTimer" type="L3BOOL">
/// ����ʱ���¼�
/// <Param name="nEventID" type="L3ULONG">�¼�ID</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::OnTimer(L3ULONG nEventID)
{
	//if(nEventID == m_iTimer)
	//{
	//	ProcTime += PROCTIME_PERIOD;
	//}
	return TRUE;
}

/// <Method class="CRH_Unit_Mag" name="StartBlowing" type="BOOL">
/// ��������ʼ�¼�
/// <Param name="Area" type="L3STRING">��ʼ���Ĺ�λ</Param>
/// </Method>
BOOL CRH_Unit_Mag::StartBlowing(L3STRING Area)
{



	LONG nTrans = 0;
	if(!IsInTrans())
	{
		nTrans = BeginTrans();
		if(nTrans < 1)
			return FALSE;
	}

	//Modify begin by llj 2011-04-18 ��������ʼ״̬�����ڴ������֮��
	if(!PutObjectIntoTrans(GetURI()))
	{
		if(nTrans > 0) Rollback(nTrans);
		return FALSE;
	}
	CString strArea = String_BSTR2TChar(Area);
	strArea.Trim();
	if(strArea !=_T("A") && strArea !=_T("B")) 
	{
		if(nTrans > 0) Rollback(nTrans);
		return FALSE;
	}
	CString strAreaID = GetIdentity().ToCString() + strArea;
	CString strAreaURI = CL3NameParser::MergeClassDomainName(RH_AREA_CLASS_URI,strAreaID);
	

	L3LONG lStatus=GetObjectPropValue(strAreaURI,_T("Status")).ToLong();
	CString csTmp;
	csTmp.Format(_T("����ʼ ��ǰ��λΪ��%s ״̬Ϊ��%d"),strArea,lStatus);
	::L3Log(3,_T("XGMES"),csTmp);
	if(lStatus != CRH_Unit_Mag::RHProcEnd)
	{
		if(nTrans > 0) Rollback(nTrans);
		SetL3LastError(XGMES_ERR_RH_WRONGSTATUS);
		return FALSE;
	}
	//Modify end

	
	
	CString strHeatID = GetObjectPropValue(strAreaURI,_T("HeatID")).ToCString();
	CString strTreatNo = GetObjectPropValue(strAreaURI,_T("TreatNo")).ToCString();
	
	if(!strAreaURI.IsEmpty())
	{
		if(!SetObjectPropValue(strAreaURI,_T("Status"),CL3Variant((LONG)CRH_Unit_Mag::RHBlowBegin)))
		{
			if(nTrans > 0) Rollback(nTrans);
			return FALSE;
		}
	}

	// ��¼�¼���־
	CL3RecordSetWrap rsStatus;
	if(!CreateClassPropSet(RH_PROCESS_STATUS_CLASS_URI,rsStatus))
	{
		if(nTrans > 0)
			Rollback(nTrans);
		return FALSE;
	}
	rsStatus.AppendRecord();
	rsStatus.SetFieldByName(_T("TreatNo"),CL3Variant(strTreatNo));
	rsStatus.SetFieldByName(_T("HeatID"),CL3Variant(strHeatID));
	rsStatus.SetFieldByName(_T("Status"),CL3Variant((LONG)CRH_Unit_Mag::RHBlowBegin));
	rsStatus.SetFieldByName(_T("Change_Time"),CL3Variant(COleDateTime::GetCurrentTime()));
	if(CreateNewObjects(RH_PROCESS_STATUS_CLASS_URI,rsStatus) < 1)
	{
		if(nTrans > 0)
			Rollback(nTrans);
		return FALSE;
	}

	// ��¼����ʵ��
	CString strProcData = CL3NameParser::MergeClassDomainName(RH_PROCESS_DATA_CLASS_URI,strTreatNo);
	SetObjectPropValue(strProcData,_T("SoftBlow_StartTime"),CL3Variant(COleDateTime::GetCurrentTime()));

	if(nTrans > 0)
		Commit(nTrans);

	// ��ʼ��ʱ��
	// ��ʼ��ʱ��
	InvokeObjectMethod(strAreaURI,_T("SetRHAreaTimer")); // 2009-05-24 ����


	return TRUE;
}

/// <Method class="CRH_Unit_Mag" name="StopBlowing" type="L3BOOL">
/// �����������¼�
/// <Param name="Area" type="L3STRING">�������Ĺ�λ</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::StopBlowing(L3STRING Area)
{
	

	LONG nTrans = 0;
	if(!IsInTrans())
	{
		nTrans = BeginTrans();
		if(nTrans < 1)
			return FALSE;
	}

	//Modify begin by llj 2011-04-18 �����������ź�������ʼ֮��
	if(!PutObjectIntoTrans(GetURI()))
	{
		if(nTrans > 0) Rollback(nTrans);
		return FALSE;
	}

	CString strArea = String_BSTR2TChar(Area);
	strArea.Trim();
	if(strArea !=_T("A") && strArea !=_T("B"))
	{
		if(nTrans > 0) Rollback(nTrans);
		return FALSE;
	}
	CString strAreaID = GetIdentity().ToCString() + strArea;
	CString strAreaURI = CL3NameParser::MergeClassDomainName(RH_AREA_CLASS_URI,strAreaID);
	
	L3LONG lStatus=GetObjectPropValue(strAreaURI,_T("Status")).ToLong();
	CString csTmp;
	csTmp.Format(_T("�������¼� ��ǰ��λΪ��%s ״̬Ϊ��%d"),strArea,lStatus);
	::L3Log(3,_T("XGMES"),csTmp);
	if(lStatus!=  CRH_Unit_Mag::RHBlowBegin)
	{
		if(nTrans > 0) Rollback(nTrans);
		SetL3LastError(XGMES_ERR_RH_WRONGSTATUS);
		return FALSE;
	}
	//Modify end

	
	
	
	CString strHeatID = GetObjectPropValue(strAreaURI,_T("HeatID")).ToCString();
	CString strTreatNo = GetObjectPropValue(strAreaURI,_T("TreatNo")).ToCString();
	
	if(!strAreaURI.IsEmpty())
	{
		if(!SetObjectPropValue(strAreaURI,_T("Status"),CL3Variant((LONG)CRH_Unit_Mag::RHBlowEnd)))
		{
			if(nTrans > 0) Rollback(nTrans);
			return FALSE;
		}
	}

	// ��¼�¼���־
	CL3RecordSetWrap rsStatus;
	if(!CreateClassPropSet(RH_PROCESS_STATUS_CLASS_URI,rsStatus))
	{
		if(nTrans > 0)
			Rollback(nTrans);
		return FALSE;
	}
	rsStatus.AppendRecord();
	rsStatus.SetFieldByName(_T("TreatNo"),CL3Variant(strTreatNo));
	rsStatus.SetFieldByName(_T("HeatID"),CL3Variant(strHeatID));
	rsStatus.SetFieldByName(_T("Status"),CL3Variant((LONG)CRH_Unit_Mag::RHBlowEnd));
	rsStatus.SetFieldByName(_T("Change_Time"),CL3Variant(COleDateTime::GetCurrentTime()));
	if(CreateNewObjects(RH_PROCESS_STATUS_CLASS_URI,rsStatus) < 1)
	{
		if(nTrans > 0)
			Rollback(nTrans);
		return FALSE;
	}

	// ��¼����ʵ��
	COleDateTime curTime = COleDateTime::GetCurrentTime();
	CString strProcData = CL3NameParser::MergeClassDomainName(RH_PROCESS_DATA_CLASS_URI,strTreatNo);
	SetObjectPropValue(strProcData,_T("SoftBlow_EndTime"),CL3Variant(curTime));
	COleDateTime start = GetObjectPropValue(strProcData,_T("SoftBlow_StartTime")).ToDateTime();
	COleDateTimeSpan span = curTime - start;
	SetObjectPropValue(strProcData,_T("SoftBlow_Time"),CL3Variant(span.GetTotalSeconds()));
	
	if(nTrans > 0)
		Commit(nTrans);

   InvokeObjectMethod(strAreaURI,_T("KillRHAreaTimer")); //2009-05-24 ����
	

	return TRUE;
}

/// <Method class="CRH_Unit_Mag" name="SteelLeave" type="L3BOOL">
/// �����ˮ��վ�¼�
/// <Param name="Area" type="L3STRING">��վ��ˮ��λ</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::SteelLeave(L3STRING Area)
{
	CString strArea = String_BSTR2TChar(Area);
	strArea.Trim();
	if(strArea !=_T("A") && strArea !=_T("B")) 
		return FALSE;


	if(CurArea == strArea)
	{
		SetL3LastError(XGMES_ERR_RH_WRONGSTATUS);
		return FALSE;
	}

	CString strAreaID = GetIdentity().ToCString() + strArea;
	CString strAreaURI = CL3NameParser::MergeClassDomainName(RH_AREA_CLASS_URI,strAreaID);
	CString strHeatID = GetObjectPropValue(strAreaURI,_T("HeatID")).ToCString();
	CString strTreatNo = GetObjectPropValue(strAreaURI,_T("TreatNo")).ToCString();
	L3LONG iAreaStatus = GetObjectPropValue(strAreaURI,_T("Status")).ToLong();

 

	LONG nTrans = 0;
	if(!IsInTrans())
	{
		nTrans = BeginTrans();
		if(nTrans < 1)
			return FALSE;
	}

	if(!PutObjectIntoTrans(strAreaURI))
	{
		if(nTrans > 0) Rollback(nTrans);
		return FALSE;
	}
	   //2009-04-03 ״̬�ж�
	if(iAreaStatus < CRH_Unit_Mag::RHProcEnd||iAreaStatus ==CRH_Unit_Mag::RHBlowBegin)
	{
		if(nTrans > 0) Rollback(nTrans);
		SetL3LastError(XGMES_ERR_RH_WRONGSTATUS);
		return FALSE;
	}

	// ��ѯ��ˮ
	CL3Variant val = InvokeObjectMethod(strAreaURI,_T("GetMaterialDetails"),_T("CSteel_Data"),_T(""));
	CL3RecordSetWrap rsSteel;
	if(FAILED(val.QueryInterface(IID_IL3RecordSet,rsSteel)) || rsSteel.GetRowCount() < 1)
	{
		if(nTrans > 0) Rollback(nTrans);
		return FALSE;
	}
	rsSteel.AddField(_T("Area"),VT_BSTR);
	rsSteel.MoveFirst();
	rsSteel.SetFieldByName(_T("Area"),CL3Variant(strAreaURI));

	// ���ݼƻ��жϸ�ˮȥ��
	strHeatID.Trim();
	CString strPlan;
	strPlan.Format(_T("select * from %s where HeatID = '%s'"),PLAN_TAPPING_CLASS_URI,(LPCTSTR)GetRealHeatID(strHeatID));
	CL3RecordSetWrap rsPlan;
	if(!Query(strPlan,rsPlan) || rsPlan.GetRowCount() < 1)
	{
		if(nTrans > 0) Rollback(nTrans);
		SetL3LastError(XGMES_ERR_PLANNOTEXIST);
		return FALSE;
	}
	rsPlan.MoveFirst();
	CString strLFID = rsPlan.GetFieldByName(_T("LFID")).ToCString();
	CString strRHID = rsPlan.GetFieldByName(_T("RHID")).ToCString();
	CString strCCMID = rsPlan.GetFieldByName(_T("CasterID")).ToCString();
	CString strType = rsPlan.GetFieldByName(_T("Refine_Type")).ToCString();
	CString strTargetCache;
	if(strType == _T("RL"))
	{	// ȥLF¯
		strTargetCache = strLFID + _T("P01");
	}
	else
	{	// ȥ����
		strTargetCache = strCCMID + _T("P01");
		//2009-02-21 
		CString csCCMMagUri = CCM_CLASS_URI + _T("\\") + strCCMID;
		CString csRHProcessUri = RH_PROCESS_DATA_CLASS_URI + _T("\\") + strTreatNo;
		SetObjectPropValue(csRHProcessUri,_T("CCM_Ladle_Weight"),GetObjectPropValue(csCCMMagUri,_T("RemainedWeight")));

	}
	strTargetCache = CL3NameParser::MergeClassDomainName(XGINTERCACHE_URI,strTargetCache);
	// ��ˮ����
	CBSTR bstrTarget = strTargetCache;
	if(!DeliverMaterialsTo(bstrTarget.GetBuffer(TRUE),rsSteel))
	{
		if(nTrans > 0) Rollback(nTrans);
		return FALSE;
	}

	SetDepartureTemp(strTreatNo);

	if(nTrans > 0) Commit(nTrans);

	// �޸ļƻ�״̬2008-12-11 tangyi
	ChangePlanStatus(strHeatID,strTreatNo,TAPPING_PLAN_RH_STATUS_LEAVE);

	InvokeObjectMethod(strAreaURI,_T("KillRHAreaTimer")); // 2009-05-24 ����

	//��վ�ɹ�������¯ԭʼ��¼���ô洢���̷�������֮��2009-04-01 tangyi
	//CL3RecordSet *pRSData = new CL3RecordSet();
	//CL3RecordSetWrap rsOrigData; pRSData->QueryInterface(IID_IL3RecordSet,rsOrigData); pRSData->Release();
	//rsOrigData.AddField(_T("UnitID"),VT_BSTR);
	//rsOrigData.AddField(_T("HeatID"),VT_BSTR);

	//rsOrigData.AppendRecord();
	//rsOrigData.SetFieldByName(_T("HeatID"),CL3Variant(strHeatID));
	//rsOrigData.SetFieldByName(_T("UnitID"),GetIdentity());

	//CreateNewObjects(_T("XGMESLogic\\BaseDataMag\\CBase_Unit_Original_Data"),rsOrigData);

	return TRUE;
}

/// <Method class="CLF_Unit_Mag" name="SetDepartureTemp" type="L3BOOL">
/// ������վ�¶� 2009-01-02
/// <Param name="csTreatNo" type="LPCTSTR">�����</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::SetDepartureTemp(LPCTSTR csTreatNo)
{
	CString strSQL;
	strSQL.Format(_T("select * from CRH_Temp_Data where TreatNo = '%s' order by MeasureTime desc"),csTreatNo);
	CL3RecordSetWrap rs;
	if(!Query(strSQL,rs))
		return FALSE;

	int rsCount = rs.GetRowCount();
	if (rsCount < 1)
	{
		return FALSE;
	}

    CString csProcDataUri = CL3NameParser::MergeClassDomainName(RH_PROCESS_DATA_CLASS_URI,csTreatNo);
	rs.MoveFirst();
	L3LONG nTemp = rs.GetFieldByName(_T("Temp")).ToLong();
	SetObjectPropValue(csProcDataUri,_T("Departure_Temp"),(L3LONG)nTemp);//������վ�¶� 2009-01-02

	return TRUE;	
}

/// <Method class="CRH_Unit_Mag" name="ChangeSteelGradeApp" type="L3BOOL">
/// ����ĸ�
/// <Param name="Reason" type="L3STRING">ԭ��</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::ChangeSteelGradeApp(L3STRING Reason)
{
	CL3RecordSetWrap rsSteel;
	if(!CreateClassPropSet(DISPATCH_STEEL_EXE_CLASS_URI,rsSteel))
		return false;
	rsSteel.DelField(_T("GUID"));
	rsSteel.DelField(_T("Name"));
	rsSteel.AppendRecord();
	CString csTreatNo =GetPropValue(_T("TreatNo")).ToCString();
	CString csUri = CL3NameParser::MergeClassDomainName(RH_BASE_DATA_CLASS_URI,csTreatNo);
	CString csHeatID = GetObjectPropValue(csUri,_T("HeatID")).ToCString();
	CString csSteelUri =  CL3NameParser::MergeClassDomainName(MATERIAL_STEEL_URI,csHeatID);
	rsSteel.SetFieldByName(_T("HeatID"),CL3Variant(csHeatID));
	rsSteel.SetFieldByName(_T("PreHeatID"),GetObjectPropValue(csSteelUri,_T("PreHeatID")));
	rsSteel.SetFieldByName(_T("SteelGradeIndex"),GetObjectPropValue(csSteelUri,_T("SteelGradeIndex")));
	rsSteel.SetFieldByName(_T("App_Time"),CL3Variant(COleDateTime::GetCurrentTime()));
	rsSteel.SetFieldByName(_T("App_Steel_Weight"),GetObjectPropValue(csSteelUri,_T("Weight")));
	rsSteel.SetFieldByName(_T("App_Operator"),CL3Variant(GetCurrentUser()));
	rsSteel.SetFieldByName(_T("App_UnitID"),GetIdentity());
	rsSteel.SetFieldByName(_T("App_Reason"),CL3Variant(Reason));

	CString strDispMag =DISPATCH_OBJ_URI;
	CL3Variant val = InvokeObjectMethod(strDispMag,_T("SteelExchangeApp"),(L3RECORDSET)rsSteel);
	return val.ToBOOL();

}


/// <Method class="CRH_Unit_Mag" name="SteelReturnApp" type="L3BOOL">
///  ��ˮ��¯����
/// <Param name="Reason" type="L3STRING">ԭ��</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::SteelReturnApp(L3STRING Reason,L3STRING strHeatID)
{
	CString csHeatID = strHeatID;
	CL3RecordSetWrap rsSteel;
	if(!CreateClassPropSet(DISPATCH_STEEL_TURN_CLASS_URI,rsSteel))
		return false;
	rsSteel.DelField(_T("GUID"));
	rsSteel.DelField(_T("Name"));
	rsSteel.AppendRecord();
	
	CString csSteelUri =  CL3NameParser::MergeClassDomainName(MATERIAL_STEEL_URI,csHeatID);
	rsSteel.SetFieldByName(_T("HeatID"),CL3Variant(csHeatID));
	rsSteel.SetFieldByName(_T("PreHeatID"),GetObjectPropValue(csSteelUri,_T("PreHeatID")));
	rsSteel.SetFieldByName(_T("SteelGradeIndex"),GetObjectPropValue(csSteelUri,_T("SteelGradeIndex")));
	rsSteel.SetFieldByName(_T("App_Time"),CL3Variant(COleDateTime::GetCurrentTime()));
	rsSteel.SetFieldByName(_T("App_Steel_Weight"),GetObjectPropValue(csSteelUri,_T("Weight")));
	rsSteel.SetFieldByName(_T("App_Operator"),CL3Variant(GetCurrentUser()));
	rsSteel.SetFieldByName(_T("App_UnitID"),GetIdentity());
	rsSteel.SetFieldByName(_T("App_Reason"),CL3Variant(Reason));

	CString strDispMag =DISPATCH_OBJ_URI;
	CL3Variant val = InvokeObjectMethod(strDispMag,_T("SteelTurnApp"),(L3RECORDSET)rsSteel);
	return val.ToBOOL();
}


/// <Method class="CRH_Unit_Mag" name="SteelBackApp" type="L3BOOL">
///  ��ˮ��������
/// <Param name="Reason" type="L3STRING">ԭ��</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::SteelBackApp(L3STRING Reason,L3STRING strHeatID)
{
	CString csHeatID = strHeatID;
	CL3RecordSetWrap rsSteel;
	if(!CreateClassPropSet(DISPATCH_STEEL_BACK_CLASS_URI,rsSteel))
		return false;
	rsSteel.DelField(_T("GUID"));
	rsSteel.DelField(_T("Name"));
	rsSteel.AppendRecord();
	
	CString csSteelUri =  CL3NameParser::MergeClassDomainName(MATERIAL_STEEL_URI,csHeatID);
	rsSteel.SetFieldByName(_T("HeatID"),CL3Variant(csHeatID));
	rsSteel.SetFieldByName(_T("PreHeatID"),GetObjectPropValue(csSteelUri,_T("PreHeatID")));
	rsSteel.SetFieldByName(_T("SteelGradeIndex"),GetObjectPropValue(csSteelUri,_T("SteelGradeIndex")));
	rsSteel.SetFieldByName(_T("App_Time"),CL3Variant(COleDateTime::GetCurrentTime()));
	rsSteel.SetFieldByName(_T("App_Steel_Weight"),GetObjectPropValue(csSteelUri,_T("Weight")));
	rsSteel.SetFieldByName(_T("App_Operator"),CL3Variant(GetCurrentUser()));
	rsSteel.SetFieldByName(_T("App_UnitID"),GetIdentity());
	rsSteel.SetFieldByName(_T("App_Reason"),CL3Variant(Reason));

	CString strDispMag =DISPATCH_OBJ_URI;
	CL3Variant val = InvokeObjectMethod(strDispMag,_T("SteelBackApp"),(L3RECORDSET)rsSteel);
	return val.ToBOOL();
}


/// <Method class="CRH_Unit_Mag" name="AcceptMaterialDischargeData" type="L3RECORDSET">
/// �ϲּ������ݲɼ�
/// <Param name="HeatID" type="L3STRING">¯��</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::AcceptMaterialDischargeData(L3RECORDSET rsMaterialData)
{
	CL3RecordSetWrap rsData =rsMaterialData;
	if( rsData.IsNull() || rsData.GetRowCount() < 1)
		return FALSE;

	if(rsData.GetFieldIndex(_T("PLC_Address")) < 0 ||
	   rsData.GetFieldIndex(_T("Amount")) < 0 )
			return FALSE;

	CL3RecordSetWrap rsLog;
	if(!CreateClassPropSet(RH_ADDITION_DATA_CLASS_URI,rsLog))
		return FALSE;

	//�齨���ݼ��Ͻ�ԭ�Ͽ����
	CL3RecordSet *pRSAlloy = new CL3RecordSet();
	CL3RecordSetWrap rsAlloyOut; pRSAlloy->QueryInterface(IID_IL3RecordSet,rsAlloyOut); pRSAlloy->Release();
	rsAlloyOut.AddField(_T("MaterialID"),VT_BSTR);
	rsAlloyOut.AddField(_T("MaterialType"),VT_BSTR);
	rsAlloyOut.AddField(_T("Amount"),VT_R4);
	rsAlloyOut.AddField(_T("StoreAreaID"),VT_BSTR);
	rsAlloyOut.AddField(_T("Target"),VT_BSTR);
	rsAlloyOut.AddField(_T("UnitID"),VT_BSTR);
	rsAlloyOut.AddField(_T("Alloy_Code"),VT_BSTR);
	rsAlloyOut.AddField(_T("Batch_ID"),VT_BSTR);

	//�齨���ݼ���������2009-03-28 tangyi
	CL3RecordSet *pRSMaterial = new CL3RecordSet();
	CL3RecordSetWrap rsMaterial; pRSMaterial->QueryInterface(IID_IL3RecordSet,rsMaterial); pRSMaterial->Release();
	rsMaterial.AddField(_T("Batch_ID"),VT_BSTR);
	rsMaterial.AddField(_T("MaterialID"),VT_BSTR);
	rsMaterial.AddField(_T("MaterialType"),VT_R4);
	rsMaterial.AddField(_T("Element"),VT_BSTR);
	rsMaterial.AddField(_T("Weight"),VT_R8);

	
	//2009-04-02 begin
	CString cstrCurArea = CurArea;
	if (!cstrCurArea.IsEmpty())
	{
		csDischargeUnit = cstrCurArea;
	}
	else
	{
		CString cstrPrevArea = PrevArea;
		csDischargeUnit = cstrPrevArea;
	}
	//2009-04-02 end

	CString csUnitID =GetIdentity().ToCString();
	//CString csAreaID = csUnitID + CurArea;//2009-04-02
	CString csAreaID = csUnitID + csDischargeUnit;//2009-04-02
	CString csAreaURI = CL3NameParser::MergeClassDomainName(RH_AREA_CLASS_URI,csAreaID);
	CString csHeatID = GetObjectPropValue(csAreaURI,_T("HeatID")).ToCString();
	CString csTreatNo = GetObjectPropValue(csAreaURI,_T("TreatNo")).ToCString();



	rsData.MoveFirst();
	while(!rsData.IsEOF())
	{
		rsMaterial.DeleteAll();

		//ת��MES�Ͻ��ϲֺ�
		CString csPlcAddress = rsData.GetFieldByName(_T("PLC_Address")).ToCString();
		csPlcAddress.Replace(_T("."),_T("_"));
		csPlcAddress.Trim();
		if(csPlcAddress.IsEmpty())
		{
			rsData.MoveNext();
			continue;
		}
		CString csAreaUri = _T("XGMESLogic\\BaseDataMag\\CBase_Address_Bulk_Relation\\") + csPlcAddress;
		CString csArea = GetObjectPropValue(csAreaUri,_T("Area")).ToCString();
		csArea.Trim();

		//���ݺϽ��ϲֺŵõ��Ͻ�
		CString csSQL;
		CL3RecordSetWrap rs;

		CString cstrAreaUri = _T("XGMESLogic\\AlloyStoreMag\\CAlloy_Bulk_Relation\\") + csArea;//	2008-12-28 yao
		csSQL.Format(_T(" select b.Alloy_Code as Element,b.Batch_ID,a.MaterialID,a.MaterialType,a.Amount as PosWeight from MATERIALPOSITION a,CAlloy_Data b where a.Position = '%s' and a.MaterialID = b.MaterialID order by Idx"),csArea);

		if(!Query(csSQL,rs))
			return FALSE;

		rs.MoveFirst();
		L3LONG nCount = rs.GetRowCount();
		
		//�ϲ�����������
		L3DOUBLE nWeight = rsData.GetFieldByName(_T("Amount")).ToDouble();
		//������ʼ��Ϊ��������
		L3DOUBLE nRemainWeight = nWeight;

		//���Ƚ��ȳ������������������ݼ�
		for(int i=0;i< nCount;i++)
		{	
			rsMaterial.AppendRecord();
			//�������͡����ϱ��롢���κš����Ϻ�
			rsMaterial.CopyCurRowFrom(rs);
			//�õ��ϲֵ�ǰ����
			L3DOUBLE nPosWeight = rs.GetFieldByName(_T("PosWeight")).ToDouble();
			if(nWeight - nPosWeight < 0)
			{
				rsMaterial.SetFieldByName(_T("Weight"),CL3Variant(nWeight));
				nRemainWeight = 0;
				break;
			}
			rsMaterial.SetFieldByName(_T("Weight"),CL3Variant(nPosWeight));
			nWeight = nWeight - nPosWeight;
			nRemainWeight = nWeight;//�õ�����
			rs.MoveNext();
		}
		//�ϲ���û��ֵ�������ϲ�����ϲ��㹤������
		if(nRemainWeight > 0)
		{
			rsMaterial.AppendRecord();
			rsMaterial.SetFieldByName(_T("Batch_ID"),CL3Variant(_T("")));
			rsMaterial.SetFieldByName(_T("MaterialID"),CL3Variant(_T("NoMaterialID")));
			//��MES�ϲ����ݲ���ȷ������£�rs���ݿ���Ϊ�գ��ʱ�����ϲ����ֶ�Ӧ��ϵ�л�ȡ2008-12-30 tangyi
			rsMaterial.SetFieldByName(_T("MaterialType"),CL3Variant(MATERIAL_TYPE_ALLOY));
			rsMaterial.SetFieldByName(_T("Element"),GetObjectPropValue(cstrAreaUri,_T("Alloy_Code")));	
			rsMaterial.SetFieldByName(_T("Weight"),CL3Variant(nRemainWeight));
		}

		rsMaterial.MoveFirst();
		while(!rsMaterial.IsEOF())
		{
			rsLog.AppendRecord();
			rsLog.CopyCurRowFrom(rsMaterial);//���κš�����,����
			rsLog.SetFieldByName(_T("Discharge_Time"),COleDateTime::GetCurrentTime());
			rsLog.SetFieldByName(_T("Area"),CL3Variant(csArea)); //2009-01-07 yao	
			rsLog.SetFieldByName(_T("Type"),CL3Variant(L3LONG(4)));
			rsLog.SetFieldByName(_T("HeatID"),CL3Variant(csHeatID));
			rsLog.SetFieldByName(_T("TreatNo"),CL3Variant(csTreatNo));

			CString csMaterialID = rsMaterial.GetFieldByName(_T("MaterialID")).ToCString();
			csMaterialID.Trim();
			if(csMaterialID != _T("NoMaterialID"))
			{
				rsAlloyOut.AppendRecord();
				rsAlloyOut.CopyCurRowFrom(rsMaterial);
				rsAlloyOut.SetFieldByName(_T("Amount"),rsMaterial.GetFieldByName(_T("Weight")));
				rsAlloyOut.SetFieldByName(_T("StoreAreaID"),CL3Variant(csArea));
				rsAlloyOut.SetFieldByName(_T("Target"),CL3Variant(csHeatID));
				rsAlloyOut.SetFieldByName(_T("UnitID"),CL3Variant(GetIdentity().ToCString()));
				rsAlloyOut.SetFieldByName(_T("Alloy_Code"),rsMaterial.GetFieldByName(_T("Element")));
			}
	
			rsMaterial.MoveNext();
		}
		
		rsData.MoveNext();		
	}

	if(CreateNewObjects(RH_ADDITION_DATA_CLASS_URI,rsLog) < rsLog.GetRowCount())
		return FALSE;

	if(!rsAlloyOut.IsNull() && rsAlloyOut.GetRowCount() > 0)
	{
		CL3Variant vtRtn = InvokeObjectMethod(ALLOY_STORE_OBJ_URI,_T("OutputMaterials"),L3RECORDSET(rsAlloyOut));
		//if(vtRtn.IsError() || !vtRtn.ToBOOL())
		//	return FALSE;
	}

	//2009-05-22 ͬһ�����϶�����ϣ��ܹ�Ŀǰ��֧�������������ʸ�Ϊ��������
	//if(!rsAlloyOut.IsNull() && rsAlloyOut.GetRowCount() > 0)
	//{
	//	CL3RecordSetWrap rsFinalData = rsAlloyOut.CloneStruct();
	//	rsFinalData.AppendRecord();	
	//	rsFinalData.MoveFirst();
	//	rsAlloyOut.MoveFirst();
	//	while(!rsAlloyOut.IsEOF())
	//	{
	//		rsFinalData.CopyCurRowFrom(rsAlloyOut);
	//		InvokeObjectMethod(ALLOY_STORE_OBJ_URI,_T("OutputMaterials"),L3RECORDSET(rsFinalData));
	//		rsFinalData.MoveFirst();
	//		rsAlloyOut.MoveNext();
	//	}
	//}

	return TRUE;
}


/// <Method class="CRH_Unit_Mag" name="MaterialGroundDischargeData" type="L3RECORDSET">
/// ��װ�Ͻ�ɢ״������
/// <Param name="HeatID" type="L3STRING">¯��</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::MaterialGroundDischargeData(L3RECORDSET rsMaterialData)
{
	CL3RecordSetWrap rsData =rsMaterialData;
	if( rsData.IsNull() || rsData.GetRowCount() < 1)
		return FALSE;

	if(rsData.GetFieldIndex(_T("StoreAreaID")) < 0 ||
	   rsData.GetFieldIndex(_T("MaterialID")) < 0 ||
	   rsData.GetFieldIndex(_T("MaterialType")) < 0 ||
	   rsData.GetFieldIndex(_T("Batch_ID")) < 0 ||
	   rsData.GetFieldIndex(_T("Amount")) < 0 )
			return FALSE;

		CL3RecordSetWrap rsLog;
	if(!CreateClassPropSet(RH_ADDITION_DATA_CLASS_URI,rsLog))
		return NULL;

	CString csAreaID = CurArea;
	CString csAreaURI = CL3NameParser::MergeClassDomainName(RH_AREA_CLASS_URI,csAreaID);
	CString csHeatID = GetObjectPropValue(csAreaURI,_T("HeatID")).ToCString();

	//�齨���ݼ��Ͻ�ԭ�Ͽ����
	CL3RecordSet *pRSAlloy = new CL3RecordSet();
	CL3RecordSetWrap rsAlloyOut; pRSAlloy->QueryInterface(IID_IL3RecordSet,rsAlloyOut); pRSAlloy->Release();
	rsAlloyOut.AddField(_T("MaterialID"),VT_BSTR);
	rsAlloyOut.AddField(_T("MaterialType"),VT_BSTR);
	rsAlloyOut.AddField(_T("Amount"),VT_R4);
	rsAlloyOut.AddField(_T("StoreAreaID"),VT_BSTR);
	rsAlloyOut.AddField(_T("Target"),VT_BSTR);
	rsAlloyOut.AddField(_T("UnitID"),VT_BSTR);
	rsAlloyOut.AddField(_T("Alloy_Code"),VT_BSTR);
	rsAlloyOut.AddField(_T("Batch_ID"),VT_BSTR);

	//�齨���ݼ�ɢ״��ԭ�Ͽ����
	CL3RecordSet *pRSBulk = new CL3RecordSet();
	CL3RecordSetWrap rsBulkOut; pRSBulk->QueryInterface(IID_IL3RecordSet,rsBulkOut); pRSBulk->Release();
	rsBulkOut.AddField(_T("MaterialID"),VT_BSTR);
	rsBulkOut.AddField(_T("MaterialType"),VT_BSTR);
	rsBulkOut.AddField(_T("Amount"),VT_R4);
	rsBulkOut.AddField(_T("StoreAreaID"),VT_BSTR);
	rsBulkOut.AddField(_T("Target"),VT_BSTR);
	rsBulkOut.AddField(_T("UnitID"),VT_BSTR);
	rsBulkOut.AddField(_T("Bulk_Code"),VT_BSTR);
	rsBulkOut.AddField(_T("Batch_ID"),VT_BSTR);

	rsData.MoveFirst();
	while(!rsData.IsEOF())
	{
		CString csArea = rsData.GetFieldByName(_T("StoreAreaID")).ToCString();
		CString csMaterialID = rsData.GetFieldByName(_T("MaterialID")).ToCString();
		CString csMaterialType = csArea.Mid(0,3);
		rsLog.AppendRecord();
		rsLog.CopyCurRowFrom(rsData);
		rsLog.SetFieldByName(_T("Weight"),rsData.GetFieldByName(_T("Amount")));
		rsLog.SetFieldByName(_T("Discharge_Time"),COleDateTime::GetCurrentTime());
		rsLog.SetFieldByName(_T("HeatID"),CL3Variant(csHeatID));
		rsLog.SetFieldByName(_T("Area"),CL3Variant(csArea));
		if(csMaterialType == STORE_ID_ALLOY)//�Ͻ��ϲ�
		{
			rsLog.SetFieldByName(_T("Element"),rsData.GetFieldByName(_T("Alloy_Code")));	
			rsLog.SetFieldByName(_T("Type"),CL3Variant(L3LONG(4)));
			rsAlloyOut.AppendRecord();
			rsAlloyOut.CopyCurRowFrom(rsData);
			rsAlloyOut.SetFieldByName(_T("Target"),CL3Variant(csHeatID));
			rsAlloyOut.SetFieldByName(_T("UnitID"),CL3Variant(GetIdentity().ToCString()));		
		}
		else
		{
			rsLog.SetFieldByName(_T("Element"),rsData.GetFieldByName(_T("Bulk_Code")));	
			rsLog.SetFieldByName(_T("Type"),CL3Variant(L3LONG(1)));
			rsBulkOut.AppendRecord();
			rsBulkOut.CopyCurRowFrom(rsData);
			rsBulkOut.SetFieldByName(_T("Target"),CL3Variant(csHeatID));
			rsBulkOut.SetFieldByName(_T("UnitID"),CL3Variant(GetIdentity().ToCString()));
		}

		rsData.MoveNext();		
	}

	if(CreateNewObjects(RH_ADDITION_DATA_CLASS_URI,rsLog) < rsLog.GetRowCount())
		return FALSE;

	//if(!rsAlloyOut.IsNull() && rsAlloyOut.GetRowCount() > 0)
	//{
	//	CL3Variant vtRtn = InvokeObjectMethod(ALLOY_STORE_OBJ_URI,_T("OutputMaterials"),L3RECORDSET(rsAlloyOut));
	//	if(vtRtn.IsError() || !vtRtn.ToBOOL())
	//		return FALSE;
	//}
	//if(!rsBulkOut.IsNull() && rsBulkOut.GetRowCount() > 0)
	//{
	//	CL3Variant vtRtn = InvokeObjectMethod(BULK_STORE_OBJ_URI,_T("OutputMaterials"),L3RECORDSET(rsBulkOut));
	//	if(vtRtn.IsError() || !vtRtn.ToBOOL())
	//		return FALSE;
	//}

	return TRUE;
}

/// <Method class="CRH_Unit_Mag" name="AcceptRHStatus" type="L3BOOL">
/// ����RH¯����״̬���� 2009-01-06
/// <Param name="rsData" type="L3RECORDSET">״̬����</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::AcceptRHStatus(L3RECORDSET rsData)
{
	CL3RecordSetWrap rs = rsData;
	if(rs.GetRowCount() < 1)
		return TRUE;

	// ��ȡ¯��
	rs.MoveFirst();
	L3LONG RHStatus = -1;
	while (!rs.IsEOF())
	{
		RHStatus = (rs.GetFieldByName(_T("RHStatus"))).ToLong();
		CString csAreaID = rs.GetFieldByName(_T("AreaID"));
		    //2009-04-03
		if ((csAreaID != _T("A")) && (csAreaID != _T("B")))
		{
			rs.MoveNext();
			continue;
		}

		L3STRING bstrAreaID = csAreaID.AllocSysString();
		switch(RHStatus)
		{
    		case CRH_Unit_Mag::RHWaiting: //����
				SteelArrived(bstrAreaID);
			break;
			case CRH_Unit_Mag::RHProcBegin: //����ʼ
				StartProcess(bstrAreaID);
			break;
			case CRH_Unit_Mag::RHProcEnd: //�������
				StopProcess();
			break;
			case CRH_Unit_Mag::RHBlowBegin: //����ʼ
				StartBlowing(bstrAreaID);
			break;
			case CRH_Unit_Mag::RHBlowEnd:  //������
				StopBlowing(bstrAreaID);
			break;
			case CRH_Unit_Mag::RHOB: //��ǹ����
				OBStarted();
			break;
			default:
				break;
		}
        L3SysFreeString(bstrAreaID);
		rs.MoveNext();
	}
	return TRUE;	
}

/// <Method class="CRH_Unit_Mag" name="AcceptRHTempData" type="L3BOOL">
/// ����RH¯�������� 2009-01-06
/// <Param name="rsData" type="L3RECORDSET">��������</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::AcceptRHTempData(L3RECORDSET rsData)
{
	CL3RecordSetWrap rs = rsData;
	if(rs.GetRowCount() < 1)
		return TRUE;

	CL3RecordSetWrap rsTemp;
	if(!CreateClassPropSet(_T("XGMESLogic\\RHMag\\CRH_Temp_Data"),rsTemp))
	{
		return FALSE;
	}

	rsTemp.CopyFrom(rs);


	rs.MoveFirst();
	rsTemp.MoveFirst();
	while (!rsTemp.IsEOF())
	{
		//Aǹ���A��λ��վ����վ�¶ȡ�����λ�¶ȣ�Bǹ���B��λ��վ����վ�¶ȡ�����λ�¶ȣ�
		//D��ʾ��������
		CString strArea = rs.GetFieldByName(_T("AreaID")).ToCString();
	
		/*if ((strArea != _T("D")))
			strArea = CurArea;*/
		CString strAreaID = strArea.IsEmpty() ? _T("") : GetIdentity().ToCString() + strArea;
		if (strAreaID.GetLength() < 1) 
		{
			return TRUE;
		}
		CString strAreaURI = strArea.IsEmpty() ? _T("") : CL3NameParser::MergeClassDomainName(RH_AREA_CLASS_URI,strAreaID);
		L3LONG nStatus = (GetObjectPropValue(strAreaURI,_T("Status"))).ToLong();
		CString csTreatNo;//(GetObjectPropValue(strAreaURI,_T("TreatNo"))).ToCString();
		CString csHeatID;
		if (nStatus == CRH_Unit_Mag::RHWaiting)
		{
			csHeatID = (GetObjectPropValue(strAreaURI,_T("NextSteel"))).ToCString();
			csTreatNo = _T("");
		}
		else
		{
			csHeatID = (GetObjectPropValue(strAreaURI,_T("HeatID"))).ToCString();
			csTreatNo = (GetObjectPropValue(strAreaURI,_T("TreatNo"))).ToCString();
		}
		rsTemp.SetFieldByName(_T("TreatNo"),CL3Variant(csTreatNo));
		rsTemp.SetFieldByName(_T("HeatID"),CL3Variant(csHeatID));

		rsTemp.SetFieldByName(_T("MeasureTime"),CL3Variant(COleDateTime::GetCurrentTime()));
		CurTemp = rsTemp.GetFieldByName(_T("Temp")).ToLong();
		rsTemp.MoveNext();
		rs.MoveNext();
	}

	rsTemp.MoveFirst();
	if(CreateNewObjects(_T("XGMESLogic\\RHMag\\CRH_Temp_Data"),rsTemp) < rsTemp.GetRowCount())
	{
		return FALSE;
	}

	return TRUE;	
}

/// <Method class="CRH_Unit_Mag" name="AcceptRHWireData" type="L3BOOL">
/// ����RH¯ι������ 2009-01-06
/// <Param name="rsData" type="L3RECORDSET">ι������</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::AcceptRHWireData(L3RECORDSET rsData)
{
//2009-03-28 tangyi�����߼����ϲֺϽ�ɢװ�ϰ����Ƚ��ȳ���ԭ���������ϣ�
	//��PLC�ϴ�һ���������ܻ���Ϊ���εĲ�ͬ��ֳɼ�������

	CL3RecordSetWrap rsWire =rsData;
	if( rsWire.IsNull() || rsWire.GetRowCount() < 1)
		return FALSE;

	if(rsWire.GetFieldIndex(_T("WireCode")) < 0 ||
	   rsWire.GetFieldIndex(_T("Weight")) < 0 )
			return FALSE;

	CString cstrWireArea = PrevArea;
	if (cstrWireArea.IsEmpty()) //2009-04-03
	{
		return FALSE;
	}

	CL3RecordSetWrap rsLog;
	if(!CreateClassPropSet(_T("XGMESLogic\\RHMag\\CRH_Wire_Data"),rsLog))
		return FALSE;

	//�齨���ݼ��Ͻ�ԭ�Ͽ����
	CL3RecordSet *pRSAlloy = new CL3RecordSet();
	CL3RecordSetWrap rsAlloyOut; pRSAlloy->QueryInterface(IID_IL3RecordSet,rsAlloyOut); pRSAlloy->Release();
	rsAlloyOut.AddField(_T("MaterialID"),VT_BSTR);
	rsAlloyOut.AddField(_T("MaterialType"),VT_BSTR);
	rsAlloyOut.AddField(_T("Amount"),VT_R8);
	rsAlloyOut.AddField(_T("StoreAreaID"),VT_BSTR);
	rsAlloyOut.AddField(_T("Target"),VT_BSTR);
	rsAlloyOut.AddField(_T("UnitID"),VT_BSTR);
	rsAlloyOut.AddField(_T("Alloy_Code"),VT_BSTR);
	rsAlloyOut.AddField(_T("Batch_ID"),VT_BSTR);

	
	//�齨���ݼ���������2009-03-28 tangyi
	CL3RecordSet *pRSMaterial = new CL3RecordSet();
	CL3RecordSetWrap rsMaterial; pRSMaterial->QueryInterface(IID_IL3RecordSet,rsMaterial); pRSMaterial->Release();
	rsMaterial.AddField(_T("Batch_ID"),VT_BSTR);
	rsMaterial.AddField(_T("MaterialID"),VT_BSTR);
	rsMaterial.AddField(_T("MaterialType"),VT_BSTR);
	rsMaterial.AddField(_T("WireCode"),VT_BSTR);
	rsMaterial.AddField(_T("Weight"),VT_R8);//����
	rsMaterial.AddField(_T("Amount"),VT_R8);//����

	CString csUnitID =GetIdentity().ToCString();
	CString csAreaID = csUnitID + cstrWireArea;//2009-04-09
	CString csAreaURI = CL3NameParser::MergeClassDomainName(RH_AREA_CLASS_URI,csAreaID);
	CString csHeatID = GetObjectPropValue(csAreaURI,_T("HeatID")).ToCString();
	CString csTreatNo = GetObjectPropValue(csAreaURI,_T("TreatNo")).ToCString();

	SetWireTemp(csTreatNo);//2009-04-01

	rsWire.MoveFirst();
	while(!rsWire.IsEOF())
	{
		rsMaterial.DeleteAll();
		//ת��MES�Ͻ��ϲֺ�
		CString csPlcAddress = rsWire.GetFieldByName(_T("WireCode")).ToCString();
		csPlcAddress.Replace(_T("."),_T("_"));
		csPlcAddress.Trim();
		if(csPlcAddress.IsEmpty())
		{
			rsWire.MoveNext();
			continue;
		}
		CString csAreaUri = _T("XGMESLogic\\BaseDataMag\\CBase_Address_Bulk_Relation\\") + csPlcAddress;
		CString csWireArea = GetObjectPropValue(csAreaUri,_T("Area")).ToCString();
		csWireArea.Trim();

		//2009-04-14 tangyiι˿ʵ����Ϊ�Ӵ�װ�Ͻ�ѷŴ����⣬ι˿������Ϊ�ϲֹ���
		//����PLC��ַ�õ�ι˿��λ������ι˿��λ�õ����֣����������ֵõ���װ�Ͻ��ϲ�
		//��3������װ�Ͻ𴦳�
		CString cstrAreaUri = _T("XGMESLogic\\AlloyStoreMag\\CAlloy_Bulk_Relation\\") + csWireArea;
		CString csAlloyCode = GetObjectPropValue(cstrAreaUri,_T("Alloy_Code")).ToCString();
		//ת��Ϊ����2009-04-30
		CString csWrieStdUri = _T("XGMESLogic\\BaseDataMag\\CBase_Wire_Coefficient\\")+csAlloyCode;
		L3DOUBLE fCoefficient = 1;
		CL3Variant ValTemp = GetObjectPropValue(csWrieStdUri,_T("Coefficient"));
		if(!ValTemp.IsEmpty() && !ValTemp.IsError() && ValTemp.IsValid() && !ValTemp.IsNull())
			fCoefficient = ValTemp.ToDouble();

		L3DOUBLE fWeight = rsWire.GetFieldByName(_T("Weight")).ToDouble();//����

		//�ϲ�����������
		L3DOUBLE nWeight = 	fWeight * fCoefficient;

		CString csArea;
		CString csTempSQL;
		CString csSQL;

		csTempSQL = _T(" select Alloy_Area from CAlloy_Bulk_Relation  where Alloy_Code = '%s' and Name ='3' ");
		CL3RecordSetWrap rsResult;

		csSQL.Format(csTempSQL,csAlloyCode);
		if(!Query(csSQL,rsResult))
			return FALSE;

		rsResult.MoveFirst();
		csArea = rsResult.GetFieldByIndex(0).ToCString();

		//���ݺϽ��ϲֺŵõ��Ͻ�
		CL3RecordSetWrap rs;
		csSQL.Format(_T(" select b.Alloy_Code as WireCode,b.Batch_ID,a.MaterialID,a.MaterialType,a.Amount as PosWeight from MATERIALPOSITION a,CAlloy_Data b where a.Position = '%s' and a.MaterialID = b.MaterialID order by Idx "),csArea);

		if(!Query(csSQL,rs))
			return FALSE;

		rs.MoveFirst();
		L3LONG nCount = rs.GetRowCount();
		

		//������ʼ��Ϊ��������
		L3DOUBLE nRemainWeight = nWeight;

		//���Ƚ��ȳ������������������ݼ�
		for(int i=0;i< nCount;i++)
		{	
			rsMaterial.AppendRecord();
			//�������͡����ϱ��롢���κš����Ϻ�
			rsMaterial.CopyCurRowFrom(rs);
			//�õ��ϲֵ�ǰ���� 
			L3DOUBLE nPosWeight = rs.GetFieldByName(_T("PosWeight")).ToDouble();
			if(nWeight - nPosWeight < 0)
			{
				rsMaterial.SetFieldByName(_T("Amount"),CL3Variant(nWeight));
				rsMaterial.SetFieldByName(_T("Weight"),CL3Variant(nWeight/fCoefficient));//����
				nRemainWeight = 0;
				break;
			}
			rsMaterial.SetFieldByName(_T("Amount"),CL3Variant(nPosWeight));
			rsMaterial.SetFieldByName(_T("Weight"),CL3Variant(nPosWeight/fCoefficient));
			nWeight = nWeight - nPosWeight;
			nRemainWeight = nWeight;//�õ�����
			rs.MoveNext();
		}

		//�ϲ���û��ֵ�������ϲ�����ϲ��㹤������
		if(nRemainWeight > 0)
		{
			rsMaterial.AppendRecord();
			rsMaterial.SetFieldByName(_T("Batch_ID"),CL3Variant(_T("")));
			rsMaterial.SetFieldByName(_T("MaterialID"),CL3Variant(_T("NoMaterialID")));
			//��MES�ϲ����ݲ���ȷ������£�rs���ݿ���Ϊ�գ��ʱ�����ϲ����ֶ�Ӧ��ϵ�л�ȡ2008-12-30 tangyi
			rsMaterial.SetFieldByName(_T("MaterialType"),CL3Variant(MATERIAL_TYPE_ALLOY));
			rsMaterial.SetFieldByName(_T("WireCode"),CL3Variant(csAlloyCode));	
			rsMaterial.SetFieldByName(_T("Amount"),CL3Variant(nRemainWeight));
			rsMaterial.SetFieldByName(_T("Weight"),CL3Variant(nRemainWeight/fCoefficient));
		}

		rsMaterial.MoveFirst();		
		while(!rsMaterial.IsEOF())
		{
			rsLog.AppendRecord();
			rsLog.CopyCurRowFrom(rsMaterial);//���κš�����,���롢����
			rsLog.SetFieldByName(_T("Speed"),rsWire.GetFieldByName(_T("Speed")));	
			rsLog.SetFieldByName(_T("WireTime"),COleDateTime::GetCurrentTime());
			rsLog.SetFieldByName(_T("HeatID"),CL3Variant(csHeatID));
			rsLog.SetFieldByName(_T("TreatNo"),CL3Variant(csTreatNo));//2009-01-11 tangyi
			rsLog.SetFieldByName(_T("Vendor"),GetObjectPropValue(cstrAreaUri,_T("Alloy_Vendor")));	

			CString csMaterialID = rsMaterial.GetFieldByName(_T("MaterialID")).ToCString();
			csMaterialID.Trim();
			if(csMaterialID != _T("NoMaterialID"))
			{
				rsAlloyOut.AppendRecord();
				rsAlloyOut.CopyCurRowFrom(rsMaterial);//�������͡����Ϻš����������κ�
				rsAlloyOut.SetFieldByName(_T("StoreAreaID"),CL3Variant(csArea));
				rsAlloyOut.SetFieldByName(_T("Target"),CL3Variant(csHeatID));
				rsAlloyOut.SetFieldByName(_T("UnitID"),CL3Variant(GetIdentity().ToCString()));	
				rsAlloyOut.SetFieldByName(_T("Alloy_Code"),rsMaterial.GetFieldByName(_T("WireCode")));
			}

			rsMaterial.MoveNext();
		}
		
		rsWire.MoveNext();		
	}

	if(CreateNewObjects(_T("XGMESLogic\\RHMag\\CRH_Wire_Data"),rsLog) < rsLog.GetRowCount())
		return FALSE;

    if(!rsAlloyOut.IsNull() && rsAlloyOut.GetRowCount() > 0)
	{
		CL3Variant vtRtn = InvokeObjectMethod(ALLOY_STORE_OBJ_URI,_T("OutputMaterials"),L3RECORDSET(rsAlloyOut));
	} 

	//2009-05-22 ͬһ�����϶�����ϣ��ܹ�Ŀǰ��֧�������������ʸ�Ϊ��������
	/*if(!rsAlloyOut.IsNull() && rsAlloyOut.GetRowCount() > 0)
	{
		CL3RecordSetWrap rsFinalData = rsAlloyOut.CloneStruct();
		rsFinalData.AppendRecord();	
		rsFinalData.MoveFirst();
		rsAlloyOut.MoveFirst();
		while(!rsAlloyOut.IsEOF())
		{
			rsFinalData.CopyCurRowFrom(rsAlloyOut);
			InvokeObjectMethod(ALLOY_STORE_OBJ_URI,_T("OutputMaterials"),L3RECORDSET(rsFinalData));
			rsFinalData.MoveFirst();
			rsAlloyOut.MoveNext();
		}
	}*/

	return TRUE;
}

/// <Method class="CRH_Unit_Mag" name="AcceptRHOxygenData" type="L3BOOL">
/// ����RH¯�������� 2009-01-06
/// <Param name="rsData" type="L3RECORDSET">��������</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::AcceptRHOxygenData(L3RECORDSET rsData)
{
	CL3RecordSetWrap rs = rsData;
	if(rs.GetRowCount() < 1)
		return TRUE;

	CL3RecordSetWrap rsOxygen;
	if(!CreateClassPropSet(_T("XGMESLogic\\RHMag\\CRH_Oxygen_Data"),rsOxygen))
	{
		return FALSE;
	}

	rsOxygen.CopyFrom(rs);
	rs.MoveFirst();
	rsOxygen.MoveFirst();
	while (!rsOxygen.IsEOF())
	{
		/*CString strArea = CurArea;
		strArea.Trim();
		if(strArea.IsEmpty())
			return FALSE;
		CString strAreaID = strArea.IsEmpty() ? _T("") : GetIdentity().ToCString() + strArea;
		CString strAreaURI = strArea.IsEmpty() ? _T("") : CL3NameParser::MergeClassDomainName(RH_AREA_CLASS_URI,strAreaID);
		CString csHeatID = (GetObjectPropValue(strAreaURI,_T("HeatID"))).ToCString();
		rsOxygen.SetFieldByName(_T("TreatNo"),CL3Variant(TreatNo));
		rsOxygen.SetFieldByName(_T("HeatID"),CL3Variant(csHeatID));
		rsOxygen.SetFieldByName(_T("MeasureTime"),CL3Variant(COleDateTime::GetCurrentTime()));
		rsOxygen.MoveNext();*/
		CString strArea = rs.GetFieldByName(_T("AreaID")).ToCString();
		CString strAreaID = strArea.IsEmpty() ? _T("") : GetIdentity().ToCString() + strArea;
		if (strAreaID.GetLength() < 1) 
		{
			return TRUE;
		}
		CString strAreaURI = strArea.IsEmpty() ? _T("") : CL3NameParser::MergeClassDomainName(RH_AREA_CLASS_URI,strAreaID);
		L3LONG nStatus = (GetObjectPropValue(strAreaURI,_T("Status"))).ToLong();
		CString csTreatNo;// (GetObjectPropValue(strAreaURI,_T("TreatNo"))).ToCString();
		CString csHeatID;
		if (nStatus == CRH_Unit_Mag::RHWaiting)
		{
			csHeatID = (GetObjectPropValue(strAreaURI,_T("NextSteel"))).ToCString();
			csTreatNo = _T("");
		}
		else
		{
			csHeatID = (GetObjectPropValue(strAreaURI,_T("HeatID"))).ToCString();
			csTreatNo = (GetObjectPropValue(strAreaURI,_T("TreatNo"))).ToCString();
		}
		rsOxygen.SetFieldByName(_T("TreatNo"),CL3Variant(csTreatNo));
		rsOxygen.SetFieldByName(_T("HeatID"),CL3Variant(csHeatID));
		rsOxygen.SetFieldByName(_T("MeasureTime"),CL3Variant(COleDateTime::GetCurrentTime()));

		rsOxygen.MoveNext();
	}

	rsOxygen.MoveFirst();
	if(CreateNewObjects(_T("XGMESLogic\\RHMag\\CRH_Oxygen_Data"),rsOxygen) < rsOxygen.GetRowCount())
	{
		return FALSE;
	}

	return TRUE;	
}

/// <Method class="CRH_Unit_Mag" name="AcceptRHProcessData" type="L3BOOL">
/// ����RH¯��ҵ���� 2009-01-06
/// <Param name="rsData" type="L3RECORDSET">ι������</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::AcceptRHProcessData(L3RECORDSET rsData)
{
	CL3RecordSetWrap rs = rsData;
	if(rs.GetRowCount() < 1)
		return TRUE;

	//�齨���ݼ�
	CL3RecordSet *pRS = new CL3RecordSet();
	CL3RecordSetWrap rstemp; pRS->QueryInterface(IID_IL3RecordSet,rstemp); pRS->Release();
	rstemp.AddField(_T("Process_Mode"),VT_INT);
	rstemp.AddField(_T("Loop_Time"),VT_INT);
	rstemp.AddField(_T("Vac_Min"),VT_R8);
	rstemp.AddField(_T("OB_Count"),VT_INT);
	rstemp.AddField(_T("O2_CONS"),VT_R8);
	rstemp.AddField(_T("OB_Cycle_Time"),VT_INT);
	//add by hyh 2012-08-01 �����û�Ҫ������ȫ��ʹ��ʱ��
	rstemp.AddField(_T("WholePump_Time"),VT_INT);
	//end

	//rstemp.AddField(_T("TreatNo"),VT_BSTR);

	
	rstemp.AppendRecord();

	rs.MoveFirst();
	CString csAreaID = rs.GetFieldByName(_T("AreaID")).ToCString();
    //2009-04-03
	if ((csAreaID != _T("A")) && (csAreaID != _T("B")))
	{
		return TRUE;
	}

	CString strArea = csAreaID;
	CString strAreaID = strArea.IsEmpty() ? _T("") : GetIdentity().ToCString() + strArea;
	CString strAreaURI = strArea.IsEmpty() ? _T("") : CL3NameParser::MergeClassDomainName(RH_AREA_CLASS_URI,strAreaID);
	if(!strAreaURI.IsEmpty())
	{
		CString csTreatNo = (GetObjectPropValue(strAreaURI,_T("TreatNo"))).ToCString();
		if (csTreatNo.GetLength() < 1)
			return TRUE;
		rstemp.SetFieldByName(_T("Loop_Time"),rs.GetFieldByName(_T("Loop_Time")));
		L3FLOAT fVacMin = rs.GetFieldByName(_T("Vac_Min")).ToFloat();
		L3SHORT nMode = -1;
		if (fVacMin < 0.5)
			nMode = 1;
		else
			nMode = 2;
		rstemp.SetFieldByName(_T("Process_Mode"),CL3Variant((L3SHORT)nMode));
		rstemp.SetFieldByName(_T("Vac_Min"),CL3Variant((L3FLOAT)fVacMin));
		rstemp.SetFieldByName(_T("OB_Count"),rs.GetFieldByName(_T("OB_Count")));
		rstemp.SetFieldByName(_T("O2_CONS"),rs.GetFieldByName(_T("O2_CONS")));
		rstemp.SetFieldByName(_T("OB_Cycle_Time"),rs.GetFieldByName(_T("OB_Cycle_Time")));
		rstemp.SetFieldByName(_T("WholePump_Time"),rs.GetFieldByName(_T("WholePumpTime")));//add by hyh 2012-08-01 �����û�Ҫ������ȫ��ʹ��ʱ��

		SetObjPropValues(_T("XGMESLogic\\RHMag\\CRH_Process_Data\\")+csTreatNo,rstemp);

	}


	return TRUE;	
}

/// <Method class="CRH_Unit_Mag" name="AcceptRHVacTime" type="L3BOOL">
/// ����RH¯��ն�ʱ�� 2009-02-11
/// <Param name="rsData" type="L3RECORDSET">ι������</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::AcceptRHVacTime(L3RECORDSET rsData)
{
	CL3RecordSetWrap rs = rsData;
	if(rs.GetRowCount() < 1)
		return TRUE;

	rs.MoveFirst();
	CString csTreatNo = TreatNo;
	if (csTreatNo.GetLength() < 1)
		return TRUE;

	L3LONG lDownToTime = rs.GetFieldByName(_T("DownToTime")).ToLong();
	L3SHORT iStatus = rs.GetFieldByName(_T("Status")).ToShort();
	switch(iStatus)
	{
		case 1: //����35KPa
			SetObjectPropValue(_T("XGMESLogic\\RHMag\\CRH_Process_Data\\")+csTreatNo,_T("VacDownTo35000_Time"),(L3LONG)lDownToTime);
		break;
		case 2: //����11.5KPa
			SetObjectPropValue(_T("XGMESLogic\\RHMag\\CRH_Process_Data\\")+csTreatNo,_T("VacDownTo11500_Time"),(L3LONG)lDownToTime);
		break;
		case 3: //����2.5KPa
			SetObjectPropValue(_T("XGMESLogic\\RHMag\\CRH_Process_Data\\")+csTreatNo,_T("VacDownTo2500_Time"),(L3LONG)lDownToTime);
		break;
		case 4: //����0.5KPa
			SetObjectPropValue(_T("XGMESLogic\\RHMag\\CRH_Process_Data\\")+csTreatNo,_T("VacDownTo500_Time"),(L3LONG)lDownToTime);
		break;
		default:
			break;
	}
	return TRUE;	
}

/// <Method class="CBOF_Unit_Mag" name="SteelReturn" type="L3BOOL">
///  ��ȡ���¯�� 2009-02-28 ����¯��
/// <Param name="Reason" type="L3STRING">ԭ��</Param>
/// </Method>
L3RECORDSET CRH_Unit_Mag::GetPreThreeHeatID()
{
	CString csUnitID = GetIdentity().ToCString();
	CString csRHID = csUnitID.Mid(2,1);
	CString csTempSQL =_T("select * from (select HeatID from CRH_Base_Data where substr(TreatNo,1,1) = '%s'  order by  ProductionDate desc) where rownum < 5");
	CString csSQL;
	csSQL.Format(csTempSQL,csRHID);
	CL3RecordSetWrap rs;
	if(!Query(csSQL,rs))
		return NULL;
	return rs.Detach();	
}

/// <Method class="CRH_Unit_Mag" name="AcceptRHBlowArData" type="L3BOOL">
/// ����RH¯����������� 2009-03-23
/// <Param name="rsData" type="L3RECORDSET">�����������</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::AcceptRHBlowArData(L3RECORDSET rsData)
{
	CL3RecordSetWrap rs = rsData;
	if(rs.GetRowCount() < 1)
		return TRUE;

	CL3RecordSetWrap rsBlowAr;
	if(!CreateClassPropSet(_T("XGMESLogic\\RHMag\\CRH_BlowAr_Data"),rsBlowAr))
	{
		return FALSE;
	}

	rsBlowAr.CopyFrom(rs);

	rsBlowAr.MoveFirst();
	rs.MoveFirst();
	while (!rsBlowAr.IsEOF())
	{
		CString strArea = rs.GetFieldByName(_T("AreaID")).ToCString();
		strArea.Trim();
		if(strArea.IsEmpty())
		{
			rsBlowAr.MoveNext();
			rs.MoveNext();
			continue;
		}

		if ((strArea != _T("A")) && (strArea != _T("B")))
		{
			rsBlowAr.MoveNext();
			rs.MoveNext();
			continue;
		}

		CString strAreaID = strArea.IsEmpty() ? _T("") : GetIdentity().ToCString() + strArea;
		CString strAreaURI = strArea.IsEmpty() ? _T("") : CL3NameParser::MergeClassDomainName(RH_AREA_CLASS_URI,strAreaID);
		CString csHeatID = (GetObjectPropValue(strAreaURI,_T("HeatID"))).ToCString();
		CString csTreatNo = (GetObjectPropValue(strAreaURI,_T("TreatNo"))).ToCString();
		rsBlowAr.SetFieldByName(_T("TreatNo"),CL3Variant(csTreatNo));
		rsBlowAr.SetFieldByName(_T("HeatID"),CL3Variant(csHeatID));
		rsBlowAr.SetFieldByName(_T("LogTime"),CL3Variant(COleDateTime::GetCurrentTime()));

		rsBlowAr.MoveNext();
		rs.MoveNext();
	}

	rsBlowAr.MoveFirst();
	if(CreateNewObjects(_T("XGMESLogic\\RHMag\\CRH_BlowAr_Data"),rsBlowAr) < rsBlowAr.GetRowCount())
	{
		return FALSE;
	}

	return TRUE;	
}

/// <Method class="CRH_Unit_Mag" name="SetTreatNoForBlowArData" type="L3BOOL">
/// �Դ���ʼǰ����������ô���������� 2009-03-23
/// <Param name="csHeatID" type="LPCTSTR">¯��</Param>
/// <Param name="csTreatNo" type="LPCTSTR">�����</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::SetTreatNoForBlowArData(LPCTSTR csHeatID,LPCTSTR csTreatNo)
{
	CString strSQL;
	strSQL.Format(_T("select * from CRH_BlowAr_Data where HeatID = '%s' order by LogTime"),csHeatID);
	CL3RecordSetWrap rs;
	if(!Query(strSQL,rs))
		return FALSE;

	int rsCount = rs.GetRowCount();
	if (rsCount < 1)
	{
		return FALSE;
	}

	rs.MoveFirst();
	while (!rs.IsEOF())
	{
		CString csGUID = rs.GetFieldByName(_T("GUID")).ToCString();
        CString csTempDataUri = CL3NameParser::MergeClassDomainName(_T("XGMESLogic\\RHMag\\CRH_BlowAr_Data"),csGUID);
		SetObjectPropValue(csTempDataUri,_T("TreatNo"),CL3Variant(csTreatNo));
		rs.MoveNext();
	}

	return TRUE;	
}

/// <Method class="CRH_Unit_Mag" name="ModifyLadleGrade" type="L3LONG">
/// �޸İ���//2009-03-30 Liao
/// <Param name="strTreatNo" type="L3STRING">�����</Param>
/// <Param name="strLadleGrade" type="L3STRING">����</Param>
/// </Method>
L3LONG CRH_Unit_Mag::ModifyLadleGrade(L3STRING strTreatNo, L3STRING strLadleGrade)
{
	// TODO : ���ڴ�����߼�����
	CString csTreatNo = strTreatNo;
	CString csLadleGrade = strLadleGrade;
	if(csTreatNo == _T("") || csLadleGrade == _T(""))
		return -1;//����Ż����Ϊ��

	BOOL bUseTrans = !IsInTrans();
	LONG nTrans = 0;
	if(bUseTrans)
	{
		nTrans = BeginTrans();
		if(nTrans < 1)
			return 0;
	}
	
	CString csProcessUri = RH_PROCESS_DATA_CLASS_URI + _T("\\") + csTreatNo;
	if(!SetObjectPropValue(csProcessUri,_T("LadleGrade"),CL3Variant(strLadleGrade)))
	{
		if(bUseTrans)
			Rollback(nTrans);
		return -2;//�޸ľ���ʵ���ְ�����ʧ��
	}

	CString csLadleInfoUri = RH_LADLE_INFO_CLASS_URI + _T("\\") + csTreatNo;
	SetObjectPropValue(csLadleInfoUri,_T("Act_Ladle_Grade"),CL3Variant(strLadleGrade));

	CString csLadleID = GetObjectPropValue(csProcessUri,_T("LadleNo")).ToCString();//�ְ���
	csLadleID.Trim();
	if(!(csLadleID.IsEmpty()))
	{
		CString csLadleBaseUri = CLADLE_BASE_URI + _T("\\") + csLadleID;
		SetObjectPropValue(csLadleBaseUri,_T("Ladle_Grade"),CL3Variant(strLadleGrade));
	}
	
	if(bUseTrans)
		Commit(nTrans);
	return 1;
}

/// <Method class="CRH_Unit_Mag" name="SetTreatNoForTempDataBeforeProcess" type="L3BOOL">
/// �Դ���ʼǰ�������ô���������� 2008-12-30
/// <Param name="csHeatID" type="LPCTSTR">¯��</Param>
/// <Param name="csTreatNo" type="LPCTSTR">�����</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::SetTreatNoForTempDataBeforeProcess(LPCTSTR csHeatID,LPCTSTR csTreatNo)
{
	CString strSQL;
	strSQL.Format(_T("select * from CRH_Temp_Data where HeatID = '%s' order by MeasureTime"),csHeatID);
	CL3RecordSetWrap rs;
	if(!Query(strSQL,rs))
		return FALSE;

	int rsCount = rs.GetRowCount();
	if (rsCount < 1)
	{
		return FALSE;
	}

    CString csProcDataUri = CL3NameParser::MergeClassDomainName(RH_PROCESS_DATA_CLASS_URI,csTreatNo);
	rs.MoveFirst();
	while (!rs.IsEOF())
	{
		L3LONG nTemp = rs.GetFieldByName(_T("Temp")).ToLong();
		CString csGUID = rs.GetFieldByName(_T("GUID")).ToCString();
        CString csTempDataUri = CL3NameParser::MergeClassDomainName(RH_TEMP_DATA_CLASS_URI,csGUID);
		SetObjectPropValue(csTempDataUri,_T("TreatNo"),CL3Variant(csTreatNo));
		SetObjectPropValue(csProcDataUri,_T("Arrival_Temp"),(L3LONG)nTemp);//���ý�վ�¶� 2009-1-2
		rs.MoveNext();
	}

	return TRUE;	
}

/// <Method class="CRH_Unit_Mag" name="SetWireTemp" type="L3BOOL">
/// ���øƴ�������¶� 2009-04-01
/// <Param name="csTreatNo" type="LPCTSTR">�����</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::SetWireTemp(LPCTSTR csTreatNo)
{
	CString strSQL;
	strSQL.Format(_T("select * from CRH_Temp_Data where TreatNo = '%s' order by MeasureTime desc"),csTreatNo);
	CL3RecordSetWrap rs;
	if(!Query(strSQL,rs))
		return FALSE;

	int rsCount = rs.GetRowCount();
	if (rsCount < 1)
	{
		return FALSE;
	}

    CString csProcDataUri = CL3NameParser::MergeClassDomainName(RH_PROCESS_DATA_CLASS_URI,csTreatNo);
	rs.MoveFirst();
	L3LONG nTemp = rs.GetFieldByName(_T("Temp")).ToLong();
	SetObjectPropValue(csProcDataUri,_T("Wire_End_Temp"),(L3LONG)nTemp);//���øƴ�������¶� 2009-04-01
	SetObjectPropValue(csProcDataUri,_T("Wire_End_Time"),CL3Variant(COleDateTime::GetCurrentTime()));//���øƴ������ʱ�� 2009-05-25

	return TRUE;	
}

/// <Method class="CRH_Unit_Mag" name="SetWeight" type="L3BOOL">
/// ��������źš�
/// <Param name="fWeight" type="L3DOUBLE">����</Param>
/// <Param name="strHeatID" type="L3STRING">¯��</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::SetWeight(L3DOUBLE fWeight,L3STRING strHeatID)
{
	if (strHeatID == NULL)
	{
		return FALSE;
	}

	CString csHeatID = strHeatID;
	LONG nTrans = 0;
	if(!IsInTrans())
	{
		nTrans = BeginTrans();
		if(nTrans < 1)
			return FALSE;
	}

	if(!PutObjectIntoTrans(GetURI()))
	{
		if(nTrans > 0) Rollback(nTrans);
		return FALSE;
	}

	CString strSteel = csHeatID;
	strSteel.Trim();
	if(strSteel.IsEmpty())
	{
		if(nTrans > 0) Rollback(nTrans);
		return FALSE;
	}

	CString strURI = CL3NameParser::MergeClassDomainName(MATERIAL_STEEL_URI,strSteel);
	if(!SetObjectPropValue(strURI,_T("Weight"),CL3Variant(fWeight)))
	{
		if(nTrans > 0) Rollback(nTrans);
		return FALSE;
	}

	CString strProcData = CL3NameParser::MergeClassDomainName(BOF_PROCESS_DATA_CLASS_URI,strSteel);
	if(!SetObjectPropValue(strProcData,_T("Tapping_Weight"),CL3Variant(fWeight)))
	{
		if(nTrans > 0) Rollback(nTrans);
		return FALSE;
	}

	if(nTrans > 0) Commit(nTrans);

	return TRUE;
}

/// <Method class="CRH_Unit_Mag" name="SetTreatNoForBlowArData" type="L3BOOL">
/// ���գңȶ�ǹ����״̬���� 2009-07-03
/// <Param name="csHeatID" type="LPCTSTR">¯��</Param>
/// <Param name="csTreatNo" type="LPCTSTR">�����</Param>
/// </Method>
L3BOOL CRH_Unit_Mag::AcceptBlowO2StatusData(L3RECORDSET rsData)
{
	CL3RecordSetWrap rs = rsData;
	if(rs.GetRowCount() < 1 || rs.IsNull())
		return FALSE;

	CL3RecordSetWrap rsBlowO2;
	if(!CreateClassPropSet(_T("XGMESLogic\\RHMag\\CRH_BlowO_Status_Data"),rsBlowO2))
	{
		return FALSE;
	}

	rs.MoveFirst();
	while(!rs.IsEOF())
	{
		CString strArea = rs.GetFieldByName(_T("AreaID")).ToCString();
		strArea.Trim();
		if ((strArea != _T("A")) && (strArea != _T("B")))
		{
			rs.MoveNext();
			continue;
		}
		rsBlowO2.AppendRecord();
		CString strAreaID = GetIdentity().ToCString() + strArea;
		CString strAreaURI = CL3NameParser::MergeClassDomainName(RH_AREA_CLASS_URI,strAreaID);
		CString csHeatID = (GetObjectPropValue(strAreaURI,_T("HeatID"))).ToCString();
		CString csTreatNo = (GetObjectPropValue(strAreaURI,_T("TreatNo"))).ToCString();
		rsBlowO2.SetFieldByName(_T("TreatNo"),CL3Variant(csTreatNo));
		rsBlowO2.SetFieldByName(_T("HeatID"),CL3Variant(csHeatID));
		rsBlowO2.SetFieldByName(_T("MeasureTime"),CL3Variant(COleDateTime::GetCurrentTime()));
		rsBlowO2.SetFieldByName(_T("Status"),rs.GetFieldByName(_T("Status")));
		rs.MoveNext();
	}

	rsBlowO2.MoveFirst();
	if(CreateNewObjects(_T("XGMESLogic\\RHMag\\CRH_BlowO_Status_Data"),rsBlowO2) < rsBlowO2.GetRowCount())
		return FALSE;

	return TRUE;

}

//Modify begin by llj 2011-04-10 �������¯�ε�Ԫ�ر�ֵ
/// <Method class="CRH_Unit_Mag" name="CalEleRateValue" type="L3LONG">
/// ���������������ֵ
/// <Param name="strHeatID" type="L3STRING">¯�κ�</Param>
/// <Param name="strEleName1" type="L3STRING">Ԫ��1</Param>
/// <Param name="strEleName2" type="L3STRING">Ԫ��2</Param>
/// </Method>
L3FLOAT CRH_Unit_Mag::CalEleRateValue(L3STRING strHeatID, L3STRING strEleName1,L3STRING strEleName2)
{
	CString csHeatID=strHeatID;
	CString csEleName1=strEleName1;
	CString csEleName2=strEleName2;

	csHeatID=csHeatID.Trim();
	csEleName1=csEleName1.Trim();
	csEleName2=csEleName2.Trim();

	if(csHeatID==_T("")||csEleName1==_T("")||csEleName2==_T(""))
		return 0.0;

	CString csSql=_T("select ")+csEleName1+_T(",")+csEleName2+_T(" from CQA_Lab_Element where HeatID='")+csHeatID+_T("' and UnitTypeID=4 order by Report_Date desc ");
	//csSql.Format(_T("select %s,%s from CQA_Lab_Element where HeatID='%s' and UnitTypeID=5 order by Report_Date desc "),csEleName1,csEleName2,csHeatID);
	CL3RecordSetWrap rs;
	if(!Query(csSql,rs)||!rs.IsNull()||rs.GetRowCount()<1)
		return 0.0;

	CString csEleValue1=rs.GetFieldByName(csEleName1).ToCString();
	CString csEleValue2=rs.GetFieldByName(csEleName2).ToCString();
	
	
	float fRateValue=0.0;
	try
	{
		float fEleValue1=0.0;
		float fEleValue2=0.0;
		fEleValue1=_tstof(csEleValue1);
		fEleValue2=_tstof(csEleValue2);
		fRateValue=fEleValue1/fEleValue2;
	}
	catch(...)
	{
		fRateValue= 0.0;
	}

	return fRateValue;

}
//Modify end

