<%@ Page language="c#" CodeFile="Space.aspx.cs" AutoEventWireup="true" Inherits="Manage.Space" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
		<title>Space</title>
		<script language="JavaScript" type="text/JavaScript">
<!--
function MM_reloadPage(init) {  //reloads the window if Nav4 resized
  if (init==true) with (navigator) {if ((appName=="Netscape")&&(parseInt(appVersion)==4)) {
    document.MM_pgW=innerWidth; document.MM_pgH=innerHeight; onresize=MM_reloadPage; }}
  else if (innerWidth!=document.MM_pgW || innerHeight!=document.MM_pgH) location.reload();
}
MM_reloadPage(true);
//-->
		</script>
	    <style type="text/css">
<!--
#Form1 #banner {
	padding-top:15em;
}
body{

	background-image:url(image/Center_back.jpg);
	background-repeat:repeat-y}
-->
        </style>
</head>
	<script language="javascript">
	function reducewidth(width)
	{var aa
		if(width>0)
		{
			var t=width-15;
			if(t<=0) {
				t=0;
				document.getElementById("banner").src = "image/Center_001.jpg"
			}
			top.document.getElementById("framec").cols = t +",*";
			setTimeout("reducewidth("+t+")",100);
		}
	}	
	
	function addwidth(width)
	{
		if(width<150)
		{
			var t=width+15;
			if(t>=178) 
			{
				t=178;
				document.getElementById("banner").src = "image/Center_001_0.jpg"
			 }
			top.document.getElementById("framec").cols = t +",*";
			setTimeout("addwidth("+t+")",100);
		}	
		
	}
	
	function changeit()
	{
		var tempwidth = top.document.getElementById("framec").cols;
		tempwidth = tempwidth.substring(0,tempwidth.length-2);
		var newwidth = eval(tempwidth);
		if(newwidth>120)
		{
			reducewidth(newwidth);	
			
		}
		else
		{
			addwidth(newwidth);
		}
		
	}
	
	
	</script>
	<body leftmargin="0" topmargin="0">
		<form id="Form1" method="post" runat="server">
				<IMG src="image/Center_001_0.jpg" name="banner" id="banner"
					onClick="changeit()"></form>
	</body>
</html>
