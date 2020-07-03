using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OracleClient;

/// <summary>
/// Common 的摘要说明
/// </summary>
public class Common
{
    public Common()
    {

    }
    //实例化类
    CommonCmd com = new CommonCmd();
    //*******************************************************-------------样式表-----------*****************************************************
    //表格的边框颜色
    private string tableCellBorderColor = "#666666";
    private string tableHeaderCellCss = "RptMainTh";
    //*******************************************************----------------------------*****************************************************
    /// <summary>
    /// 二维表的形式
    /// </summary>
    /// <param name="TableName">数据库名称</param>
    /// <param name="Table1">界面上table</param>
    /// <param name="strCodeGroup"> 新建一个数组存CodeID用</param>
    public void CreatePlanar(string TableName, Table Table1, ref string[,] strCodeGroup)
    {
        int row0041 = 0;
        int col0041 = 0;
        DataTable dt = com.GetTableStructInfo(TableName, ref col0041, ref row0041);
        if (dt != null && dt.Rows.Count > 0)
        {
            //根据行和列生成可写table
            CreateTableRows(TableName, Table1, row0041 + 1, col0041 + 1, 100, 1);
            //填充列名称,在数组中填充代码
            strCodeGroup = new string[row0041 + 1, col0041 + 1];
            //填充表头名
            FillTextBox(TableName, Table1, strCodeGroup, dt);
        }
    }

