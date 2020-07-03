var tablelistds;
var title = new Array();
var checkid=null;
var mulselect=null;
var useMethod=null;
var pageMethod=null;
var varelideCols = null;

function showtablelist(conid,padid,pagecount,tablelistds1,title1,canmul,tempmethod,isPagechange,elideCols)
{
	tablelistds = tablelistds1;
	title = title1;
	mulselect = canmul;
	useMethod = tempmethod;
	pageMethod = isPagechange;
	if(elideCols==null)
	{
	    varelideCols = new Array(0);
	}
	else
	{
	    varelideCols = elideCols;
	}    
	PageIt(conid,padid,pagecount,0);
}


function PageIt(conid,padid,pagecount,beginNum)
{
	checkid=null;
	if(pageMethod)
	{
		var currentpage = Math.round(beginNum/pagecount+0.5);
		try
		{
			PageCommonMethod(currentpage);
		}
		catch(err)
		{

		}
	}
	var InfoDiv = document.getElementById(conid);
	var s = new Array();
	var pads = new Array();
	if(tablelistds==null)
	{
	    s[s.length] = "<table width=100% border=1 bordercolor=#C0C0C0 bgcolor=#FFFFFF  class=\"Mytable\" >";
	    s[s.length] = "<tr class=\"HeatTR\" nowrap=\"nowrap\">";
		for(var i=0;i<title.length;i++)
		{
			s[s.length] = "<td align=center>" + title[i] +"</td>";
		}
		s[s.length] = "</tr>";
	    s[s.length] = "<tr nowrap=\"nowrap\"><td align=\"center\" colspan="+title.length+">There is no any data!</td></tr>";
	    s[s.length] = "</table>"; 
	}
	
	if(tablelistds!=null && typeof(tablelistds)=="object" && tablelistds.Tables!=null)
	{
		s[s.length] = "<table width=100% border=1 bordercolor=#C0C0C0 bgcolor=#FFFFFF  class=\"Mytable\" >";
		s[s.length] = "<tr class=\"HeatTR\" nowrap=\"nowrap\">";
		for(var i=0;i<title.length;i++)
		{
			s[s.length] = "<td align=center>" + title[i] +"</td>";
		}
		s[s.length] = "</tr>";
		
		var Col = title.length;
		var Row=tablelistds.Tables[0].Rows.length;
		var discount = Row-beginNum;
		if(discount>pagecount) discount=pagecount;
		pads[pads.length] = "<table width=\"250px\" ><tr>";
		
		/////first page
		pads[pads.length] = "<td style=\"cursor:hand\" width=60px ";
		if(beginNum>0)
		{
			pads[pads.length] = "onclick=\"PageIt('"+conid+"','"+padid+"',"+pagecount+",0)\" ";
		}
		pads[pads.length] = "><img id=\"myfirstPagepng\" alt=\"First Page\" src=\"image/firstPage.gif\" onmouseover=\"this.src='image/firstPage2.gif'\" onmouseout=\"this.src='image/firstPage.gif'\"   /></td>";
		
		
		////previous page
		pads[pads.length] = "<td style=\"cursor:hand\" width=60px  ";
		if((beginNum-pagecount)>=0)
		{
			var currentrow = beginNum-pagecount;
			pads[pads.length] = "onclick=\"PageIt('"+conid+"','"+padid+"',"+pagecount+","+currentrow+")\" ";
		}
		pads[pads.length] = "><img id=\"myprevPagepng\" alt=\"Prev Page\" src=\"image/prevPage.gif\"  onmouseover=\"this.src='image/prevPage2.gif'\" onmouseout=\"this.src='image/prevPage.gif'\"    /></td>";
		
		
		////next page
		pads[pads.length] = "<td style=\"cursor:hand\"  width=60px  ";
		if(Row>(beginNum+pagecount))
		{
			var currentrow = beginNum+pagecount;
			pads[pads.length] = "onclick=\"PageIt('"+conid+"','"+padid+"',"+pagecount+","+currentrow+")\" ";
		}
		pads[pads.length] = "><img id=\"mynextPagepng\" alt=\"Next Page\" src=\"image/nextPage.gif\"  onmouseover=\"this.src='image/nextPage2.gif'\" onmouseout=\"this.src='image/nextPage.gif'\"  /></td>";
		
		
		////last page
		pads[pads.length] = "<td style=\"cursor:hand\" width=60px  ";
		var currentpage = Math.round(beginNum/pagecount+0.5)*pagecount;
		if(currentpage<Row)
		{
			var currentrow = Math.round(Row/pagecount-0.5)*pagecount;
			pads[pads.length] = "onclick=\"PageIt('"+conid+"','"+padid+"',"+pagecount+","+currentrow+")\" ";
		}
		pads[pads.length] = "><img id=\"mylastPagepng\" alt=\"Last Page\" src=\"image/lastPage.gif\"  onmouseover=\"this.src='image/lastPage2.gif'\" onmouseout=\"this.src='image/lastPage.gif'\"  /></td>";
		pads[pads.length] = "<td align=right>";
		var totpage = Math.round(Row/pagecount+0.49999);
		var curpage = Math.round((beginNum+1)/pagecount+0.49999);
		pads[pads.length] = curpage+"/"+totpage;
		pads[pads.length] = "</td>"; 
		pads[pads.length] = "<td align=right>";
		pads[pads.length] = "Total:"+Row;
		pads[pads.length] = "</td>";
		pads[pads.length] = "</tr></table>";
		
		document.getElementById(padid).innerHTML = pads.join("");
		for(var i=beginNum;i<(discount+beginNum);i++)
		{
			s[s.length] = "<tr align=center id=\"tr"+i+"\" onMouseOver=\" SetBgColor(this)\" onmouseout=\"OrgBgColor(this)\" onClick=\" onClickSetBgColor(this);";
			if(useMethod)
			{
				
				s[s.length] = "TrCommonMethod("+i+");";
			}
			s[s.length] = " \" >";	
			
			/////对特长的字段进行省略处理，同时使用提示的方式显示完整内容		
			var elideCollength = varelideCols.length;
			var elidei = 0;
			if(Col>0)
			{
			    s[s.length] = "<td align=center id=\"tr"+i+'_td0'+"\"><input  style='WIDTH: 30px'type='checkbox' id=\"c"+i+"\" onclick=\"SetCheckID('c"+i+"')\" ></td>";
			}
			if(Col>1)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==1)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td1'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL1 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL1); 
			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td1'+"\">" + tablelistds.Tables[0].Rows[i].COL1 +"</td>";
				}    
			}
			if(Col>2)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==2)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td2'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL2 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL2);
			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td2'+"\">" + tablelistds.Tables[0].Rows[i].COL2 +"</td>";
				}    
			}
			if(Col>3)
			{
				if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==3)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td3'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL3 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL3);
			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td3'+"\">" + tablelistds.Tables[0].Rows[i].COL3 +"</td>";
				}    
			}
			if(Col>4)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==4)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td4'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL4 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL4);
			        elidei++;
			    }
			    else
			    {			
				    s[s.length] = "<td align=center id=\"tr"+i+'_td4'+"\">" + tablelistds.Tables[0].Rows[i].COL4 +"</td>";
				}    
			}
			if(Col>5)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==5)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td5'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL5 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL5);  
			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td5'+"\">" + tablelistds.Tables[0].Rows[i].COL5 +"</td>";
				}
			}
			if(Col>6)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==6)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td6'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL6 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL6); 
			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td6'+"\">" + tablelistds.Tables[0].Rows[i].COL6 +"</td>";
				}    
			}
			if(Col>7)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==7)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td7'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL7 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL7);
			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td7'+"\">" + tablelistds.Tables[0].Rows[i].COL7 +"</td>";
				}    
			}
			if(Col>8)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==8)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td8'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL8 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL8); 
			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td8'+"\">" + tablelistds.Tables[0].Rows[i].COL8 +"</td>";
				}    
			}
			if(Col>9)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==9)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td9'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL9 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL9);
			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td9'+"\">" + tablelistds.Tables[0].Rows[i].COL9 +"</td>";
				}
			}
			if(Col>10)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==10)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td10'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL10 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL10); 
			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td10'+"\">" + tablelistds.Tables[0].Rows[i].COL10 +"</td>";
				}    
			}
			if(Col>11)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==11)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td11'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL11 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL11);
			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td11'+"\">" + tablelistds.Tables[0].Rows[i].COL11 +"</td>";
				}    
			}
			if(Col>12)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==12)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td12'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL12 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL12);  
			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td12'+"\">" + tablelistds.Tables[0].Rows[i].COL12 +"</td>";
				}    
			}
			if(Col>13)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==13)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td13'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL13 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL13);
			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td13'+"\">" + tablelistds.Tables[0].Rows[i].COL13 +"</td>";
				}    
			}
			if(Col>14)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==14)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td14'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL14 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL14); 
			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td14'+"\">" + tablelistds.Tables[0].Rows[i].COL14 +"</td>";
				}    
			}
			if(Col>15)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==15)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td15'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL15 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL15);
			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td15'+"\">" + tablelistds.Tables[0].Rows[i].COL15 +"</td>";
				}    
			}
			if(Col>16)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==16)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td16'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL16 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL16);
			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td16'+"\">" + tablelistds.Tables[0].Rows[i].COL16 +"</td>";
				}    
			}
			if(Col>17)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==17)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td17'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL17 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL17);
			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td17'+"\">" + tablelistds.Tables[0].Rows[i].COL17 +"</td>";
				}    
			}
			if(Col>18)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==18)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td18'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL18 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL18);
			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td18'+"\">" + tablelistds.Tables[0].Rows[i].COL18 +"</td>";
				}    
			}
			if(Col>19)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==19)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td19'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL19 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL19);
			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td19'+"\">" + tablelistds.Tables[0].Rows[i].COL19 +"</td>";
				}    
			}
			if(Col>20)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==20)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td20'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL20 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL20);
			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td20'+"\">" + tablelistds.Tables[0].Rows[i].COL20 +"</td>";
				}    
			}
			if(Col>21)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==21)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td21'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL21 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL21)+"</td>";
 			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td21'+"\">" + tablelistds.Tables[0].Rows[i].COL21 +"</td>";
				}    
			}
			if(Col>22)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==22)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td22'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL22 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL22);
			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td22'+"\">" + tablelistds.Tables[0].Rows[i].COL22 +"</td>";
				}    
			}
			if(Col>23)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==23)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td23'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL23 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL23);
			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td23'+"\">" + tablelistds.Tables[0].Rows[i].COL23 +"</td>";
				}    
			}
			if(Col>24)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==24)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td24'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL24 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL24); 
			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td24'+"\">" + tablelistds.Tables[0].Rows[i].COL24 +"</td>";
				}    
			}
			if(Col>25)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==25)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td25'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL25 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL25);
			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td25'+"\">" + tablelistds.Tables[0].Rows[i].COL25 +"</td>";
				}   
			}
			if(Col>26)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==26)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td26'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL26 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL26);
			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td26'+"\">" + tablelistds.Tables[0].Rows[i].COL26 +"</td>";
				}    
			}
			if(Col>27)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==27)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td27'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL27 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL27);
			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td27'+"\">" + tablelistds.Tables[0].Rows[i].COL27 +"</td>";
				}    
			}
			if(Col>28)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==28)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td28'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL28 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL28);
			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td28'+"\">" + tablelistds.Tables[0].Rows[i].COL28 +"</td>";
				}    
			}
			if(Col>29)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==29)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td29'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL29 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL29);
			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td29'+"\">" + tablelistds.Tables[0].Rows[i].COL29 +"</td>";
				}    
			}
			if(Col>30)
			{
			    if(elideCollength>0&&elideCollength>elidei&&varelideCols[elidei]==30)
			    {
			        s[s.length] = "<td align=center id=\"tr"+i+'_td30'+"\" title=\""+ tablelistds.Tables[0].Rows[i].COL30 +"\" >" + elidestring(tablelistds.Tables[0].Rows[i].COL30);
			        elidei++;
			    }
			    else
			    {
				    s[s.length] = "<td align=center id=\"tr"+i+'_td30'+"\">" + tablelistds.Tables[0].Rows[i].COL30 +"</td>";
				}    
			}
			
			s[s.length] = "</tr>";
		
		}
		s[s.length] = "</table>";		
		
	}
	
	InfoDiv.innerHTML =s.join("");
    //correctPNG("myfirstPagepng");
    //correctPNG("myprevPagepng");
    //correctPNG("mynextPagepng");
    //correctPNG("mylastPagepng");
    
}



