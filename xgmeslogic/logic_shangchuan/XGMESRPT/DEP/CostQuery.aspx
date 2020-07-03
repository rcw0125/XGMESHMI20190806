<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CostQuery.aspx.cs" Inherits="BOF_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="Panel1" runat="server" Height="412px" Width="237px">
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            <asp:Label ID="Label1" runat="server" BorderStyle="None" Text="查询条件" Width="73px"></asp:Label>
            &nbsp;<br />
            <br />
            &nbsp; &nbsp;成本中心: &nbsp;&nbsp;
            <asp:DropDownList ID="ddlCostCenter" runat="server" Width="118px">
                <asp:ListItem Value="S63">3#铸机</asp:ListItem>
                <asp:ListItem Value="S64">4#铸机</asp:ListItem>
                <asp:ListItem Value="S65">5#铸机</asp:ListItem>
                <asp:ListItem Value="S67">7#铸机</asp:ListItem>
            </asp:DropDownList><br />
            <br />
            &nbsp;&nbsp; 产品分类: &nbsp;&nbsp;
            <asp:DropDownList ID="ddlProType" runat="server" Width="118px">
                <asp:ListItem Value="F">常规钢</asp:ListItem>
                <asp:ListItem Value="J">品种钢</asp:ListItem>
                <asp:ListItem Value="P">精品钢</asp:ListItem>
            </asp:DropDownList><br />
            <br />
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; 产品: &nbsp; &nbsp; &nbsp;&nbsp;<asp:DropDownList
                ID="ddlSteelGrade" runat="server" Width="118px">
            </asp:DropDownList>
            &nbsp;&nbsp;<br />
            <br />
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; 物料: &nbsp;&nbsp;
            <asp:TextBox ID="txtMaterial" runat="server" Width="110px"></asp:TextBox><br />
            <br />
            &nbsp;&nbsp; 成本项目: &nbsp;&nbsp;
            <asp:DropDownList ID="ddlCostItem" runat="server" Width="118px">
                <asp:ListItem Value="1">直接材料</asp:ListItem>
                <asp:ListItem Value="11">钢铁料</asp:ListItem>
                <asp:ListItem Value="12">合金料</asp:ListItem>
                <asp:ListItem Value="13">散状料</asp:ListItem>
                <asp:ListItem Value="14">耐材</asp:ListItem>
                <asp:ListItem Value="2">介质费用</asp:ListItem>
                <asp:ListItem Value="3">耐材费用</asp:ListItem>
            </asp:DropDownList>&nbsp;<br />
            <br />
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; 日期: &nbsp;&nbsp;<asp:Calendar ID="Date"
                runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1"
                DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399"
                Height="200px" Width="220px">
                <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                <WeekendDayStyle BackColor="#CCCCFF" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True"
                    Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
            </asp:Calendar>
            <br />
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:Button
                ID="btnConfirm" runat="server" OnClick="btnConfirm_Click" Text="确定" />
            &nbsp; &nbsp;<asp:Button ID="btnCancel" runat="server" Text="取消" /></asp:Panel>
    
    </div>
    </form>
</body>
</html>
