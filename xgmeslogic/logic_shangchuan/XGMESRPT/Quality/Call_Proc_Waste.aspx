<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Call_Proc_Waste.aspx.cs" Inherits="Quality_Call_Proc_Waste" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table id="TABLE1"  style="left: 105px; width: 466px;
            border-top-style: none; border-right-style: none; border-left-style: none; position: absolute;
            top: 69px; height: 183px; border-bottom-style: none">
            <tr>
                <td align="right" colspan="6" style="font-weight: bold; text-align: center">
                    甩废报表手动生成</td>
            </tr>
            <tr>
                <td align="right" colspan="3" style="width: 117px; text-align: right">
                </td>
                <td colspan="3" style="width: 320px; text-align: left">
                </td>
            </tr>
            <tr>
                <td align="right" colspan="6" style="text-align: left">
                    &nbsp;&nbsp;<table align="center" border="1" cellpadding="0" cellspacing="0" style="width: 98%;
                        height: 1px">
                        <tr>
                            <td align="center" style="width: 23px; text-align: center">
                            </td>
                            <td align="center" style="width: 40px; text-align: center">
                    日期:</td>
                            <td align="center" style="width: 40px">
                                <asp:DropDownList ID="ddlYear" runat="server" AutoPostBack="True" BackColor="White"
                                    OnSelectedIndexChanged="ddlYear_SelectedIndexChanged" Width="70px">
                                </asp:DropDownList></td>
                            <td align="center" style="width: 24px; text-align: center">
                    年</td>
                            <td align="center" style="width: 40px">
                                <asp:DropDownList ID="ddlMonth" runat="server" AutoPostBack="True" BackColor="White"
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
                            <td align="center" nowrap="nowrap" style="width: 24px; text-align: center">
                    月</td>
                            <td align="center" style="width: 40px">
                                <asp:DropDownList ID="ddlDay" runat="server" BackColor="White" Width="50px">
                                </asp:DropDownList></td>
                            <td align="center" style="width: 24px; text-align: center">
                    日</td>
                            <td align="center" style="width: 24px; text-align: center">
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td align="right" colspan="6" style="height: 33px; text-align: center">
                    <asp:Button ID="btnCallProc" runat="server" Height="24px" OnClick="btnCallProc_Click"
                        Text="生成报表" Width="72px" /></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
