<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmTrans.aspx.cs" Inherits="Trans_frmTrans" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <table align="center" bgcolor="#00cccc" border="1" bordercolor="#996633" cellpadding="0"
            cellspacing="0" style="width: 98%; height: 1px">
            <tr>
                <td colspan="8" style="height: 28px; text-align: center">
                    炉号：<asp:TextBox ID="txtHeatID" runat="server"></asp:TextBox></td>
                <td style="width: 78px; height: 28px">
                    <asp:Button ID="btnQuery" runat="server" Height="24px" OnClick="btnQuery_Click" Text="查询"
                        Width="72px" /></td>
            </tr>
        </table>
    
    </div>
        <rsweb:reportviewer id="ReportViewer1" runat="server" font-names="Verdana" font-size="8pt"
            height="170px" width="800px">
<LocalReport ReportPath="BOF\rptBOFData.rdlc"><DataSources>
<rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="dsBOF_TS_ORIGINALDATA"></rsweb:ReportDataSource>
</DataSources>
</LocalReport>
</rsweb:reportviewer>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData"
            TypeName="dsBOFTableAdapters.TS_ORIGINALDATATableAdapter" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}">
            <InsertParameters>
                <asp:Parameter Name="BOFID" Type="String" />
                <asp:Parameter Name="LOGTIME" Type="String" />
                <asp:Parameter Name="TEAM" Type="String" />
                <asp:Parameter Name="SHIFT" Type="String" />
                <asp:Parameter Name="HEADFURNACE" Type="String" />
                <asp:Parameter Name="ASSISTANT" Type="String" />
                <asp:Parameter Name="SECONDHAND" Type="String" />
                <asp:Parameter Name="HEATID" Type="String" />
                <asp:Parameter Name="FURNACEAGE" Type="Decimal" />
                <asp:Parameter Name="PLAN_STEELGRADE" Type="String" />
                <asp:Parameter Name="CASTINGNO" Type="String" />
                <asp:Parameter Name="IRONWEIGHT" Type="Decimal" />
                <asp:Parameter Name="SCRAPWEIGHT" Type="Decimal" />
                <asp:Parameter Name="PIGIRONWEIGHT" Type="Decimal" />
                <asp:Parameter Name="MIFID" Type="String" />
                <asp:Parameter Name="S_IRON" Type="Decimal" />
                <asp:Parameter Name="SI_IRON" Type="Decimal" />
                <asp:Parameter Name="P_IRON" Type="Decimal" />
                <asp:Parameter Name="CHARGING_START_TIME" Type="DateTime" />
                <asp:Parameter Name="TAPPING_END_TIME" Type="DateTime" />
                <asp:Parameter Name="TOTAL_O2_PRESS" Type="Decimal" />
                <asp:Parameter Name="WORK_O2_PRESS" Type="Decimal" />
                <asp:Parameter Name="O2_BLOW" Type="Decimal" />
                <asp:Parameter Name="LANCE_AGE" Type="Decimal" />
                <asp:Parameter Name="BLOWO2_TIME" Type="Decimal" />
                <asp:Parameter Name="LIME_MAT" Type="Decimal" />
                <asp:Parameter Name="MAGNESIUM" Type="Decimal" />
                <asp:Parameter Name="FLUORITE_MAT" Type="Decimal" />
                <asp:Parameter Name="DOLOMITE_MAT" Type="Decimal" />
                <asp:Parameter Name="FEO_MAT" Type="Decimal" />
                <asp:Parameter Name="MOD_AGENT_MAT" Type="Decimal" />
                <asp:Parameter Name="REBLOW_COUNT" Type="Decimal" />
                <asp:Parameter Name="REBLOW_TIME" Type="Decimal" />
                <asp:Parameter Name="DOLOMITE_LAC" Type="Decimal" />
                <asp:Parameter Name="LIME_LAC" Type="Decimal" />
                <asp:Parameter Name="MOD_AGENT_LAC" Type="Decimal" />
                <asp:Parameter Name="LAC_TEMP" Type="Decimal" />
                <asp:Parameter Name="TAPPING_TEMP" Type="Decimal" />
                <asp:Parameter Name="TAPPING_OXYGEN" Type="Decimal" />
                <asp:Parameter Name="LADLE_STATUS" Type="String" />
                <asp:Parameter Name="C_LAC" Type="String" />
                <asp:Parameter Name="P_LAC" Type="String" />
                <asp:Parameter Name="S_LAC" Type="String" />
                <asp:Parameter Name="TAPHOLE_LIFE" Type="Decimal" />
                <asp:Parameter Name="TAP_TIME" Type="Decimal" />
                <asp:Parameter Name="TAPPING_WEIGHT" Type="Decimal" />
                <asp:Parameter Name="DOWN_SLAG_FLAG" Type="String" />
                <asp:Parameter Name="SPLASHING_TIME" Type="Decimal" />
                <asp:Parameter Name="ELECTRODE_TABLETS" Type="Decimal" />
                <asp:Parameter Name="CARBURIZING_AGENTS" Type="Decimal" />
                <asp:Parameter Name="SI_FE" Type="Decimal" />
                <asp:Parameter Name="LOW_AL_FERROSILICON" Type="Decimal" />
                <asp:Parameter Name="MICRO_AL_FERROSILICON" Type="Decimal" />
                <asp:Parameter Name="SI_MN" Type="Decimal" />
                <asp:Parameter Name="HIGH_C_FERROMANGANESE" Type="Decimal" />
                <asp:Parameter Name="p1" Type="Decimal" />
                <asp:Parameter Name="MN_AL_FE_ALLOY" Type="Decimal" />
                <asp:Parameter Name="SIC" Type="Decimal" />
                <asp:Parameter Name="CALCIUM_CARBIDE" Type="Decimal" />
                <asp:Parameter Name="MO_FE" Type="Decimal" />
                <asp:Parameter Name="HIGH_C_FERROCHROME" Type="Decimal" />
                <asp:Parameter Name="p4" Type="Decimal" />
                <asp:Parameter Name="LOW_C_FERROCHROME" Type="Decimal" />
                <asp:Parameter Name="V_FE" Type="Decimal" />
                <asp:Parameter Name="PRE_SLAG" Type="Decimal" />
                <asp:Parameter Name="p7" Type="String" />
                <asp:Parameter Name="p10" Type="Decimal" />
                <asp:Parameter Name="FLUORITE_TOP" Type="Decimal" />
                <asp:Parameter Name="LIME_TOP" Type="Decimal" />
                <asp:Parameter Name="SI_AL_FE_O2" Type="Decimal" />
                <asp:Parameter Name="MN_AL_FE_O2" Type="Decimal" />
                <asp:Parameter Name="AL" Type="Decimal" />
                <asp:Parameter Name="TEMP_BEFORE_BLOWAR" Type="Decimal" />
                <asp:Parameter Name="O2_BEFORE_BLOWAR" Type="Decimal" />
                <asp:Parameter Name="SI_AL_FE_REO2" Type="Decimal" />
                <asp:Parameter Name="MN_AL_FE_REO2" Type="Decimal" />
                <asp:Parameter Name="TEMP_BLOWNAR" Type="Decimal" />
                <asp:Parameter Name="O2_BLOWNAR" Type="Decimal" />
                <asp:Parameter Name="BLOW_MODE" Type="Decimal" />
                <asp:Parameter Name="TUNE_FLAG" Type="String" />
                <asp:Parameter Name="BLOWAR_TIME" Type="Decimal" />
                <asp:Parameter Name="FEED_WEIGHT" Type="Decimal" />
                <asp:Parameter Name="C_ARRIVAL_ELEMENT" Type="Decimal" />
                <asp:Parameter Name="SI_ARRIVAL_ELEMENT" Type="Decimal" />
                <asp:Parameter Name="MN_ARRIVAL_ELEMENT" Type="Decimal" />
                <asp:Parameter Name="P_ARRIVAL_ELEMENT" Type="Decimal" />
                <asp:Parameter Name="S_ARRIVAL_ELEMENT" Type="Decimal" />
                <asp:Parameter Name="AL_ARRIVAL_ELEMENT" Type="Decimal" />
                <asp:Parameter Name="V_ARRIVAL_ELEMENT" Type="Decimal" />
                <asp:Parameter Name="TI_ARRIVAL_ELEMENT" Type="Decimal" />
                <asp:Parameter Name="MO_ARRIVAL_ELEMENT" Type="Decimal" />
                <asp:Parameter Name="B_ARRIVAL_ELEMENT" Type="Decimal" />
                <asp:Parameter Name="CR_ARRIVAL_ELEMENT" Type="Decimal" />
                <asp:Parameter Name="C_FIN" Type="Decimal" />
                <asp:Parameter Name="SI_FIN" Type="Decimal" />
                <asp:Parameter Name="MN_FIN" Type="Decimal" />
                <asp:Parameter Name="P_FIN" Type="Decimal" />
                <asp:Parameter Name="S_FIN" Type="Decimal" />
                <asp:Parameter Name="AL_FIN" Type="Decimal" />
                <asp:Parameter Name="V_FIN" Type="Decimal" />
                <asp:Parameter Name="TI_FIN" Type="Decimal" />
                <asp:Parameter Name="MO_FIN" Type="Decimal" />
                <asp:Parameter Name="B_FIN" Type="Decimal" />
                <asp:Parameter Name="CR_FIN" Type="Decimal" />
                <asp:Parameter Name="CAO" Type="Decimal" />
                <asp:Parameter Name="SIO2" Type="Decimal" />
                <asp:Parameter Name="MGO" Type="Decimal" />
                <asp:Parameter Name="TFE" Type="Decimal" />
                <asp:Parameter Name="BOTTOMFLOW1" Type="String" />
                <asp:Parameter Name="BOTTOMFLOW2" Type="String" />
                <asp:Parameter Name="BOTTOMFLOW3" Type="String" />
                <asp:Parameter Name="BOTTOMFLOW4" Type="String" />
                <asp:Parameter Name="BOTTOMFLOW5" Type="String" />
                <asp:Parameter Name="BOTTOMFLOW6" Type="String" />
                <asp:Parameter Name="WAITING_TIME" Type="String" />
                <asp:Parameter Name="NOTE" Type="String" />
                <asp:Parameter Name="FURNACE_LINE_STATUS" Type="String" />
                <asp:Parameter Name="SCRAPSTATUS" Type="String" />
            </InsertParameters>
        </asp:ObjectDataSource>
        <rsweb:reportviewer id="ReportViewer2" runat="server" font-names="Verdana" font-size="8pt"
            height="170px" width="800px">
