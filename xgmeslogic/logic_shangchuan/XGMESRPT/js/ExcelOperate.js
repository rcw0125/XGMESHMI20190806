////filename : ExcelOperate.js
////project : JISCO
////author : xierui
////date : 2006/05/17
////function :  Web get data from Excel and save data into Excel.


function COMMON_SetRangeMerge(Excel_Pos)
{
    if(this.xlsheet!=null)
    {
        this.xlsheet.Range(Excel_Pos).Merge();
    }
}

function COMMON_SetColumnsWidth(Excel_col,Excel_width)
{
    if(this.xlsheet!=null)
    {
        this.xlsheet.Columns(Excel_col+":"+Excel_col).ColumnWidth = Excel_width;
    }
}

function COMMON_SetRowsHeight(Excel_row,Excel_height)
{
    if(this.xlsheet!=null)
    {
        this.xlsheet.Rows(Excel_row+":"+Excel_row).RowHeight = Excel_height;
    }
}

function COMMON_SetFontItalic(Excel_x,Excel_y,TorF)
{
    if(this.xlsheet!=null)
    {
        this.xlsheet.Cells(Excel_x,Excel_y).Font.Italic = TorF;
    }
}

function COMMON_SetFontSize(Excel_x,Excel_y,cell_font_size)
{
    if(this.xlsheet != null)
    {
        this.xlsheet.Cells(Excel_x,Excel_y).Font.Size = cell_font_size;
    }
}

function COMMON_SetFontName(Excel_x,Excel_y,Excel_font_name)
{
    if(this.xlsheet != null)
    {
        this.xlsheet.Cells(Excel_x,Excel_y).Font.Name = Excel_font_name;
    }
}

function COMMON_SetFontColor(Excel_x,Excel_y,Excel_font_color)
{
    if(this.xlsheet != null)
    {
        this.xlsheet.Cells(Excel_x,Excel_y).Font.ColorIndex = Excel_font_color;
    }
}

function COMMON_SetCellColor(Excel_pos,Excel_font_color)
{
    if(this.xlsheet != null)
    {
        this.xlsheet.Range(Excel_pos).Interior.ColorIndex = Excel_font_color;
    }
}

function COMMON_SetFontBold(Excel_x,Excel_y,TorF)
{
    if(this.xlsheet!=null)
    {
        this.xlsheet.Cells(Excel_x,Excel_y).Font.Bold = TorF;
    }
}

function COMMON_CellHAlign(Excel_pos,Excel_align_format)
{
    if(this.xlsheet!=null)
    {
        this.xlsheet.Range(Excel_pos).HorizontalAlignment = Excel_align_format;
    }
}

function COMMON_CellVAlign(Excel_pos,Excel_align_format)
{
    if(this.xlsheet!=null)
    {
        this.xlsheet.Range(Excel_pos).VerticalAlignment = Excel_align_format;
    }
}



function COMMON_CreateExcel()
{
    try
    {
        this.xls = new ActiveXObject("Excel.Application");
    }
    catch(e)
    {
        alert("You have not install Microsoft Excel.");
        return "";
    }
    this.xlbook = this.xls.Workbooks.Add;
    this.xlsheet = this.xlbook.Worksheets(1);
}


function COMMON_SetValue(Excel_x,Excel_y,Excel_value)
{
    try
    {
        this.xlsheet.Cells(Excel_x,Excel_y).Value=Excel_value;
    }
    catch(e)
    {
        alert("Excel File Error! Can't Write value into Excel.");
    }
}



function COMMON_SaveExcel()
{
    var Excel_filename = this.xls.Application.GetSaveAsFileName("*.xls","Excel Format(*.xls),*.xls");
    if(Excel_filename!=null)
        this.xlbook.SaveAs(Excel_filename);
}



function Common_Excel_Object()
{
    this.filepath = null;
    this.rowcount = 0;
    this.colcount = 0;
    this.xls = null;
    this.xlbook = null;
    this.xlsheet = null;
    this.OpenExcel = COMMON_OpenExcel;
    this.readCell = COMMON_GetValue;
    this.CloseExcel = COMMON_CloseExcel;
    this.CreateExcel = COMMON_CreateExcel;
    this.writeCell = COMMON_SetValue;
    this.SaveExcel = COMMON_SaveExcel; 
    this.FontBold = COMMON_SetFontBold;
    this.CellMerge = COMMON_SetRangeMerge;
    this.SetColWidth = COMMON_SetColumnsWidth;
    this.SetRowHeight = COMMON_SetRowsHeight;
    this.FontItalic = COMMON_SetFontItalic;
    this.FontSize = COMMON_SetFontSize;
    this.FontName = COMMON_SetFontName;
    this.FontColor = COMMON_SetFontColor;
    this.CellColor = COMMON_SetCellColor;
    this.CellHAlign = COMMON_CellHAlign;
    this.CellVAlign = COMMON_CellVAlign;
}


function COMMON_CloseExcel()
{
    try
    {
        if(this.xlbook!=null)
            this.xlbook.Close();
        if(this.xls!=null)
            this.xls.Quit();
        this.xls = null;
    }
    finally
    {
        this.xls = null;
        this.xls.Quit();
    }
}


function COMMON_GetValue(Excel_x,Excel_y)
{
    try
    {  
        if (this.xlsheet.Cells(Excel_x,Excel_y).Value == undefined) return null
        else  return this.xlsheet.Cells(Excel_x,Excel_y).Value;
    }
    catch(e)
    {
        return e;
    }
}

function COMMON_OpenExcel()
{
    try
    {
        this.xls = new ActiveXObject("Excel.Application");
    }
    catch(e)
    {
        alert("You have not install Microsoft Excel.");
        return "";
    }
    if(this.filepath!=null)
    {
        this.filepath = this.filepath.replace(/\\/g,"\\\\");
    }
    else
    {
        alert("File Path is Error,Please check it.");
        return "";
    }
    try
    {
        this.xlbook = this.xls.Workbooks.Open(this.filepath);
        this.xlsheet = this.xlbook.Worksheets(1);
    }
    catch(e)
    {
        alert("file or file path Error,please check it.");
        return "";
    }
}

