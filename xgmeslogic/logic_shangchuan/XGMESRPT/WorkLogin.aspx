<%--<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>--%>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WorkLogin.aspx.cs" Inherits="WorkLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
 <head id="Head1" runat="server">
		<title>WorkLogin</title>
		<style type="text/css">BODY { margin:0 0 0 0";  background="images/default_03.gif }
	A:link { FONT-SIZE: 12px; COLOR: #333333; FONT-FAMILY: Arial, Helvetica, sans-serif; TEXT-DECORATION: none }
	A:hover { COLOR: #000066; TEXT-DECORATION: none }
	A:visited { FONT-SIZE: 12px; COLOR: #333333; TEXT-DECORATION: none }
	A:active { FONT-SIZE: 12px; COLOR: #006699; TEXT-DECORATION: none }
	.WhiteText { FONT-WEIGHT: bold; FONT-SIZE: 12px; COLOR: #ffffff; FONT-FAMILY: Arial, Helvetica, sans-serif }
	LINK { FONT-SIZE: 12px; COLOR: #333333 }
	.inputBG {
	background-color: #e2f2f9;
}
	</style>
		<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
 </head>
	<body >
		<form id="Form1" method="post" runat="server">
<asp:label id="Label1" style="Z-INDEX: 106; LEFT: 362px; POSITION: absolute; TOP: 203px; background-color:" runat="server"
	Width="405px" ForeColor="Red" Font-Bold="True" Height="26px"></asp:label>
<div style="position:absolute; top: 0px; background-image:url(images/default_01.gif);left:0px; width:100%; height:25px"></div>
<div style="position:absolute; background-image:url(images/default_05.jpg); top:25px; width:100%; height: 550px; background-position:center; background-repeat:no-repeat; left: 0px;" >

<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="325" border="0" align="center" cellpadding="0" cellspacing="12" style="font:'宋体'; font-size:12px">
  <tr>
    <td width="121" style="text-align:right">用户名:</td>
    <td style="width: 167px">
    <asp:textbox id="txtUser" style="Z-INDEX: 101; POSITION:inherit;"
		runat="server" Height="18px" Width="164px" CssClass="inputBG"></asp:textbox>
        &nbsp;</td>
  </tr>
  <tr>
    <td  width="121"  style="text-align:right">密&nbsp; 码:</td>
    <td style="width: 167px"><asp:textbox id="txtPassword" style="Z-INDEX: 102;  POSITION: inherit;"
		runat="server" Height="18px" Width="164px" TextMode="Password" CssClass="inputBG"></asp:textbox></td>
    </tr>
  <tr>
    <td style="height: 40px">&nbsp;</td>
    <td style="width: 167px; height: 40px;">
      
        <div align="center"><asp:imagebutton id="ImageButton1" style="Z-INDEX: 103; POSITION: inherit;"
			runat="server" Height="21px" Width="73px" ImageUrl="~/images/&#30830;&#35748;.gif" OnClick="ImageButton1_Click"></asp:imagebutton>&nbsp;<img  src="images/&#21462;&#28040;.png" width="81"style="Z-INDEX: 108;  WIDTH: 73px; POSITION:inherit; HEIGHT: 21px" onclick="window.close();"
	type="button" value="Close">&nbsp;</div></td>
    </tr>
</table>





</div>

<div style="position:absolute; bottom: 0px; background-image:url(images/default_01.gif); width:100%; height:25px; left: 0px;"></div>		
		</form>
		
	</body>
</html>
