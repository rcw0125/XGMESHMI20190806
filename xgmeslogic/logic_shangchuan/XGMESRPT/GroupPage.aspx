<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GroupPage.aspx.cs" Inherits="GroupPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
		<title>GroupPage</title>
		<style type="text/css"> body { background-image: url(../image/bg.gif); font-size: 10px; margin-left: 0px; margin-top: 0px; }
		</style>
		<LINK href="CSS/style.css" type="text/css" rel="stylesheet">
		<script language="javascript" src="JS/newform.js" type="text/javascript"></script>
		<script language="javascript">
		var selectid;
		
		///////get all groups
		function getAllGroup()
		{
		    //parent.topFrame.document.getElementById("QueryInfo").innerText="授权管理";		  
			var response = GroupPage.getAllGroup();
			var ds = response.value;
			var s = new Array();
			if(ds!=null && typeof(ds) == "object" && ds.Tables!=null)
			{
				if(ds.Tables[0].Rows.length>0)
				{
					s[s.length] = "<SELECT id=\"SelectGroupList\" size=\"16\" style=\"Z-INDEX: 101; WIDTH: 320px; POSITION: absolute; HEIGHT: 253px\" onclick=\"getAllGroupPage();\" >";
					s[s.length] = "<option value=\"\">(null)</option>";
					for(var i=0;i<ds.Tables[0].Rows.length;i++)
					{
						s[s.length] = "<option value=\""+ds.Tables[0].Rows[i].GROUPNAME+"\">"+ds.Tables[0].Rows[i].GROUPNAME+"</option>";
					}
				}	
				s[s.length] = "</SELECT>";
				document.getElementById("GroupList").innerHTML = s.join("");
			}
		}
		
		///////get all relation page of the group
		function getAllGroupPage()
		{
			var response = GroupPage.getAllPage(0);
			var ds = response.value;
			var s = new Array();			
			s[s.length] = "<table  border=1 id=\"SelectGroupPageMap\" width=100% class=\"Mytable\">";
			if(ds!=null && typeof(ds) == "object" && ds.Tables!=null)
			{
				for(var i=0;i<ds.Tables[0].Rows.length;i++)
				{
					s[s.length] = "<tr><td align=\"left\"><input id=\"m"+ds.Tables[0].Rows[i].PAGEID+"\" type=checkbox style=\"width:15px\" onclick=\"ChangeCheckbox(this);\"></td><td id=t"+ds.Tables[0].Rows[i].PAGEID+" align=\"left\" onclick=\"changebg("+ds.Tables[0].Rows[i].PAGEID+") \">"+ds.Tables[0].Rows[i].PAGENAME+"</td></tr>";
					var cresponse = GroupPage.getAllPage(ds.Tables[0].Rows[i].PAGEID);
					var cds = cresponse.value;
					if(cds!=null && typeof(cds) == "object" && cds.Tables!=null)
					{
						if(cds.Tables[0].Rows.length>0)
						{
							for(var j=0;j<cds.Tables[0].Rows.length;j++)
							{
								s[s.length] = "<tr><td align=\"left\"><input id=\"m"+cds.Tables[0].Rows[j].PAGEID+"\" type=checkbox style=\"width:15px\" onclick=\"ChangeCheckbox(this);\"></td><td id=t"+cds.Tables[0].Rows[j].PAGEID+" align=\"right\" onclick=\"changebg("+cds.Tables[0].Rows[j].PAGEID+") \" >"+cds.Tables[0].Rows[j].PAGENAME+"</td></tr>";
							}
						}
					}
				}
			}
			s[s.length] = "</table>";
			document.getElementById("GroupPage").innerHTML = s.join("");	
			
			var response = GroupPage.getPageIDByName(document.getElementById("SelectGroupList").value);
			var ds = response.value;
			if(ds!=null && typeof(ds) == "object" && ds.Tables!=null)
			{
				for(var i=0;i<ds.Tables[0].Rows.length;i++)
				{
					document.getElementById("m"+ds.Tables[0].Rows[i].PAGEID).checked = true;
				}
			}
		}
	
		function changebg(tdid)
		{
			if(selectid!=null)
			{
				document.getElementById("t"+selectid).style.backgroundColor = "";
			}
			selectid = tdid;
			document.getElementById("t"+tdid).style.backgroundColor = "#7799aa";
		}
	
	
		function ChangeCheckbox(obj)
		{
			var j = document.getElementById("SelectGroupList").selectedIndex;
			if(j>0)
			{
				if(obj.checked)
				{
					var response = GroupPage.addRelation(document.getElementById("SelectGroupList").value,obj.id.substring(1,obj.id.length));
					var retval = response.value;
					if(retval!="0")
					{
						alert(retval);
					}
				}
				else
				{
					var response = GroupPage.delRelation(document.getElementById("SelectGroupList").value,obj.id.substring(1,obj.id.length));
					var retval = response.value;
					if(retval!="0")
					{
						alert(retval);
					}
				}
			}
			else
			{
				alert("请选择一个组进行操作");
				obj.checked = false;
			}
		}
	
	
	function displayaddpage()
	{
		var s=new Array();
		s[s.length] = "<table width=100% height=100% border=0>";
		s[s.length] = "<tr>";
		s[s.length] = "<td>是否根目录</td><td><input id=yes style=\"width:15px\" type=\"radio\" onclick=\"if(this.checked){this.checked=false;}else{this.checked=true;document.getElementById('no').checked=false;}\">是</td><td><input id=no style=\"width:15px\" type=\"radio\" onclick=\"if(this.checked){this.checked=false;}else{this.checked=true;document.getElementById('yes').checked=false;}\">否</td> ";
		s[s.length] = "</tr><tr>";
		s[s.length] = "<td>上一级目录</td><td colspan=2><select id=selectgrouppage style=\"width:100px\">";
		var response = GroupPage.getAllPage(0);
		var ds = response.value;
		for(var i=0;i<ds.Tables[0].Rows.length;i++)
		{
			s[s.length] = "<option value=\""+ds.Tables[0].Rows[i].PAGENAME+"\">"+ds.Tables[0].Rows[i].PAGENAME+"</option>";
		}
		s[s.length] = "</select>";
		s[s.length] = "</tr><tr>";
		s[s.length] = "<td>网页名称</td><td colspan=2><input id=newpagename type=text style=\"width:150px\"></td>";
		s[s.length] = "</tr><tr>";
		s[s.length] = "<td>网页URL</td><td colspan=2><input id=newpageurl type=text style=\"width:150px\"></td>";
		s[s.length] = "</tr><tr>";
		s[s.length] = "<td colspan=3 align=center><input type=button value=提交 onclick=\"addnewpage()\"></td>"; 
		s[s.length] = "</tr>";
		s[s.length] = "</table>";
//		showform('demo1',250,370,300,200,'New Page',s.join(""),false);
		showform('demo1',250,300,300,200,'新增网页',s.join(""),true); //邓强20080311
	}
	
	
	function addnewpage()
	{
		var response = GroupPage.addnewpage(document.getElementById("yes").checked,document.getElementById("selectgrouppage").value,document.getElementById("newpagename").value,document.getElementById("newpageurl").value);
		var retval = response.value;
		document.getElementById("demo1").innerHTML = "";
		if(retval!="0")
		{
			alert(retval);
		}
		else getAllGroupPage();
	}
	
	function displaydelpage()
	{
		if(selectid!=null)
		{
			var s = new Array();
//			s[s.length] = "<table width=100% height=100% valign=top ><tr><td align=center>Are you sure <font color=red>DELETE</font> this Page? <br>It will delete the Page-Group relation at the same time .</td></tr>";
			s[s.length] = "<table width=100% height=100% valign=top ><tr><td align=center>确定要 <font color=red>删除</font> 该页? <br>如果删除该页,所有组别将不能访问该页.</td></tr>";
			s[s.length] = "<tr><td align=center><input type=button value=\"删除\" onclick=\"deletePage()\"></td></tr></table>";
//			showform('demo1',250,370,250,200,'Delete Page',s.join(""),false);
			showform('demo1',250,300,250,200,'删除网页',s.join(""),true);　　　//邓强20080311
		}
		else
		{
			alert("请选择一项进行操作!");
		}
	}	
	
	
	function deletePage()
	{
		var response = GroupPage.delpage(selectid);
		var retval = response.value;
		document.getElementById("demo1").innerHTML = "";
		if(retval!="0")
		{
			alert(retval);
		}
		else getAllGroupPage();
	}
	
	
	function displayeditpage()
	{
		if(selectid!=null)
		{
			var response = GroupPage.getPageInfobyID(selectid);
			var ds = response.value;
			var s=new Array();
			s[s.length] = "<table width=100% height=100% border=1>";
			s[s.length] = "<tr>";
			s[s.length] = "<td>是否根目录</td><td><input id=yes style=\"width:15px\" type=\"radio\" onclick=\"if(this.checked){this.checked=false;}else{this.checked=true;document.getElementById('no').checked=false;}\">是</td><td><input id=no style=\"width:15px\" type=\"radio\" onclick=\"if(this.checked){this.checked=false;}else{this.checked=true;document.getElementById('yes').checked=false;}\">否</td> ";
			s[s.length] = "</tr><tr>";
			s[s.length] = "<td>上一级目录</td><td colspan=2><select id=selectgrouppage style=\"width:100px\">";
			var cresponse = GroupPage.getAllPage(0);
			var cds = cresponse.value;
			for(var i=0;i<cds.Tables[0].Rows.length;i++)
			{
				if(ds.Tables[0].Rows[0].PAGEPARENT==cds.Tables[0].Rows[i].PAGEID)
				{
					s[s.length] = "<option value=\""+cds.Tables[0].Rows[i].PAGENAME+"\" selected>"+cds.Tables[0].Rows[i].PAGENAME+"</option>";
				}
				else s[s.length] = "<option value=\""+cds.Tables[0].Rows[i].PAGENAME+"\">"+cds.Tables[0].Rows[i].PAGENAME+"</option>";
			}
			s[s.length] = "</select>";
			s[s.length] = "</tr><tr>";
			s[s.length] = "<td>网页名称</td><td colspan=2><input id=newpagename type=text style=\"width:150px\"></td>";
			s[s.length] = "</tr><tr>";
			s[s.length] = "<td>网页URL</td><td colspan=2><input id=newpageurl type=text style=\"width:150px\"></td>";
			s[s.length] = "</tr><tr>";
			s[s.length] = "<td colspan=3 align=center><input type=button value=提交 onclick=\"modifypage()\"></td>"; 
			s[s.length] = "</tr>";
			s[s.length] = "</table>";
//			showform('demo1',250,370,250,200,'Modify Page',s.join(""),false); 	
            showform('demo1',250,300,250,200,'修改网页',s.join(""),true);  //邓强20080311 	
			
			if(ds.Tables[0].Rows.length>0)
			{
				if(ds.Tables[0].Rows[0].PAGEPARENT=="0")
				{
					document.getElementById("yes").checked = true;
				}
				else  document.getElementById("no").checked = true;
				
				document.getElementById("newpagename").value = ds.Tables[0].Rows[0].PAGENAME;
				document.getElementById("newpageurl").value = ds.Tables[0].Rows[0].ACTIONNAME;
			}
		}
		else
		{
			alert("请选择一项进行操作!");
		}
		
	}
	
	function modifypage()
	{
		var response = GroupPage.modifypage(selectid,document.getElementById("yes").checked,document.getElementById("selectgrouppage").value,document.getElementById("newpagename").value,document.getElementById("newpageurl").value);
		var retval = response.value;
		document.getElementById("demo1").innerHTML = "";
		if(retval!="0")
		{
			alert(retval);
		}
		else getAllGroupPage();
	}
	
		
     </script>
	</head>
	<body onload="getAllGroup();getAllGroupPage();" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<div id="GroupList" style="Z-INDEX: 101; LEFT: 70px; WIDTH: 320px; POSITION: absolute; TOP: 64px; HEIGHT: 253px"></div>
			<INPUT style="Z-INDEX: 107; LEFT: 648px; WIDTH: 56px; POSITION: absolute; TOP: 329px; HEIGHT: 25px"
				type="button" value="删除" onclick="displaydelpage()"><INPUT style="Z-INDEX: 106; LEFT: 586px; WIDTH: 56px; POSITION: absolute; TOP: 329px; HEIGHT: 25px"
				type="button" value="修改" onclick="displayeditpage()">
			<div id="GroupPage" style="OVERFLOW-Y: auto; Z-INDEX: 102; LEFT: 446px; WIDTH: 317px; POSITION: absolute; TOP: 63px; HEIGHT: 249px; border:solid 1px #cccccc"></div>
			<DIV style="DISPLAY: inline; Z-INDEX: 103; LEFT: 70px; WIDTH: 318px; POSITION: absolute; TOP: 32px; HEIGHT: 23px"
				align="center"><font size="4">组别列表</font></DIV>
			<DIV style="DISPLAY: inline; Z-INDEX: 104; LEFT: 447px; WIDTH: 319px; POSITION: absolute; TOP: 29px; HEIGHT: 24px"
				align="center" ms_positioning="FlowLayout"><font size="4">组页对照表</font></DIV>
			<INPUT style="Z-INDEX: 105; LEFT: 524px; WIDTH: 56px; POSITION: absolute; TOP: 330px; HEIGHT: 24px"
				onclick="displayaddpage()" type="button" value="新增" id="Button1">
			<div id="demo1" style="Z-INDEX: 899"><FONT face="宋体"></FONT></div>
		</form>
   	</body>
</html>

