using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OracleClient;

/// <summary>
/// Class1 的摘要说明
/// </summary>
public class CommonCmd
{
    //数据库连接
    private Service1 svr = new Service1();
    string strDate = "";
    //获取表结构信息
    public DataTable GetTableStructInfo(string strTableName,ref int xPos,ref int yPos)
    {
        string strSql = string.Format("select name,code_id from PSVCC_CODESET where substr(code_id,1,4) = '{0:s}'and CODE_ID_DESC='ABB' order by code_id asc", strTableName);
        DataTable dt = new DataTable();
        string strID = "";
        string strDirect = "";
        dt = svr.Query("", strSql).Tables[0];
        DataTable dtTarget = new DataTable();
        dtTarget.Columns.Add("Name");
        dtTarget.Columns.Add("Code_ID");
        dtTarget.Columns.Add("Direct");
        dtTarget.Columns.Add("Position");
        int iCount = 1;
        //strID = dt.Rows[0]["code_id"].ToString();
        //strDirect = strID.Substring(10, 1);
        //strID = dt.Rows[dt.Rows.Count]["code_id"].ToString();
        int iPozi = 1, iDir = 1;
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            strID = dt.Rows[i]["code_id"].ToString();
            strDirect = strID.Substring(10, 1);
            if (strDirect == "1")
            {
                dtTarget.Rows.Add();
                dtTarget.Rows[i]["Name"] = dt.Rows[i]["name"].ToString();
                strID = dt.Rows[i]["code_id"].ToString();
                dtTarget.Rows[i]["Code_ID"] = strID;
                strDirect = strID.Substring(10, 1);
                iCount =  System.Convert.ToInt32( strID.Substring(11,3));
                //if (iCount > xPos)
                //{
                //    xPos = iCount;
                //}
                dtTarget.Rows[i]["Direct"] = 0;
                dtTarget.Rows[i]["Position"] = xPos = iPozi;
                iPozi++;
            }
            else if (strDirect == "2")
            {
                dtTarget.Rows.Add();
                dtTarget.Rows[i]["Name"] = dt.Rows[i]["name"].ToString();
                strID = dt.Rows[i]["code_id"].ToString();
                dtTarget.Rows[i]["Code_ID"] = strID;
                iCount = System.Convert.ToInt32(strID.Substring(11, 3));
                //if (iCount > yPos)
                //{
                //    yPos = iCount;
                //}
                dtTarget.Rows[i]["Direct"] = yPos = iDir;
                dtTarget.Rows[i]["Position"] = 0;
                iDir++;
            }
        }

