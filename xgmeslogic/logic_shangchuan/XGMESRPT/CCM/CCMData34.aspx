<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CCMData34.aspx.cs" Inherits="CCM_CCMData34" %>

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
            cellspacing="0" style="width: 100%; height: 1px">
            <tr>
                <td style="width: 33px; height: 20px; text-align: center">
                    <span style="font-size: 11pt">
                    日期:</span></td>
                <td style="width: 63px; height: 20px; text-align: center">
                    <asp:DropDownList ID="ddlStartYear" runat="server" AutoPostBack="True" BackColor="#C0C0FF"
                        OnSelectedIndexChanged="ddlYear_SelectedIndexChanged" Width="70px">
                    </asp:DropDownList></td>
                <td style="width: 11px; height: 20px; text-align: center">
                    <span style="font-size: 11pt">年</span></td>
                <td style="width: 45px; height: 20px; text-align: center">
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
                <td style="width: 18px; height: 20px; text-align: center">
                    <span style="font-size: 11pt">月</span></td>
                <td style="width: 35px; height: 20px; text-align: center">
                    <asp:DropDownList ID="ddlStartDay" runat="server" BackColor="#C0C0FF" Width="50px">
                    </asp:DropDownList></td>
                <td style="width: 17px; height: 20px; text-align: center">
                    <span style="font-size: 11pt">日</span></td>
                <td style="width: 11px; height: 20px; text-align: center">
                    －</td>
                <td style="width: 29px; height: 20px">
                    <asp:DropDownList ID="ddlYear" runat="server" AutoPostBack="True" BackColor="#C0C0FF"
                        OnSelectedIndexChanged="ddlYear_SelectedIndexChanged" Width="70px">
                    </asp:DropDownList></td>
                <td style="height: 20px; text-align: center; width: 21px;">
                    <span style="font-size: 11pt">
                    年</span></td>
                <td style="width: 35px; height: 20px">
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
                <td nowrap="nowrap" style="width: 17px; height: 20px; text-align: center">
                    <span style="font-size: 11pt">
                    月</span></td>
                <td style="width: 41px; height: 20px">
                    <asp:DropDownList ID="ddlDay" runat="server" BackColor="#C0C0FF" Width="50px">
                    </asp:DropDownList></td>
                <td style="width: 14px; height: 20px; text-align: center">
                    <span style="font-size: 11pt">
                    日</span></td>
                <td style="width: 38px; height: 20px; text-align: center">
                    <span style="font-size: 11pt">
                    &nbsp;机别</span></td>
                <td style="width: 60px; height: 20px; text-align: left">
                    <asp:DropDownList ID="Quality" runat="server" BackColor="#C0C0FF" Width="68px">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem Value="S63">3#机</asp:ListItem>
                        <asp:ListItem Value="S64">4#机</asp:ListItem>
                    </asp:DropDownList></td>
                <td style="width: 36px; height: 20px; text-align: center">
                    <span style="font-size: 11pt">班别</span></td>
                <td style="width: 35px; height: 20px; text-align: left">
                    <asp:DropDownList ID="TeamDropDownList" runat="server" BackColor="#C0C0FF" Width="68px">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem Value="1">甲班</asp:ListItem>
                        <asp:ListItem Value="2">乙班</asp:ListItem>
                        <asp:ListItem Value="3">丙班</asp:ListItem>
                        <asp:ListItem Value="4">丁班</asp:ListItem>
                    </asp:DropDownList></td>
                <td style="height: 20px; width: 17px;">
                    <asp:Button ID="btnQuery" runat="server" Height="24px" OnClick="btnQuery_Click" Text="查询"
                        Width="46px" /></td>
            </tr>
        </table>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <rsweb:reportviewer id="ReportViewer1" runat="server" height="820px" width="480cm" Font-Names="Verdana" Font-Size="8pt" Visible="False">
            <LocalReport ReportPath="CCM\CCMData34.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="CCMData34_TC_ORIGINALDATA_NO3ANDNO4" />
                </DataSources>
            </LocalReport>
        </rsweb:reportviewer>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData"
            TypeName="CCMData34TableAdapters.TC_ORIGINALDATA_NO3ANDNO4TableAdapter"></asp:ObjectDataSource>
        <br />
    </form>
</body>
</html>
