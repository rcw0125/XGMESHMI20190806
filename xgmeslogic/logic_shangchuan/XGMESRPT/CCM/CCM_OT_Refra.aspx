<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CCM_OT_Refra.aspx.cs" Inherits="CCM_CCM_OT_Refra" %>

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
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
</head>
<body style="font-size: 12pt">
    <form id="form1" runat="server">
    <div>
        <table align="center" bgcolor="#00cccc" border="1" bordercolor="#996633" cellpadding="0"
            cellspacing="0" style="width: 98%; height: 1px; position: static;">
            <tr>
                <td style="width: 36px; height: 28px; text-align: center">
                    <span><span style="font-size: 11pt"><span>日期</span>:</span></span></td>
                <td style="height: 28px">
                    <asp:DropDownList ID="ddlYear" runat="server" AutoPostBack="True" BackColor="#C0C0FF"
                        OnSelectedIndexChanged="ddlYear_SelectedIndexChanged" Width="60px">
                    </asp:DropDownList></td>
                <td style="height: 28px; text-align: center">
                    <span style="font-size: 11pt">年</span></td>
                <td style="height: 28px">
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
                <td nowrap="nowrap" style="height: 28px; text-align: center">
                    <span style="font-size: 11pt">月</span></td>
                <td style="height: 28px">
                    <asp:DropDownList ID="ddlDay" runat="server" BackColor="#C0C0FF" Width="40px">
                    </asp:DropDownList></td>
                <td style="height: 28px; text-align: center">
                    <span style="font-size: 11pt">日</span></td>
                <td style="height: 28px; text-align: center">
                    －</td>
                <td style="height: 28px; text-align: center; width: 68px;">
                    <asp:DropDownList ID="ddlEndYear" runat="server" AutoPostBack="True" BackColor="#C0C0FF"
                        OnSelectedIndexChanged="ddlEndYear_SelectedIndexChanged" Width="60px">
                    </asp:DropDownList></td>
                <td style="height: 28px; text-align: center">
                    <span style="font-size: 11pt">年</span></td>
                <td style="height: 28px; text-align: center">
                    <asp:DropDownList ID="ddlEndMonth" runat="server" AutoPostBack="True" BackColor="#C0C0FF"
                        OnSelectedIndexChanged="ddlEndMonth_SelectedIndexChanged" Width="40px">
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
                <td style="height: 28px; text-align: center">
                    <span style="font-size: 11pt">月</span></td>
                <td style="height: 28px; text-align: center">
                    <asp:DropDownList ID="ddlEndDay" runat="server" BackColor="#C0C0FF" Width="40px">
                    </asp:DropDownList></td>
                <td style="height: 28px; text-align: center">
                    <span style="font-size: 11pt">日</span></td>
                <td style="width: 20px; height: 28px; text-align: center">
                </td>
                <td style="width: 93px; height: 28px; text-align: center">
                    <span style="font-size: 11pt">
                    <span>铸机号</span>：</span></td>
                <td style="height: 28px; text-align: center">
                    <asp:DropDownList ID="ddlCCMID" runat="server" BackColor="#C0C0FF">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem Value="S61">1#铸机</asp:ListItem>
                        <asp:ListItem Value="S62">2#铸机</asp:ListItem>
                    </asp:DropDownList></td>
                <td style="width: 76px; height: 28px; text-align: center">
                </td>
                <td style="width: 86px; height: 28px">
                    <asp:Button ID="btnQuery" runat="server" Height="24px" OnClick="btnQuery_Click" Text="查询"
                        Width="72px" /></td>
            </tr>
        </table>
    
    </div>
        <cr:crystalreportviewer id="CrystalReportViewer1" runat="server" autodatabind="true"
              HasZoomFactorList="False" EnableDatabaseLogonPrompt="False" EnableDrillDown="False" EnableParameterPrompt="False" EnableTheming="False"></cr:crystalreportviewer>
    </form>
</body>
</html>
