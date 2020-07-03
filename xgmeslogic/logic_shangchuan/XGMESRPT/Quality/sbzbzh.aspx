<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sbzbzh.aspx.cs" Inherits="sbzbzh" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<%@ Register Src="../userCtl/ucDate.ascx" TagName="ucDate" TagPrefix="uc1" %>
<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            height: 12px;
            width: 110px;
        }
        .style2
        {
            height: 12px;
            width: 46px;
        }
        .style3
        {
            height: 12px;
            width: 128px;
        }
        .style4
        {
            height: 10px;
            width: 53px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table align="center" bgcolor="#00cccc" border="1"  cellpadding="0"
            cellspacing="0" style="width: 98%; height: 1px">
            <tr>
                <td style="width: 40px; height: 10px; text-align: center">
                    <span style="font-size: 11pt">
                    日期:</span></td>
                <td class="style4">
                    <asp:DropDownList ID="ddlStartYear" runat="server" BackColor="#C0C0FF" 
                        Width="60px">
                    </asp:DropDownList></td>
                <td style="height: 10px; text-align: center; width: 20px;">
                    <span style="font-size: 11pt">
                    年</span></td>
                <td style="width: 13px; height: 12px; text-align: center">
                    <asp:DropDownList ID="ddlStartMonth" runat="server" BackColor="#C0C0FF"
                       
                        Width="53px" Height="16px">
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
                <td style="text-align: center" class="style2">
                    &nbsp;</td>
                <td class="style1">
                    第
                    <asp:DropDownList ID="ddlzhou" runat="server" BackColor="#C0C0FF"
                       
                        Width="53px" Height="16px">
                        <asp:ListItem Value="1">1</asp:ListItem>
                        <asp:ListItem Value="2">2</asp:ListItem>
                        <asp:ListItem Value="3">3</asp:ListItem>
                        <asp:ListItem Value="4">4</asp:ListItem>
                        <asp:ListItem Value="5">5</asp:ListItem>            
                    </asp:DropDownList>&nbsp;周</td>
                <td class="style3">
                    &nbsp;</td>
                <td style="width: 231px; height: 10px; text-align: center">
                    &nbsp;</td>
                <td style="width: 78px; height: 10px">
                    <asp:Button ID="btnQuery" runat="server" Height="24px" OnClick="btnQuery_Click" Text="查询"
                        Width="72px" /></td>
            </tr>
        </table>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Height="778px" 
            Visible="False" Width="2278px" Font-Names="Verdana" Font-Size="8pt" 
            SizeToReportContent="True" InteractiveDeviceInfos="(集合)" 
            WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt">
            <LocalReport ReportPath="Quality\sbdjzb.rdlc">
            </LocalReport>
        </rsweb:ReportViewer>
        <%-- <asp:ListItem Value="2">综合办</asp:ListItem>--%>        <%--<asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetData"
            TypeName="dsBOFEleDisQualityTableAdapters.TQ_BOF_ELE_DISQUALITYTableAdapter" OldValuesParameterFormatString="original_{0}">
        </asp:ObjectDataSource>--%>
            
    </form>
</body>
</html>
