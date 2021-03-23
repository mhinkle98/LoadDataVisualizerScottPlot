using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.XlsIO;
using Syncfusion.XlsIO.Implementation.PivotAnalysis;

namespace LoadDataVisualizerScottPlot.Model
{
    public class ExcelBuilding
    {
        public string BuildingName;
        public List<string> _hours = new List<string>();
        public List<double> _kW = new List<double>();
        public string HourCell;
        public string kWCell;
        public double kWValue;
        public string HourValue;
        public double averageLoad;
        public List<double> monthlyPeakLoads = new List<double>();
        
        #region monthlyloads
        public List<double> JanuaryLoads = new List<double>();
        public List<double> FebruaryLoads = new List<double>();
        public List<double> MarchLoads = new List<double>();
        public List<double> AprilLoads = new List<double>();
        public List<double> MayLoads = new List<double>();
        public List<double> JuneLoads = new List<double>();
        public List<double> JulyLoads = new List<double>();
        public List<double> AugustLoads = new List<double>();
        public List<double> SeptemberLoads = new List<double>();
        public List<double> OctoberLoads = new List<double>();
        public List<double> NovemberLoads = new List<double>();
        public List<double> DecemberLoads = new List<double>();
        #endregion




        public ExcelBuilding(IWorksheet buildingWorksheet)
        {
            BuildingName = buildingWorksheet.Range["D2"].Text;
            int dataLength = 8755;
            for (int i = 2; i < dataLength; i++)
            {
                HourCell = "A" + i.ToString();
                kWCell = "B" + i.ToString();
                if (buildingWorksheet.Range[HourCell].HasDateTime)
                    HourValue = buildingWorksheet.Range[HourCell].DateTime.ToString();
                if (buildingWorksheet.Range[kWCell].HasNumber)
                    kWValue = (buildingWorksheet.Range[kWCell].Number);
                if (kWValue != Double.NaN)
                {
                    _kW.Add(kWValue);
                }
                if (HourValue != null)
                {
                    var ExcelMonth = HourValue.Split('/')[0];
                    switch (ExcelMonth)
                    {
                        case "1":
                            JanuaryLoads.Add(kWValue);
                            break;
                        case "2":
                            FebruaryLoads.Add(kWValue);
                            break;
                        case "3":
                            MarchLoads.Add(kWValue);
                            break;
                        case "4":
                            AprilLoads.Add(kWValue);
                            break;
                        case "5":
                            MayLoads.Add(kWValue);
                            break;
                        case "6":
                            JuneLoads.Add(kWValue);
                            break;
                        case "7":
                            JulyLoads.Add(kWValue);
                            break;
                        case "8":
                            AugustLoads.Add(kWValue);
                            break;
                        case "9":
                            SeptemberLoads.Add(kWValue);
                            break;
                        case "10":
                            OctoberLoads.Add(kWValue);
                            break;
                        case "11":
                            NovemberLoads.Add(kWValue);
                            break;
                        case "12":
                            DecemberLoads.Add(kWValue);
                            break;
                    }
                    _hours.Add(HourValue);
                }
            }
            averageLoad = _kW.Sum() / _kW.Count;
        }
        public void GetMonthlyPeaks()
        {
            int j = 0;
            int month = 1;
            double monthlyLoadPeak = 0d;
            foreach (var hour in _hours)
            {
                var ExcelMonth = hour.Split('/')[0];
                if (ExcelMonth == month.ToString())
                {
                    if (_kW[j] >= monthlyLoadPeak)
                    {
                        monthlyLoadPeak = _kW[j];
                    }
                    j++;
                }
                if (ExcelMonth == (month + 1).ToString())
                {
                    monthlyPeakLoads.Add(monthlyLoadPeak);
                    monthlyLoadPeak = 0;
                    if (month != 12)
                        month += 1;
                }
            }
            monthlyPeakLoads.Add(monthlyLoadPeak);
        }
    }
}
