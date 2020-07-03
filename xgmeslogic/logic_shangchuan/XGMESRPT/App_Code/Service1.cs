using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data;
using System.Data.OracleClient;
using System.Configuration;
using System.IO;


public class Service1 
{
    public Service1 () {

        //如果使用设计的组件，请取消注释以下行 
        //InitializeComponent(); 
        gkconnstr = ConfigurationManager.AppSettings["oraclestr"];
        gkconn.ConnectionString = gkconnstr;

    }

    private string gkconnstr;
    private OracleConnection gkconn = new OracleConnection();

    
    public OracleTransaction gktrans;


    public bool NewTrans()
    {
        try
        {
            if (gkconn.State == ConnectionState.Closed)
            {
                gkconn.Open();
                gktrans = gkconn.BeginTransaction();
            }

            return true;
        }
        catch (Exception e)
        {
            if (gkconn.State == ConnectionState.Open)
            {
                gktrans.Rollback();
                gkconn.Close();
            }
            return false;
        }
    }

    public bool CommitTrans()
    {
        try
        {
            gktrans.Commit();
            gkconn.Close();
            return true;
        }
        catch (Exception e)
        {
            if (gkconn != null)
            gktrans.Rollback();
            gkconn.Close();
            return false;
        }
    }

    public bool RollbackTrans()
    {
        try
        {
            gktrans.Rollback();
            gkconn.Close();
            return true;
        }
        catch (Exception ex)
        {
            if (gkconn.State == ConnectionState.Open)
            {
                gkconn.Close();
            }
            return false;
        }
    }

    [WebMethod]
    public string dmldata(string strSql)
    {
        bool bMark = false;
        try
        {
            OracleCommand myCommand = new OracleCommand(strSql);
            //if (gkconn.State == ConnectionState.Closed)
            //{
            //    gkconn.Open();
            //    gktrans = gkconn.BeginTransaction();
            //    bMark = true;
            //}
            myCommand.Connection = gkconn;
            myCommand.Transaction = gktrans;
            myCommand.ExecuteNonQuery();
            //if (bMark == true)
            //{
            //    gktrans.Commit();
            //    gkconn.Close();
            //}
            return "0";
        }
        catch (Exception e)
        {
            //if (bMark == true)
            //{
            //    gktrans.Rollback();
            //    gkconn.Close();
            //}
            return e.Message;
        }   
    }



    [WebMethod]
	public string Insert(string VerifyInfo,string tablename,DataSet newdata)
	{
		////连接数据库
		string connstr;
		
		connstr = ConfigurationManager.AppSettings["oraclestr"];
		OracleConnection conn = new OracleConnection(connstr);
        conn.Open();
        OracleTransaction mytrans = conn.BeginTransaction();

		string sqlinsert;
		string sqlhead,sqlvalue;
		int i,j,k;

		i = newdata.Tables[0].Rows.Count;
		j = newdata.Tables[0].Columns.Count;
		sqlinsert = "Insert into "+ tablename + " ( ";
		sqlhead = "";
		sqlvalue = "";
		for(k=0;k<j;k++)
		{
			if(k>0) 
			{
				sqlhead += ",";
				sqlvalue += ",";
			}
			sqlhead += newdata.Tables[0].Columns[k].ColumnName ;
			if(newdata.Tables[0].Rows[0][k].GetType()==Type.GetType("System.Int32")||newdata.Tables[0].Rows[0][k].GetType()==Type.GetType("System.Double")||newdata.Tables[0].Rows[0][k].GetType()==Type.GetType("System.Int16"))
			{
				sqlvalue +=Convert.ToString(newdata.Tables[0].Rows[0][k]);
			}
			else if(newdata.Tables[0].Rows[0][k].GetType()==Type.GetType("System.DateTime"))
			{
				sqlvalue +="'" +Convert.ToString(Convert.ToDateTime(newdata.Tables[0].Rows[0][k]))+"'";
			}
			else
			{
				sqlvalue +="'"+ newdata.Tables[0].Rows[0][k]+"'";
			}
			
		}
		sqlinsert += sqlhead + ") values("+sqlvalue+")";

		try
		{
			OracleCommand myCommand = new OracleCommand(sqlinsert);
			myCommand.Connection = conn;
            myCommand.Transaction = mytrans;
			
			myCommand.ExecuteNonQuery();
            mytrans.Commit();
			conn.Close();
		}
		catch (Exception e)
		{
            mytrans.Rollback();
			conn.Close();
			return e.Message;
		}
		return "0";				
	}

	[WebMethod]
	public DataSet Query(string VerifyInfo,string SqlStr)
	{
        
		string connstr;
        connstr = ConfigurationManager.AppSettings["oraclestr"];
        DataSet myDataSet = new DataSet();
        try
        {
            OracleConnection conn = new OracleConnection(connstr);
            OracleDataAdapter adapter = new OracleDataAdapter();

            //conn.Open();
            
            adapter.SelectCommand = new OracleCommand(SqlStr, conn);
            adapter.Fill(myDataSet);

            conn.Close();
        }
        catch (Exception e)
        {
            string cc = e.Message;
            return null;

        }
        return myDataSet;
	}

[WebMethod]
	public string Update(string VerifyInfo,string SqlStr)
	{
		////连接数据库
		string connstr;
        connstr = ConfigurationManager.AppSettings["oraclestr"];
		OracleConnection conn = new OracleConnection(connstr);
		conn.Open();
        OracleTransaction mytrans = conn.BeginTransaction();
		try
		{
			OracleCommand myCommand = new OracleCommand(SqlStr);
			myCommand.Connection = conn;
            myCommand.Transaction = mytrans;
			myCommand.ExecuteNonQuery();
            mytrans.Commit();
			conn.Close();
		}
		catch (Exception e)
		{
            mytrans.Rollback();
			conn.Close();
			return e.Message;
		}
		return "0";		

	}


