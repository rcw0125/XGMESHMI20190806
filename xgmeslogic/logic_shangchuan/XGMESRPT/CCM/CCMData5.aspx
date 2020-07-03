<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CCMData5.aspx.cs" Inherits="CCM_CCMData5" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <table align="center" bgcolor="#00cccc" border="1" bordercolor="#996633" cellpadding="0"
            cellspacing="0" style="width: 103%; height: 1px">
            <tr>
                <td style="width: 33px; height: 19px; text-align: left">
                    <span style="font-size: 11pt">
                    日期:</span></td>
                <td style="width: 12px; height: 19px; text-align: left">
                    <asp:DropDownList ID="ddlStartYear" runat="server" AutoPostBack="True" BackColor="#C0C0FF"
                        OnSelectedIndexChanged="ddlYear_SelectedIndexChanged" Width="60px">
                    </asp:DropDownList></td>
                <td style="width: 10px; height: 19px; text-align: center">
                    <span style="font-size: 11pt">年</span></td>
                <td style="width: 44px; height: 19px; text-align: left">
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
                <td style="width: 16px; height: 19px; text-align: center">
                    <span style="font-size: 11pt">月</span></td>
                <td style="width: 37px; height: 19px; text-align: left">
                    <asp:DropDownList ID="ddlStartDay" runat="server" BackColor="#C0C0FF" Width="40px">
                    </asp:DropDownList></td>
                <td style="width: 15px; height: 19px; text-align: center">
                    <span style="font-size: 11pt">日</span></td>
                <td style="width: 3px; height: 19px; text-align: center">
                    －</td>
                <td style="width: 35px; height: 19px">
                    <asp:DropDownList ID="ddlYear" runat="server" AutoPostBack="True" BackColor="#C0C0FF"
                        OnSelectedIndexChanged="ddlYear_SelectedIndexChanged" Width="60px">
                    </asp:DropDownList></td>
                <td style="height: 19px; text-align: center; width: 17px;">
                    <span style="font-size: 11pt">
                    年</span></td>
                <td style="width: 40px; height: 19px">
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
                <td nowrap="nowrap" style="width: 15px; height: 19px; text-align: center">
                    <span style="font-size: 11pt">
                    月</span></td>
                <td style="width: 40px; height: 19px">
                    <asp:DropDownList ID="ddlDay" runat="server" BackColor="#C0C0FF" Width="40px">
                    </asp:DropDownList></td>
                <td style="width: 14px; height: 19px; text-align: center">
                    <span style="font-size: 11pt">
                    日</span></td>
                <td style="width: 30px; height: 19px; text-align: center">
                    <span style="font-size: 10pt">班别</span></td>
                <td style="width: 51px; height: 19px; text-align: center">
                    <asp:DropDownList ID="TeamDropDownList" runat="server" BackColor="#C0C0FF" Width="53px">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem Value="1">甲班</asp:ListItem>
                        <asp:ListItem Value="2">乙班</asp:ListItem>
                        <asp:ListItem Value="3">丙班</asp:ListItem>
                        <asp:ListItem Value="4">丁班</asp:ListItem>
                    </asp:DropDownList></td>
                <td style="width: 77px; height: 19px">
                    <asp:Button ID="btnQuery" runat="server" Height="24px" OnClick="btnQuery_Click" Text="查询"
                        Width="67px" /></td>
            </tr>
        </table>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <rsweb:reportviewer id="ReportViewer1" runat="server" height="480px" width="800cm" Font-Names="Verdana" Font-Size="8pt" Visible="False">
            <LocalReport ReportPath="CCM\CCMData5.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="CCMData5_TC_ORIGINALDATA_NO5" />
                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource2" Name="CCMData34_TC_ORIGINALDATA_NO3ANDNO4" />
                </DataSources>
            </LocalReport>
        </rsweb:reportviewer>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData"
            TypeName="CCMData5TableAdapters.TC_ORIGINALDATA_NO5TableAdapter" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}">
            <InsertParameters>
                <asp:Parameter Name="LOGTIME" Type="String" />
                <asp:Parameter Name="TEAM" Type="String" />
                <asp:Parameter Name="SHIFT" Type="String" />
                <asp:Parameter Name="LOG_PER" Type="String" />
                <asp:Parameter Name="HEADFURNACE" Type="String" />
                <asp:Parameter Name="CASTINGNO" Type="String" />
                <asp:Parameter Name="STEEL_GRADE" Type="String" />
                <asp:Parameter Name="HEATID" Type="String" />
                <asp:Parameter Name="BLOCK_SIZE" Type="String" />
                <asp:Parameter Name="LADLEID" Type="String" />
                <asp:Parameter Name="LADLE_GRADE" Type="String" />
                <asp:Parameter Name="STEEL_WEIGHT" Type="Decimal" />
                <asp:Parameter Name="TEMP" Type="Decimal" />
                <asp:Parameter Name="STEELTEMPUPTO" Type="Decimal" />
                <asp:Parameter Name="ARRIVAL_TIME" Type="DateTime" />
                <asp:Parameter Name="CASTING_START_TIME" Type="DateTime" />
                <asp:Parameter Name="CASTING_STOP_TIME" Type="DateTime" />
                <asp:Parameter Name="REMAINWEIGHT" Type="Decimal" />
                <asp:Parameter Name="HOLDTIME" Type="Decimal" />
                <asp:Parameter Name="AUTOFLOW" Type="Decimal" />
                <asp:Parameter Name="UNAUTOFLOW_REASON" Type="String" />
                <asp:Parameter Name="PROTECTION" Type="Decimal" />
                <asp:Parameter Name="UNPROTECTION_REASON" Type="String" />
                <asp:Parameter Name="OFF_LADLE_TIME" Type="DateTime" />
                <asp:Parameter Name="TUNDISH_CARID" Type="String" />
                <asp:Parameter Name="TUNDISHID" Type="String" />
                <asp:Parameter Name="p1" Type="String" />
                <asp:Parameter Name="THICKNESS" Type="Decimal" />
                <asp:Parameter Name="BOTTOM_TEMP" Type="Decimal" />
                <asp:Parameter Name="WALL_TEMP" Type="Decimal" />
                <asp:Parameter Name="CASTINGSTARTTIME1" Type="DateTime" />
                <asp:Parameter Name="CASTINGSTOPTIME1" Type="DateTime" />
                <asp:Parameter Name="CASTINGSTARTTIME2" Type="DateTime" />
                <asp:Parameter Name="CASTINGSTOPTIME2" Type="DateTime" />
                <asp:Parameter Name="CASTINGSTARTTIME3" Type="DateTime" />
                <asp:Parameter Name="CASTINGSTOPTIME3" Type="DateTime" />
                <asp:Parameter Name="CASTINGSTARTTIME4" Type="DateTime" />
                <asp:Parameter Name="CASTINGSTOPTIME4" Type="DateTime" />
                <asp:Parameter Name="TUNDISHTEMP5" Type="Decimal" />
                <asp:Parameter Name="TUNDISHTEMP10" Type="Decimal" />
                <asp:Parameter Name="TUNDISHTEMP15" Type="Decimal" />
                <asp:Parameter Name="TUNDISHTEMP20" Type="Decimal" />
                <asp:Parameter Name="TUNDISHTEMP25" Type="Decimal" />
                <asp:Parameter Name="TUNDISHTEMP30" Type="Decimal" />
                <asp:Parameter Name="TUNDISHTEMP35" Type="Decimal" />
                <asp:Parameter Name="TUNDISHTEMP40" Type="Decimal" />
                <asp:Parameter Name="TUNDISHTEMP45" Type="Decimal" />
                <asp:Parameter Name="LADLESTOPTEMP" Type="Decimal" />
                <asp:Parameter Name="TUNDISHTEMPUPTO" Type="Decimal" />
                <asp:Parameter Name="SPEED1ST" Type="Decimal" />
                <asp:Parameter Name="SPEED2ND" Type="Decimal" />
                <asp:Parameter Name="SPEED3RD" Type="Decimal" />
                <asp:Parameter Name="SPEED4TH" Type="Decimal" />
                <asp:Parameter Name="SPEEDCHANGE" Type="String" />
                <asp:Parameter Name="STEELWEIGHT" Type="Decimal" />
                <asp:Parameter Name="TUNDISH_1ST_OFFICER" Type="String" />
                <asp:Parameter Name="TUNDISH_2ND_OFFICER" Type="String" />
                <asp:Parameter Name="TUNDISH_3RD_OFFICER" Type="String" />
                <asp:Parameter Name="TUNDISH_4TH_OFFICER" Type="String" />
                <asp:Parameter Name="LADLE_OPERATOR" Type="String" />
                <asp:Parameter Name="CONTROL_OPERATOR" Type="String" />
                <asp:Parameter Name="ELEC_MIX_CURRENT_1ST" Type="Decimal" />
                <asp:Parameter Name="ELEC_MIX_CURRENT_2ND" Type="Decimal" />
                <asp:Parameter Name="ELEC_MIX_CURRENT_3RD" Type="Decimal" />
                <asp:Parameter Name="ELEC_MIX_CURRENT_4TH" Type="Decimal" />
                <asp:Parameter Name="ELEC_MIX_FREQ_1ST" Type="Decimal" />
                <asp:Parameter Name="ELEC_MIX_FREQ_2ND" Type="Decimal" />
                <asp:Parameter Name="ELEC_MIX_FREQ_3RD" Type="Decimal" />
                <asp:Parameter Name="ELEC_MIX_FREQ_4TH" Type="Decimal" />
                <asp:Parameter Name="DIRECTION_ELECTMIX" Type="Decimal" />
                <asp:Parameter Name="COOLING_METERNO" Type="Decimal" />
                <asp:Parameter Name="TEMP_IN_COOLING" Type="Decimal" />
                <asp:Parameter Name="COOLING_PRESS" Type="Decimal" />
                <asp:Parameter Name="COOLING_EXCEPTION" Type="String" />
                <asp:Parameter Name="IN_TEMP" Type="Decimal" />
                <asp:Parameter Name="FLOW_1ST" Type="Decimal" />
                <asp:Parameter Name="FLOW_2ND" Type="Decimal" />
                <asp:Parameter Name="FLOW_3RD" Type="Decimal" />
                <asp:Parameter Name="FLOW_4TH" Type="Decimal" />
                <asp:Parameter Name="OSCILLATE_METERNO" Type="Decimal" />
                <asp:Parameter Name="PROTECT_DREG_TYPE" Type="String" />
                <asp:Parameter Name="PROTECT_DREG_FAC" Type="String" />
                <asp:Parameter Name="BATCH_ID" Type="String" />
                <asp:Parameter Name="COVER_TYPE" Type="String" />
                <asp:Parameter Name="COVER_FAC" Type="String" />
                <asp:Parameter Name="LENGTH" Type="Decimal" />
                <asp:Parameter Name="BLOOM_COUNT" Type="Decimal" />
                <asp:Parameter Name="REASON_HOLT_CASTING" Type="String" />
                <asp:Parameter Name="NOTE" Type="String" />
                <asp:Parameter Name="DIRECTION_ELECTMIX1" Type="Decimal" />
                <asp:Parameter Name="DIRECTION_ELECTMIX2" Type="Decimal" />
                <asp:Parameter Name="DIRECTION_ELECTMIX3" Type="Decimal" />
                <asp:Parameter Name="DIRECTION_ELECTMIX4" Type="Decimal" />
                <asp:Parameter Name="TEMP_DIF_MOLD1" Type="Decimal" />
                <asp:Parameter Name="TEMP_DIF_MOLD2" Type="Decimal" />
                <asp:Parameter Name="TEMP_DIF_MOLD3" Type="Decimal" />
                <asp:Parameter Name="TEMP_DIF_MOLD4" Type="Decimal" />
                <asp:Parameter Name="SOFT_PRESS_FLAG1" Type="String" />
                <asp:Parameter Name="SOFT_PRESS_FLAG2" Type="String" />
                <asp:Parameter Name="SOFT_PRESS_FLAG3" Type="String" />
                <asp:Parameter Name="SOFT_PRESS_FLAG4" Type="String" />
                <asp:Parameter Name="CCMID" Type="String" />
                <asp:Parameter Name="TUNDISH_HEATCOUNT" Type="String" />
                <asp:Parameter Name="EXCEPT" Type="String" />
            </InsertParameters>
        </asp:ObjectDataSource>
    </form>
</body>
</html>
