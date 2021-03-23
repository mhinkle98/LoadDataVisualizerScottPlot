using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoadDataVisualizerScottPlot.Model;

namespace LoadDataVisualizerScottPlot.View
{
    public partial class mainWindow : Form
    {
        private ExcelBuilding selectedBuilding = null;
        public mainWindow()
        {
            InitializeComponent();
            PopulateBuildingsList();
        }

        private void PopulateBuildingsList()
        {
            Model.AllBuildingsLoad.LoadWorkbook();
            buildingFilesBox.Items.Clear();
            foreach (var building in AllBuildingsLoad.BuildingsData)
            {
                buildingFilesBox.Items.Add(building.BuildingName);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void graphButton_Click(object sender, EventArgs e)
        {
            foreach (var building in Model.AllBuildingsLoad.BuildingsData)
            {
                if (buildingFilesBox.SelectedItem.ToString() == building.BuildingName)
                {
                    selectedBuilding = building;
                }
            }

            var buildingVals = Graphing.loads(selectedBuilding, monthsList.SelectedItem.ToString());
            graphingWindow newGraph = new graphingWindow(buildingVals,
                selectedBuilding.BuildingName + " " + monthsList.SelectedItem.ToString() + " Loads", 180d);
            newGraph.Show();
        }
    }
}