	[WebMethod]
	public string Delete(string VerifyInfo,string SqlStr)
	{
		////连接数据库
		string connstr;
        connstr = ConfigurationManager.AppSettings["oraclestr"];
		OracleConnection conn = new OracleConnection(connstr);
		conn.Open();
        OracleTransaction mytrans = conn.BeginTransaction();
		try
		{
			OracleCommand myCommand = new OracleCommand(SqlStr);
			myCommand.Connection = conn;
            myCommand.Transaction = mytrans;
			myCommand.ExecuteNonQuery();
            mytrans.Commit();
			conn.Close();
		}
		catch (Exception e)
		{
            mytrans.Rollback();
			conn.Close();
			return e.Message;
		}
		return "0";		
	}

	[WebMethod]
	public string GetSeqNum(string VerifyInfo,string DescInfo)
	{
		string connstr;
        connstr = ConfigurationManager.AppSettings["oraclestr"];
		OracleConnection conn  = new OracleConnection(connstr);
		long retSeq = 0;
		long MaxSeq = 0;
		long MinSeq = 0;
		long SeqLength = 0;
		
		try
		{
			string strSql = "Select SEQNO,MAXSEQ,MINSEQ,SEQLENS from COMM_SEQUENCE where SEQDESC='"+DescInfo+"'";
			OracleCommand clsComd = new OracleCommand(strSql,conn);
			
			OracleDataReader clsReader;
			clsReader = clsComd.ExecuteReader();
			if(clsReader.Read())
			{
				retSeq = clsReader.GetInt64(0);
				MaxSeq = clsReader.GetInt64(1);
				MinSeq = clsReader.GetInt64(2);
				SeqLength = clsReader.GetInt64(3);
			}
			conn.Close();
			if(retSeq<MaxSeq)
				strSql = "Update COMM_SEQUENCE Set SEQNO=SEQNO+1 where SEQDESC='"+DescInfo+"'";
			else
				strSql = "Update COMM_SEQUENCE Set SEQNO="+Convert.ToString(MinSeq)+" where SEQDESC='"+DescInfo+"'";
			clsComd.CommandText = strSql;
			conn.Open();
            OracleTransaction mytrans = conn.BeginTransaction();
            try
            {
                clsComd.Transaction = mytrans;
                clsComd.ExecuteNonQuery();
                mytrans.Commit();
                conn.Close();
            }
            catch (Exception mye)
            {
                mytrans.Rollback();
                conn.Close();
                return mye.Message;
            }
            
		}
		catch(Exception e)
		{
			conn.Close();
			return e.Message;
		}

		string tempSeq = Convert.ToString(retSeq);
		for(int i=tempSeq.Length;i<SeqLength;i++)
			tempSeq = "0"+tempSeq;
		return  tempSeq;
	}

	[WebMethod]
	public string GetSystemTime(string VerifyInfo,string FormatString)
	{

		string strY,strM,strD,strh,strm,strs,strz;
		DateTime cc = DateTime.Now;
		strY = Convert.ToString(cc.Year);
		strM = Convert.ToString(cc.Month);
		if(cc.Month<10)
			strM = "0"+strM;
		strD = Convert.ToString(cc.Day);
		if(cc.Day<10)
			strD = "0"+strD;
		strh = Convert.ToString(cc.Hour);
		if(cc.Hour<10)
			strh = "0"+strh;
		strm = Convert.ToString(cc.Minute);
		if(cc.Minute<10)
			strm = "0"+strm;
		strs = Convert.ToString(cc.Second);
		if(cc.Second<10)
			strs = "0"+strs;
		strz = Convert.ToString(cc.Millisecond);

		FormatString = FormatString.Replace("YYYY",strY);
		FormatString = FormatString.Replace("MM",strM);
		FormatString = FormatString.Replace("DD",strD);
		FormatString = FormatString.Replace("hh",strh);
		FormatString = FormatString.Replace("mm",strm);
		FormatString = FormatString.Replace("ss",strs);
		FormatString = FormatString.Replace("zzz",strz);
	
		return FormatString;
	}
	

	[WebMethod]
	public DataSet GetCurrentShiftTeam(string VerifyInfo)
	{
		////连接数据库
		string connstr;
        connstr = ConfigurationManager.AppSettings["oraclestr"];
		DataSet myDataSet = new DataSet();
		string SqlStr;
		try
		{
			SqlStr = "select SHIFT,TEAM,SEQUENCE_NO,BEGIN_TIME,END_TIME from OTHER_CURRENT_TEAM";
			OracleConnection conn = new OracleConnection(connstr);
			OracleDataAdapter adapter = new OracleDataAdapter();

			adapter.SelectCommand = new OracleCommand(SqlStr,conn);
			adapter.Fill(myDataSet);

			conn.Close();
		}
		catch(Exception e)
		{
			string cc = e.Message;
			return null;
		}
		return myDataSet;

	}

}


