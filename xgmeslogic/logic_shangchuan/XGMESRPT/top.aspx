<%@ Page Language="C#" AutoEventWireup="true" CodeFile="top.aspx.cs" Inherits="top" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
	<title>top</title>
	<style type="text/css"> 
	BODY { BACKGROUND-IMAGE: url(image/top_bg.gif)} 
	</style>
	<link href="CSS/Manage.css" rel="stylesheet" type="text/css"><link />
	
	<style type="text/css">
    <!--
    body {
	background-image: url(images/top_bg.jpg);
	background-repeat:no-repeat;
	background-color: #FBFBF8;
	margin-left: 0px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
	color:#000000;
    }
    #QueryDate {
	    position:absolute;
	    left:13px;
	    top:36px;
	    width:415px;
	    height:15px;
	    z-index:1;
	    font-size: 24px;
	    font-family: "黑体";
	    font-weight: bold;
	    color: #990000;
	    text-decoration: blink;
    }
    -->
    </style>
	<style type="text/css">  
	#Layer4 {
	Z-INDEX: 4;
	LEFT: 464px;
	WIDTH: 102px;
	POSITION: absolute;
	TOP: 19px;
	HEIGHT: 49px;
	visibility: visible;
} 
	#banner {	position:absolute;
	left:126px;
	top:49px;
	width:180px;
	height:23px;
	z-index:1;
}
    #Layer6 {
	position:absolute;
	left:723px;
	top:3px;
	width:309px;
	height:15px;
	z-index:106;
}
    #OperatorDiv {
	position:absolute;
	left:655px;
	top:40px;
	width:42px;
	height:9px;
	z-index:105;
	visibility: hidden;
}
    #Layer1 {
	position:absolute;
	left:63px;
	top:3px;
	width:623px;
	height:48px;
	z-index:106;
	background-color: #0B267C;
}
    #Layer2 {
	position:absolute;
	left:832px;
	top:3px;
	width:132px;
	height:47px;
	z-index:107;
}
    #Layer3 {
	position:absolute;
	left:67px;
	top:10px;
	width:44px;
	height:12px;
	z-index:108;
}
    /*body,td,th {
	color: #2E73AA;*/
}

    .STYLE1 {color: #FFCC00}
    .STYLE3 {color: #99FF00}
    .STYLE4 {color:#ffffff;}
    #Layer7 {
	position:absolute;
	left:6px;
	top:-1px;
	width:28px;
	height:28px;
	z-index:110;
}
    #Layer8 {
	position:absolute;
	left:20px;
	top:22px;
	width:1px;
	height:3px;
	z-index:111;
}
    #Layer5 {
	position:absolute;
	left:205px;
	top:195px;
	height:29px;
	z-index:111;
}
    </style>
    <script language="javascript" src="JS/newform.js" type="text/javascript"></script>
	<script language="javascript" type="text/javascript">	
	var nowtime=null;
	var myhours=null;
	var myminute=null;
	var mysec=null;
	var changeshifttime = null;
	var manualchangeshift = null;
	var isrun = null;
	var dsLog;
	
	function GetOperator()
	{
	    var response = top.GetUserName();
	    var strOperator = response.value;
	    if(strOperator =="")
	        OperatorDiv.innerText = "System Error";
	    else
	    {
	        OperatorDiv.value = strOperator;
	        OperatorDiv.innerText = strOperator;
	       // Loginfo.innerText = strOperator;
	    }
	}
	
	function GetLogInfo()
	{
	    GetOperator();
	}
	
	function closewindow()
	{
		parent.window.opener =null;
		parent.window.close();
		
	}
	
	function SetUserNull()
	{
	    var response = top.SetUserNull();
	}
	
	//设置注销
	function RegForm()
	{
	  parent.window.opener =null;
	  parent.location.replace("default.aspx");
	}
	
	function getDate()
	{
		var response = top.GetDate();
		return response.value;
	}
	
	function ModifyPasword()
	{
	    var s=new Array();	
		s[s.length] = "<table width=100% height=100% border=0>";
		s[s.length] = "<tr>";
		s[s.length] = "<td>用户名</td><td colspan=2><input id=username  type=text style=\"width:150px\"></td>";
		s[s.length] = "</tr><tr>";
		s[s.length] = "<td>新密码</td><td colspan=2><input id=newpassword type=text style=\"width:150px\"></td>";
		s[s.length] = "</tr><tr>";
		s[s.length] = "<td>密码确认</td><td colspan=2><input id=newpassagain type=text style=\"width:150px\"></td>";
		s[s.length] = "</tr>";
		s[s.length] = "<td colspan=3 align=center><input type=button value=confirm onclick=\"ModPassword()\"></td>"; 
		s[s.length] = "</tr>";
		s[s.length] = "</table>";
		showform('demo1',150,270,800,800,'New Page',s.join(""),false); 
	}

	
	</script>
	
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
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" /></head>
	<body id="topFrame" style="background-color:#8194AC" onLoad="GetOperator();">
		<div id="OperatorDiv" style="left: 565px; top: 53px" ></div>
		<%--<div class="operateDiv">--%>
		<form id="Form1" method="post" runat="server">
			<!-- End ImageReady Slices -->
			<%--;parent.location.replace('default.aspx');--%>
			<div id="111" style=" position:inherit;width:95%; text-align:right; font-size:12px; color:White">
                <table border="0">
                  <tr>
                    <td scope="row"  onclick="SetUserNull();RegForm();" style="height: 20px"><a href="#">注销</a></td>
                    <td style="width: 3px; height: 20px;" ></td>
                    <td onclick="SetUserNull();closewindow();"  style="cursor:hand; height: 20px;"><a href="#">关闭</a></td>
                     <td style="width: 3px; height: 20px;" ></td>
                    <td  style="cursor:hand; height: 20px;"><a href="PswdMaintenance.aspx" target="mainFrame">密码修改</a></td>
                  </tr>
                </table>
               </div>
               <div id="QueryInfo" style=" font-size:24px; color:#990000;
	                                        font-weight:bold;
	                                        font-family:宋体; padding-top:13px;
	                                        padding-left:20px;"></div>
		</form> 
		<div id="demo1" style="Z-INDEX: 899"> <FONT face="宋体"></FONT></div>
	</body>
</html>
