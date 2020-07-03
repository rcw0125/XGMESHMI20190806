///////功能描述
//////网页间传递参数脚本
//////编写：谢瑞
//////时间：2006-01-05

function GetParam()
{
	var allstr = location.search;
	allstr = allstr.substring(1,allstr.length);
	var myParam = new Array(0);
	var aPos = allstr.indexOf("&");
	var qPos;
	while(aPos>0)
	{
		var strtemp = allstr.substring(0,aPos);
		qPos = strtemp.indexOf("=");
		strtemp = strtemp.substring(qPos+1);
		myParam[myParam.length] = strtemp; 
		allstr = allstr.substring(aPos+1);
		aPos = allstr.indexOf("&");
	}
	qPos = allstr.indexOf("=");
	allstr = allstr.substring(qPos+1);
	myParam[myParam.length] = allstr;
	return myParam;
}
