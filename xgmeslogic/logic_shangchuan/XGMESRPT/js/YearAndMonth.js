// JScript 文件
//此脚本用于插入日历表格(只显示年和月)
//2006-11-29
//版权：托日公司

function showYearAndMon(conid,tagad,ccdate)
{  
	var cc;
	var myy,mym;   
	if(ccdate==null)
	{	
		var today = new Date();
		myy = today.getFullYear();
		mym = today.getMonth()+1;
		if(mym<10) mym = "0"+mym;
		cc = myy+"-"+mym
	}
	else
	{
		cc = ccdate;
		myy = cc.substr(0,4);
		mym = cc.substr(5,2);
	}
	

	var val = document.getElementById(conid);
	var s = new Array();
	s[s.length] = "";
	val.innerHTML = s.join("");
	s[s.length] = "<table border='1' bordercolor=\"#448EBB\"cellpadding=\"1\" cellspacing=\"0\" bgcolor=\"#F4F9FF\"><tr height =20px ><td bordercolor=\"#FFFFFF\" width=30px align = right style =\"cursor:hand;\" onclick=\"mydecrease('"+conid+"','"+tagad+"',"+myy+","+mym+")\" ><<</td>";
	//s[s.length] = "<table border='1' bgcolor=\"#F4F9FF\"><tr height =20px ><td bordercolor=\"#FFFFFF\" width=30px align = right style =\"cursor:hand;\" onclick=\"mydecrease('"+conid+"','"+tagad+"',"+myy+","+mym+")\" ><<</td>";
	s[s.length] = "<td bordercolor=\"#FFFFFF\" style =\"cursor:hand;\"  onclick=\"monthdec('"+conid+"','"+tagad+"',"+myy+","+mym+")\" ><</td><td  bordercolor=\"#FFFFFF\" align='center' style='font-size:12'>"+cc+"</td>";
	s[s.length] = "<td bordercolor=\"#FFFFFF\" style =\"cursor:hand;\" onclick=\"monthcre('"+conid+"','"+tagad+"',"+myy+","+mym+")\">></td><td  bordercolor=\"#FFFFFF\" style =\"cursor:hand;\" onclick=\"mycrease('"+conid+"','"+tagad+"',"+myy+","+mym+")\">>></td>";
	s[s.length] = "<td bordercolor=\"#FFFFFF\" style =\"cursor:hand;\" onclick=\"hide('"+conid+"','"+tagad+"','"+ccdate+"')\"><img src=\"image/X2.gif\" align = 'right' ></td>";
	s[s.length] = "<td align='right'bgcolor='#FFFFFF'  style =\"cursor:hand;\" onclick=\"myclick('"+myy+"-"+mym+"','"+conid+"','"+tagad+"')\">OK</td></tr>";
	//s[s.length] = "<td align='right'bgcolor='green'  style =\"cursor:hand;font-size:12;\"  onclick=\"myclick('"+myy+"-"+mym+"','"+conid+"','"+tagad+"')\">OK</td>";
	s[s.length] = "</tr></table></td></tr></table>";	
	val.innerHTML = s.join("");
	var divpos = document.getElementById(tagad).getBoundingClientRect();
	val.style.left = divpos.left-2;
	val.style.top = divpos.top+20;
}

function hide(conid,tagad,ccdate)
{
	var s = new Array();
	s[s.length] = "&nbsp";
	var val = document.getElementById(conid);
	val.innerHTML = s.join("");
	document.getElementById(tagad).value = ccdate;
}
function myclick(ym,conid,tagetid)
{
	document.getElementById(tagetid).value = ym;
	var s = new Array();
	s[s.length] = "&nbsp;";
	var val = document.getElementById(conid);
	val.innerHTML = s.join("");	
}

///////减少一年
function mydecrease(conid,tagad,myy,mym)

{
	myy = myy-1;
	if(mym<10) mym = "0"+mym;
	var cc = myy+"-"+mym;
	showYearAndMon(conid,tagad,cc);
}
//////增加一年
function mycrease(conid,tagad,myy,mym)

{
	myy = myy + 1;
	if(mym<10) mym = "0"+mym;
    var cc = myy + "-" + mym;
	showYearAndMon(conid,tagad,cc);
}

//////减少一个月
function monthdec(conid,tagad,myy,mym)
{
	if(mym>1)
		mym = mym-1;
	else
	{
		myy = myy-1;
		mym = 12;
	}
	if(mym<10) mym = "0"+mym;
	var cc = myy + "-" + mym;
	showYearAndMon(conid,tagad,cc);
}

//////增加一个月
function monthcre(conid,tagad,myy,mym)
{
	if(mym<12)
		mym = mym+1;
	else
	{
		myy = myy+1;
		mym = 1;
	}
	if(mym<10) mym = "0" + mym;
    var cc = myy + "-" + mym;
	showYearAndMon(conid,tagad,cc);
}


/************** 取得月份的第一天为星期几 *********************/
function getFirstDay(theYear, theMonth)
{
var firstDate = new Date(theYear,theMonth-1,1);
return firstDate.getDay();
}


/************** 取得月份共有几天 *********************/
function getMonthLen(theYear, theMonth) {
theMonth--;
var oneDay = 1000 * 60 * 60 * 24;
var thisMonth = new Date(theYear, theMonth, 1);
var nextMonth = new Date(theYear, theMonth + 1, 1);
var len = Math.ceil((nextMonth.getTime() - thisMonth.getTime())/oneDay);
return len;
}