function SetBgColor(obj)
{
	var tempid=obj.id;
	var mycheckid="c"+tempid.substring(2,tempid.length); 
	if(document.getElementById(mycheckid).checked)
	{
		
	}
	else
	{
		obj.bgColor="#EDF5FC";
		obj.style.color="#2D72AA";
	}
}

function OrgBgColor(obj)
{
	var tempid=obj.id;
	var mycheckid="c"+tempid.substring(2,tempid.length); 
	if(document.getElementById(mycheckid).checked)
	{
		
	}
	else
	{
		obj.bgColor="";
		obj.style.color="";
	}
}

function onClickSetBgColor(obj)
{
	var tempid = obj.id;
	var mycheckid = "c"+tempid.substring(2,tempid.length);
	if(document.getElementById(mycheckid).checked)
	{
		document.getElementById(mycheckid).checked = false;
		obj.bgColor="";
		obj.style.color="";
		checkid=null;
	}
	else
	{
		document.getElementById(mycheckid).checked = true;
		obj.bgColor="#000000";
		obj.style.color="#ffffff";
		SetCheckID(mycheckid);
	}
}

function SetCheckID(conid)
{
	if(mulselect)
	{
		checkid = conid.substring(1,conid.length);	
	}
	else
	{
		if(checkid!=null)
		{
			try
			{
				document.getElementById("tr"+checkid).bgColor="";
				document.getElementById("tr"+checkid).style.color="";
				document.getElementById("c"+checkid).checked = false;
			}
			catch(err)
			{

			}
		}
		checkid = conid.substring(1,conid.length);
	}
}


function checkelide(tempstr)
{
    if(tempstr!=null&&tempstr.length>8)
        return true;
    else
        return false;
}

function elidestring(tempstr)
{
    if(checkelide(tempstr))
        return tempstr.substring(0,6)+"...";
    else
        return tempstr;
}


function correctPNG(conid)
{
      var img = document.getElementById(conid);
      if(img!=null)
      {
	    var LW=img.width;
	    var LH=img.height;
	    var imgName = img.src.toUpperCase();
	    img.style.filter+="progid:DXImageTransform.Microsoft.AlphaImageLoader(src="+img.src+", sizingmethod=scale);";
        img.src="/image/transparent.gif";
        img.width=LW;
        img.height=LH;
      }  
}


function PosCurrentRow(conid,padid,pagecount,tempRow)
{
    if(tempRow!=null)
    {
        var currentpage = Math.round(tempRow/pagecount-0.5);
        var startRow = currentpage*pagecount;
        PageIt(conid,padid,pagecount,startRow);
        var obj = document.getElementById("tr"+tempRow);
        onClickSetBgColor(obj);
    }

}