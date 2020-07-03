<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ucDate.ascx.cs" Inherits="userCtl_ucDate" %>
<table cellpadding="0" cellspacing="0" class="0" style="width: 328px">
    <tr>
        <td align="right" style="width: 100px; height: 22px">
            日期：</td>
        <td style="width: 63px; height: 22px">
            <asp:DropDownList ID="ddlYear" runat="server" Width="82px">
            </asp:DropDownList></td>
        <td style="width: 21px; height: 22px">
            年</td>
        <td style="width: 51px; height: 22px">
            <asp:DropDownList ID="ddlMonth" runat="server">
                <asp:ListItem>01</asp:ListItem>
                <asp:ListItem>02</asp:ListItem>
                <asp:ListItem>03</asp:ListItem>
                <asp:ListItem>04</asp:ListItem>
                <asp:ListItem>05</asp:ListItem>
                <asp:ListItem>06</asp:ListItem>
                <asp:ListItem>07</asp:ListItem>
                <asp:ListItem>08</asp:ListItem>
                <asp:ListItem>09</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>11</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
            </asp:DropDownList></td>
        <td style="width: 21px; height: 22px">
            月</td>
        <td style="width: 75px; height: 22px">
            <asp:DropDownList ID="ddlDay" runat="server">
            </asp:DropDownList></td>
        <td style="width: 100px; height: 22px">
            日</td>
    </tr>
</table>
