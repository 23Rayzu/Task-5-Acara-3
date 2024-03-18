namespace Raster_Data_Operations_in_DotSpatial
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlOperations = new System.Windows.Forms.Panel();
            this.txtElavation = new System.Windows.Forms.TextBox();
            this.chbRasterValue = new System.Windows.Forms.CheckBox();
            this.lblRasterValue = new System.Windows.Forms.Label();
            this.lblElavation = new System.Windows.Forms.Label();
            this.btnReclassify = new System.Windows.Forms.Button();
            this.btnMultiplyRaster = new System.Windows.Forms.Button();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.btnHillshade = new System.Windows.Forms.Button();
            this.btnLoadRaster = new System.Windows.Forms.Button();
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.Legend1 = new DotSpatial.Controls.Legend();
            this.pnlMap = new System.Windows.Forms.Panel();
            this.map1 = new DotSpatial.Controls.Map();
            this.appManager1 = new DotSpatial.Controls.AppManager();
            this.pnlOperations.SuspendLayout();
            this.pnlLegend.SuspendLayout();
            this.pnlMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOperations
            // 
            this.pnlOperations.Controls.Add(this.txtElavation);
            this.pnlOperations.Controls.Add(this.chbRasterValue);
            this.pnlOperations.Controls.Add(this.lblRasterValue);
            this.pnlOperations.Controls.Add(this.lblElavation);
            this.pnlOperations.Controls.Add(this.btnReclassify);
            this.pnlOperations.Controls.Add(this.btnMultiplyRaster);
            this.pnlOperations.Controls.Add(this.btnChangeColor);
            this.pnlOperations.Controls.Add(this.btnHillshade);
            this.pnlOperations.Controls.Add(this.btnLoadRaster);
            this.pnlOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperations.Location = new System.Drawing.Point(0, 0);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(800, 78);
            this.pnlOperations.TabIndex = 0;
            // 
            // txtElavation
            // 
            this.txtElavation.Location = new System.Drawing.Point(393, 14);
            this.txtElavation.Name = "txtElavation";
            this.txtElavation.Size = new System.Drawing.Size(74, 20);
            this.txtElavation.TabIndex = 8;
            this.txtElavation.Text = "3000";
            // 
            // chbRasterValue
            // 
            this.chbRasterValue.AutoSize = true;
            this.chbRasterValue.Location = new System.Drawing.Point(568, 17);
            this.chbRasterValue.Name = "chbRasterValue";
            this.chbRasterValue.Size = new System.Drawing.Size(157, 17);
            this.chbRasterValue.TabIndex = 7;
            this.chbRasterValue.Text = "Raster value at check point";
            this.chbRasterValue.UseVisualStyleBackColor = true;
            this.chbRasterValue.CheckedChanged += new System.EventHandler(this.chbRasterValue_CheckedChanged);
            // 
            // lblRasterValue
            // 
            this.lblRasterValue.AutoSize = true;
            this.lblRasterValue.Location = new System.Drawing.Point(565, 47);
            this.lblRasterValue.Name = "lblRasterValue";
            this.lblRasterValue.Size = new System.Drawing.Size(106, 13);
            this.lblRasterValue.TabIndex = 6;
            this.lblRasterValue.Text = "Row: Column: Value:";
            // 
            // lblElavation
            // 
            this.lblElavation.AutoSize = true;
            this.lblElavation.Location = new System.Drawing.Point(336, 19);
            this.lblElavation.Name = "lblElavation";
            this.lblElavation.Size = new System.Drawing.Size(51, 13);
            this.lblElavation.TabIndex = 5;
            this.lblElavation.Text = "Elavation";
            // 
            // btnReclassify
            // 
            this.btnReclassify.Location = new System.Drawing.Point(473, 12);
            this.btnReclassify.Name = "btnReclassify";
            this.btnReclassify.Size = new System.Drawing.Size(75, 23);
            this.btnReclassify.TabIndex = 4;
            this.btnReclassify.Text = "&Reclassify Raster";
            this.btnReclassify.UseVisualStyleBackColor = true;
            this.btnReclassify.Click += new System.EventHandler(this.btnReclassify_Click);
            // 
            // btnMultiplyRaster
            // 
            this.btnMultiplyRaster.Location = new System.Drawing.Point(255, 12);
            this.btnMultiplyRaster.Name = "btnMultiplyRaster";
            this.btnMultiplyRaster.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplyRaster.TabIndex = 3;
            this.btnMultiplyRaster.Text = "&Multiply Raster";
            this.btnMultiplyRaster.UseVisualStyleBackColor = true;
            this.btnMultiplyRaster.Click += new System.EventHandler(this.btnMultiplyRaster_Click);
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(174, 12);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(75, 23);
            this.btnChangeColor.TabIndex = 2;
            this.btnChangeColor.Text = "&Change Color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // btnHillshade
            // 
            this.btnHillshade.Location = new System.Drawing.Point(93, 12);
            this.btnHillshade.Name = "btnHillshade";
            this.btnHillshade.Size = new System.Drawing.Size(75, 23);
            this.btnHillshade.TabIndex = 1;
            this.btnHillshade.Text = "&Hillshade";
            this.btnHillshade.UseVisualStyleBackColor = true;
            this.btnHillshade.Click += new System.EventHandler(this.btnHillshade_Click);
            // 
            // btnLoadRaster
            // 
            this.btnLoadRaster.Location = new System.Drawing.Point(12, 12);
            this.btnLoadRaster.Name = "btnLoadRaster";
            this.btnLoadRaster.Size = new System.Drawing.Size(75, 23);
            this.btnLoadRaster.TabIndex = 0;
            this.btnLoadRaster.Text = "&Load Raster";
            this.btnLoadRaster.UseVisualStyleBackColor = true;
            this.btnLoadRaster.Click += new System.EventHandler(this.btnLoadRaster_Click);
            // 
            // pnlLegend
            // 
            this.pnlLegend.Controls.Add(this.Legend1);
            this.pnlLegend.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLegend.Location = new System.Drawing.Point(0, 78);
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Size = new System.Drawing.Size(233, 372);
            this.pnlLegend.TabIndex = 1;
            // 
            // Legend1
            // 
            this.Legend1.BackColor = System.Drawing.Color.White;
            this.Legend1.ControlRectangle = new System.Drawing.Rectangle(0, 0, 233, 372);
            this.Legend1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Legend1.DocumentRectangle = new System.Drawing.Rectangle(0, 0, 187, 428);
            this.Legend1.HorizontalScrollEnabled = true;
            this.Legend1.Indentation = 30;
            this.Legend1.IsInitialized = false;
            this.Legend1.Location = new System.Drawing.Point(0, 0);
            this.Legend1.MinimumSize = new System.Drawing.Size(5, 5);
            this.Legend1.Name = "Legend1";
            this.Legend1.ProgressHandler = null;
            this.Legend1.ResetOnResize = false;
            this.Legend1.SelectionFontColor = System.Drawing.Color.Black;
            this.Legend1.SelectionHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.Legend1.Size = new System.Drawing.Size(233, 372);
            this.Legend1.TabIndex = 0;
            this.Legend1.Text = "legend1";
            this.Legend1.UseLegendForSelection = true;
            this.Legend1.VerticalScrollEnabled = true;
            // 
            // pnlMap
            // 
            this.pnlMap.Controls.Add(this.map1);
            this.pnlMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMap.Location = new System.Drawing.Point(0, 78);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(800, 372);
            this.pnlMap.TabIndex = 1;
            // 
            // map1
            // 
            this.map1.AllowDrop = true;
            this.map1.BackColor = System.Drawing.Color.White;
            this.map1.CollisionDetection = false;
            this.map1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map1.ExtendBuffer = false;
            this.map1.FunctionMode = DotSpatial.Controls.FunctionMode.None;
            this.map1.IsBusy = false;
            this.map1.IsZoomedToMaxExtent = false;
            this.map1.Legend = this.Legend1;
            this.map1.Location = new System.Drawing.Point(0, 0);
            this.map1.Name = "map1";
            this.map1.ProgressHandler = null;
            this.map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.map1.RedrawLayersWhileResizing = false;
            this.map1.SelectionEnabled = true;
            this.map1.Size = new System.Drawing.Size(800, 372);
            this.map1.TabIndex = 0;
            this.map1.ZoomOutFartherThanMaxExtent = false;
            // 
            // appManager1
            // 
            this.appManager1.Directories = ((System.Collections.Generic.List<string>)(resources.GetObject("appManager1.Directories")));
            this.appManager1.DockManager = null;
            this.appManager1.HeaderControl = null;
            this.appManager1.Legend = this.Legend1;
            this.appManager1.Map = this.map1;
            this.appManager1.ProgressHandler = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlLegend);
            this.Controls.Add(this.pnlMap);
            this.Controls.Add(this.pnlOperations);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlOperations.ResumeLayout(false);
            this.pnlOperations.PerformLayout();
            this.pnlLegend.ResumeLayout(false);
            this.pnlMap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.Panel pnlLegend;
        private System.Windows.Forms.Panel pnlMap;
        private System.Windows.Forms.TextBox txtElavation;
        private System.Windows.Forms.CheckBox chbRasterValue;
        private System.Windows.Forms.Label lblRasterValue;
        private System.Windows.Forms.Label lblElavation;
        private System.Windows.Forms.Button btnReclassify;
        private System.Windows.Forms.Button btnMultiplyRaster;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Button btnHillshade;
        private System.Windows.Forms.Button btnLoadRaster;
        private DotSpatial.Controls.Legend Legend1;
        private DotSpatial.Controls.Map map1;
        private DotSpatial.Controls.AppManager appManager1;
    }
}