
//此脚本用于验证文本框中输入内容
//编写：谢瑞
//2005-12-23


////有效长度验证
	function ValidLength(conname,conlength)
	{
		var cc = document.getElementById(conname).value;
		if (cc.length>conlength) 
		{
			
			//alert(document.getElementById(conname).name+"文本控件长度超过"+conlength +"位！");
			alert(document.getElementById(conname).name+" Text Length overstep "+conlength +" chars!" );
			document.getElementById(conname).value = cc.substr(0,conlength);
		} 			
	}
	
		
//////有效数字验证		
	function ValidNum(conname)
	{
		var cc = document.getElementById(conname).value;
		for(i=0;i<cc.length;i++)
		{
			var xixi = cc.charCodeAt(i);
			if((xixi<48 || xixi>57) && (xixi!=46))  
			{
				//alert(document.getElementById(conname).name +"有效数字验证");
				alert(" This is not a valid number!");
				document.getElementById(conname).value="";
			}
		}
		
	}		
		
	function ValidChemicalNum(conid,minv,maxv)
		{
		          ValidNum(conid);
		          if (document.getElementById(conid).value < minv || document.getElementById(conid).value >	maxv)
		          {	
		             document.getElementById(conid).value = "";
		             //alert("有效范围0-100");
		          }
                  if((conid=="PopWeight") || (conid=="NI")||(conid=="CR")||(conid=="Weight"))
                  {
                       var value1 =document.getElementById(conid).value;
                       if(value1.substring(value1.indexOf(".")+1,value1.length).length>3)
                       document.getElementById(conid).value= value1.substring(0,value1.length-1);
                  }
		}


		
	function ABBRound(oldvalue)
	{
		var newvalue = oldvalue*1000;
		newvalue = Math.round(newvalue); 
		newvalue = newvalue/1000;
		return newvalue;
	}