<LocalReport ReportPath="LF\rptLFData.rdlc"><DataSources>
<rsweb:ReportDataSource DataSourceId="ObjectDataSource2" Name="dsLF_TR_LF_ORIGINALDATA"></rsweb:ReportDataSource>
</DataSources>
</LocalReport>
</rsweb:reportviewer>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetData"
            TypeName="dsLFTableAdapters.TR_LF_ORIGINALDATATableAdapter" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}">
            <InsertParameters>
                <asp:Parameter Name="LFID" Type="String" />
                <asp:Parameter Name="LOGTIME" Type="String" />
                <asp:Parameter Name="TEAM" Type="String" />
                <asp:Parameter Name="SHIFT" Type="String" />
                <asp:Parameter Name="HEATFURNACE" Type="String" />
                <asp:Parameter Name="ASSISTANT" Type="String" />
                <asp:Parameter Name="SECONDHAND" Type="String" />
                <asp:Parameter Name="HEATID" Type="String" />
                <asp:Parameter Name="STEELGRADE" Type="String" />
                <asp:Parameter Name="CASTINGNO" Type="String" />
                <asp:Parameter Name="LADLESTATUS" Type="String" />
                <asp:Parameter Name="LADLEAGE" Type="Decimal" />
                <asp:Parameter Name="LADLEID" Type="String" />
                <asp:Parameter Name="LADLESTATUS_NOTE" Type="String" />
                <asp:Parameter Name="LID_LIFE" Type="Decimal" />
                <asp:Parameter Name="STEEL_WEIGHT" Type="Decimal" />
                <asp:Parameter Name="ARRIVAL_TIME" Type="DateTime" />
                <asp:Parameter Name="C_ARRIVAL" Type="Decimal" />
                <asp:Parameter Name="SI_ARRIVAL" Type="Decimal" />
                <asp:Parameter Name="MN_ARRIVAL" Type="Decimal" />
                <asp:Parameter Name="P_ARRIVAL" Type="Decimal" />
                <asp:Parameter Name="S_ARRIVAL" Type="Decimal" />
                <asp:Parameter Name="AL_ARRIVAL" Type="Decimal" />
                <asp:Parameter Name="CR_ARRIVAL" Type="Decimal" />
                <asp:Parameter Name="TI_ARRIVAL" Type="Decimal" />
                <asp:Parameter Name="V_ARRIVAL" Type="Decimal" />
                <asp:Parameter Name="B_ARRIVAL" Type="Decimal" />
                <asp:Parameter Name="MO_ARRIVAL" Type="Decimal" />
                <asp:Parameter Name="HEAT_START_TIME" Type="DateTime" />
                <asp:Parameter Name="HEAT_END_TIME" Type="DateTime" />
                <asp:Parameter Name="HEAT_TIME" Type="Decimal" />
                <asp:Parameter Name="OXYGEN_FACTORY" Type="String" />
                <asp:Parameter Name="OXYGEN1" Type="Decimal" />
                <asp:Parameter Name="OXYGEN1_TEMP" Type="Decimal" />
                <asp:Parameter Name="OXYGEN1_AL" Type="Decimal" />
                <asp:Parameter Name="OXYGEN2" Type="Decimal" />
                <asp:Parameter Name="OXYGEN2_TEMP" Type="Decimal" />
                <asp:Parameter Name="OXYGEN2_AL" Type="Decimal" />
                <asp:Parameter Name="ELEC_CONSUM" Type="Decimal" />
                <asp:Parameter Name="FEEDWIRE_TIME" Type="DateTime" />
                <asp:Parameter Name="FEEDWIRE_TEMP" Type="Decimal" />
                <asp:Parameter Name="SOFTBLOW_STARTTIME" Type="DateTime" />
                <asp:Parameter Name="SOFTBLOW_ENDTIME" Type="DateTime" />
                <asp:Parameter Name="SOFTBLOW_TIME" Type="Decimal" />
                <asp:Parameter Name="DEPARTURE_TEMP" Type="Decimal" />
                <asp:Parameter Name="DEPARTURE_REMA_WT" Type="Decimal" />
                <asp:Parameter Name="TECHNOLOGY_QUALITY" Type="String" />
                <asp:Parameter Name="DISTEMP_REASON" Type="String" />
                <asp:Parameter Name="CIRCSOFRHYTHM" Type="String" />
                <asp:Parameter Name="TUNDISH_TEMP_5MIN" Type="Decimal" />
                <asp:Parameter Name="TUNDISH_TEMP_10MIN" Type="Decimal" />
                <asp:Parameter Name="TUNDISH_TEMP_15MIN" Type="Decimal" />
                <asp:Parameter Name="TUNDISH_TEMP_20MIN" Type="Decimal" />
                <asp:Parameter Name="TUNDISH_TEMP_25MIN" Type="Decimal" />
                <asp:Parameter Name="TUNDISH_TEMP_30MIN" Type="Decimal" />
                <asp:Parameter Name="TUNDISH_TEMP_35MIN" Type="Decimal" />
                <asp:Parameter Name="CASTING_STOP_TEMP" Type="Decimal" />
                <asp:Parameter Name="TUNDISHTEMP_QUALITY" Type="String" />
                <asp:Parameter Name="C_PROCESS" Type="Decimal" />
                <asp:Parameter Name="SI_PROCESS" Type="Decimal" />
                <asp:Parameter Name="MN_PROCESS" Type="Decimal" />
                <asp:Parameter Name="P_PROCESS" Type="Decimal" />
                <asp:Parameter Name="S_PROCESS" Type="Decimal" />
                <asp:Parameter Name="AL_PROCESS" Type="Decimal" />
                <asp:Parameter Name="CR_PROCESS" Type="Decimal" />
                <asp:Parameter Name="TI_PROCESS" Type="Decimal" />
                <asp:Parameter Name="V_PROCESS" Type="Decimal" />
                <asp:Parameter Name="B_PROCESS" Type="Decimal" />
                <asp:Parameter Name="MO_PROCESS" Type="Decimal" />
                <asp:Parameter Name="CA_PROCESS" Type="Decimal" />
                <asp:Parameter Name="C_FINISHED" Type="Decimal" />
                <asp:Parameter Name="SI_FINISHED" Type="Decimal" />
                <asp:Parameter Name="MN_FINISHED" Type="Decimal" />
                <asp:Parameter Name="P_FINISHED" Type="Decimal" />
                <asp:Parameter Name="S_FINISHED" Type="Decimal" />
                <asp:Parameter Name="AL_FINISHED" Type="Decimal" />
                <asp:Parameter Name="CR_FINISHED" Type="Decimal" />
                <asp:Parameter Name="TI_FINISHED" Type="Decimal" />
                <asp:Parameter Name="V_FINISHED" Type="Decimal" />
                <asp:Parameter Name="B_FINISHED" Type="Decimal" />
                <asp:Parameter Name="MO_FINISHED" Type="Decimal" />
                <asp:Parameter Name="CA_FINISHED" Type="Decimal" />
                <asp:Parameter Name="CAO_PROCESS_ADD" Type="Decimal" />
                <asp:Parameter Name="CAF_PROCESS_ADD" Type="Decimal" />
                <asp:Parameter Name="AL2O3_PROCESS_ADD" Type="Decimal" />
                <asp:Parameter Name="SIO2_PROCESS_ADD" Type="Decimal" />
                <asp:Parameter Name="CAC_PROCESS_ADD" Type="Decimal" />
                <asp:Parameter Name="ALL_PROCESS_ADD" Type="Decimal" />
                <asp:Parameter Name="SI_FE_F_PROCESS_ADD" Type="Decimal" />
                <asp:Parameter Name="H_C_MN_FE_PROCESS_ADD" Type="Decimal" />
                <asp:Parameter Name="M_C_MN_FE_PROCESS_ADD" Type="Decimal" />
                <asp:Parameter Name="SI_FE_PROCESS_ADD" Type="Decimal" />
                <asp:Parameter Name="CR_FE_PROCESS_ADD" Type="Decimal" />
                <asp:Parameter Name="B_FE_PROCESS_ADD" Type="Decimal" />
                <asp:Parameter Name="V_FE_PROCESS_ADD" Type="Decimal" />
                <asp:Parameter Name="MO_FE_PROCESS_ADD" Type="Decimal" />
                <asp:Parameter Name="TI_FE_PROCESS_ADD" Type="Decimal" />
                <asp:Parameter Name="OTHER" Type="Decimal" />
                <asp:Parameter Name="MODEL_SYNTHETIC_SLAG" Type="String" />
                <asp:Parameter Name="DOSAGE_SYNTHETIC_SLAG" Type="Decimal" />
                <asp:Parameter Name="C_AMOUNT" Type="Decimal" />
                <asp:Parameter Name="FECA_AMOUNT" Type="Decimal" />
                <asp:Parameter Name="FECA_ADDCA" Type="Decimal" />
                <asp:Parameter Name="SICA_AMOUNT" Type="Decimal" />
                <asp:Parameter Name="ALADD_AMOUNT" Type="Decimal" />
                <asp:Parameter Name="NOTE" Type="String" />
                <asp:Parameter Name="SLAGANALYSIS_FEO" Type="Decimal" />
                <asp:Parameter Name="SLAGANALYSIS_SIO2" Type="Decimal" />
                <asp:Parameter Name="SLAGANALYSIS_CAO" Type="Decimal" />
                <asp:Parameter Name="SLAGANALYSIS_MGO" Type="Decimal" />
                <asp:Parameter Name="SLAGANALYSIS_AL203" Type="Decimal" />
                <asp:Parameter Name="SLAGANALYSIS_S" Type="Decimal" />
                <asp:Parameter Name="SLAGANALYSIS_P" Type="Decimal" />
                <asp:Parameter Name="SLAGANALYSIS_MNO" Type="Decimal" />
                <asp:Parameter Name="SLAGANALYSIS_TIO2" Type="Decimal" />
                <asp:Parameter Name="HEAT_GAS" Type="Decimal" />
                <asp:Parameter Name="SOFTBLOW_GAS" Type="Decimal" />
                <asp:Parameter Name="PRODUCTIONDATE" Type="DateTime" />
                <asp:Parameter Name="ARRIVE_TEMP" Type="Decimal" />
                <asp:Parameter Name="NI_ARRIVAL" Type="Decimal" />
                <asp:Parameter Name="NI_FINISHED" Type="Decimal" />
                <asp:Parameter Name="L_C_MN_FE_PROCESS_ADD" Type="Decimal" />
                <asp:Parameter Name="p1" Type="Decimal" />
                <asp:Parameter Name="H_C_CR_FE_PROCESS_ADD" Type="Decimal" />
                <asp:Parameter Name="p4" Type="Decimal" />
                <asp:Parameter Name="p7" Type="Decimal" />
                <asp:Parameter Name="C_SECOND" Type="Decimal" />
                <asp:Parameter Name="SI_SECOND" Type="Decimal" />
                <asp:Parameter Name="MN_SECOND" Type="Decimal" />
                <asp:Parameter Name="P_SECOND" Type="Decimal" />
                <asp:Parameter Name="S_SECOND" Type="Decimal" />
                <asp:Parameter Name="AL_SECOND" Type="Decimal" />
                <asp:Parameter Name="CR_SECOND" Type="Decimal" />
                <asp:Parameter Name="TI_SECOND" Type="Decimal" />
                <asp:Parameter Name="V_SECOND" Type="Decimal" />
                <asp:Parameter Name="B_SECOND" Type="Decimal" />
                <asp:Parameter Name="MO_SECOND" Type="Decimal" />
                <asp:Parameter Name="CA_SECOND" Type="Decimal" />
                <asp:Parameter Name="NI_SECOND" Type="Decimal" />
                <asp:Parameter Name="C_THIRD" Type="Decimal" />
                <asp:Parameter Name="SI_THIRD" Type="Decimal" />
                <asp:Parameter Name="MN_THIRD" Type="Decimal" />
                <asp:Parameter Name="P_THIRD" Type="Decimal" />
                <asp:Parameter Name="S_THIRD" Type="Decimal" />
                <asp:Parameter Name="AL_THIRD" Type="Decimal" />
                <asp:Parameter Name="CR_THIRD" Type="Decimal" />
                <asp:Parameter Name="TI_THIRD" Type="Decimal" />
                <asp:Parameter Name="V_THIRD" Type="Decimal" />
                <asp:Parameter Name="B_THIRD" Type="Decimal" />
                <asp:Parameter Name="MO_THIRD" Type="Decimal" />
                <asp:Parameter Name="CA_THIRD" Type="Decimal" />
                <asp:Parameter Name="NI_THIRD" Type="Decimal" />
            </InsertParameters>
        </asp:ObjectDataSource>
        <rsweb:reportviewer id="ReportViewer3" runat="server" font-names="Verdana" font-size="8pt"
            height="170px" width="800px">
