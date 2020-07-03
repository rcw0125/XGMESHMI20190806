<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MonthPlanInput.aspx.cs" Inherits="Plant_MonthPlanInput" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table id="TABLE1" onclick="return TABLE1_onclick()" style="left: 105px; width: 466px;
            border-top-style: none; border-right-style: none; border-left-style: none; position: absolute;
            top: 69px; height: 183px; border-bottom-style: none">
            <tr>
                <td align="right" colspan="6" style="font-weight: bold; text-align: center">
                    月计划钢坯数据录入</td>
            </tr>
            <tr>
                <td align="right" colspan="3" style="width: 120px; text-align: right">
                </td>
                <td colspan="3" style="width: 320px; text-align: left">
                </td>
            </tr>
            <tr>
                <td align="right" colspan="6" style="text-align: left">
                    &nbsp;&nbsp;<table align="center" border="1" cellpadding="0" cellspacing="0" style="width: 98%;
                        height: 1px">
                        <tr>
                            <td align="center" style="width: 105px; text-align: center">
                            </td>
                            <td align="center" style="width: 40px; text-align: center">
                                日期:</td>
                            <td align="center" style="width: 40px">
                                <asp:DropDownList ID="ddlYear" runat="server" AutoPostBack="True" BackColor="White" Width="70px">
                                </asp:DropDownList></td>
                            <td align="center" style="width: 24px; text-align: center">
                                年</td>
                            <td align="center" style="width: 40px">
                                <asp:DropDownList ID="ddlMonth" runat="server" AutoPostBack="True" BackColor="White" Width="50px">
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
                            <td align="center" colspan="3" style="text-align: center">
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td align="right" colspan="3" style="width: 120px; height: 26px; text-align: right">
                </td>
                <td colspan="3" style="width: 320px; height: 26px; text-align: left">
                </td>
            </tr>
            <tr>
                <td align="right" colspan="3" style="width: 120px; height: 26px; text-align: right">
                    <asp:Label ID="Label13" runat="server" Text="常规钢(t)："></asp:Label></td>
                <td align="left" colspan="3" style="width: 320px; height: 26px; text-align: left">
                    <asp:TextBox ID="txtFSteel" runat="server"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtFSteel"
                        Display="Dynamic" ErrorMessage="数据类型错误!" MaximumValue="10000000" MinimumValue="0"
                        Type="Double"></asp:RangeValidator></td>
            </tr>
            <tr>
                <td align="right" colspan="3" style="width: 120px; height: 26px; text-align: right">
                    <asp:Label ID="Label14" runat="server" Text="精炼钢(t)："></asp:Label></td>
                <td align="left" colspan="3" style="width: 320px; height: 26px; text-align: left">
                    <asp:TextBox ID="txtPSteel" runat="server"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtPSteel"
                        Display="Dynamic" ErrorMessage="数据类型错误!" MaximumValue="10000000" MinimumValue="0"
                        Type="Double"></asp:RangeValidator></td>
            </tr>
            <tr>
                <td align="right" colspan="3" style="width: 120px; height: 26px; text-align: right">
                    <asp:Label ID="Label1" runat="server" Text="大方坯(t)："></asp:Label></td>
                <td align="left" colspan="3" style="width: 320px; height: 26px; text-align: left">
                    <asp:TextBox ID="txtJSteel" runat="server"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="txtJSteel"
                        Display="Dynamic" ErrorMessage="数据类型错误!" MaximumValue="10000000" MinimumValue="0"
                        Type="Double"></asp:RangeValidator></td>
            </tr>
            <tr>
                <td align="right" colspan="6" style="height: 33px; text-align: center">
                    <asp:Button ID="btnSaveData" runat="server" OnClick="btnSaveData_Click" Text="保存"
                        Width="56px" />
                    </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
