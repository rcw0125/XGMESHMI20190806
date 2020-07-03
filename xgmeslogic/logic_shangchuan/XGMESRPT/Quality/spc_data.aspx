<%@ Page Language="C#" AutoEventWireup="true" CodeFile="spc_data.aspx.cs" Inherits="Default2" %>

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
                <td style="width: 35px; height: 12px; text-align: center">
                    <asp:DropDownList ID="ddlStartYear" runat="server" AutoPostBack="True" BackColor="#C0C0FF"
                        OnSelectedIndexChanged="ddlYear_SelectedIndexChanged" Width="78px">
                    </asp:DropDownList></td>
                <td style="width: 22px; height: 12px; text-align: center">
                    <span style="font-size: 11pt">年</span></td>
                <td style="width: 16px; height: 12px; text-align: center">
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
                <td style="width: 19px; height: 12px; text-align: center">
                    <span style="font-size: 11pt">月</span></td>
                <td style="width: 35px; height: 12px; text-align: center">
                    <asp:DropDownList ID="ddlStartDay" runat="server" BackColor="#C0C0FF" Width="51px">
                    </asp:DropDownList></td>
                <td style="width: 11px; height: 12px; text-align: center">
                    <span style="font-size: 11pt">日</span></td>
                <td style="width: 21px; height: 12px; text-align: center">
                    －</td>
                <td style="width: 33px; height: 12px">
                    <asp:DropDownList ID="ddlYear" runat="server" AutoPostBack="True" BackColor="#C0C0FF"
                        OnSelectedIndexChanged="ddlYear_SelectedIndexChanged" Width="78px">
                    </asp:DropDownList></td>
                <td style="height: 12px; text-align: center; width: 13px;">
                    <span style="font-size: 11pt">
                    年</span></td>
                <td style="width: 47px; height: 12px">
                    <asp:DropDownList ID="ddlMonth" runat="server" AutoPostBack="True" BackColor="#C0C0FF"
                        OnSelectedIndexChanged="ddlMonth_SelectedIndexChanged" Width="47px">
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
                <td style="width: 46px; height: 12px">
                    <asp:DropDownList ID="ddlDay" runat="server" BackColor="#C0C0FF" Width="46px">
                    </asp:DropDownList></td>
                <td style="width: 19px; height: 12px; text-align: center">
                    <span style="font-size: 11pt">
                    日</span></td>
                <td style="width: 36px; height: 12px; text-align: center">
                    <span style="font-size: 11pt"></span></td>
                <td style="width: 50px; height: 12px; text-align: center"></td>
                <td style="height: 12px; text-align: center; width: 179px;">
                    <span style="font-size: 11pt">项目：<asp:DropDownList ID="DropDownList2" runat="server"
                        Width="94px">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>终点C</asp:ListItem>
                        <asp:ListItem>终点P</asp:ListItem>
                        <asp:ListItem>进站C</asp:ListItem>
                        <asp:ListItem>进站P</asp:ListItem>
                        <asp:ListItem>成品P</asp:ListItem>
                        <asp:ListItem>出钢量</asp:ListItem>
                        <asp:ListItem>出钢氧</asp:ListItem>
                        <asp:ListItem>离站C</asp:ListItem>
                        <asp:ListItem>精炼渣Al2O3</asp:ListItem>
                        <asp:ListItem>精炼渣R</asp:ListItem>
                        <asp:ListItem>软吹时间</asp:ListItem>
                        <asp:ListItem>软吹开始温度</asp:ListItem>
                        <asp:ListItem>C增量</asp:ListItem>
                        <asp:ListItem>大包温降</asp:ListItem>
                        <asp:ListItem>钙线喂入量</asp:ListItem>
                        <asp:ListItem>RH离站C</asp:ListItem>
                        <asp:ListItem>中包温度</asp:ListItem>
                        <asp:ListItem>中包开浇重量</asp:ListItem>
                    </asp:DropDownList></span></td>
                <td style="width: 96px; height: 12px; text-align: center">
                    <asp:Button ID="btnQuery" runat="server" Height="24px" OnClick="btnQuery_Click" Text="查询"
                        Width="72px" /></td>
                <td style="width: 37px; height: 12px">
                    </td>
            </tr>
        </table>
        <br />
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt"
            Height="480px" Visible="False" Width="800cm">
            <LocalReport ReportPath="Quality\spc.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource4" Name="spc_SPC_DATA" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
        <asp:ObjectDataSource ID="ObjectDataSource4" runat="server" SelectMethod="GetData"
            TypeName="spcTableAdapters.SPC_DATATableAdapter"></asp:ObjectDataSource>
        &nbsp; &nbsp; &nbsp;
    
    </div>
    </form>
</body>
</html>
