<%@ Page Language="C#" AutoEventWireup="true" CodeFile="left.aspx.cs" Inherits="left" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1">
		<title>left</title>
		<script language="JavaScript">
		
		function GetOperator()
	    {
	        var response = left.GetUserName();
	        var strOperator = response.value;
	        if(strOperator =="")
	            OperatorDiv.innerText = "System Error";
	        else
	        {
	            OperatorDiv.value = strOperator;
	            OperatorDiv.innerText = "您好: "+strOperator;
	        }
	    }
	
		
function showOpt(j,total)
{
	if (document.getElementById("tb"+j).style.display != "none") 
	{
        document.getElementById("tb"+j).style.display = "none";
    } 
    else 
    {
        for(var i=1;i<=total;i++)
        {
            document.getElementById("tb"+i).style.display = "none";
        }
        document.getElementById("tb"+j).style.display = "";
    }
		
}

function show(id) 
{
	document.getElementById("tb"+id).style.display=""
}


function ChangeTopTitle(strTitle,strSubTitle)
{
    //alert("topFrame");
    //parent.topFrame.document.getElementById("Title").innerHTML = strTitle+"--->"+strSubTitle;
}

function FadeIn(Pid,Cid)
{
    if(Cid==null)
    {
        if(MenuPID==Pid)
        {
            var obj = document.getElementById("MenuParent"+Pid);
            var cc=obj.style.filter;
            cc = cc.substring(cc.indexOf("=")+1,cc.indexOf(")"));
            var opnum = parseInt(cc);
            if(opnum<100)
            { 
                opnum = opnum + 4.0;
                obj.style.filter = "alpha(opacity="+opnum+")";
                setTimeout("FadeIn("+Pid+")",50);
            }
            else
            {
                obj.style.filter = "alpha(opacity=100)";
            }
        }
    }
    else
    {
        if(MenuCID==Cid&&MenuPID==Pid)
        {
            var objp = document.getElementById("MenuParent"+Pid);
            var objc = document.getElementById("MenuChild"+Cid);
            
            var cc1=objc.style.filter;
            cc1 = cc1.substring(cc1.indexOf("=")+1,cc1.indexOf(")"));
            var opnum1 = parseInt(cc1);
            
            var cc2=objp.style.filter;
            cc2 = cc2.substring(cc2.indexOf("=")+1,cc2.indexOf(")"));
            var opnum2 = parseInt(cc2);
            
            if(opnum1<100)
            { 
                opnum1 = opnum1 + 4.0;
                objc.style.filter = "alpha(opacity="+opnum1+")";
            }
            else
            {
                objc.style.filter = "alpha(opacity=100)";
            }
            
            if(opnum2<100)
            {
                opnum2 = opnum2 + 4.0;
                objp.style.filter = "alpha(opacity="+opnum2+")";
            }
            else
            {
                objp.style.filter = "alpha(opacity=100)";
            }
            if(opnum1<100||opnum2<100)
            {
                setTimeout("FadeIn("+Pid+","+Cid+")",50);
            }
        }
    }
    
}

