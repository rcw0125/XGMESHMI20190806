//此脚本用于插入日历表格
//编写：谢瑞
//2005-12-27
//版权：托日公司

function show(conid,tagad,ccdate)
{
	var cc;
	var myy,mym,myd;
	if(ccdate==null)
	{	
		var today = new Date();
		myy = today.getFullYear();
		mym = today.getMonth()+1;
		if(mym<10) mym = "0"+mym;
		myd = today.getDate();
		if(myd<10) myd = "0" + myd;
		cc = myy+"-"+mym+"-"+myd;
	}
	else
	{
		cc = ccdate;
		myy = cc.substr(0,4);
		mym = cc.substr(5,2);
		myd = cc.substr(8,2);
	}
	

	var val = document.getElementById(conid);
	var s = new Array();
	s[s.length] = "";
	val.innerHTML = s.join("");
	s[s.length] = "<table border='1' bordercolor=\"#448EBB\"cellpadding=\"1\" cellspacing=\"0\" bgcolor=\"#F4F9FF\"><tr height =20px><td bordercolor=\"#FFFFFF\" width=30px align = right style =\"cursor:hand;\" onclick=\"mydecrease('"+conid+"','"+tagad+"',"+myy+","+mym+","+myd+")\" ><<</td>";
	s[s.length] = "<td bordercolor=\"#FFFFFF\" style =\"cursor:hand;\"  onclick=\"monthdec('"+conid+"','"+tagad+"',"+myy+","+mym+","+myd+")\" ><</td><td  bordercolor=\"#FFFFFF\" align='center' style='font-size:12'>"+cc+"</td>";
	s[s.length] = "<td bordercolor=\"#FFFFFF\" style =\"cursor:hand;\" onclick=\"monthcre('"+conid+"','"+tagad+"',"+myy+","+mym+","+myd+")\">></td><td  bordercolor=\"#FFFFFF\" style =\"cursor:hand;\" onclick=\"mycrease('"+conid+"','"+tagad+"',"+myy+","+mym+","+myd+")\">>></td>";
	s[s.length] = "<td bordercolor=\"#FFFFFF\" style =\"cursor:hand;\" onclick=\"hide('"+conid+"','"+tagad+"','"+ccdate+"')\"><img src=\"image/X2.gif\" align = 'right' ></td></tr>";
	s[s.length] = "<tr><td bordercolor=\"#FFFFFF\" colspan=6><table ><tr><td  bordercolor=\"#FFFFFF\"style='font-size:12'>SUN</td><td  bordercolor=\"#FFFFFF\"style='font-size:12'>MON</td><td bordercolor=\"#FFFFFF\" style='font-size:12'>TUS</td><td bordercolor=\"#FFFFFF\" style='font-size:12'>WEN</td><td bordercolor=\"#FFFFFF\" style='font-size:12'>THU</td><td  bordercolor=\"#FFFFFF\" style='font-size:12'>FRI</td><td bordercolor=\"#FFFFFF\" style='font-size:12'>SAT</td></tr>";
	s[s.length] = "<tr>";                                                                       
	                                                                                                    
	
	var i = getFirstDay(myy,mym);
	for(var m=0;m<i;m++)
	{
		s[s.length] = "<td>&nbsp;</td>";
	}
	var j = getMonthLen(myy,mym);
	
	for(var n=1;n<=j;n++)
	{
		if(i>6)
		{
			i=0;
			s[s.length] = "</tr><tr>";	
		}
		if(i==0||i==6)
		{
			if(n==myd)
				s[s.length] = "<td align='right' bgcolor='blue'style =\"cursor:hand;color:yellow;font-size:12;\" onclick=\"myclick('"+myy+"-"+mym+"','"+n+"','"+conid+"','"+tagad+"')\">"+n+"</td>";
			else
				s[s.length] = "<td align='right' style =\"cursor:hand;font-size:12;\" onclick=\"myclick('"+myy+"-"+mym+"','"+n+"','"+conid+"','"+tagad+"')\"><font color=red>"+n+"</font></td>";
			
		}  
		
		else
		{
			if(n==myd)
				s[s.length] = "<td align='right' bgcolor='blue' style =\"cursor:hand;color:yellow;font-size:12;\" onclick=\"myclick('"+myy+"-"+mym+"','"+n+"','"+conid+"','"+tagad+"')\">"+n+"</td>";
			else
				s[s.length] = "<td align='right' style =\"cursor:hand;font-size:12;\" onclick=\"myclick('"+myy+"-"+mym+"','"+n+"','"+conid+"','"+tagad+"')\">"+n+"</td>";
		}
		i++;
	}
	for(var k=i;k<7;k++)
	{
		s[s.length] = "<td>&nbsp;</td>"
	
	}
	
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

function myclick(ym,myd,conid,tagetid)
{
	if(myd<10) myd = "0"+myd;
	document.getElementById(tagetid).value = ym+"-"+myd;
	var s = new Array();
	s[s.length] = "&nbsp;";
	var val = document.getElementById(conid);
	val.innerHTML = s.join("");
	
}

///////减少一年
function mydecrease(conid,tagad,myy,mym,myd)
{
	myy = myy-1;
	if(mym<10) mym = "0"+mym;
	if(myd<10) mym = "0"+myd;
	var cc = myy+"-"+mym+"-"+myd;
	show(conid,tagad,cc);
}
//////增加一年
function mycrease(conid,tagad,myy,mym,myd)
{
	myy = myy + 1;
	if(mym<10) mym = "0"+mym;
	if(myd<10) mym = "0"+myd;
	var cc = myy + "-" + mym + "-" + myd;
	show(conid,tagad,cc);
}

//////减少一个月
function monthdec(conid,tagad,myy,mym,myd)
{
	if(mym>1)
		mym = mym-1;
	else
	{
		myy = myy-1;
		mym = 12;
	}
	if(mym<10) mym = "0"+mym;
	if(myd<10) myd = "0"+myd;
	var cc = myy + "-" + mym + "-" + myd;
	show(conid,tagad,cc);
}

//////增加一个月
function monthcre(conid,tagad,myy,mym,myd)
{
	if(mym<12)
		mym = mym+1;
	else
	{
		myy = myy+1;
		mym = 1;
	}
	if(mym<10) mym = "0" + mym;
	if(myd<10) myd = "0" + myd;
	var cc = myy + "-" + mym + "-" + myd;
	show(conid,tagad,cc);
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
