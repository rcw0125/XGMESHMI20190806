<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BOF_OriginalData.aspx.cs" Inherits="Default2" %>

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
        <table align="center" bgcolor="#00cccc" border="1" bordercolor="#996633" cellpadding="0"
            cellspacing="0" style="width: 102%; height: 1px">
            <tr>
                <td style="width: 36px; height: 12px; text-align: left">
                    <span style="font-size: 11pt">
                    日期:</span></td>
                <td style="width: 32px; height: 12px; text-align: center">
                    <asp:DropDownList ID="ddlStartYear" runat="server" AutoPostBack="True" BackColor="#C0C0FF"
                        OnSelectedIndexChanged="ddlYear_SelectedIndexChanged" Width="60px">
                    </asp:DropDownList></td>
                <td style="width: 22px; height: 12px; text-align: center">
                    <span style="font-size: 11pt">年</span></td>
                <td style="width: 13px; height: 12px; text-align: center">
                    <asp:DropDownList ID="ddlStartMonth" runat="server" AutoPostBack="True" BackColor="#C0C0FF"
                        OnSelectedIndexChanged="ddlStartMonth_SelectedIndexChanged" Width="40px">
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
                <td style="width: 19px; height: 12px; text-align: center">
                    <span style="font-size: 11pt">月</span></td>
                <td style="width: 35px; height: 12px; text-align: center">
                    <asp:DropDownList ID="ddlStartDay" runat="server" BackColor="#C0C0FF" Width="40px">
                    </asp:DropDownList></td>
                <td style="width: 11px; height: 12px; text-align: center">
                    <span style="font-size: 11pt">日</span></td>
                <td style="width: 21px; height: 12px; text-align: center">
                    －</td>
                <td style="width: 24px; height: 12px">
                    <asp:DropDownList ID="ddlYear" runat="server" AutoPostBack="True" BackColor="#C0C0FF"
                        OnSelectedIndexChanged="ddlYear_SelectedIndexChanged" Width="60px">
                    </asp:DropDownList></td>
                <td style="height: 12px; text-align: center; width: 13px;">
                    <span style="font-size: 11pt">
                    年</span></td>
                <td style="width: 40px; height: 12px">
                    <asp:DropDownList ID="ddlMonth" runat="server" AutoPostBack="True" BackColor="#C0C0FF"
                        OnSelectedIndexChanged="ddlMonth_SelectedIndexChanged" Width="40px">
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
                <td nowrap="nowrap" style="width: 15px; height: 12px; text-align: center">
                    <span style="font-size: 11pt">
                    月</span></td>
                <td style="width: 34px; height: 12px">
                    <asp:DropDownList ID="ddlDay" runat="server" BackColor="#C0C0FF" Width="40px">
                    </asp:DropDownList></td>
                <td style="width: 19px; height: 12px; text-align: center">
                    <span style="font-size: 11pt">
                    日</span></td>
                <td style="width: 36px; height: 12px; text-align: center">
                    <span style="font-size: 11pt">炉座</span></td>
                <td style="width: 49px; height: 12px; text-align: center"><asp:DropDownList ID="Quality" runat="server" BackColor="#C0C0FF" Width="60px">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem Value="1">1#转炉</asp:ListItem>
                    <asp:ListItem Value="2">2#转炉</asp:ListItem>
                    <asp:ListItem Value="3">3#转炉</asp:ListItem>
                    <asp:ListItem Value="4">4#转炉</asp:ListItem>
                </asp:DropDownList></td>
                <td style="width: 32px; height: 12px; text-align: center">
                    <span style="font-size: 11pt">
                    班别</span></td>
                <td style="width: 52px; height: 12px; text-align: center">
                    <asp:DropDownList ID="TeamDropDownList" runat="server" BackColor="#C0C0FF" Width="60px">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem Value="1">甲班</asp:ListItem>
                        <asp:ListItem Value="2">乙班</asp:ListItem>
                        <asp:ListItem Value="3">丙班</asp:ListItem>
                        <asp:ListItem Value="4">丁班</asp:ListItem>
                    </asp:DropDownList></td>
                <td style="width: 37px; height: 12px">
                    <asp:Button ID="btnQuery" runat="server" Height="24px" OnClick="btnQuery_Click" Text="查询"
                        Width="46px" /></td>
            </tr>
        </table>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt"
            Height="480px" Visible="False" Width="800cm">
            <LocalReport ReportPath="BOF\rptBOFData.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="dsBOF_TS_ORIGINALDATA" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
        <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="GetData"
            TypeName="DataSet1TableAdapters.TS_ORIGINALDATATableAdapter"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetData"
            TypeName="DataSet1TableAdapters.TP_REHEAT_ACCOUNTTableAdapter"></asp:ObjectDataSource>
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
                <asp:Parameter Name="FEP_ALLOY" Type="Decimal" />
                <asp:Parameter Name="FES_ALLOY" Type="Decimal" />
                <asp:Parameter Name="NIBOARD_ALLOY" Type="Decimal" />
                <asp:Parameter Name="CU_FIN" Type="Decimal" />
                <asp:Parameter Name="NI_FIN" Type="Decimal" />
                <asp:Parameter Name="CU_ARRIVAL_ELEMENT" Type="Decimal" />
                <asp:Parameter Name="NI_ARRIVAL_ELEMENT" Type="Decimal" />
                <asp:Parameter Name="ALV_MAT" Type="Decimal" />
                <asp:Parameter Name="SIO2_MAT" Type="Decimal" />
                <asp:Parameter Name="TEMP_BEF_AR_FLAG" Type="String" />
                <asp:Parameter Name="RETURN_STEEL_WEIGHT" Type="Decimal" />
                <asp:Parameter Name="HEATNUM_CASTING" Type="String" />
                <asp:Parameter Name="HEATNUM_TUNDISH" Type="String" />
                <asp:Parameter Name="EXCEPT" Type="String" />
                <asp:Parameter Name="LADLE_NO" Type="String" />
                <asp:Parameter Name="TI_IRON" Type="Decimal" />
                <asp:Parameter Name="MN_IRON" Type="Decimal" />
                <asp:Parameter Name="C_IRON" Type="Decimal" />
                <asp:Parameter Name="SI_FE_ALLOY" Type="Decimal" />
                <asp:Parameter Name="LOW_C_MN_FE_ALLOY" Type="Decimal" />
                <asp:Parameter Name="PROTOCOL" Type="String" />
                <asp:Parameter Name="TUNDISH_TEMP_FLAG" Type="String" />
                <asp:Parameter Name="CEQ_FIN" Type="Decimal" />
                <asp:Parameter Name="SI_BA" Type="Decimal" />
                <asp:Parameter Name="L_S_ELECTRODE_TABLETS" Type="Decimal" />
                <asp:Parameter Name="FINAL_STEELGRADE" Type="String" />
                <asp:Parameter Name="CHANGE_REASON" Type="String" />
                <asp:Parameter Name="TEMP_AFT_AR_FLAG" Type="String" />
                <asp:Parameter Name="COLD_MAT_CUNSUME" Type="Decimal" />
                <asp:Parameter Name="PRESSURE_SPRAY_AGENT" Type="Decimal" />
                <asp:Parameter Name="COPPER_PLATE" Type="Decimal" />
            </InsertParameters>
        </asp:ObjectDataSource>
         &nbsp;
    
    </div>
    </form>
</body>
</html>
