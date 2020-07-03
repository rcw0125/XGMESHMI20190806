<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserGroup.aspx.cs" Inherits="UserGroup" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>UserGroup</title>
<style type="text/css"> body { background-image: url(../image/bg.gif); font-size: 10px; margin-left: 0px; margin-top: 0px; }
		</style>
		<LINK href="CSS/style.css" type="text/css" rel="stylesheet">
		<script language="javascript" src="JS/tableList.js" type="text/javascript"></script>
        <script language="javascript" src="JS/newform.js" type="text/javascript"></script>
        <script language="javascript" src="JS/GetParam.js" type="text/javascript"></script>
		<script language="javascript">

	/////Get relational Group of the user 
	function GetUserGroupMap()
	{
		var response = UserGroup.GetUserGroupMap(document.getElementById("SelectUserList").value);
		var ds = response.value;
		var s= new Array();
		if(ds!=null && typeof(ds) == "object" && ds.Tables!=null)
		{
			s[s.length] = "<SELECT id=\"SelectUserGroupMap\" size=\"16\" style=\"Z-INDEX: 101; WIDTH: 212px; POSITION: absolute; HEIGHT: 256px\" >";
			for(var i=0;i<ds.Tables[0].Rows.length;i++)
			{
				s[s.length] = "<option value=\""+ds.Tables[0].Rows[i].GROUPNAME+"\">"+ds.Tables[0].Rows[i].GROUPNAME+"</option>";
			}
		}	
		s[s.length] = "</SELECT>";
		document.getElementById("UserGroup").innerHTML = s.join("");
	}
	
	
	/////Get all user
	function GetAllUser()
	{
		var response = UserGroup.GetAllUser();
		var ds = response.value;
		var s = new Array();
		if(ds!=null && typeof(ds) == "object" && ds.Tables!=null)
		{
			s[s.length] = "<SELECT id=\"SelectUserList\" size=\"16\" style=\"Z-INDEX: 101; WIDTH: 200px; POSITION: absolute; HEIGHT: 256px\" onclick=\"GetUserGroupMap();GetOtherGroup();\" >";
			s[s.length] = "<option value=\"\">(null)</option>";
			for(var i=0;i<ds.Tables[0].Rows.length;i++)
			{
				s[s.length] = "<option value=\""+ds.Tables[0].Rows[i].USERNAME+"\">"+ds.Tables[0].Rows[i].USERNAME+'_'+ds.Tables[0].Rows[i].USERREALNAME+"</option>";
			}
		}	
		s[s.length] = "</SELECT>";
		document.getElementById("UserList").innerHTML = s.join("");
		parent.topFrame.document.getElementById("QueryInfo").innerText="用户管理";
	}
	
	
	////Get no relation Group of the User
	function GetOtherGroup()
	{
		var response = UserGroup.GetOtherGroup(document.getElementById("SelectUserList").value);
		var ds = response.value;
		var s = new Array();
		if(ds!=null && typeof(ds) == "object" && ds.Tables!=null)
		{
			s[s.length] = "<SELECT id=\"SelectGroupList\" size=\"16\" style=\"Z-INDEX: 101; WIDTH: 212px; POSITION: absolute; HEIGHT: 256px\">";
			for(var i=0;i<ds.Tables[0].Rows.length;i++)
			{
				s[s.length] = "<option value=\""+ds.Tables[0].Rows[i].GROUPNAME+"\">"+ds.Tables[0].Rows[i].GROUPNAME+"</option>";
			}
		}	
		s[s.length] = "</SELECT>";
		document.getElementById("GroupList").innerHTML = s.join("");
	}
	
	
	//// Remove relation between User and Group
	function RemoveGroup()
	{
		var i = document.getElementById("SelectUserGroupMap").selectedIndex;
		var j = document.getElementById("SelectUserList").selectedIndex;
		if(i>=0&&j>=0)
		{
			var response = UserGroup.RemoveGroup(document.getElementById("SelectUserGroupMap").value,document.getElementById("SelectUserList").value);
			var retval = response.value;
			if(retval=="1")
			{
				alert("Remove Group failure!");
			}
			else
			{
				GetUserGroupMap();
				GetOtherGroup();
			}
			
		}
		else
		{
			alert("You must to select a node.");
		}
	
	}
	
	//// add relation between User and Group
	function AddGroup()
	{
		var i = document.getElementById("SelectGroupList").selectedIndex;
		var j = document.getElementById("SelectUserList").selectedIndex;
		if(i>=0 && j>=0 )
		{
			var response = UserGroup.AddGroup(document.getElementById("SelectGroupList").value,document.getElementById("SelectUserList").value);
			var retval = response.value;
			if(retval=="0")
			{
				GetUserGroupMap();
				GetOtherGroup();
			}
			else
			{
				alert(retval);
			}
		}
		else
		{
			if(i<0)	alert("You must to select a Group-List node.");
			if(j<0) alert("You must to select a User-List node.");
		}	
	}
	
	////display new user dialog
	function displaynewuser()
	{
	    var response = UserGroup.GetUserProf(); 
	    var res =  response.value; 
		var s = new Array();
		s[s.length] = "<table width=100%>";
		s[s.length] = "<tr>";
		s[s.length] = "<td>锁定</td><td><input id=\"lockflag\" type=\"checkbox\"></td>";
		s[s.length] = "</tr><tr>";
		s[s.length] = "<td>工号</td><td><input type=\"text\" id=\"textusername\" ></td>";
		s[s.length] = "</tr><tr>";
		s[s.length] = "<td>用户名</td><td><input type=\"text\" id=\"textuserrealname\" ></td>";
		s[s.length] = "</tr><tr>";
		s[s.length] = "</tr><tr>";
		s[s.length] = "<td>职称</td>";
		s[s.length] = "<td><SELECT id='textuserprof' style='width:160px'>";	
	    if (res != null)
        {
            for(var i=0;i< res.Tables[0].Rows.length;i++)
            {
                if(i==0)
                    s[s.length] = "<option value='"+res.Tables[0].Rows[i].COL1+"' selected>"+res.Tables[0].Rows[i].COL1+"</option>";    
                else
                    s[s.length] = "<option value='"+res.Tables[0].Rows[i].COL1+"'>"+res.Tables[0].Rows[i].COL1+"</option>";  
            }    
        }
        s[s.length] ="</SELECT></td>";
		s[s.length] = "</tr><tr>";
		s[s.length] = "<td align=center colspan=2><input type=\"button\" value=\"提交\" onclick=\"newUser()\" >";
		s[s.length] = "</tr>";
		s[s.length] = "</table>";
		//showform('demo1',50,370,250,200,'新增用户',s.join(""),false);showform('demo1',299,200,250,200,'
		showform('demo1',299,310,250,200,'新增用户',s.join(""),true);  //邓强20080310
	}
	
	///////add new user
	function newUser()
	{   
	    var userName = document.getElementById("textusername").value;
	    var userRealName = document.getElementById("textuserrealname").value;
	    var userProf = document.getElementById("textuserprof").value;
	    if (userName==""||userRealName=="")
	    {
	       alert("用户名和用户代码不能为空！");
	       return false;
	    }
		var response = UserGroup.newUser(document.getElementById("lockflag").checked,'1',userName,userRealName,userProf);
		var retval = response.value;
		if(retval=="0")
		{
			document.getElementById("demo1").innerHTML = "";
			GetAllUser();
		}
		else
		{
			alert(retval);
		}
	}
	
	////display edit user dialog
	function displaymodifyuser()
	{
		var j = document.getElementById("SelectUserList").selectedIndex;
		if(j>0)
		{
			var response = UserGroup.getUserInfo(document.getElementById("SelectUserList").value)
			var ds = response.value;
			if(ds.Tables[0].Rows.length>0)
			{
			     var response = UserGroup.GetUserProf(); 
	             var res =  response.value; 
				var s = new Array();
				s[s.length] = "<table width=100%>";
				s[s.length] = "<tr>";
				s[s.length] = "<td><div id=\"modifyUserID\" value=\""+ds.Tables[0].Rows[0].USERID+"\"></div></td>"; 
				s[s.length] = "</tr><tr>";
				s[s.length] = "<td>锁定</td><td><input id=\"lockflag\" type=\"checkbox\"";
				if(ds.Tables[0].Rows[0].ACCOUNTLOCK=="1")
				{
					s[s.length] = " CHECKED ></td>";
				}
				else
				{
					s[s.length] = "></td>";
				}
				s[s.length] = "</tr><tr>";
				s[s.length] = "<td>工号</td><td><input type=\"text\" id=\"textusername\" value=\""+ds.Tables[0].Rows[0].USERNAME+"\" ></td>";
				s[s.length] = "</tr><tr>";
				s[s.length] = "<td>用户名</td><td><input type=\"text\" id=\"textuserrealname\" value=\""+ds.Tables[0].Rows[0].USERREALNAME+"\" ></td>";
				s[s.length] = "</tr><tr>";
				s[s.length] = "</tr><tr>";
				s[s.length] = "<td>职称</td>";
				s[s.length] = "<td><SELECT id='textuserprof' style='width:160px'>";	
		            if (res != null)
                    {
                        for(var i=0;i< res.Tables[0].Rows.length;i++)
                        {
                           if(res.Tables[0].Rows[i].COL1==ds.Tables[0].Rows[0].USER_PROF)
                            s[s.length] = "<option value='"+res.Tables[0].Rows[i].COL1+"' selected>"+res.Tables[0].Rows[i].COL1+"</option>";    
                           else
                            s[s.length] = "<option value='"+res.Tables[0].Rows[i].COL1+"'>"+res.Tables[0].Rows[i].COL1+"</option>";  
                        }    
                    }
                s[s.length] ="</SELECT></td>";
				s[s.length] = "</tr><tr>";
				s[s.length] = "<td>设定新密码</td><td><input type=\"password\" id=\"newPassword\" TextMode=\"Password\" value=\""+""+"\" ></td>";
				s[s.length] = "</tr><tr>";
				s[s.length] = "<td align=center colspan=2><input type=\"button\" value=\"提交\" onclick=\"modifyUser()\" >";
				s[s.length] = "</tr>";
				s[s.length] = "</table>";
				//showform('demo1',50,370,250,200,'修改用户',s.join(""),false);
                showform('demo1',299,310,250,200,'修改用户',s.join(""),true); //邓强20080310
			}
		}
		else
		{
			alert("请选择一个用户进行操作");
		}
	}	
	
	
	//////Modify user
	function modifyUser()
	{   
	    var userName = document.getElementById("textusername").value;
	    var userRealName = document.getElementById("textuserrealname").value;
	    var userProf = document.getElementById("textuserprof").value;
	    var userPassword = document.getElementById("newPassword").value;
	    if (userName==""||userRealName=="")
	    {
	       alert("用户名\用户代码不能为空!");
	       return false;
	    }
		var response = UserGroup.modifyUser(document.getElementById("modifyUserID").value,document.getElementById("lockflag").checked,document.getElementById("textusername").value,userRealName,userProf,userPassword);
		var retval = response.value;
		if(retval=="0")
		{
			document.getElementById("demo1").innerHTML = "";
			GetAllUser();
		}
		else
		{
			alert(retval);
		}
	}
	
	////display delete user warning dialog
	function displaydelwarning()
	{
	    //alert("删除操作已经屏蔽");
		var j = document.getElementById("SelectUserList").selectedIndex;
		if(j>0)
		{
			var s = new Array();
			s[s.length] = "<table width=100% height=100% valign=top ><tr><td align=center>Are you sure <font color=red>DELETE</font> this user ? <br>It will delete the User's Group relation at the same time .</td></tr>";
			s[s.length] = "<tr><td align=center><input type=button value=\"Delete\" onclick=\"deleteUser()\"></td></tr></table>";
			showform('demo1',50,370,250,200,'Delete User',s.join(""),false);
		}
		else
		{
			alert("You must to select a User-List node.");
		}	
	}
	
	/////delete user
	function deleteUser()
	{
		var response = UserGroup.deleteUser(document.getElementById("SelectUserList").value);
		var retval = response.value;
		if(retval=="0")
		{
			document.getElementById("demo1").innerHTML = "";
			GetAllUser();
			GetUserGroupMap();
			GetOtherGroup();
		}
		else
		{
			alert(retval);
		}		
	}
	
	/////display new group dialog
	function displaynewgroup()
	{
		var s = new Array();
		s[s.length] = "<table width=100%>";
		s[s.length] = "<tr>";
		s[s.length] = "<td>组别名</td><td><input type=\"text\" id=\"textgroupname\" ></td>";
		s[s.length] = "</tr><tr>";
		s[s.length] = "<td>组别描述</td><td><input id=\"textgroupdesc\" type=\"text\"></td>";
		s[s.length] = "</tr><tr>";
		s[s.length] = "<td>锁定</td><td><input type=\"checkbox\" id=\"checkgrouplock\" ></td>";
		s[s.length] = "</tr><tr>";
		s[s.length] = "<td align=center colspan=2><input type=\"button\" value=\"提交\" onclick=\"newGroup()\" >";
		s[s.length] = "</tr>";
		s[s.length] = "</table>";
//		showform('demo1',400,370,300,200,'新增组别',s.join(""),false);
		showform('demo1',299,310,300,200,'新增组别',s.join(""),true); //邓强20080310
	}
	
	
	/////add a new group
	function newGroup()
	{
		var response = UserGroup.newGroup(document.getElementById("textgroupdesc").value,document.getElementById("textgroupname").value,document.getElementById("checkgrouplock").checked);
		var retval = response.value;
		if(retval=="0")
		{
			document.getElementById("demo1").innerHTML = "";
			GetOtherGroup();
		}
		else
		{
			alert(retval);
		}	
	}
	
	
	
	////////display delete a group warning dialog
	function displaydelgroupwarning()
	{
		var j = document.getElementById("SelectGroupList").selectedIndex;
		if(j>=0)
		{
			var s = new Array();
			//s[s.length] = "<table width=100% height=100% valign=top ><tr><td align=center>Are you sure <font color=red>DELETE</font> this group ? <br>It will delete the Group relation at the same time .</td></tr>";
			s[s.length] = "<table width=100% height=100% valign=top ><tr><td align=center>确定要 <font color=red>删除</font> 该组别吗?</td></tr>";
			s[s.length] = "<tr><td align=center><input type=button value=\"删除\" onclick=\"deleteGroup()\"></td></tr></table>";
			showform('demo1',299,310,300,200,'删除组别',s.join(""),true);
		}
		else
		{
			alert("请选择一个组别进行操作");
		}
	}
	
	/////delete group and relation
	function deleteGroup()
	{
		var response = UserGroup.deleteGroup(document.getElementById("SelectGroupList").value);
		var retval = response.value;
		if(retval=="0")
		{
			document.getElementById("demo1").innerHTML = "";
			GetAllUser();
			GetUserGroupMap();
			GetOtherGroup();
		}
		else
		{
			alert(retval);
		}		
	
	}	
	
	//////display modify group dialog
	function displaymodifygroup()
	{
		var j = document.getElementById("SelectGroupList").selectedIndex;
		if(j>=0)
		{
			var response = UserGroup.getGroupinfo(document.getElementById("SelectGroupList").value);
			var ds = response.value;
			if(ds.Tables[0].Rows.length>0)
			{
				var s = new Array();
				s[s.length] = "<table width=100%>";
				s[s.length] = "<tr><td><div id=\"modifyGroupid\" value=\""+ds.Tables[0].Rows[0].GROUPID+"\"></div></td></tr>";
				s[s.length] = "<tr>";
				s[s.length] = "<td>组别名</td><td><input type=\"text\" id=\"textgroupname\" value=\""+ds.Tables[0].Rows[0].GROUPNAME+"\" ></td>";
				s[s.length] = "</tr><tr>";
				s[s.length] = "<td>组别描述</td><td><input id=\"textgroupdesc\" type=\"text\" value=\""+ds.Tables[0].Rows[0].DESCR+"\"></td>";
				s[s.length] = "</tr><tr>";
				s[s.length] = "<td>锁定</td><td><input type=\"checkbox\" id=\"checkgrouplock\" ";
				if(ds.Tables[0].Rows[0].GROUPLOCK=="1")
				{
					s[s.length] = "checked ></td>";
				}
				else
				{
					s[s.length] = "></td>";
				}
				s[s.length] = "</tr><tr>";
				s[s.length] = "<td align=center colspan=2><input type=\"button\" value=\"提交\" onclick=\"modifyGroup()\" >";
				s[s.length] = "</tr>";
				s[s.length] = "</table>";
//				showform('demo1',400,370,300,200,'修改组别',s.join(""),false);	
				showform('demo1',299,310,300,200,'修改组别',s.join(""),true);	  //邓强20080310
			}
		}
		else
		{
			alert("请选择一个组别进行操作");
		}
	}
	
	function modifyGroup()
	{
		var response = UserGroup.modifyGroup(document.getElementById("modifyGroupid").value,document.getElementById("textgroupdesc").value,document.getElementById("textgroupname").value,document.getElementById("checkgrouplock").checked);
		var retval = response.value;
		if(retval=="0")
		{
			document.getElementById("demo1").innerHTML = "";
			GetOtherGroup();
		}
		else
		{
			alert(retval);
		}			
	}
		</script>
	</head>
	<body onload="GetAllUser();GetOtherGroup();GetUserGroupMap()" ms_positioning="GridLayout">
		<form id="Form1" method="post" runat="server">
			<div id="UserList" style="Z-INDEX: 101; LEFT: 48px; WIDTH: 200px; POSITION: absolute; TOP: 63px; HEIGHT: 256px"></div>
			<INPUT style="Z-INDEX: 114; LEFT: 666px; WIDTH: 60px; POSITION: absolute; TOP: 325px; HEIGHT: 25px"
				type="button" value="修改" onclick="displaymodifygroup()">
			<DIV style="DISPLAY: inline; Z-INDEX: 102; LEFT: 49px; WIDTH: 198px; POSITION: absolute; TOP: 32px; HEIGHT: 24px"
				align="center"><font size="4">用户列表</font></DIV>
			<INPUT style="Z-INDEX: 103; LEFT: 49px; WIDTH: 60px; POSITION: absolute; TOP: 325px; HEIGHT: 25px"
				type="button" value="新增" onclick="displaynewuser()" id="Button2"> 
				<INPUT style="Z-INDEX: 104; LEFT: 176px; WIDTH: 60px; POSITION: absolute; TOP: 325px; HEIGHT: 25px"
				type="button" value="删除" onclick="displaydelwarning()"　>
			<div id="UserGroup" style="Z-INDEX: 105; LEFT: 299px; WIDTH: 212px; POSITION: absolute; TOP: 63px; HEIGHT: 256px"></div>
			<DIV style="DISPLAY: inline; Z-INDEX: 106; LEFT: 297px; WIDTH: 216px; POSITION: absolute; TOP: 32px; HEIGHT: 24px"
				align="center"><font size="4">用户所属组别</font></DIV>
			<div id="GroupList" style="Z-INDEX: 107; LEFT: 603px; WIDTH: 212px; POSITION: absolute; TOP: 63px; HEIGHT: 256px"></div>
			<INPUT style="Z-INDEX: 108; LEFT: 603px; WIDTH: 60px; POSITION: absolute; TOP: 325px; HEIGHT: 25px"
				type="button" value="新增" onclick="displaynewgroup()">
				<INPUT style="Z-INDEX: 109; LEFT: 729px; WIDTH: 60px; POSITION: absolute; TOP: 325px; HEIGHT: 25px"
				type="button" value="删除" onclick="displaydelgroupwarning()">
			<DIV style="DISPLAY: inline; Z-INDEX: 110; LEFT: 603px; WIDTH: 188px; POSITION: absolute; TOP: 32px; HEIGHT: 24px"
				align="center"><font size="4">组别列表</font></DIV>
			<INPUT style="Z-INDEX: 111; LEFT: 528px; WIDTH: 56px; POSITION: absolute; TOP: 111px; HEIGHT: 24px"
				type="button" value="-->" onclick="RemoveGroup();"> <INPUT style="Z-INDEX: 112; LEFT: 528px; WIDTH: 56px; POSITION: absolute; TOP: 167px; HEIGHT: 24px"
				type="button" value="<--" onclick="AddGroup();"> <INPUT style="Z-INDEX: 113; LEFT: 112px; WIDTH: 60px; POSITION: absolute; TOP: 325px; HEIGHT: 25px"
				type="button" value="修改" onclick="displaymodifyuser()" id="Button1">
			<div id="demo1" style="Z-INDEX:899"><FONT face="宋体">&nbsp; </FONT>
			</div>
		</form>
	</body>
</html>

