<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmLFData4.aspx.cs" Inherits="LF_frmLFData4" %>

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
    
    </div>
        &nbsp;<table align="center" bgcolor="#00cccc" border="1" bordercolor="#996633" cellpadding="0"
            cellspacing="0" style="width: 99%; height: 1px" id="TABLE1">
            <tr>
                <td style="width: 33px; height: 18px; text-align: left">
                    <span style="font-size: 11pt">
                    日期:</span></td>
                <td style="height: 18px; text-align: center; width: 7px;"><asp:DropDownList ID="ddlStartYear" runat="server" BackColor="#C0C0FF" Width="56px" AutoPostBack="True" OnSelectedIndexChanged="ddlYear_SelectedIndexChanged">
                </asp:DropDownList></td>
                <td style="width: 17px; height: 18px; text-align: center">
                    <span style="font-size: 11pt">年</span></td>
                <td style="width: 37px; height: 18px; text-align: center">
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
                <td style="width: 9px; height: 18px; text-align: center">
                    <span style="font-size: 11pt">月</span></td>
                <td style="width: 28px; height: 18px; text-align: center">
                    <asp:DropDownList ID="ddlStartDay" runat="server" BackColor="#C0C0FF" Width="40px">
                    </asp:DropDownList></td>
                <td style="width: 17px; height: 18px; text-align: center">
                    <span style="font-size: 11pt">日</span></td>
                <td style="width: 6px; height: 18px; text-align: center">
                    －</td>
                <td style="width: 5px; height: 18px">
                    <asp:DropDownList ID="ddlYear" runat="server" AutoPostBack="True" BackColor="#C0C0FF"
                        OnSelectedIndexChanged="ddlYear_SelectedIndexChanged" Width="60px">
                    </asp:DropDownList></td>
                <td style="height: 18px; text-align: center; width: 8px;">
                    <span style="font-size: 11pt">
                    年</span></td>
                <td style="width: 16px; height: 18px">
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
                <td nowrap="nowrap" style="width: 8px; height: 18px; text-align: center">
                    <span style="font-size: 11pt">
                    月</span></td>
                <td style="height: 18px; width: 28px;">
                    <asp:DropDownList ID="ddlDay" runat="server" BackColor="#C0C0FF" Width="40px">
                    </asp:DropDownList></td>
                <td style="width: 18px; height: 18px; text-align: center">
                    <span style="font-size: 11pt">
                    日</span></td>
                <td style="width: 26px; height: 18px; text-align: center">
                    <span style="font-size: 10pt">炉座</span></td>
                <td style="width: 4px; height: 18px; text-align: center">
                    <span style="font-size: 11pt"></span>
                    <asp:DropDownList ID="Quality" runat="server" BackColor="#C0C0FF" Width="50px">
                        <asp:ListItem Value="4" Selected="True">4#LF炉</asp:ListItem>
                    </asp:DropDownList></td>
                <td style="width: 26px; height: 18px; text-align: center">
                    <span style="font-size: 10pt">班别</span></td>
                <td style="width: 1px; height: 18px; text-align: center">
                    <asp:DropDownList ID="TeamDropDownList" runat="server" BackColor="#C0C0FF" Width="50px">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem Value="1">甲班</asp:ListItem>
                        <asp:ListItem Value="2">乙班</asp:ListItem>
                        <asp:ListItem Value="3">丙班</asp:ListItem>
                        <asp:ListItem Value="4">丁班</asp:ListItem>
                    </asp:DropDownList></td>
                <td style="width: 13px; height: 18px">
                    <asp:Button ID="btnQuery" runat="server" Height="24px" OnClick="btnQuery_Click" Text="查询"
                        Width="42px" /></td>
            </tr>
        </table>
        <span style="font-size: 11pt"></span>&nbsp; 
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <rsweb:ReportViewer ID="ReportViewer1"  runat="server" Font-Names="Verdana" Font-Size="8pt"
            Height="619px" Visible="False" Width="460cm" SizeToReportContent="True">
            <LocalReport ReportPath="LF\rptLFData4.rdlc" EnableExternalImages="True">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="dsLF_TR_LF_ORIGINALDATA" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData"
            TypeName="dsLFTableAdapters.TR_LF_ORIGINALDATATableAdapter"></asp:ObjectDataSource>
    </form>
</body>
</html>
