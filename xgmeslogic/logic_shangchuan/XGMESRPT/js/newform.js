//此脚本用于插入图层
//编写：谢瑞
//2006-03-20
//版权：托日公司

var stat;
var xx,yy;
var vx,vy,vx1,vy1;


function showform(conid,fleft,ftop,fwidth,fheight,fcaption,fs,candrag)
{
	if(candrag&&fleft<140)
		fleft = 140;
	if(candrag&&ftop<140)
		ftop = 140;
    if(fwidth>600)
		fleft = 30;
		
  newform(conid,fleft,ftop,fwidth,fheight);
  addtable(conid,fwidth,fheight,fcaption,fs,candrag);
  //adjustBGFormLayer();
}

function newform(conid,fleft,ftop,fwidth,fheight)
{

  var s = new Array();
  var bfleft,bftop;
  var leftwidth,downheight;
  bfleft = fleft+5;
  bftop = ftop+6;
  s[s.length] = "<div id=\"NewFormLayer\" style=\"Z-INDEX:901;LEFT:";
  s[s.length] = fleft+"px;WIDTH:"+fwidth+";POSITION: absolute; TOP:"+ftop+"px; filter:progid:DXImageTransform.Microsoft.Shadow(color=#999999,direction=135);  \"></div>";

  document.getElementById(conid).innerHTML = s.join("");
  stat = "0";
}


function addtable(conid,fwidth,fheight,fcaption,fs,candrag)
{

  var ss = new Array();
  leftwidth = fwidth-22;
  downheight = fheight-22;
  //标题表格
	ss[ss.length] = "<table width='100%' height='33px' border='0' cellspacing='0' cellpadding='0'>";
	ss[ss.length] = "<tr>";
	ss[ss.length] = "		<td id='dialog_top_Left' width='20'  >&nbsp;</td>";
	if(candrag)
	{
		ss[ss.length] = "		<td id = 'dialog_top_Center' onmousedown=\"movemyform()\"  onmousemove=\"movemyformto()\"   ondrag=\"movemyformto()\" onmouseup=\"stopmyform()\"> "+ fcaption + "</td>";
		
	}
	else
		ss[ss.length] = "		<td id = 'dialog_top_Center'>"+ fcaption +"</td>";
	
	ss[ss.length] = "		<td id='dialog_top_right'><img id= 'dialog_Close' alert = ' Close ' src='image/dialog_close.gif' onclick=\"closemyform('"+conid+"')\"></td>";
	ss[ss.length] = "  </tr>";
	ss[ss.length] = "</table>";
	
	//内容
	ss[ss.length] = "<table id='__01' width='100%' border='0' cellpadding='0' cellspacing='0' background='image/dialog1_06.gif'>";
	ss[ss.length] = "	<tr>";
	ss[ss.length] = "		<td id = 'dialog_center_left' width='7'  >&nbsp;</td>";
	ss[ss.length] = "		<td width='92%'>"+fs+"</td>";
	ss[ss.length] = "		<td id = 'dialog_center_right' >&nbsp;</td>";
	ss[ss.length] = "	</tr>";
	ss[ss.length] = "</table>";
	
	//表格下端
	ss[ss.length] = "<table width='100%' border='0' cellpadding='0' cellspacing='0'>";
	ss[ss.length] = "  <tr>";
	ss[ss.length] = "		<td id= 'dialog_bottom_left'  >		</td>";
	ss[ss.length] = "	    <td id= 'dialog_bottom_center' >&nbsp;</td>";
	ss[ss.length] = "	    <td id= 'dialog_bottom_right'></td>";
	ss[ss.length] = "  </tr>";
	ss[ss.length] = "</table>";

 document.getElementById("NewFormLayer").innerHTML = ss.join(""); 
}


function movemyform()
{
	stat = "1";
	xx = event.x;
	yy = event.y; 
	vx = parseInt(document.getElementById("NewFormLayer").style.left)-xx;
	vy = parseInt(document.getElementById("NewFormLayer").style.top)-yy;
//	vx1 = parseInt(document.getElementById("BGNewFormLayer").style.left)-xx;
//	vy1 = parseInt(document.getElementById("BGNewFormLayer").style.top)-yy;
}

function movemyformto()
{
	if(stat=="1")
	{
		document.getElementById("NewFormLayer").style.left = event.x+vx;
		document.getElementById("NewFormLayer").style.top = event.y+vy;
//		document.getElementById("BGNewFormLayer").style.left = event.x+vx1;
//		document.getElementById("BGNewFormLayer").style.top = event.y+vy1;
	}
}

function stopmyform()
{
	stat = "0";
}

function closemyform(conid)
{
	document.getElementById(conid).innerHTML = "";
}

		