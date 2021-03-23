using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScottPlot;

namespace LoadDataVisualizerScottPlot.Model
{
    public static class Graphing
    {
        //private static ScottPlot.Plot plt = new ScottPlot.Plot(600,400);
        public static double[] loads(ExcelBuilding building, string month, float dischargeThreshold = 40000f)
        {
            //ScottPlot.Plot plt = new Plot();
            double[] loadValues = null;
            double[] xs;
            switch (month)
            {
                case "January":
                    loadValues = building.JanuaryLoads.ToArray();
                    xs = DataGen.Range(loadValues.Count());
                    //plt.PlotScatter(xs, loadValues);
                    break;
                case "February":
                    loadValues = building.FebruaryLoads.ToArray();
                    xs = DataGen.Range(loadValues.Count());
                    //plt.PlotScatter(xs, loadValues);
                    break;
                case "March":
                    loadValues = building.MarchLoads.ToArray();
                    xs = DataGen.Range(loadValues.Count());
                    //plt.PlotScatter(xs, loadValues);
                    break;
                case "April":
                    loadValues = building.AprilLoads.ToArray();
                    xs = DataGen.Range(loadValues.Count());
                    //plt.PlotScatter(xs, loadValues);
                    break;
                case "May":
                    loadValues = building.MayLoads.ToArray();
                    xs = DataGen.Range(loadValues.Count());
                    //plt.PlotScatter(xs, loadValues);
                    break;
                case "June":
                    loadValues = building.JuneLoads.ToArray();
                    xs = DataGen.Range(loadValues.Count());
                    //plt.PlotScatter(xs, loadValues);
                    break;
                case "July":
                    loadValues = building.JulyLoads.ToArray();
                    xs = DataGen.Range(loadValues.Count());
                    //plt.PlotScatter(xs, loadValues);
                    break;
                case "August":
                    loadValues = building.AugustLoads.ToArray();
                    xs = DataGen.Range(loadValues.Count());
                    //plt.PlotScatter(xs, loadValues);
                    break;
                case "September":
                    loadValues = building.SeptemberLoads.ToArray();
                    xs = DataGen.Range(loadValues.Count());
                    //plt.PlotScatter(xs, loadValues);
                    break;
                case "October":
                    loadValues = building.OctoberLoads.ToArray();
                    xs = DataGen.Range(loadValues.Count());
                    //plt.PlotScatter(xs, loadValues);
                    break;
                case "November":
                    loadValues = building.NovemberLoads.ToArray();
                    xs = DataGen.Range(loadValues.Count());
                    //plt.PlotScatter(xs, loadValues);
                    break;
                case "December":
                    loadValues = building.DecemberLoads.ToArray();
                    xs = DataGen.Range(loadValues.Count());
                    //plt.PlotScatter(xs, loadValues);
                    break;
            }

            return loadValues;
        }
    }
}
