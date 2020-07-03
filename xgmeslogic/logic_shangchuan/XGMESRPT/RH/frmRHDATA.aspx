<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmRHDATA.aspx.cs" Inherits="RH_frmRHDATA" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table align="center" bgcolor="#00cccc" border="1" bordercolor="#996633" cellpadding="0"
            cellspacing="0" style="width: 98%; height: 1px">
            <tr>
                <td style="width: 38px; height: 9px; text-align: left">
                    <span style="font-size: 11pt">
                    日期:</span></td>
                <td style="height: 9px; text-align: left; width: 7px;">
                    <asp:DropDownList ID="ddlStartYear" runat="server" AutoPostBack="True" BackColor="#C0C0FF"
                        OnSelectedIndexChanged="ddlYear_SelectedIndexChanged" Width="70px">
                    </asp:DropDownList></td>
                <td style="width: 3px; height: 9px; text-align: left">
                    <span style="font-size: 11pt">年</span></td>
                <td style="width: 38px; height: 9px; text-align: left">
                    <asp:DropDownList ID="ddlStartMonth" runat="server" AutoPostBack="True" BackColor="#C0C0FF"
                        OnSelectedIndexChanged="ddlStartMonth_SelectedIndexChanged" Width="60px">
                        <asp:ListItem Value="01">01</asp:ListItem>
                        <asp:ListItem Value="02">02</asp:ListItem>
                        <asp:ListItem Value="03">03</asp:ListItem>
                        <asp:ListItem Value="04">04</asp:ListItem>
                        <asp:ListItem Value="05">05</asp:ListItem>
                        <asp:ListItem Value="06">06</asp:ListItem>
                        <asp:ListItem Value="07">07</asp:ListItem>
                        <asp:ListItem Value="08">08</asp:ListItem>
                        <asp:ListItem Value="09">09</asp:ListItem>
                        <asp:ListItem Value="10">10</asp:ListItem>
                        <asp:ListItem Value="11">11</asp:ListItem>
                        <asp:ListItem Value="12">12</asp:ListItem>
                    </asp:DropDownList></td>
                <td style="width: 9px; height: 9px; text-align: center">
                    <span style="font-size: 11pt">月</span></td>
                <td style="width: 41px; height: 9px; text-align: left">
                    <asp:DropDownList ID="ddlStartDay" runat="server" BackColor="#C0C0FF" Width="50px">
                    </asp:DropDownList></td>
                <td style="width: 16px; height: 9px; text-align: center">
                    <span style="font-size: 11pt">日</span></td>
                <td style="width: 5px; height: 9px; text-align: center">
                    －</td>
                <td style="width: 32px; height: 9px">
                    <asp:DropDownList ID="ddlYear" runat="server" AutoPostBack="True" BackColor="#C0C0FF"
                        OnSelectedIndexChanged="ddlYear_SelectedIndexChanged" Width="70px">
                    </asp:DropDownList></td>
                <td style="height: 9px; text-align: center; width: 18px;">
                    <span style="font-size: 11pt">
                    年</span></td>
                <td style="width: 31px; height: 9px">
                    <asp:DropDownList ID="ddlMonth" runat="server" AutoPostBack="True" BackColor="#C0C0FF"
                        OnSelectedIndexChanged="ddlMonth_SelectedIndexChanged" Width="50px">
                        <asp:ListItem Value="01">01</asp:ListItem>
                        <asp:ListItem Value="02">02</asp:ListItem>
                        <asp:ListItem Value="03">03</asp:ListItem>
                        <asp:ListItem Value="04">04</asp:ListItem>
                        <asp:ListItem Value="05">05</asp:ListItem>
                        <asp:ListItem Value="06">06</asp:ListItem>
                        <asp:ListItem Value="07">07</asp:ListItem>
                        <asp:ListItem Value="08">08</asp:ListItem>
                        <asp:ListItem Value="09">09</asp:ListItem>
                        <asp:ListItem Value="10">10</asp:ListItem>
                        <asp:ListItem Value="11">11</asp:ListItem>
                        <asp:ListItem Value="12">12</asp:ListItem>
                    </asp:DropDownList></td>
                <td nowrap="nowrap" style="width: 23px; height: 9px; text-align: center">
                    <span style="font-size: 11pt">
                    月</span></td>
                <td style="width: 40px; height: 9px">
                    <asp:DropDownList ID="ddlDay" runat="server" BackColor="#C0C0FF" Width="50px">
                    </asp:DropDownList></td>
                <td style="width: 18px; height: 9px; text-align: center">
                    <span style="font-size: 11pt">
                    日</span></td>
                <td style="width: 33px; height: 9px; text-align: center">
                    <span style="font-size: 11pt">班别</span></td>
                <td style="width: 53px; height: 9px; text-align: center">
                    <asp:DropDownList ID="TeamDropDownList" runat="server" BackColor="#C0C0FF" Width="50px">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem Value="1">甲班</asp:ListItem>
                        <asp:ListItem Value="2">乙班</asp:ListItem>
                        <asp:ListItem Value="3">丙班</asp:ListItem>
                        <asp:ListItem Value="4">丁班</asp:ListItem>
                    </asp:DropDownList></td>
                <td style="width: 31px; height: 9px">
                    <asp:Button ID="btnQuery" runat="server" Height="24px" OnClick="btnQuery_Click" Text="查询"
                        Width="68px" /></td>
            </tr>
        </table>
    
    </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" InsertMethod="Insert"
            OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="dsRHTableAdapters.TR_RH_ORIGINALDATATableAdapter">
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
        <rsweb:reportviewer id="ReportViewer1" runat="server" font-names="Verdana" font-size="8pt"
            height="360px" visible="False" width="360cm">
<LocalReport ReportPath="RH\rptRHData.rdlc"><DataSources>
<rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="dsRH_TR_RH_ORIGINALDATA"></rsweb:ReportDataSource>
</DataSources>
</LocalReport>
</rsweb:reportviewer>
        <br />
    </form>
</body>
</html>