function FadeOut(Pid,Cid)
{
   if(Cid==null)
    {
        if(MenuPID!=Pid)
        {
            var obj = document.getElementById("MenuParent"+Pid);
            var cc=obj.style.filter;
            cc = cc.substring(cc.indexOf("=")+1,cc.indexOf(")"));
            var opnum = parseInt(cc);
            if(opnum>60)
            { 
                opnum = opnum - 4.0;
                obj.style.filter = "alpha(opacity="+opnum+")";
                setTimeout("FadeOut("+Pid+")",50);
            }
            else
            {
                obj.style.filter = "alpha(opacity=60)";
            }
        }
    }
    else
    {
        if(MenuCID!=Cid&&MenuPID==Pid)
        {
            var objc = document.getElementById("MenuChild"+Cid);
            var cc1=objc.style.filter;
            cc1 = cc1.substring(cc1.indexOf("=")+1,cc1.indexOf(")"));
            var opnum1 = parseInt(cc1);
            if(opnum1>60)
            { 
                opnum1 = opnum1 - 4.0;
                objc.style.filter = "alpha(opacity="+opnum1+")";
                setTimeout("FadeOut("+Pid+","+Cid+")",50);
            }
            else
            {
                objc.style.filter = "alpha(opacity=60)";
            }
            
        }
        
        if(MenuCID!=Cid&&MenuPID!=Pid)
        {
            var objp = document.getElementById("MenuParent"+Pid);
            var objc = document.getElementById("MenuChild"+Cid);
            
            var cc1=objc.style.filter;
            cc1 = cc1.substring(cc1.indexOf("=")+1,cc1.indexOf(")"));
            var opnum1 = parseInt(cc1);
            
            var cc2=objp.style.filter;
            cc2 = cc2.substring(cc2.indexOf("=")+1,cc2.indexOf(")"));
            var opnum2 = parseInt(cc2);
            
            if(opnum1>60)
            { 
                opnum1 = opnum1 - 4.0;
                objc.style.filter = "alpha(opacity="+opnum1+")";
            }
            else
            {
                objc.style.filter = "alpha(opacity=60)";
                
            }
            if(opnum2>60)
            {
                opnum2 = opnum2 - 4.0;
                objp.style.filter = "alpha(opacity="+opnum2+")";
            }
            else
            {
                objp.style.filter = "alpha(opacity=60)";
            }
            if(opnum1>56||opnum2>56)
            {
                setTimeout("FadeOut("+Pid+","+Cid+")",50);
            }
        } 
     }   
  }


		</script>
		<LINK href="CSS/Manage.css" type="text/css" rel="stylesheet">
			<style type="text/css">

                body {
	                background-image: url(images/left_06.jpg);
	                background-repeat: repeat-y;
                }
                </style>
			<LINK href="Manage.css" type="text/css" rel="stylesheet">
				<style type="text/css"> <!-- #Layer2 { position:absolute; left:406px; top:22px; width:11px; height:86px; z-index:2; }
	a:link { font-family: "Times New Roman", Times, serif; font-size: 9pt; color: #000000; text-decoration: none; }
	a:visited { font-family: "Times New Roman", Times, serif; font-size: 12px; color: #000000; text-decoration: none; }
	a:hover { font-family: "Times New Roman", Times, serif; font-size: 12px; color: #0066FF; text-decoration: none; }
	a:active { font-family: "Times New Roman", Times, serif; font-size: 12px; color: #000000; text-decoration: none; }
	--></style>
	</head>
	<body  leftMargin="0" topMargin="0" marginheight="0" marginwidth="0" onload="GetOperator()">
	<form id="Form1" method="post" runat="server">
		<!-- ImageReady Slices (BSL3Demo3.psd) -->
		<table width="150" height="100%" border="0" cellPadding="0" cellSpacing="0" id="01">
			<tr>
				<td vAlign="top" align="left" height="33"><table width="243" height="73" border="0" cellpadding="0" cellspacing="0" id="__01">
                  <tr>
                    <td width="10" style="background-image:url(images/left_top_02.jpg)"><img src="images/left_top_01.jpg" width="6" height="11" alt="" /></td>
                    <td width="223" style="background-image:url(images/left_top_02.jpg)"></td>
                    <td width="10" style="background-image:url(images/left_top_02.jpg)"><img src="images/left_top_03.jpg" width="10" height="11" alt=""; style="float:right" /></td>
                  </tr>
                  <tr>
                    <td style="background-image:url(images/left_top_05.jpg)"><img src="images/left_top_04.jpg" width="6" height="25" alt="" /></td>
                    <td style="background-image:url(images/left_top_05.jpg)"><div id = "OperatorDiv" style="padding-left:10px; padding-top:3px; color:#FFFFFF"></div></td>
                    <td ><img src="images/left_top_06.jpg" width="10" height="25" alt=""  style="float:right" /></td>
                  </tr>
                  <tr>
                    <td style="background-image:url(images/left_top_10.jpg)"><img src="images/left_top_07.jpg" width="6" height="37" alt="" /></td>
                    <td style="background-image:url(images/left_top_10.jpg)"><img src="images/left_top_08.jpg" width="134" height="37" alt="" /></td>
                    <td style="background-image:url(images/left_top_10.jpg)"><img src="images/left_top_09.jpg" width="10" height="37" alt="" style="float:right" /></td>
                  </tr>
                </table>
				  <br>
			  </td><td vAlign="top" align="left"><table cellSpacing="0" cellPadding="0" background="image/Center_back.jpg" border="0">
						<tr>
							<th vAlign="top" scope="col" background="image/Center_back.jpg" height="100%">
								
							</th>
						</tr>
					</table>
				</td>
			</tr>
		</table>
	  <div style ="position:absolute; bottom:0px; vertical-align:bottom">
	  <table width="243" border="0" cellpadding="0" cellspacing="0" id="Table2">
                  <tr>
                    <td width="10" style="background-image:url(images/left_top_02.jpg)"><img src="images/left_top_01.jpg" width="6" height="11" alt="" /></td>
                    <td width="223" style="background-image:url(images/left_top_02.jpg)"></td>
                    <td width="10" style="background-image:url(images/left_top_02.jpg)"><img src="images/left_top_03.jpg" width="10" height="11" alt=""; style="float:right" /></td>
                  </tr>
        </table>
	  </div>
		<!-- End ImageReady Slices -->
	</form>
	</body>
</html>

