using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing;

namespace ROISelection
{
    class DataExcel
    {
        Excel.Application excelApp;
        Excel._Workbook wBook;
        Excel._Worksheet wSheet;
        //Excel.Range wRange;

        public DataExcel()
        {
            // 開啟一個新的應用程式
            excelApp = new Excel.Application
            {
                // 讓Excel文件可見
                //Visible = true,

                // 停用警告訊息
                DisplayAlerts = false
            };

            // 加入新的活頁簿
            excelApp.Workbooks.Add(Type.Missing);

            // 引用第一個活頁簿
            wBook = excelApp.Workbooks[1];

            // 設定活頁簿焦點
            wBook.Activate();

            // 引用第一個工作表
            wSheet = (Excel._Worksheet)wBook.Worksheets[1];

            // 命名工作表的名稱
            wSheet.Name = "result";

            // 設定工作表焦點
            wSheet.Activate();
        }

        public void AddData(int row, int column, object data)
        {
            excelApp.Cells[row, column] = data;
        }

        public void Save(string pathFile)
        {
            //wRange = wSheet.Range[wSheet.Cells[1, 1], wSheet.Cells[1, rowNumber]];

            //wRange.Select();
            //wRange.Columns.AutoFit();
            try
            {
                //另存活頁簿
                wBook.SaveAs(pathFile, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                Console.WriteLine("儲存文件於 " + Environment.NewLine + pathFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine("儲存檔案出錯，檔案可能正在使用" + Environment.NewLine + ex.Message);
            }
        }

        public void Close()
        {
            //關閉活頁簿
            wBook.Close(false, Type.Missing, Type.Missing);

            //關閉Excel
            excelApp.Quit();

            //釋放Excel資源
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            wBook = null;
            wSheet = null;
            //wRange = null;
            excelApp = null;
            GC.Collect();
        }


    }
}
