namespace LoadDataVisualizerScottPlot.View
{
    partial class mainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buildingFilesBox = new System.Windows.Forms.ListBox();
            this.buildingsLabel = new System.Windows.Forms.Label();
            this.monthlyPeakLoads = new System.Windows.Forms.Label();
            this.MonthlyLoadPeaksBox = new System.Windows.Forms.ListBox();
            this.dataLabel = new System.Windows.Forms.Label();
            this.graphButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.monthsList = new System.Windows.Forms.ListBox();
            this.monthsLabel = new System.Windows.Forms.Label();
            this.BatteryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buildingFilesBox
            // 
            this.buildingFilesBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.buildingFilesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buildingFilesBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.buildingFilesBox.FormattingEnabled = true;
            this.buildingFilesBox.ItemHeight = 21;
            this.buildingFilesBox.Location = new System.Drawing.Point(20, 50);
            this.buildingFilesBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buildingFilesBox.Name = "buildingFilesBox";
            this.buildingFilesBox.Size = new System.Drawing.Size(590, 653);
            this.buildingFilesBox.TabIndex = 0;
            // 
            // buildingsLabel
            // 
            this.buildingsLabel.AutoSize = true;
            this.buildingsLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingsLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.buildingsLabel.Location = new System.Drawing.Point(16, 9);
            this.buildingsLabel.Name = "buildingsLabel";
            this.buildingsLabel.Size = new System.Drawing.Size(92, 23);
            this.buildingsLabel.TabIndex = 1;
            this.buildingsLabel.Text = "Buildings";
            // 
            // monthlyPeakLoads
            // 
            this.monthlyPeakLoads.AutoSize = true;
            this.monthlyPeakLoads.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyPeakLoads.ForeColor = System.Drawing.Color.DarkOrange;
            this.monthlyPeakLoads.Location = new System.Drawing.Point(637, 9);
            this.monthlyPeakLoads.Name = "monthlyPeakLoads";
            this.monthlyPeakLoads.Size = new System.Drawing.Size(208, 23);
            this.monthlyPeakLoads.TabIndex = 7;
            this.monthlyPeakLoads.Text = "Peak Loads (Monthly)";
            // 
            // MonthlyLoadPeaksBox
            // 
            this.MonthlyLoadPeaksBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.MonthlyLoadPeaksBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MonthlyLoadPeaksBox.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthlyLoadPeaksBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.MonthlyLoadPeaksBox.FormattingEnabled = true;
            this.MonthlyLoadPeaksBox.ItemHeight = 16;
            this.MonthlyLoadPeaksBox.Location = new System.Drawing.Point(641, 50);
            this.MonthlyLoadPeaksBox.Name = "MonthlyLoadPeaksBox";
            this.MonthlyLoadPeaksBox.Size = new System.Drawing.Size(204, 626);
            this.MonthlyLoadPeaksBox.TabIndex = 8;
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.dataLabel.Location = new System.Drawing.Point(901, 9);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(55, 23);
            this.dataLabel.TabIndex = 9;
            this.dataLabel.Text = "Data";
            // 
            // graphButton
            // 
            this.graphButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.graphButton.Location = new System.Drawing.Point(870, 641);
            this.graphButton.Name = "graphButton";
            this.graphButton.Size = new System.Drawing.Size(129, 35);
            this.graphButton.TabIndex = 10;
            this.graphButton.Text = "Show Loads";
            this.graphButton.UseVisualStyleBackColor = true;
            this.graphButton.Click += new System.EventHandler(this.graphButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.Salmon;
            this.closeButton.Location = new System.Drawing.Point(1088, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(59, 30);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // monthsList
            // 
            this.monthsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.monthsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthsList.ForeColor = System.Drawing.Color.DarkOrange;
            this.monthsList.FormattingEnabled = true;
            this.monthsList.ItemHeight = 21;
            this.monthsList.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthsList.Location = new System.Drawing.Point(870, 75);
            this.monthsList.Name = "monthsList";
            this.monthsList.Size = new System.Drawing.Size(221, 338);
            this.monthsList.TabIndex = 12;
            // 
            // monthsLabel
            // 
            this.monthsLabel.AutoSize = true;
            this.monthsLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.monthsLabel.Location = new System.Drawing.Point(866, 50);
            this.monthsLabel.Name = "monthsLabel";
            this.monthsLabel.Size = new System.Drawing.Size(68, 21);
            this.monthsLabel.TabIndex = 13;
            this.monthsLabel.Text = "Months";
            // 
            // BatteryLabel
            // 
            this.BatteryLabel.AutoSize = true;
            this.BatteryLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.BatteryLabel.Location = new System.Drawing.Point(866, 430);
            this.BatteryLabel.Name = "BatteryLabel";
            this.BatteryLabel.Size = new System.Drawing.Size(67, 21);
            this.BatteryLabel.TabIndex = 13;
            this.BatteryLabel.Text = "Battery";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1159, 727);
            this.Controls.Add(this.BatteryLabel);
            this.Controls.Add(this.monthsLabel);
            this.Controls.Add(this.monthsList);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.graphButton);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.MonthlyLoadPeaksBox);
            this.Controls.Add(this.monthlyPeakLoads);
            this.Controls.Add(this.buildingsLabel);
            this.Controls.Add(this.buildingFilesBox);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "mainWindow";
            this.Text = "mainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox buildingFilesBox;
        private System.Windows.Forms.Label buildingsLabel;
        private System.Windows.Forms.Label monthlyPeakLoads;
        private System.Windows.Forms.ListBox MonthlyLoadPeaksBox;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Button graphButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ListBox monthsList;
        private System.Windows.Forms.Label monthsLabel;
        private System.Windows.Forms.Label BatteryLabel;
    }
}