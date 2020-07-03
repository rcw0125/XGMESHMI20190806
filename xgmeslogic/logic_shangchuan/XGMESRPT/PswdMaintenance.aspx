<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PswdMaintenance.aspx.cs" Inherits="PswdMaintenance" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
 <title>PswdMaintenance</title>
 <link href="CSS/style.css" rel="stylesheet" type="text/css" />
	
	<script language="JavaScript" type="text/JavaScript">
	var UserCode;
	function getUserName()
	{
	     UserCode = parent.topFrame.document.getElementById("OperatorDiv").innerText;
	     var res1 = PswdMaintenance.GetUserName(UserCode);
	     document.getElementById("username").innerText = res1.value;
	     parent.topFrame.document.getElementById("QueryInfo").innerText = "成员"+res1.value+ "的帐号修改";
	}
	
	//修改密码
	function ModifyPswd()
	{ 
	    document.getElementById("username").value = UserCode;
	    var OldPswd = document.getElementById("OldPswd").value;
	    var response = PswdMaintenance.GetOldPswd(UserCode,OldPswd);
	    var SameOrNot = response.value;
	    if(SameOrNot=="Not")
	    {
            alert("旧密码不正确！");
            return false;
	    }
	    var NewPswd = document.getElementById("NewPswd").value;
	    var NewPswdMore = document.getElementById("NewPswdMore").value;
	    if(NewPswd!=NewPswdMore)
	    {
	        alert("新口令输入不一致，请重新输入！");
	        return false;
	    } 
	    var response1 = PswdMaintenance.ModifyPswd(UserCode,NewPswd);
	    alert(response1.value);
	    back();
	}
	
    function back()
    {
        location.replace("mainForm.aspx");  
        parent.topFrame.document.getElementById("QueryInfo").innerText = "";
    }
 
	
	</script>
    
</head>
<body onload="getUserName()">
    <form id="form1" runat="server"  >
    <div  style="position:absolute; left:39px; top:33px;">
    <table cellspacing=5px;>
    <tr>
    <td> 用户名：</td>
    <td><asp:Label ID="username" runat="server" Width="157px"></asp:Label></td>
    </tr>
    
    <tr>
    <td>旧密码：</td>
    <td><input id="OldPswd" type="text" /></td>
    </tr>
    
    <tr>
    <td>新密码：</td>
    <td><input id="NewPswd" type="text" /></td>
    </tr>
    
    <tr>
    <td>密码确认：</td>
    <td><input id="NewPswdMore" type="text" /></td>
    </tr>
    
    <tr align=right><td colspan = "2"><input id="Button1" type="button" onclick ="ModifyPswd();" value="提交"  style="width: 44px" /> <input id="Button2" type="button"   onclick="back();" value="返回" /></td></tr>
    </table>
    </div>
        
       <%-- <a  href="#"></a>--%>
    </form>
</body>
</html>