        //二维记录集表
        return dtTarget;
    }

    //保存前台数据
    public bool SaveData(DataTable dtSource)
    {
        DataTable dtTmp = new DataTable();
        try
        {
            string strErr;
            string strTableName = "PSVCC_RPT_" + dtSource.TableName.Substring(1, 2);
            int i;
            //strTableName = string.Format("insert into PSVCC_RPT_{0:s%} ",strTableName);
            string strSql;
            int Colcount = dtSource.Columns.Count;
            string[] strValue = new string[100];    //插入值
            //string[] strColName = new string[100];  //列名
            //string[] strConName = new string[100];  //主键名
            //string[] strConValue = new string[100]; //主键值
            //string strCondition = "";               //主键串
            //int ConCount=0;                           //主键列数

            //GetKeyName(strTableName, ref strConName, ref ConCount);
            //strCondition = "where ";
            //strCondition = string.Format("{0:s} {1:s} = '{2:s}{3:d}:s{4:s}'", strCondition, strConName[0], "{", 0,"}");
            //for (i = 1; i < ConCount ; i++)
            //{
            //    strCondition = string.Format("{0:s} and {1:s} = '{2:s}{3:d}:s{4:s}'", strCondition, strConName[i], "{", i,"}");
            //}
            //插入列参数
            string strNameArgs = " (";
            for (i = 0; i < Colcount - 1; i++)
            {
                strNameArgs = string.Format("{0:s%} {1:s%} ,", strNameArgs, dtSource.Columns[i].ColumnName.ToString());
            }
            strNameArgs = string.Format("{0:s%} {1:s%} )", strNameArgs, dtSource.Columns[i].ColumnName.ToString());

            string strValueArgs = " values(";
            for (i = 0; i < Colcount - 1; i++)
            {
                strValueArgs = string.Format("{4:%s} '{0:%s}{1:d}:{2:%s}{3:%s}' ,", "{", i, @"s", "}", strValueArgs);
            }
            strValueArgs = string.Format("{4:%s} '{0:%s}{1:d}:{2:%s}{3:%s}')", "{", i, @"s%", "}", strValueArgs);


            strDate = dtSource.Rows[0]["FDATE"].ToString();
            //先删除当天的报表记录
            
            //开始事务
            if (svr.NewTrans() != true)
            {
                return false;
            }
            strSql = string.Format("delete from {0:s} where FDATE = '{1:s}'", strTableName, dtSource.Rows[0]["FDATE"].ToString());
            strErr = svr.dmldata(strSql);
            if (strErr != "0")
            {
                throw new Exception(strErr);
            }
            //重新
            foreach (DataRow dr in dtSource.Rows)
            {
                for (i = 0; i < Colcount; i++)
                {
                    strValue[i] = dr[i].ToString();
                }
                //for (i = 0; i < ConCount; i++)
                //{
                //    strConValue[i] = dr[strConName[i]].ToString();
                //}
                //strConValue[0] = string.Format(strCondition, strConValue);
                //strSql = string.Format("select {0:s} from {1:s} {2:s}", strConName[0], strTableName, strConValue[0]);
                //dtTmp = svr.Query("", strSql).Tables[0];
                //if (dtTmp.Rows.Count > 0)
                //{
                //    strSql = string.Format("delete from {0:s} {1:s}", strTableName, strConValue[0]);
                //    svr.Delete("", strSql);
                //}
                strValue[0] = string.Format(strValueArgs, strValue);
                strSql = string.Format("insert into {3:s} {0:%s}{1:%s}{2:%s}", strTableName, strNameArgs, strValue[0], strTableName);
                strErr = svr.dmldata(strSql);
                if (strErr != "0")
                {
                    throw new Exception(strErr);
                }


            }

            //插入报表导出表
            strSql = string.Format("delete from psvcc_rpt_export where tempname ='{0:s}' and rptdate = '{1:s}'", "a.xls", strDate);
            svr.dmldata(strSql);
            strSql = string.Format("insert into psvcc_rpt_export values('{0:s}','','{1:s}')", "a.xls", strDate);
            svr.dmldata(strSql);
            if (svr.CommitTrans() != true)
            {
                throw new Exception("");
            }
            return true;
        }
        catch(Exception e)
        {
            svr.RollbackTrans();
            return false;
        }

    }

    /// <summary>
    /// 保存前台数据(大宗原燃料)
    /// </summary>
    /// <param name="dtSource"></param>
    /// <param name="flag">用于一般的值集代码</param>
    /// <returns></returns>
    public bool SaveData(DataTable dtSource, int flag, string strTableName,string csSQL)
    {
        DataTable dtTmp = new DataTable();
        try
        {
            string strErr;
            //string strTableName = "PSVCC_RPT_" + dtSource.TableName.Substring(1, 2)+"_2";
            int i;
            //strTableName = string.Format("insert into PSVCC_RPT_{0:s%} ",strTableName);
            string strSql;
            int Colcount = dtSource.Columns.Count; 
            string[] strValue = new string[100];    //插入值
            //插入列参数
            string strNameArgs = " (";
            for (i = 0; i < Colcount - 1; i++)
            {
                strNameArgs = string.Format("{0:s%} {1:s%} ,", strNameArgs, dtSource.Columns[i].ColumnName.ToString());
            }
            strNameArgs = string.Format("{0:s%} {1:s%} )", strNameArgs, dtSource.Columns[i].ColumnName.ToString());

            string strValueArgs = " values(";
            for (i = 0; i < Colcount - 1; i++)
            {
                strValueArgs = string.Format("{4:%s} '{0:%s}{1:d}:{2:%s}{3:%s}' ,", "{", i, @"s", "}", strValueArgs);
            }
            strValueArgs = string.Format("{4:%s} '{0:%s}{1:d}:{2:%s}{3:%s}')", "{", i, @"s%", "}", strValueArgs);


            strDate = dtSource.Rows[0]["FDATE"].ToString();
            //先删除当天的报表记录

            //开始事务
            if (svr.NewTrans() != true)
            {
                return false;
            }
            if (csSQL != "")
                strSql = csSQL;
            else
                strSql = string.Format("delete from {0:s} where FDATE = '{1:s}'", strTableName, dtSource.Rows[0]["FDATE"].ToString());
            strErr = svr.dmldata(strSql);
            if (strErr != "0")
            {
                throw new Exception(strErr);
            }
            //重新
            foreach (DataRow dr in dtSource.Rows)
            {
                for (i = 0; i < Colcount; i++)
                {
                    strValue[i] = dr[i].ToString();
                }
                strValue[0] = string.Format(strValueArgs, strValue);
                //strSql = string.Format("insert into {3:s} {0:%s}{1:%s}{2:%s}", strTableName, strNameArgs, strValue[0], strTableName);
                strSql = string.Format("insert into {0:%s}{1:%s}{2:%s}", strTableName, strNameArgs, strValue[0], strTableName);
                strErr = svr.dmldata(strSql);
                if (strErr != "0")
                {
                    throw new Exception(strErr);
                }


            }
            //插入报表导出表
            strSql = string.Format("delete from psvcc_rpt_export where tempname ='{0:s}' and rptdate = '{1:s}'", "a.xls", strDate);
            svr.dmldata(strSql);
            strSql = string.Format("insert into psvcc_rpt_export values('{0:s}','','{1:s}')", "a.xls", strDate);
            svr.dmldata(strSql);

            if (svr.CommitTrans() != true)
            {
                throw new Exception("");
            }
            return true;
        }
        catch (Exception e)
        {
            svr.RollbackTrans();
            return false;
        }

    }

    
    //删除单记录查询
    public bool SaveData(DataTable dtSource,string strNull)
    {
        DataTable dtTmp = new DataTable();
        try
        {
            string strErr;
            string strTableName = "PSVCC_RPT_" + dtSource.TableName.Substring(1, 2);
            int i;
            //strTableName = string.Format("insert into PSVCC_RPT_{0:s%} ",strTableName);
            string strSql;
            int Colcount = dtSource.Columns.Count;
            string[] strValue = new string[100];    //插入值
            string[] strColName = new string[100];  //列名
            string[] strConName = new string[100];  //主键名
            string[] strConValue = new string[100]; //主键值
            string strCondition = "";               //主键串
            int ConCount = 0;                           //主键列数

            GetKeyName(strTableName, ref strConName, ref ConCount);
            strCondition = "where ";
            strCondition = string.Format("{0:s} {1:s} = '{2:s}{3:d}:s{4:s}'", strCondition, strConName[0], "{", 0, "}");
            for (i = 1; i < ConCount; i++)
            {
                strCondition = string.Format("{0:s} and {1:s} = '{2:s}{3:d}:s{4:s}'", strCondition, strConName[i], "{", i, "}");
            }
            //插入列参数
            string strNameArgs = " (";
            for (i = 0; i < Colcount - 1; i++)
            {
                strNameArgs = string.Format("{0:s%} {1:s%} ,", strNameArgs, dtSource.Columns[i].ColumnName.ToString());
            }
            strNameArgs = string.Format("{0:s%} {1:s%} )", strNameArgs, dtSource.Columns[i].ColumnName.ToString());

            string strValueArgs = " values(";
            for (i = 0; i < Colcount - 1; i++)
            {
                strValueArgs = string.Format("{4:%s} '{0:%s}{1:d}:{2:%s}{3:%s}' ,", "{", i, @"s", "}", strValueArgs);
            }
            strValueArgs = string.Format("{4:%s} '{0:%s}{1:d}:{2:%s}{3:%s}')", "{", i, @"s%", "}", strValueArgs);
            strDate = dtSource.Rows[0]["FDATE"].ToString();

            //开始事务
            if (svr.NewTrans() != true)
            {
                return false;
            }
            //strSql = string.Format("delete from {0:s} where FDATE = '{1:s}'", strTableName, dtSource.Rows[0]["FDATE"].ToString());
            //strErr = svr.dmldata(strSql);
            //if (strErr != "0")
            //{
            //    throw new Exception(strErr);
            //}
            //重新
            foreach (DataRow dr in dtSource.Rows)
            {
                for (i = 0; i < Colcount; i++)
                {
                    strValue[i] = dr[i].ToString();
                }
                for (i = 0; i < ConCount; i++)
                {
                    strConValue[i] = dr[strConName[i]].ToString();
                }
                strConValue[0] = string.Format(strCondition, strConValue);
                strSql = string.Format("select {0:s} from {1:s} {2:s}", strConName[0], strTableName, strConValue[0]);
                dtTmp = svr.Query("", strSql).Tables[0];
                if (dtTmp.Rows.Count > 0)
                {
                    //删除老记录
                    strSql = string.Format("delete from {0:s} {1:s} and FDATE = '{2:s}'", strTableName, strConValue[0],strDate);
                    svr.dmldata(strSql);
                }
                strValue[0] = string.Format(strValueArgs, strValue);
                strSql = string.Format("insert into {3:s} {0:%s}{1:%s}{2:%s}", strTableName, strNameArgs, strValue[0], strTableName);
                strErr = svr.dmldata(strSql);
                if (strErr != "0")
                {
                    throw new Exception(strErr);
                }


            }
            strSql = string.Format("delete from psvcc_rpt_export where tempname ='{0:s}' and rptdate = '{1:s}'", "a.xls", strDate);
            svr.dmldata(strSql);
            strSql = string.Format("insert into psvcc_rpt_export values('{0:s}','','{1:s}')", "a.xls", strDate);
            svr.dmldata(strSql);
            if (svr.CommitTrans() != true)
            {
                throw new Exception("");
            }
            ExcelWrite.RptExport exp = new ExcelWrite.RptExport();
            return true;
        }
        catch (Exception e)
        {
            svr.RollbackTrans();
            return false;
        }

    }


    //查询报表数据
    public DataTable GetData(string strTableName, string strDate)
    {
        string strName = "PSVCC_RPT_" + strTableName.Substring(1, 2);
        string strSql = string.Format("select * from {0:s} where fdate = '{1:s}'", strName, strDate);
        return svr.Query("",strSql).Tables[0];
    }

    //查数据
    public DataTable Query(string strSql)
    {
        return svr.Query("", strSql).Tables[0];
    }
    //查找表关键字
    private void GetKeyName(string strTableName, ref string []strName,ref int count)
    {
        string strSql = string.Format("select column_name from user_cons_columns wherE CONSTRAINT_NAME in (select CONSTRAINT_NAME from user_constraints where table_name =upper('{0:s}') and CONSTRAINT_TYPE='P')", strTableName);
        DataTable dtTmp = new DataTable();
        dtTmp = svr.Query("", strSql).Tables[0];
        count = dtTmp.Rows.Count;
        for (int i = 0; i < count; i++)
        {
            strName[i] = dtTmp.Rows[i][0].ToString();
        }
    }

}
