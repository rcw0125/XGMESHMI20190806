<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AOD_OriginalData.aspx.cs" Inherits="Default2" %>

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
                    <asp:ListItem Value="1">AOD炉</asp:ListItem>
                    
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
            <LocalReport ReportPath="AOD\rptAODData.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="dsAOD_TS_AOD_ORIGINALDATA" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
        <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="GetData"
            TypeName="DataSet1TableAdapters.TS_ORIGINALDATATableAdapter"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetData"
            TypeName="DataSet1TableAdapters.TP_REHEAT_ACCOUNTTableAdapter"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="Fill"
            TypeName="dsAODTableAdapters.dsAOD_TS_AOD_ORIGINALDATA" OldValuesParameterFormatString="original_{0}">
            <SelectParameters>
                <asp:Parameter Name="dataTable" Type="Object" />
            </SelectParameters>
        </asp:ObjectDataSource>
         &nbsp;
    
    </div>
    </form>
</body>
</html>
