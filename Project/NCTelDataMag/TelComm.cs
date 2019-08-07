using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Web;
using System.Net;
using System.Configuration;
using System.Reflection;

namespace NCTelDataMag
{
    public class TelComm
    {
        public static string NCServer = @"http://192.168.2.68:80/service/XChangeServlet?account=1&amp;receiver=101 ";
        public static string TranslateDataSetToNC(string strxslt, DataSet data)
        {
            System.Xml.Xsl.XslCompiledTransform trans = new System.Xml.Xsl.XslCompiledTransform();
            trans.Load(strxslt);
            string strTmpDir = Path.GetTempPath();
            //string strLogDir = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "DataSent");
            string strLogDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string strDataFile = Path.Combine(strTmpDir, "MES_Data.xml");
            string strXmlFile = Path.Combine(strLogDir, string.Format("{0}.xml", "MES_Data"));
            data.WriteXml(strDataFile);
            trans.Transform(strDataFile, strXmlFile);
            return strXmlFile;
        }

        public static string XmlGetElement(XmlDocument doc, string value)
        {
            XmlNode root = doc.DocumentElement.FirstChild;
            IEnumerator ienum = root.GetEnumerator();
            XmlElement book = null;
            while (ienum.MoveNext())
            {
                book = (XmlElement)ienum.Current;
                if (book.Name.Equals(value))
                {                   
                    break;
                }

            }

            return (book != null) ? book.InnerText : null;
        }

        public static string TransferXML(string strXML)
        {
            try
            {
                //1�������ж�ȡ�ֽڿ飬��������д�����������
                System.IO.FileStream file = new System.IO.FileStream(strXML, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);
                file.Seek(0, System.IO.SeekOrigin.Begin);//�����ļ����ĵ�ǰλ��
                int iLen = (int)file.Length;
                byte[] data = new byte[iLen];
                file.Read(data, 0, iLen);//�����ж�ȡ�ֽڿ飬��������д�����������
                file.Close();//�ر������ͷ���Դ

                //2����ʼ��WebRequestʵ��  ����NC������
                string strURI = NCServer;
                System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(strURI);//��ʼ��WebRequestʵ��  ����NC������
                if (request == null)
                    return "����NC������ʧ��";
                request.Method = "POST";
                request.ContentType = "text/xml; charset=gb2312";
                request.ContentLength = iLen;
                request.Timeout = 500000; // 500��
                try
                {
                    System.IO.Stream postDataStream = request.GetRequestStream();//�ֽ����е�һ����ͼ
                    postDataStream.Write(data, 0, iLen);
                    postDataStream.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return e.Message.ToString();
                }


                //3��Get answer
                System.Net.HttpWebResponse resp;
                try
                {
                    resp = (HttpWebResponse)request.GetResponse();
                }
                catch (WebException err)
                {
                    MessageBox.Show(err.Status + " - " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resp = (HttpWebResponse)err.Response;
                    if (resp == null)
                    {
                        return err.Message.ToString(); ;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return err.Message.ToString(); ;
                }

                //��ȡ��������Ӧ����
                Stream rcvStream = resp.GetResponseStream();
                byte[] respBytes = new byte[256];
                int byteCount;

                //����������Ӧת�����ַ�������
                StringBuilder builder = new StringBuilder(); //�ɱ��ַ��ַ���
                do
                {
                    byteCount = rcvStream.Read(respBytes, 0, 256);
                    System.Text.Encoding encoding = System.Text.Encoding.UTF8;
                    string inputString = encoding.GetString(respBytes);
                    builder.Append(inputString);

                } while (byteCount > 0);

                XmlDocument doc = new XmlDocument();
                string xmlRet = builder.ToString();
                int iPos = xmlRet.IndexOf(@"</ufinterface>");
                xmlRet = xmlRet.Substring(0, iPos + ((string)@"</ufinterface>").Length);
                doc.LoadXml(xmlRet);

                string tok = XmlGetElement(doc, "resultcode");
                string resultCont = XmlGetElement(doc, "resultdescription");
                resultCont = resultCont.Replace("\r\n", "");
                resultCont = resultCont.Replace("\t", "");
                resp.Close();
                rcvStream.Close();

                //������ȷд��־��������
                if (!tok.Equals("1"))
                {
                    MessageBox.Show(string.Format("����NC�ӿڴ���!\r" + resultCont));
                    return resultCont;
                }
                else
                {
                    MessageBox.Show(string.Format("�������ݳɹ�!"));
                    return "1";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return e.ToString();
            }
        }

        public static string ErrorTransferXML(string strXML)
        {
            try
            {
                System.IO.FileStream file = new System.IO.FileStream(strXML, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);
                file.Seek(0, System.IO.SeekOrigin.Begin);
                int iLen = (int)file.Length;
                byte[] data = new byte[iLen];
                file.Read(data, 0, iLen);
                file.Close();

                string strURI = NCServer;
                System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(strURI);
                if (request == null)
                    return "����NC������ʧ��";
                request.Method = "POST";
                request.ContentType = "text/xml; charset=gb2312";
                request.ContentLength = iLen;

                try
                {
                    System.IO.Stream postDataStream = request.GetRequestStream();
                    postDataStream.Write(data, 0, iLen);
                    postDataStream.Close();
                }
                catch (Exception e)
                {

                    return e.Message.ToString();
                }

                //Get answer
                System.Net.HttpWebResponse resp;
                try
                {
                    resp = (HttpWebResponse)request.GetResponse();
                }
                catch (WebException err)
                {
                   
                    resp = (HttpWebResponse)err.Response;
                    if (resp == null)
                    {
                        return err.Message.ToString(); ;
                    }
                }
                catch (Exception err)
                {
                
                    return err.Message.ToString(); ;
                }


                Stream rcvStream = resp.GetResponseStream();
                byte[] respBytes = new byte[256];
                int byteCount;

                StringBuilder builder = new StringBuilder();
                do
                {
                    byteCount = rcvStream.Read(respBytes, 0, 256);
                    System.Text.Encoding encoding = System.Text.Encoding.UTF8;
                    string inputString = encoding.GetString(respBytes);
                    builder.Append(inputString);

                } while (byteCount > 0);

                XmlDocument doc = new XmlDocument();
                string xmlRet = builder.ToString();
                int iPos = xmlRet.IndexOf(@"</ufinterface>");
                xmlRet = xmlRet.Substring(0, iPos + ((string)@"</ufinterface>").Length);
                doc.LoadXml(xmlRet);

                string tok = XmlGetElement(doc, "resultcode");
                string resultCont = XmlGetElement(doc, "resultdescription");
                resultCont = resultCont.Replace("\r\n", "");
                resultCont = resultCont.Replace("\t", "");
                resp.Close();
                rcvStream.Close();

                //������ȷд��־��������
                if (!tok.Equals("1"))
                {
                    return resultCont;
                }
                else
                {
                    return "1";
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public static bool deleteXml()
        {
            string strLogDir = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "DataSent");
            string strFileName = Path.Combine(strLogDir, string.Format("{0}.xml", "MES_Data"));
            try
            {
                File.Delete(strFileName);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
