<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmManualData.aspx.cs" Inherits="Plant_frmManualData" %>

<%@ Register Src="../userCtl/ucDate.ascx" TagName="ucDate" TagPrefix="uc1" %>

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
                    质量指标数据录入</td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: right; width: 117px;" align="right">
                </td>
                <td colspan="3" style="text-align: left; width: 320px;">
                </td>
            </tr>
            <tr>
                <td align="right" colspan="6" style="text-align: left">
                    &nbsp;&nbsp;<table align="center" border="1" 
                        cellpadding="0" cellspacing="0" style="width: 98%; height: 1px">
                        <tr>
                            <td style="width: 23px; text-align: center" align="center">
                            </td>
                            <td style="width: 40px; text-align: center" align="center">
                                日期:</td>
                            <td style="width: 40px;" align="center">
                                <asp:DropDownList ID="ddlYear" runat="server" AutoPostBack="True" BackColor="White"
                                    OnSelectedIndexChanged="ddlYear_SelectedIndexChanged" Width="70px">
                                </asp:DropDownList></td>
                            <td style="text-align: center; width: 24px;" align="center">
                                年</td>
                            <td style="width: 40px;" align="center">
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
                            <td nowrap="nowrap" style="width: 24px; text-align: center" align="center">
                                月</td>
                            <td style="width: 40px;" align="center">
                                <asp:DropDownList ID="ddlDay" runat="server" BackColor="White" Width="50px">
                                </asp:DropDownList></td>
                            <td style="width: 24px; text-align: center" align="center">
                                日</td>
                            <td style="width: 24px; text-align: center" align="center">
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td colspan="3" style="height: 26px; text-align: right; width: 117px;" align="right">
                </td>
                <td colspan="3" style="height: 26px; text-align: left; width: 320px;">
                </td>
            </tr>
            <tr>
                <td colspan="3" style="height: 26px; text-align: right; width: 117px;" align="right">
                    <asp:Label ID="Label13" runat="server" Text="号外炉数："></asp:Label></td>
                <td colspan="3" style="height: 26px; text-align: left; width: 320px;" align="left">
                    <asp:TextBox ID="txtOutNum" runat="server"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtOutNum"
                        Display="Dynamic" ErrorMessage="数据类型错误!" MaximumValue="100000" MinimumValue="0"
                        Type="Integer"></asp:RangeValidator></td>
                    
            </tr>
            <tr>
                <td colspan="3" style="text-align: right; width: 117px; height: 26px;" align="left">
                    <asp:Label ID="Label14" runat="server" Text="跨号改判炉数："></asp:Label></td>
                <td colspan="3" style="text-align: left; width: 320px; height: 26px;" align="left">
                    <asp:TextBox ID="txtCrossTotal" runat="server"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtCrossTotal"
                        Display="Dynamic" ErrorMessage="数据类型错误!" MaximumValue="100000" MinimumValue="0"
                        Type="Integer"></asp:RangeValidator></td>
            </tr>
            <tr>
                <td colspan="6" style="height: 33px; text-align: center" align="right">
                    <asp:Button ID="btnSaveData" runat="server" OnClick="btnSaveData_Click" Text="保存"
                        Width="56px" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
