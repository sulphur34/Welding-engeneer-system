using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    class Excel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;
        public Excel(string path, int Sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[Sheet];
        }
        public Excel()
        {

        }
        public Range FindCellByString(Range range, string searchstring) 
        {
           Range findrange = range.Find(searchstring, Missing.Value, XlFindLookIn.xlValues, XlLookAt.xlPart, XlSearchOrder.xlByRows, XlSearchDirection.xlNext, false, Missing.Value, Missing.Value);
           return findrange;
        }
        public void CreateNewFile()
        {
            this.wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            this.ws = wb.Worksheets[1];
        }
        public void CreateNewSheet()
        {
            Worksheet test = wb.Worksheets.Add(After:ws);
        }
        public string ReadCell(int i, int j)
        {
            i++;
            j++;
            if (ws.Cells[i, j].Value2 != null)
                return ws.Cells[i, j].Value2;
            else
                return "";
        }
        public void WriteCell(int i, int j, string value)
        {
            i++;
            j++;
            ws.Cells[i, j].Value2 = value;
        }
        public void Save()
        {
            wb.Save();
        
        }
        public void SaveAs(string path)
        {
            wb.SaveAs(path);
        }
        public void Close()
        {
            wb.Close();
        }
        public void SelectSheet(int sheetnumber)
        {
            this.ws = wb.Worksheets[sheetnumber];
        }
        public void DeleteSheet(int sheetnumber)
        {
            wb.Worksheets[sheetnumber].Delete();
        }
        public void ProtectSheet()
        {
            ws.Protect();
        }
        public void ProtectSheet(string password)
        {
            ws.Protect(password) ;
        }
        public void UnprotectSheet()
        {
            ws.Unprotect();
        }
        public void UnprotectSheet(string password)
        {
            ws.Unprotect(password);
        }
        public string[,] ReadRange (int istart, int ystart, int iend, int yend)
        {
            Range range = (Range)ws.Range[ws.Cells[istart, ystart], ws.Cells[iend, yend]];
            object[,] holder = range.Value2;
            string[,] returnstring = new string[iend - istart+1, yend - ystart+1];
            for (int i = 0; i <= iend - istart; i++)
            {
                for (int j = 0; j <= yend - ystart; j++)
                {
                    returnstring[i, j] = holder[i+1, j+1].ToString();
                }
            }
            return returnstring;
        }
        public string[] ReadRow(int istart, int ystart, int iend)
        {
            Range range = (Range)ws.Range[ws.Cells[istart, ystart], ws.Cells[iend, ystart]];
            object[,] holder = range.Value2;
            string[] returnstring = new string[iend - istart + 1];
            for (int i = 0; i <= iend - istart; i++)
            {
                returnstring[i] = holder[i + 1, 1].ToString();
            }
            return returnstring;
        }
        public void WriteRange (int istart, int ystart, int iend, int yend, string[,] writerange)
        {
            Range range = (Range)ws.Range[ws.Cells[istart, ystart], ws.Cells[iend, yend]];
            range.Value2 = writerange;
        }
    }
}
