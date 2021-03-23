using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;
using ScottPlot.Config;
using ScottPlot.Drawing;
using Syncfusion.XlsIO.Implementation.XmlSerialization.Shapes;

namespace LoadDataVisualizerScottPlot.View
{
    public partial class graphingWindow : Form
    {
        //public static ScottPlot.FormsPlot graph = new FormsPlot();
        private double[] xs;
        private double[] loads;
        private string graphName = "";

        public graphingWindow(double[] Loads, string name, double loadMax)
        {
            graphName = name;
            loads = Loads;
            this.xs = DataGen.Range(loads.Length);
            InitializeComponent();
            double[] xs = DataGen.Range(loads.Count());
            var newLoads = new double[xs.Length];
            for (int i = 0; i < loads.Length; i++)
            {
                if (loads[i] > loadMax)
                {
                    newLoads[i] = loadMax;
                }
                else
                {
                    newLoads[i] = loads[i];
                }


            }

            graphPlotForm.plt.PlotScatter(xs, loads);
            graphPlotForm.plt.PlotScatter(xs, newLoads);
            graphPlotForm.plt.Title(name);
            graphPlotForm.plt.XLabel("Hours");
            graphPlotForm.plt.YLabel("Loads (kW)");
            //graphPlotForm.plt.PlotFill(xs, loads, lineColor: Color.AliceBlue, fillColor: Color.Beige);
            graphPlotForm.Render();
        }

        public void UpdateGraph(double loadCap)
        {
            graphPlotForm.Reset();
            var newLoads = new double[xs.Length];
            for (int i = 0; i < loads.Length; i++)
            {
                if (loads[i] > loadCap)
                {
                    newLoads[i] = loadCap;
                }
                else
                {
                    newLoads[i] = loads[i];
                }
            }

            graphPlotForm.plt.PlotScatter(xs, newLoads);
            graphPlotForm.plt.PlotScatter(xs, loads);
            graphPlotForm.plt.Title(graphName);
            graphPlotForm.plt.XLabel("Hours");
            graphPlotForm.plt.YLabel("Loads (kW)");
            graphPlotForm.Render();

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateGraph(vScrollBar1.Value);
        }
    }
}