    /// <summary>
    /// 二维表的形式
    /// </summary>
    /// <param name="TableName">数据库名称</param>
    /// <param name="Table1">界面上table</param>
    /// <param name="strCodeGroup"> 新建一个数组存CodeID用</param>
    /// <param name="Rows">强制生成的行数，传入0则自动行数</param>
    /// <param name="columns">强制生成的列数，传入0则自动列数</param>
    public void CreatePlanar(string TableName, Table Table1, ref string[,] strCodeGroup, int Rows, int columns)
    {
        int row0041 = 0;
        int col0041 = 0;
        DataTable dt = com.GetTableStructInfo(TableName, ref col0041, ref row0041);
        if (dt != null && dt.Rows.Count > 0)
        {
            //根据行和列生成可写table
            int rowTrue = 0;
            int columnTrue = 0;
            if (Rows == 0)//如果传入为0，就去数据库值，如果传入不为0，取传入值
            {
                rowTrue = row0041;
            }
            else rowTrue = Rows;
            if (columns == 0)
            {
                columnTrue = col0041;
            }
            else columnTrue = columns;
            CreateTableRows(TableName, Table1, rowTrue + 1, columnTrue + 1, 100, 1);
            //填充列名称,在数组中填充代码
            strCodeGroup = new string[row0041 + 1, col0041 + 1];
            //填充表头名
            FillTextBox(TableName, Table1, strCodeGroup, dt);

        }
    }
    //填充表头名
    private void FillTextBox(string TableName, Table Table1, string[,] strCodeGroup, DataTable dt)
    {
        //0行0列加上表头样式
        TextBox texb1 = (TextBox)Table1.FindControl("textBox" + TableName + "00");
        if (texb1 != null)
        {
            TableCell tc = (TableCell)texb1.Parent;
            tc.Controls.Clear();
            tc.CssClass = tableHeaderCellCss;
        }
        //查找表头，加上表头样式
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            string strI = dt.Rows[i]["Direct"].ToString();
            string strJ = dt.Rows[i]["Position"].ToString();
            TextBox texb = (TextBox)Table1.FindControl("textBox" + TableName + strI + strJ);
            if (texb != null)
            {
                TableCell tc = (TableCell)texb.Parent;
                tc.Controls.Clear();
                tc.Text = dt.Rows[i]["name"].ToString();
                tc.CssClass = tableHeaderCellCss;
                strCodeGroup[Convert.ToInt32(strI), Convert.ToInt32(strJ)] = dt.Rows[i]["code_ID"].ToString();
            }
        }
    }
    //手动填充表头形式
    /// <summary>
    /// 
    /// </summary>
    /// <param name="tb">要填充的textBox</param>
    /// <param name="strName">填充数组</param>
    /// <param name="i">填充数组中的第几个，从0开始</param>
    public void FillCell(TextBox tb, string[] strName, int i)
    {
        if (tb != null)
        {
            TableCell tc = (TableCell)tb.Parent;
            tc.Controls.Clear();
            tc.Text = strName[i];
            tc.CssClass = tableHeaderCellCss;
        }
    }
    /// <summary>
    /// 二维表的形式
    /// </summary>
    /// <param name="TableName">数据库名称</param>
    /// <param name="Table1">界面上table</param>
    /// <param name="strCodeGroup"> 新建一个数组存CodeID用</param>
    /// <param name="Rows">强制生成的行数，传入0则自动行数</param>
    /// <param name="columns">强制生成的列数，传入0则自动列数</param>
    /// <param name="MaxColNum">多多少行转行</param>
    public void CreatePlanar(string TableName, Table Table1, ref string[,] strCodeGroup, int Rows, int columns, int MaxColNum)
    {
        int row0041 = 0;
        int col0041 = 0;
        DataTable dt = com.GetTableStructInfo(TableName, ref col0041, ref row0041);
        if (dt != null)
        {
            //根据行和列生成可写table
            int rowTrue = 0;
            int columnTrue = 0;
            if (Rows == 0)//如果传入为0，就去数据库值，如果传入不为0，取传入值
            {
                rowTrue = row0041;
            }
            else rowTrue = Rows;
            if (columns == 0)
            {
                columnTrue = col0041;
            }
            else columnTrue = columns;
            if (MaxColNum > 0)
            {
                //算的要转行的次数
                int laps = columnTrue / MaxColNum;
                int Modle = columnTrue % MaxColNum;
                if (Modle != 0)
                    laps++;
                //生成table
                CreateTableRows(TableName, Table1, (rowTrue + 1) * laps, MaxColNum + 1, 100, 1);
                //填充列名称,在数组中填充代码
                strCodeGroup = new string[(rowTrue + 1) * laps, MaxColNum + 1];
                //先填充表头0行0列的空格样式
                for (int i = 0; i < laps; i++)
                {
                    TextBox texb1 = (TextBox)Table1.FindControl("textBox" + TableName + Convert.ToString((rowTrue + 1) * i) + "0");
                    if (texb1 != null)
                    {
                        TableCell tc = (TableCell)texb1.Parent;
                        tc.Controls.Clear();
                        tc.CssClass = tableHeaderCellCss;
                    }
                }
                //填充表头
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int intI = Convert.ToInt32(dt.Rows[i]["Direct"]);
                    int intJ = Convert.ToInt32(dt.Rows[i]["Position"]);
                    if (intI == 0)//列字段
                    {
                        for (int j = 0; j < laps; j++)
                        {
                            TextBox texb = (TextBox)Table1.FindControl("textBox" + TableName + Convert.ToString(intI + (row0041 + 1) * j) + Convert.ToString(intJ - MaxColNum * j));
                            if (texb != null)
                            {
                                TableCell tc = (TableCell)texb.Parent;
                                tc.Controls.Clear();
                                tc.Text = dt.Rows[i]["name"].ToString();
                                tc.CssClass = tableHeaderCellCss;
                                strCodeGroup[intI + (row0041 + 1) * j, (intJ - MaxColNum * j)] = dt.Rows[i]["code_ID"].ToString();
                                break;//跳出for循环
                            }
                        }
                    }
                    else//行上字段
                    {
                        for (int j = 0; j < laps; j++)
                        {
                            TextBox texb2 = (TextBox)Table1.FindControl("textBox" + TableName + Convert.ToString(intI + (row0041 + 1) * j) + intJ.ToString());
                            if (texb2 != null)
                            {
                                TableCell tc = (TableCell)texb2.Parent;
                                tc.Controls.Clear();
                                tc.Text = dt.Rows[i]["name"].ToString();
                                tc.CssClass = tableHeaderCellCss;
                                strCodeGroup[intI + (row0041 + 1) * j, intJ] = dt.Rows[i]["code_ID"].ToString();
                            }
                        }
                    }
                }
            }
            else
            {
                //生成table
                CreateTableRows(TableName, Table1, rowTrue + 1, columnTrue + 1, 100, 1);
                //填充列名称,在数组中填充代码
                strCodeGroup = new string[row0041 + 1, col0041 + 1];
                //填充表头名
                FillTextBox(TableName, Table1, strCodeGroup, dt);
            }
        }

    }
    /// <summary>
    /// 单维数表--正对横向的表
    /// </summary>
    /// <param name="TableName">表名</param>
    /// <param name="Table1">界面上table</param>
    /// <param name="row">强制生成的行数，传入0则自动行数</param>
    /// <param name="strCodeGroup">strCodeGroup存CODEID的数组</param>
    /// <param name="columnSpan">跨列数，默认输入1</param>
    public void CreateTableGrid(string TableName, Table Table1, int row, ref string[] strCodeGroup, int columnSpan)
    {
        int row1 = 0;
        int column1 = 0;
        DataTable dt = com.GetTableStructInfo(TableName, ref row1, ref column1);
        if (dt != null)
        {
            //根据行和列生成可写table
            int col = dt.Rows.Count;
            CreateTableRows(TableName, Table1, row, col, 100, columnSpan);
            //找值填充
            strCodeGroup = new string[col];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int strJ = Convert.ToInt32(dt.Rows[i]["Position"]) - 1;
                TextBox texb = (TextBox)Table1.FindControl("textBox" + TableName + "0" + strJ.ToString());
                if (texb != null)
                {
                    TableCell tc = (TableCell)texb.Parent;
                    tc.Controls.Clear();
                    tc.Text = dt.Rows[i]["name"].ToString();
                    tc.CssClass = tableHeaderCellCss;
                    strCodeGroup[strJ] = dt.Rows[i]["code_ID"].ToString();
                }
            }
        }
    }

    /// <summary>
    /// 单维数表--即只有横列或纵列的表
    /// </summary>
    /// <param name="TableName">表名</param>
    /// <param name="Table1">界面上table</param>
    /// <param name="Rows">强制生成的行数，传入0则自动行数</param>
    /// <param name="columns">强制生成的列数，传入0则自动列数</param>
    /// <param name="strCodeGroup">strCodeGroup存CODEID的数组</param>
    /// <param name="columnSpan">跨列数，默认输入1</param>
    public void CreateTableGrid(string TableName, Table Table1, int Rows, int columns, ref string[] strCodeGroup, int columnSpan)
    {
        int row1 = 0;
        int column1 = 0;
        DataTable dt = com.GetTableStructInfo(TableName, ref column1, ref row1);
        if (dt != null)
        {
            int rowTrue = 0;
            int columnTrue = 0;
            if (Rows == 0)//如果传入为0，就去数据库值，如果传入不为0，取传入值
            {
                rowTrue = row1;
            }
            else rowTrue = Rows;
            if (columns == 0)
            {
                columnTrue = column1;
            }
            else columnTrue = columns;
            //根据行和列生成可写table
            CreateTableRows(TableName, Table1, rowTrue, columnTrue, 100, columnSpan);
            //找值填充
            if (column1 == 0)
            {
                strCodeGroup = new string[row1];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int strI = Convert.ToInt32(dt.Rows[i]["Direct"]) - 1;
                    string strTemp = "textBox" + TableName + strI.ToString() + "0";
                    TextBox texb = (TextBox)Table1.FindControl(strTemp);
                    if (texb != null)
                    {
                        TableCell tc = (TableCell)texb.Parent;
                        tc.Controls.Clear();
                        tc.Text = dt.Rows[i]["name"].ToString();
                        tc.CssClass = tableHeaderCellCss;
                        strCodeGroup[strI] = dt.Rows[i]["code_ID"].ToString();
                    }
                }
            }
            else if (row1 == 0)
            {
                strCodeGroup = new string[column1];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int strJ = Convert.ToInt32(dt.Rows[i]["Position"]) - 1;
                    TextBox texb = (TextBox)Table1.FindControl("textBox" + TableName + "0" + strJ.ToString());
                    if (texb != null)
                    {
                        TableCell tc = (TableCell)texb.Parent;
                        tc.Controls.Clear();
                        tc.Text = dt.Rows[i]["name"].ToString();
                        tc.CssClass = tableHeaderCellCss;
                        strCodeGroup[strJ] = dt.Rows[i]["code_ID"].ToString();
                    }
                }
            }
        }
    }
    /// <summary>
    /// 单维数表--即只有横列或纵列的表
    /// </summary>
    /// <param name="TableName">表名</param>
    /// <param name="Table1">界面上table</param>
    /// <param name="Rows">强制生成的行数，传入0则自动行数</param>
    /// <param name="columns">强制生成的列数，传入0则自动列数</param>
    /// <param name="strCodeGroup">strCodeGroup存CODEID的数组</param>
    /// <param name="columnSpan">跨列数，默认输入1</param>
    /// <param name="MaxColNum">多多少行转行</param>
    public void CreateTableGrid(string TableName, Table Table1, int Rows, int columns, ref string[,] strCodeGroup, int columnSpan, int MaxColNum)
    {
        int row0041 = 0;
        int column0041 = 0;
        DataTable dt = com.GetTableStructInfo(TableName, ref column0041, ref row0041);
        if (dt != null)
        {
            int rowTrue = 0;
            int columnTrue = 0;
            if (Rows == 0)//如果传入为0，就去数据库值，如果传入不为0，取传入值
            {
                rowTrue = row0041;
            }
            else rowTrue = Rows;
            if (columns == 0)
            {
                columnTrue = column0041;
            }
            else columnTrue = columns;
            if (MaxColNum > 0)
            {
                //算的要转行的次数
                int laps = columnTrue / MaxColNum;
                int Modle = columnTrue % MaxColNum;
                if (Modle != 0)
                    laps++;
                //生成table
                CreateTableRows(TableName, Table1, rowTrue * laps, MaxColNum, 100, columnSpan);
                //填充列名称,在数组中填充代码
                strCodeGroup = new string[rowTrue * laps, MaxColNum];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int intI = Convert.ToInt32(dt.Rows[i]["Direct"]);
                    int intJ = Convert.ToInt32(dt.Rows[i]["Position"]);
                    if (intI == 0)//列字段
                    {
                        for (int j = 0; j < laps; j++)
                        {
                            TextBox texb = (TextBox)Table1.FindControl("textBox" + TableName + Convert.ToString(intI + rowTrue * j) + Convert.ToString((intJ - 1) - MaxColNum * j));
                            if (texb != null)
                            {
                                TableCell tc = (TableCell)texb.Parent;
                                tc.Controls.Clear();
                                tc.Text = dt.Rows[i]["name"].ToString();
                                tc.CssClass = tableHeaderCellCss;
                                strCodeGroup[intI + rowTrue * j, ((intJ - 1) - MaxColNum * j)] = dt.Rows[i]["code_ID"].ToString();
                                break;//跳出for循环
                            }
                        }
                    }
                    else//行上字段
                    {
                        for (int j = 0; j < laps; j++)
                        {
                            TextBox texb2 = (TextBox)Table1.FindControl("textBox" + TableName + Convert.ToString(intI + row0041 * j) + intJ.ToString());
                            if (texb2 != null)
                            {
                                TableCell tc = (TableCell)texb2.Parent;
                                tc.Controls.Clear();
                                tc.Text = dt.Rows[i]["name"].ToString();
                                tc.CssClass = tableHeaderCellCss;
                                strCodeGroup[intI + row0041 * j, intJ] = dt.Rows[i]["code_ID"].ToString();
                            }
                        }
                    }
                }
            }
            else
            {
                //根据行和列生成可写table
                CreateTableRows(TableName, Table1, rowTrue, columnTrue, 100, columnSpan);
                //找值填充
                strCodeGroup = new string[rowTrue, columnTrue];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int strI = Convert.ToInt32(dt.Rows[i]["Direct"]) - 1;
                    int strJ = Convert.ToInt32(dt.Rows[i]["Position"]) - 1;
                    if (strI < 0)
                        strI = 0;
                    if (strJ < 0)
                        strJ = 0;
                    TextBox texb = (TextBox)Table1.FindControl("textBox" + TableName + strI.ToString() + strJ.ToString());
                    if (texb != null)
                    {
                        TableCell tc = (TableCell)texb.Parent;
                        tc.Controls.Clear();
                        tc.Text = dt.Rows[i]["name"].ToString();
                        tc.CssClass = tableHeaderCellCss;
                        strCodeGroup[strI, strJ] = dt.Rows[i]["code_ID"].ToString();
                    }
                }
            }
        }
    }

    /// <summary>
    /// 在table上追加行
    /// </summary>
    /// <param name="TableName">数据库的表名称--用于生产Text的ID唯一标识</param>
    /// <param name="Table11">要追加的table</param>
    /// <param name="row">追加的行数</param>
    /// <param name="col">追加的列数</param>
    public void CreateTableRows(string TableName, Table Table11, int row, int col)
    {
        for (int i = 0; i < row; i++)
        {
            TableRow tableRow = new TableRow();
            for (int j = 0; j < col; j++)
            {
                TableCell cellContent = new TableCell();
                TextBox textBox = new TextBox();
                textBox.BorderColor = System.Drawing.Color.Transparent;
                textBox.BackColor = System.Drawing.Color.Transparent;
                textBox.BorderStyle = BorderStyle.None;
                textBox.Width = 100;
                //textBox.ID = "textBox" + TableName + i.ToString() + j.ToString();
                textBox.ID = "textBox" + TableName + i.ToString() + j.ToString();
                cellContent.Controls.Add(textBox);
                cellContent.BorderColor = System.Drawing.Color.FromName(tableCellBorderColor);
                cellContent.BorderWidth = 1;
                cellContent.HorizontalAlign = HorizontalAlign.Left;
                cellContent.Width = 100;
                tableRow.Cells.Add(cellContent);
                tableRow.Height = 22;
            }
            Table11.Rows.Add(tableRow);
        }
    }
    /// <summary>
    /// 在table上追加行
    /// </summary>
    /// <param name="TableName">数据库的表名称--用于生产Text的ID唯一标识</param>
    /// <param name="Table11">要追加的table</param>
    /// <param name="row">追加的行数</param>
    /// <param name="col">追加的列数</param>
    /// <param name="flag">重载该方法表示生成的textbox在i和j之间加上了“-”，在i>10时候调该方法</param>
    public void CreateTableRows(string TableName, Table Table11, int row, int col, int flag)
    {
        short iLab = 0;
        for (int i = 0; i < row; i++)
        {
            TableRow tableRow = new TableRow();
            for (int j = 0; j < col; j++)
            {
                TableCell cellContent = new TableCell();
                TextBox textBox = new TextBox();
                textBox.BorderColor = System.Drawing.Color.Transparent;
                textBox.BackColor = System.Drawing.Color.Transparent;
                textBox.BorderStyle = BorderStyle.None;
                textBox.Width = 100;
                textBox.ID = "textBox" + TableName + i.ToString() + "-" + j.ToString();
                textBox.TabIndex = iLab;
                cellContent.Controls.Add(textBox);
                cellContent.BorderColor = System.Drawing.Color.FromName(tableCellBorderColor);
                cellContent.BorderWidth = 1;
                cellContent.HorizontalAlign = HorizontalAlign.Left;
                cellContent.Width = 100;
                tableRow.Cells.Add(cellContent);
                tableRow.Height = 22;
                iLab++;
            }
            Table11.Rows.Add(tableRow);
        }
    }

    /// <summary>
    /// 在table上追加行
    /// </summary>
    /// <param name="TableName">数据库的表名称--用于生产Text的ID唯一标识</param>
    /// <param name="Table11">要追加的table</param>
    /// <param name="row">追加的行数</param>
    /// <param name="width">产生的单个Cell格子的宽</param>
    /// <param name="columnSpan">跨列数，默认输入1</param>
    /// <param name="flag">重载该方法表示生成的textbox在i和j之间加上了“-”，在i>10时候调该方法</param>
    public void CreateTableRows(string TableName, Table Table11, int row, int col, int width, int columnSpan)
    {
        short iLab = 0;
        for (int i = 0; i < row; i++)
        {
            TableRow tableRow = new TableRow();
            for (int j = 0; j < col; j++)
            {
                TableCell cellContent = new TableCell();
                TextBox textBox = new TextBox();
                textBox.BorderColor = System.Drawing.Color.Transparent;
                textBox.BackColor = System.Drawing.Color.Transparent;
                textBox.BorderStyle = BorderStyle.None;
                textBox.Width = width;
                textBox.ID = "textBox" + TableName + i.ToString() + j.ToString();
                textBox.TabIndex = iLab;
                cellContent.Controls.Add(textBox);
                cellContent.BorderColor = System.Drawing.Color.FromName(tableCellBorderColor);
                cellContent.BorderWidth = 1;
                cellContent.HorizontalAlign = HorizontalAlign.Left;
                cellContent.Width = width;
                cellContent.ColumnSpan = columnSpan;
                tableRow.Cells.Add(cellContent);
                tableRow.Height = 22;
                iLab++;
            }
            Table11.Rows.Add(tableRow);
        }
    }

    /*******/
    /// <summary>
    /// 在table上追加行
    /// </summary>
    /// <param name="TableName">数据库的表名称--用于生产Text的ID唯一标识</param>
    /// <param name="Table11">要追加的table</param>
    /// <param name="row">追加的行数</param>
    /// <param name="width">产生的单个Cell格子的宽</param>
    /// <param name="columnSpan">跨列数，默认输入1</param>
    /// <param name="flag">重载该方法表示生成的textbox在i和j之间加上了“-”，在i>10时候调该方法</param>
    public void CreateTableRows(string TableName, Table Table11, int row, int col, int width, int columnSpan, int flag)
    {
        short iLab = 0;
        for (int i = 0; i < row; i++)
        {
            TableRow tableRow = new TableRow();
            for (int j = 0; j < col; j++)
            {
                TableCell cellContent = new TableCell();
                TextBox textBox = new TextBox();
                textBox.BorderColor = System.Drawing.Color.Transparent;
                textBox.BackColor = System.Drawing.Color.Transparent;
                textBox.BorderStyle = BorderStyle.None;
                textBox.Width = width;
                textBox.ID = "textBox" + TableName + i.ToString() + "-" + j.ToString();
                textBox.TabIndex = iLab;
                cellContent.Controls.Add(textBox);
                cellContent.BorderColor = System.Drawing.Color.FromName(tableCellBorderColor);
                cellContent.BorderWidth = 1;
                cellContent.HorizontalAlign = HorizontalAlign.Left;
                cellContent.Width = width;
                cellContent.ColumnSpan = columnSpan;
                tableRow.Cells.Add(cellContent);
                tableRow.Height = 22;
                iLab++;
            }
            Table11.Rows.Add(tableRow);
        }
    }
    /// <summary>
    /// 在table上追加行
    /// </summary>
    /// <param name="TableName">数据库的表名称--用于生产Text的ID唯一标识</param>
    /// <param name="Table11">要追加的table</param>
    /// <param name="row">追加的行数</param>
    /// <param name="width">产生的单个Cell格子的宽</param>
    /// <param name="columnSpan">跨列数，默认输入1</param>
    /// <param name="flag">重载该方法表示生成的textbox在i和j之间加上了“-”，在i>10时候调该方法</param>
    /// <param name="indexStart">textBox.TabIndex起始值</param>
    public void CreateTableRows(string TableName, Table Table11, int row, int col, int width, int columnSpan, int flag, short indexStart)
    {
        short iLab = indexStart;
        for (int i = 0; i < row; i++)
        {
            TableRow tableRow = new TableRow();
            for (int j = 0; j < col; j++)
            {
                TableCell cellContent = new TableCell();
                TextBox textBox = new TextBox();
                textBox.BorderColor = System.Drawing.Color.Transparent;
                textBox.BackColor = System.Drawing.Color.Transparent;
                textBox.BorderStyle = BorderStyle.None;
                textBox.Width = width;
                textBox.ID = "textBox" + TableName + i.ToString() + "-" + j.ToString();
                textBox.TabIndex = iLab;
                cellContent.Controls.Add(textBox);
                cellContent.BorderColor = System.Drawing.Color.FromName(tableCellBorderColor);
                cellContent.BorderWidth = 1;
                cellContent.HorizontalAlign = HorizontalAlign.Left;
                cellContent.Width = width;
                cellContent.ColumnSpan = columnSpan;
                tableRow.Cells.Add(cellContent);
                tableRow.Height = 22;
                iLab++;
            }
            Table11.Rows.Add(tableRow);
        }
    }

    /// <summary>
    /// 设置TextBox背景颜色
    /// </summary>
    /// <param name="strFrework">传入FREWORK的值</param>
    /// <param name="texb">要设置的TextBox</param>
    public void SetCellBackColor(string strFrework, TextBox texb)
    {
        if (strFrework == "0")
            texb.ForeColor = System.Drawing.Color.Black;//系统录入
        else if (strFrework == "1")
            texb.ForeColor = System.Drawing.Color.Blue;//人工录入
        else if (strFrework == "2")
            texb.ForeColor = System.Drawing.Color.Red;//人工修改
    }
    //校验
    public bool Validated(string TableName, Table table1, string[,] strCodeGroup0041, Page page1)
    {
        bool boolfalg = true; ;
        for (int i = 0; i < table1.Rows.Count; i++)
        {
            for (int j = 0; j < table1.Rows[i].Cells.Count; j++)
            {
                TextBox texb = (TextBox)table1.FindControl("textBox" + TableName + i.ToString() + j.ToString());
                if (texb != null && strCodeGroup0041[0, j] != null)
                {
                    string strCode = strCodeGroup0041[0, j].Substring(14, 2);
                    if (strCode == "01")//数字
                    {
                        try
                        {
                            int iTemp = Convert.ToInt32(texb.Text);
                        }
                        catch
                        {
                            texb.BackColor = System.Drawing.Color.Red;
                            boolfalg = false;
                        }
                    }
                }
            }
        }
        if (boolfalg == false)
        {
            page1.Response.Write("<script>alert('红色背景框里输入的不为数字!')</script>");
        }
        return boolfalg;

    }

  
}
