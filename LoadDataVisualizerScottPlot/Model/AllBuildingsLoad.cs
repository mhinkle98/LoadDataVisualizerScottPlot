using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.XlsIO;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace LoadDataVisualizerScottPlot.Model
{
    public static class AllBuildingsLoad
    {
        private static readonly string _path = @"D:/School/Semester8/UNLEASTDATA.xlsx";
        public static IWorkbook BuildingsWorkbook;
        public static List<ExcelBuilding> BuildingsData = new List<ExcelBuilding>();

        public static void LoadWorkbook()
        {
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2013;
                FileStream inputStream = new FileStream(_path, FileMode.Open);
                BuildingsWorkbook = excelEngine.Excel.Workbooks.Open(inputStream);
                BuildingsWorkbook = application.ActiveWorkbook;
                for (int i = 0; i < 13; i++)
                {
                    IWorksheet worksheet = BuildingsWorkbook.Worksheets[i];
                    ExcelBuilding building = new ExcelBuilding(worksheet);
                    BuildingsData.Add(building);
                }
            }


        }
    }
}