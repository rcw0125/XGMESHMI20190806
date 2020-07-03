<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cost_Reprot.aspx.cs" Inherits="BOF_Cost_Reprot" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <script language="JavaScript" type = "text/javascript"> 
    <!-- 
    function openwin() { window.open ("CostQuery.aspx", "Default", "height=550px, width=237px, toolbar=no, menubar=no, scrollbars=no, resizable=no, location=no, status=no") } 
    --> 
    </script>

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
<body>
    <form id="form1" runat="server">
        <table align="center" bgcolor="#00cccc" border="1" bordercolor="#996633" cellpadding="0"
            cellspacing="0" style="width: 98%; height: 1px">
            <tr>
                <td style="width: 40px; height: 28px; text-align: center">
                    <span style="font-size: 11pt">日期:</span></td>
                <td style="width: 40px; height: 28px">
                    <asp:DropDownList ID="ddlYear" runat="server" AutoPostBack="True" BackColor="#C0C0FF"
                        OnSelectedIndexChanged="ddlYear_SelectedIndexChanged" Width="70px">
                    </asp:DropDownList></td>
                <td style="width: 35px; height: 28px; text-align: center">
                    <span style="font-size: 11pt">年</span></td>
                <td style="width: 40px; height: 28px">
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
                <td nowrap="nowrap" style="width: 28px; height: 28px; text-align: center">
                    <span style="font-size: 11pt">月</span></td>
                <td style="width: 40px; height: 28px">
                    <asp:DropDownList ID="ddlDay" runat="server" BackColor="#C0C0FF" Width="50px">
                    </asp:DropDownList></td>
                <td style="width: 24px; height: 28px; text-align: center">
                    <span style="font-size: 11pt">日</span></td>
                <td style="width: 90px; height: 28px; text-align: center">
                    成本中心:</td>
                <td style="width: 72px; height: 28px; text-align: center">
                    <asp:DropDownList ID="ddlCostCenter" runat="server" Width="72px" AutoPostBack="True" OnSelectedIndexChanged="ddlCostCenter_SelectedIndexChanged">
                        <asp:ListItem Value="S63">3#铸机</asp:ListItem>
                        <asp:ListItem Value="S64">4#铸机</asp:ListItem>
                        <asp:ListItem Value="S65">5#铸机</asp:ListItem>
                        <asp:ListItem Value="S66">6#铸机</asp:ListItem>
                        <asp:ListItem Value="S67">7#铸机</asp:ListItem>
                    </asp:DropDownList></td>
                <td style="width: 48px; height: 28px; text-align: center">
                    钢种:</td>
                <td style="width: 114px; height: 28px; text-align: center">
                    <asp:DropDownList ID="ddlSteelGrade" runat="server" Width="118px" >
                    </asp:DropDownList></td>
                <td style="width: 93px; height: 28px; text-align: center">
                    价格类型:</td>
                <td style="width: 114px; height: 28px; text-align: center">
                    <asp:DropDownList ID="ddlPriceType" runat="server">
                        <asp:ListItem Selected="True" Value="1">年度预算价</asp:ListItem>
                        <asp:ListItem Value="2">月度预算价</asp:ListItem>
                        <asp:ListItem Value="3">最新预算价</asp:ListItem>
                    </asp:DropDownList></td>
                <td style="width: 78px; height: 28px">
                    <asp:Button ID="btnQuery" runat="server" Height="24px" OnClick="btnQuery_Click" Text="查询"
                        Width="72px" /></td>
            </tr>
        </table>
        <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="True"
              EnableDatabaseLogonPrompt="False" EnableDrillDown="False"
            EnableParameterPrompt="False" EnableTheming="False" HasZoomFactorList="False"
            Height="50px" Width="350px" />
    </form>
</body>
</html>
