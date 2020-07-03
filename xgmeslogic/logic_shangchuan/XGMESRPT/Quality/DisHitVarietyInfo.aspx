<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DisHitVarietyInfo.aspx.cs" Inherits="Quality_Waste" %>

<%@ Register Src="../userCtl/ucDate.ascx" TagName="ucDate" TagPrefix="uc1" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    
</head>
<body>
    <form id="form1" runat="server">
        <table align="center" bgcolor="#00cccc" border="1" bordercolor="#996633" cellpadding="0"
            cellspacing="0" style="width: 98%; height: 1px">
            <tr>
                <td style="width: 40px; height: 13px; text-align: center">
                    <span style="font-size: 11pt">
                    日期:</span></td>
                <td style="width: 40px; height: 13px; font-size: 12pt;">
                    <asp:DropDownList ID="ddlYear" runat="server" AutoPostBack="True" BackColor="#C0C0FF"
                        OnSelectedIndexChanged="ddlYear_SelectedIndexChanged" Width="70px">
                    </asp:DropDownList></td>
                <td style="height: 13px; text-align: center; font-size: 12pt;" width="40">
                    <span style="font-size: 11pt">
                    年</span></td>
                <td style="width: 40px; height: 13px; font-size: 12pt;">
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
                <td nowrap="nowrap" style="width: 40px; height: 13px; text-align: center; font-size: 12pt;" width="52">
                    <span style="font-size: 11pt">
                    月</span></td>
                <td style="width: 40px; height: 13px">
                    <asp:DropDownList ID="ddlDay" runat="server" BackColor="#C0C0FF" Width="50px">
                    </asp:DropDownList></td>
                <td style="width: 24px; height: 13px; text-align: center">
                    <span style="font-size: 11pt">
                    日</span></td>
                <td style="width: 82px; height: 13px; text-align: center"><asp:DropDownList ID="Quality" runat="server" BackColor="#C0C0FF" Width="205px">
                    <asp:ListItem Value="3">未命中品种钢内控明细</asp:ListItem>
                    <%--<asp:ListItem Value="0">炼钢厂甩废报表</asp:ListItem>
                    <asp:ListItem Value="1">车间甩废报表</asp:ListItem>--%>
                </asp:DropDownList></td>
                <td style="width: 78px; height: 13px">
                    <asp:Button ID="btnQuery" runat="server" Height="24px" OnClick="btnQuery_Click" Text="查询"
                        Width="72px" /></td>
            </tr>
        </table>
        &nbsp;<asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
&nbsp;<rsweb:reportviewer id="ReportViewer1" runat="server" font-names="Verdana" font-size="8pt"
            height="680px" visible="False" width="800cm">
            <LocalReport ReportPath="Quality\DisHitVarietyInfo.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="dsWaste" />
                </DataSources>
            </LocalReport>
        </rsweb:reportviewer>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}"
            SelectMethod="GetData" TypeName="dsDisHitVarietyInfoTableAdapters.TQ_DISHIT_VARIETY_INFOTableAdapter">
        </asp:ObjectDataSource>
    </form>
</body>
</html>