<LocalReport ReportPath="RH\rptRHData.rdlc"><DataSources>
<rsweb:ReportDataSource DataSourceId="ObjectDataSource3" Name="dsRH_TR_RH_ORIGINALDATA"></rsweb:ReportDataSource>
</DataSources>
</LocalReport>
</rsweb:reportviewer>
        <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="GetData"
            TypeName="dsRHTableAdapters.TR_RH_ORIGINALDATATableAdapter" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}">
            <InsertParameters>
                <asp:Parameter Name="LOGTIME" Type="String" />
                <asp:Parameter Name="TEAM" Type="String" />
                <asp:Parameter Name="SHIFT" Type="String" />
                <asp:Parameter Name="HEATFURNACE" Type="String" />
                <asp:Parameter Name="ASSISTANT" Type="String" />
                <asp:Parameter Name="SECONDHAND" Type="String" />
                <asp:Parameter Name="HEATID" Type="String" />
                <asp:Parameter Name="STEELGRADE" Type="String" />
                <asp:Parameter Name="CASTINGNO" Type="String" />
                <asp:Parameter Name="LADLESTATUS" Type="String" />
                <asp:Parameter Name="STEELWEIGHT" Type="Decimal" />
                <asp:Parameter Name="ARRIVAL_TIME" Type="DateTime" />
                <asp:Parameter Name="IN_TEMP" Type="Decimal" />
                <asp:Parameter Name="IN_TEMP_QUALITY" Type="Decimal" />
                <asp:Parameter Name="p1" Type="Decimal" />
                <asp:Parameter Name="AREAID" Type="String" />
                <asp:Parameter Name="VACTUBE_ID" Type="String" />
                <asp:Parameter Name="C_BOFIN_COMPOSITION" Type="Decimal" />
                <asp:Parameter Name="C_ARRIVAL_COMPOSITION" Type="Decimal" />
                <asp:Parameter Name="p4" Type="Decimal" />
                <asp:Parameter Name="p7" Type="Decimal" />
                <asp:Parameter Name="P_ARRIVAL_COMPOSITION" Type="Decimal" />
                <asp:Parameter Name="S_ARRIVAL_COMPOSITION" Type="Decimal" />
                <asp:Parameter Name="p10" Type="Decimal" />
                <asp:Parameter Name="p13" Type="Decimal" />
                <asp:Parameter Name="p16" Type="Decimal" />
                <asp:Parameter Name="V_ARRIVAL_COMPOSITION" Type="Decimal" />
                <asp:Parameter Name="B_ARRIVAL_COMPOSITION" Type="Decimal" />
                <asp:Parameter Name="p19" Type="Decimal" />
                <asp:Parameter Name="TREATMENT_MODEL" Type="String" />
                <asp:Parameter Name="START_TIME" Type="DateTime" />
                <asp:Parameter Name="END_TIME" Type="DateTime" />
                <asp:Parameter Name="LOOP_TIME" Type="String" />
                <asp:Parameter Name="VACUUM_MIN" Type="Decimal" />
                <asp:Parameter Name="OB_VIEWS" Type="Decimal" />
                <asp:Parameter Name="OB_OXYGENCONSUMPTION" Type="Decimal" />
                <asp:Parameter Name="OB_ALCONSUMPTION" Type="Decimal" />
                <asp:Parameter Name="OB_CYCLE_TIME" Type="Decimal" />
                <asp:Parameter Name="OXYGENFACTORY" Type="String" />
                <asp:Parameter Name="OXYGEN1" Type="Decimal" />
                <asp:Parameter Name="OXYGEN1_TEMP" Type="Decimal" />
                <asp:Parameter Name="PROCESS_OXYGEN_TEMP" Type="Decimal" />
                <asp:Parameter Name="PROCESS_OXYGEN" Type="Decimal" />
                <asp:Parameter Name="OXYGEN2" Type="Decimal" />
                <asp:Parameter Name="OXYGEN2_TEMP" Type="Decimal" />
                <asp:Parameter Name="FEEDWIRE_TIME" Type="DateTime" />
                <asp:Parameter Name="FEEDWIRE_TEMP" Type="Decimal" />
                <asp:Parameter Name="SOFTBLOW_STARTTIME" Type="DateTime" />
                <asp:Parameter Name="SOFTBLOW_ENDTIME" Type="DateTime" />
                <asp:Parameter Name="SOFTBLOW_TIME" Type="Decimal" />
                <asp:Parameter Name="DEPARTURE_TEMP" Type="Decimal" />
                <asp:Parameter Name="p22" Type="Decimal" />
                <asp:Parameter Name="CIRCSOFRHYTHM" Type="String" />
                <asp:Parameter Name="TECHNOLOGY_QUALITY" Type="String" />
                <asp:Parameter Name="p25" Type="String" />
                <asp:Parameter Name="TUNDISH_TEMP_QUALITY" Type="String" />
                <asp:Parameter Name="C_OUT_ANALYSIS" Type="Decimal" />
                <asp:Parameter Name="SI_OUT_ANALYSIS" Type="Decimal" />
                <asp:Parameter Name="MN_OUT_ANALYSIS" Type="Decimal" />
                <asp:Parameter Name="P_OUT_ANALYSIS" Type="Decimal" />
                <asp:Parameter Name="S_OUT_ANALYSIS" Type="Decimal" />
                <asp:Parameter Name="AL_OUT_ANALYSIS" Type="Decimal" />
                <asp:Parameter Name="CR_OUT_ANALYSIS" Type="Decimal" />
                <asp:Parameter Name="TI_OUT_ANALYSIS" Type="Decimal" />
                <asp:Parameter Name="V_OUT_ANALYSIS" Type="Decimal" />
                <asp:Parameter Name="B_OUT_ANALYSIS" Type="Decimal" />
                <asp:Parameter Name="MO_OUT_ANALYSIS" Type="Decimal" />
                <asp:Parameter Name="CA_OUT_ANALYSIS" Type="Decimal" />
                <asp:Parameter Name="C_FINISHED_ANALYSIS" Type="Decimal" />
                <asp:Parameter Name="SI_FINISHED_ANALYSIS" Type="Decimal" />
                <asp:Parameter Name="MN_FINISHED_ANALYSIS" Type="Decimal" />
                <asp:Parameter Name="P_FINISHED_ANALYSIS" Type="Decimal" />
                <asp:Parameter Name="S_FINISHED_ANALYSIS" Type="Decimal" />
                <asp:Parameter Name="AL_FINISHED_ANALYSIS" Type="Decimal" />
                <asp:Parameter Name="CR_FINISHED_ANALYSIS" Type="Decimal" />
                <asp:Parameter Name="TI_FINISHED_ANALYSIS" Type="Decimal" />
                <asp:Parameter Name="V_FINISHED_ANALYSIS" Type="Decimal" />
                <asp:Parameter Name="B_FINISHED_ANALYSIS" Type="Decimal" />
                <asp:Parameter Name="MO_FINISHED_ANALYSIS" Type="Decimal" />
                <asp:Parameter Name="CA_FINISHED_ANALYSIS" Type="Decimal" />
                <asp:Parameter Name="p28" Type="Decimal" />
                <asp:Parameter Name="SI_FE_PROCESS_ADD" Type="Decimal" />
                <asp:Parameter Name="p31" Type="Decimal" />
                <asp:Parameter Name="p34" Type="Decimal" />
                <asp:Parameter Name="p37" Type="Decimal" />
                <asp:Parameter Name="ALL_PROCESS_ADD" Type="Decimal" />
                <asp:Parameter Name="p40" Type="Decimal" />
                <asp:Parameter Name="B_FE_PROCESS_ADD" Type="Decimal" />
                <asp:Parameter Name="TI_FE_PROCESS_ADD" Type="Decimal" />
                <asp:Parameter Name="COLD_FEED_PROCESS_ADD" Type="Decimal" />
                <asp:Parameter Name="p43" Type="Decimal" />
                <asp:Parameter Name="CA_ADDCA" Type="Decimal" />
                <asp:Parameter Name="SLAGANALYSIS_SIO2" Type="Decimal" />
                <asp:Parameter Name="SLAGANALYSIS_FEO" Type="Decimal" />
                <asp:Parameter Name="SLAGANALYSIS_CAO" Type="Decimal" />
                <asp:Parameter Name="SLAGANALYSIS_MGO" Type="Decimal" />
                <asp:Parameter Name="SLAGANALYSIS_AL2O3" Type="Decimal" />
                <asp:Parameter Name="SLAGANALYSIS_S" Type="Decimal" />
                <asp:Parameter Name="SLAGANALYSIS_P" Type="Decimal" />
                <asp:Parameter Name="SLAGANALYSIS_MNO" Type="Decimal" />
                <asp:Parameter Name="SLAGANALYSIS_TIO2" Type="Decimal" />
                <asp:Parameter Name="NOTE" Type="String" />
                <asp:Parameter Name="p46" Type="Decimal" />
                <asp:Parameter Name="AMOUNT_CWIRE" Type="Decimal" />
                <asp:Parameter Name="AMOUNT_FECAWIRE" Type="Decimal" />
                <asp:Parameter Name="AMOUNT_SICAWIRE" Type="Decimal" />
                <asp:Parameter Name="AMOUNT_ALWIRE" Type="Decimal" />
                <asp:Parameter Name="PRODUCTIONDATE" Type="DateTime" />
            </InsertParameters>
        </asp:ObjectDataSource>
        <rsweb:ReportViewer ID="ReportViewer4" runat="server" Font-Names="Verdana" Font-Size="8pt"
            Height="204px" Width="803px">
            <LocalReport ReportPath="CCM\CCMData5.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource6" Name="CCMData5_TC_ORIGINALDATA_NO5" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
        <asp:ObjectDataSource ID="ObjectDataSource6" runat="server" SelectMethod="GetData"
            TypeName="CCMData5TableAdapters.TC_ORIGINALDATA_NO5TableAdapter"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="ObjectDataSource5" runat="server" SelectMethod="GetData"
            TypeName="CCMData34TableAdapters.TC_ORIGINALDATA_NO3ANDNO4TableAdapter"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="ObjectDataSource4" runat="server" SelectMethod="GetData"
            TypeName="CCMData12TableAdapters.TC_ORIGINALDATA_NO1ANDNO2TableAdapter"></asp:ObjectDataSource>
        &nbsp; &nbsp;
    </form>
</body>
</html>
