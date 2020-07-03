<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CCMData12.aspx.cs" Inherits="CCM_CCMData12" %>

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
                <td style="width: 36px; height: 25px; text-align: left">
                    <span style="font-size: 11pt">
                    日期:</span></td>
                <td style="width: 51px; height: 25px; text-align: left">
                    <asp:DropDownList ID="ddlStartYear" runat="server" AutoPostBack="True" BackColor="#C0C0FF"
                        OnSelectedIndexChanged="ddlYear_SelectedIndexChanged" Width="70px">
                    </asp:DropDownList></td>
                <td style="width: 19px; height: 25px; text-align: left">
                    <span style="font-size: 11pt">年</span></td>
                <td style="width: 47px; height: 25px; text-align: left">
                    <asp:DropDownList ID="ddlStartMonth" runat="server" AutoPostBack="True" BackColor="#C0C0FF"
                        OnSelectedIndexChanged="ddlStartMonth_SelectedIndexChanged" Width="50px">
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
                <td style="width: 16px; height: 25px; text-align: center">
                    <span style="font-size: 11pt">月</span></td>
                <td style="width: 34px; height: 25px; text-align: left">
                    <asp:DropDownList ID="ddlStartDay" runat="server" BackColor="#C0C0FF" Width="50px">
                    </asp:DropDownList></td>
                <td style="width: 19px; height: 25px; text-align: center">
                    <span style="font-size: 11pt">日</span></td>
                <td style="width: 12px; height: 25px; text-align: center">
                    －</td>
                <td style="width: 1px; height: 25px; text-align: left;">
                    <asp:DropDownList ID="ddlYear" runat="server" AutoPostBack="True" BackColor="#C0C0FF"
                        OnSelectedIndexChanged="ddlYear_SelectedIndexChanged" Width="70px">
                    </asp:DropDownList></td>
                <td style="height: 25px; text-align: left; width: 5px;">
                    <span style="font-size: 11pt">
                    年</span></td>
                <td style="width: 22px; height: 25px">
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
                <td nowrap="nowrap" style="width: 20px; height: 25px; text-align: center">
                    <span style="font-size: 11pt">
                    月</span></td>
                <td style="width: 25px; height: 25px">
                    <asp:DropDownList ID="ddlDay" runat="server" BackColor="#C0C0FF" Width="50px">
                    </asp:DropDownList></td>
                <td style="width: 17px; height: 25px; text-align: center">
                    <span style="font-size: 11pt">
                    日</span></td>
                <td style="width: 31px; height: 25px; text-align: center">
                    <span style="font-size: 11pt">
                    机别</span></td>
                <td style="width: 61px; height: 25px; text-align: center"><asp:DropDownList ID="Quality" runat="server" BackColor="#C0C0FF" Width="60px">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem Value="S61">1#机</asp:ListItem>
                    <asp:ListItem Value="S62">2#机</asp:ListItem>
                </asp:DropDownList></td>
                <td style="width: 43px; height: 25px; text-align: center">
                    <span style="font-size: 11pt">班别</span></td>
                <td style="width: 57px; height: 25px; text-align: center">
                    <asp:DropDownList ID="TeamDropDownList" runat="server" BackColor="#C0C0FF" Width="60px">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem Value="1">甲班</asp:ListItem>
                        <asp:ListItem Value="2">乙班</asp:ListItem>
                        <asp:ListItem Value="3">丙班</asp:ListItem>
                        <asp:ListItem Value="4">丁班</asp:ListItem>
                    </asp:DropDownList></td>
                <td style="width: 48px; height: 25px">
                    <asp:Button ID="btnQuery" runat="server" Height="24px" OnClick="btnQuery_Click" Text="查询"
                        Width="54px" /></td>
            </tr>
        </table>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <rsweb:reportviewer id="ReportViewer1" runat="server" height="360px" width="365cm" Font-Names="Verdana" Font-Size="8pt" Visible="False" SizeToReportContent="True">
            <LocalReport ReportPath="CCM\CCMData12.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="CCMData12_TC_ORIGINALDATA_NO1ANDNO2" />
                </DataSources>
            </LocalReport>
        </rsweb:reportviewer>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData"
            TypeName="CCMData34TableAdapters.TC_ORIGINALDATA_NO3ANDNO4TableAdapter"></asp:ObjectDataSource>
    </form>
</body>
</html>
