namespace MESIF
{
    using AppSvrIF;
    using System;
    using System.Configuration;
    using System.Data;
    using System.Web.Configuration;

    public class MESAgent
    {
        private Session m_Session = new Session();

        public MESAgent()
        {
            string str = ConfigurationManager.AppSettings["MESServer"];
            string str2 = ConfigurationManager.AppSettings["Account"];
            string str3 = ConfigurationManager.AppSettings["Password"];
            this.m_Session.ConnectionStr = str;
            this.m_Session.User = str2;
            this.m_Session.Password = str3;
        }
        
        /// <summary>
        /// 获取主从表
        /// </summary>
        /// <param name="strMethod"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public DataSet GetMainSecondTable(string strMethod, string param)
        {
            if (!m_Session.Opened)
            {
                int num = this.m_Session.Open();
                if (num != 0)
                {
                    throw new Exception("服务没有打开！");
                }
            }
            AppSvrIF.Command cmdMaterial = null;
            int iRet = m_Session.CreateCommand((int)AppSvrIF.CommandType.Call, @"XGMESLogic\BaseDataMag\CBaseData_Mag\BaseData_Mag", strMethod, ref cmdMaterial);
            if (iRet != 0)
                return null;
            cmdMaterial.set_Parameters(0, param);
            m_Session.Execute(cmdMaterial);

            DataSet dsMain = cmdMaterial.get_Parameters(1) as DataSet;
            if (dsMain == null)
                return null;
            if (dsMain.Tables.Count < 1)
                return null;
            //从表
            DataSet dsReturn = cmdMaterial.Return as DataSet;
            if (dsReturn == null)
                return null;
            if (dsReturn.Tables.Count < 1)
                return null;
            DataSet dsM = new DataSet();
            //组织主表记录集
            DataTable tbM = new DataTable();
            tbM = dsMain.Tables[0].Clone();
            tbM = dsMain.Tables[0].Copy();
            tbM.TableName = "M";
            dsM.Tables.Add(tbM);
            //组织从表记录集
            DataTable tbS = new DataTable();
            tbS = dsReturn.Tables[0].Clone();
            tbS = dsReturn.Tables[0].Copy();
            tbS.TableName = "s1";
            dsM.Tables.Add(tbS);
            return dsM;
            
        }
        public int SendToMES(string type, DataTable tb)
        {
            MESIFDataConfigSection webApplicationSection = WebConfigurationManager.GetWebApplicationSection("MESIFDataConfigSection") as MESIFDataConfigSection;
            if (webApplicationSection == null)
            {
                return -1;
            }
            MESIFDataConfigElement element = webApplicationSection.MESIFDatas[type];
            if (element == null)
            {
                return -2;
            }
            string str = element.Target.Trim();
            string target = element.Method.Trim();
            if (((str == null) || (target == null)) || ((str.Length < 1) || (target.Length < 1)))
            {
                return -3;
            }
            int num = this.m_Session.Open();
            if (num != 0)
            {
                return num;
            }
            Command cmd = null;
            num = this.m_Session.CreateCommand(5, str, target, ref cmd);
            if (num != 0)
            {
                return num;
            }
            if (cmd.ParameterCount != 1)
            {
                return -3;
            }
            DataSet set = new DataSet("L3DataSet");
            DataTable table = tb.Clone();
            table.Merge(tb);
            table.TableName = "L3DataTable";
            set.Tables.Add(table);
            cmd.set_Parameters(0, set);
            num = this.m_Session.Execute(cmd);
            if (num != 0)
            {
                return num;
            }
            if (!Convert.ToBoolean(cmd.Return))
            {
                return (int) cmd.ErrorCode;
            }
            this.m_Session.Close();
            return 0;
        }



        /// <summary>
        /// 使用session执行sql命令（update，insert）
        /// 返回0则成功，其他为错误代码
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public string exeSql(string sql)
        {
            try
            {
                int num = this.m_Session.Open();
                if (num != 0)
                {
                    return num.ToString();
                }
                Command cmd = null;
                //创建sql命令
                int result = m_Session.CreateCommand(14, sql, "", ref cmd);
                if (result == 0)
                {
                    //使用session执行sql命令
                    return m_Session.Execute(cmd).ToString();

                }
                else
                {
                    return result.ToString();
                }
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }

           
         
        }
        /// <summary>
        /// 获取objurl（表/主键）路径下某项的值
        /// </summary>
        /// <param name="objUrl"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public object getValue(string objUrl, string item)
        {
            try
            {
                object Obj = new object();
                if (!m_Session.Opened)
                {
                    int num = this.m_Session.Open();
                    if (num != 0)
                    {
                        return "错误" + num;
                    }
                }
                int i = m_Session.Get(objUrl, item, ref Obj);
                if (i == 0)
                {
                    return Obj;
                }
                else
                {
                    return "错误" + i;
                }
            }
            catch (Exception ex)
            {
                return "错误"+ex.ToString();
            }


          
        }
    }
}

