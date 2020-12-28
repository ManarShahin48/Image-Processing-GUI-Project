namespace IP_GUI_Project
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGRToGrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGR2YCrCbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGRHSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGRLuvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGRLabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGRHLSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.aaaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cannyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplacianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip5 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate180ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate270ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip6 = new System.Windows.Forms.MenuStrip();
            this.adaptiveThresholdingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaptiveThresholdingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adaptiveThresholdingToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.adaptiveThresholdingMeanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.menuStrip4.SuspendLayout();
            this.menuStrip5.SuspendLayout();
            this.menuStrip6.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1181, 55);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(12);
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(66, 51);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // uploadToolStripMenuItem
            // 
            this.uploadToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.uploadToolStripMenuItem.Text = "Upload";
            this.uploadToolStripMenuItem.Click += new System.EventHandler(this.uploadToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.closeToolStripMenuItem.Text = "Exit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtersToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 55);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1181, 55);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bGRToGrayToolStripMenuItem,
            this.bGR2YCrCbToolStripMenuItem,
            this.bGRHSVToolStripMenuItem,
            this.bGRLuvToolStripMenuItem,
            this.bGRLabToolStripMenuItem,
            this.bGRHLSToolStripMenuItem});
            this.filtersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtersToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Padding = new System.Windows.Forms.Padding(12);
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(209, 51);
            this.filtersToolStripMenuItem.Text = "Color Transformation";
            this.filtersToolStripMenuItem.Click += new System.EventHandler(this.filtersToolStripMenuItem_Click);
            // 
            // bGRToGrayToolStripMenuItem
            // 
            this.bGRToGrayToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGRToGrayToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.bGRToGrayToolStripMenuItem.Name = "bGRToGrayToolStripMenuItem";
            this.bGRToGrayToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.bGRToGrayToolStripMenuItem.Text = "BGR - Gray";
            this.bGRToGrayToolStripMenuItem.Click += new System.EventHandler(this.bGRToGrayToolStripMenuItem_Click);
            // 
            // bGR2YCrCbToolStripMenuItem
            // 
            this.bGR2YCrCbToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGR2YCrCbToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.bGR2YCrCbToolStripMenuItem.Name = "bGR2YCrCbToolStripMenuItem";
            this.bGR2YCrCbToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.bGR2YCrCbToolStripMenuItem.Text = "BGR - YCrCb";
            this.bGR2YCrCbToolStripMenuItem.Click += new System.EventHandler(this.bGR2YCrCbToolStripMenuItem_Click);
            // 
            // bGRHSVToolStripMenuItem
            // 
            this.bGRHSVToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGRHSVToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.bGRHSVToolStripMenuItem.Name = "bGRHSVToolStripMenuItem";
            this.bGRHSVToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.bGRHSVToolStripMenuItem.Text = "BGR - HSV";
            this.bGRHSVToolStripMenuItem.Click += new System.EventHandler(this.bGRHSVToolStripMenuItem_Click);
            // 
            // bGRLuvToolStripMenuItem
            // 
            this.bGRLuvToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGRLuvToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.bGRLuvToolStripMenuItem.Name = "bGRLuvToolStripMenuItem";
            this.bGRLuvToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.bGRLuvToolStripMenuItem.Text = "BGR - Luv";
            this.bGRLuvToolStripMenuItem.Click += new System.EventHandler(this.bGRLuvToolStripMenuItem_Click);
            // 
            // bGRLabToolStripMenuItem
            // 
            this.bGRLabToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGRLabToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.bGRLabToolStripMenuItem.Name = "bGRLabToolStripMenuItem";
            this.bGRLabToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.bGRLabToolStripMenuItem.Text = "BGR - Lab";
            this.bGRLabToolStripMenuItem.Click += new System.EventHandler(this.bGRLabToolStripMenuItem_Click);
            // 
            // bGRHLSToolStripMenuItem
            // 
            this.bGRHLSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGRHLSToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.bGRHLSToolStripMenuItem.Name = "bGRHLSToolStripMenuItem";
            this.bGRHLSToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.bGRHLSToolStripMenuItem.Text = "BGR - HLS";
            this.bGRHLSToolStripMenuItem.Click += new System.EventHandler(this.bGRHLSToolStripMenuItem_Click);
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aaaaToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 110);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip3.Size = new System.Drawing.Size(1181, 55);
            this.menuStrip3.TabIndex = 2;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // aaaaToolStripMenuItem
            // 
            this.aaaaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cannyToolStripMenuItem,
            this.sobalToolStripMenuItem,
            this.laplacianToolStripMenuItem});
            this.aaaaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aaaaToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.aaaaToolStripMenuItem.Name = "aaaaToolStripMenuItem";
            this.aaaaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(12);
            this.aaaaToolStripMenuItem.Size = new System.Drawing.Size(161, 51);
            this.aaaaToolStripMenuItem.Text = "Edge Detection";
            this.aaaaToolStripMenuItem.Click += new System.EventHandler(this.aaaaToolStripMenuItem_Click);
            // 
            // cannyToolStripMenuItem
            // 
            this.cannyToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cannyToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.cannyToolStripMenuItem.Name = "cannyToolStripMenuItem";
            this.cannyToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.cannyToolStripMenuItem.Text = "Canny";
            this.cannyToolStripMenuItem.Click += new System.EventHandler(this.cannyToolStripMenuItem_Click);
            // 
            // sobalToolStripMenuItem
            // 
            this.sobalToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobalToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.sobalToolStripMenuItem.Name = "sobalToolStripMenuItem";
            this.sobalToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.sobalToolStripMenuItem.Text = "Sobal";
            this.sobalToolStripMenuItem.Click += new System.EventHandler(this.sobalToolStripMenuItem_Click);
            // 
            // laplacianToolStripMenuItem
            // 
            this.laplacianToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laplacianToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.laplacianToolStripMenuItem.Name = "laplacianToolStripMenuItem";
            this.laplacianToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.laplacianToolStripMenuItem.Text = "Laplacian";
            this.laplacianToolStripMenuItem.Click += new System.EventHandler(this.laplacianToolStripMenuItem_Click);
            // 
            // menuStrip4
            // 
            this.menuStrip4.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip4.Location = new System.Drawing.Point(0, 165);
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip4.Size = new System.Drawing.Size(1181, 55);
            this.menuStrip4.TabIndex = 3;
            this.menuStrip4.Text = "menuStrip4";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Blue;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Padding = new System.Windows.Forms.Padding(12);
            this.toolStripMenuItem1.Size = new System.Drawing.Size(151, 51);
            this.toolStripMenuItem1.Text = "Segmentation";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.Navy;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(224, 28);
            this.toolStripMenuItem2.Text = "Watershed";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // menuStrip5
            // 
            this.menuStrip5.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip5.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4});
            this.menuStrip5.Location = new System.Drawing.Point(0, 220);
            this.menuStrip5.Name = "menuStrip5";
            this.menuStrip5.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip5.Size = new System.Drawing.Size(1181, 55);
            this.menuStrip5.TabIndex = 6;
            this.menuStrip5.Text = "menuStrip5";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.rotate180ToolStripMenuItem,
            this.rotate270ToolStripMenuItem});
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.Blue;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Padding = new System.Windows.Forms.Padding(12);
            this.toolStripMenuItem4.Size = new System.Drawing.Size(249, 51);
            this.toolStripMenuItem4.Text = "Geometric Transformation";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.Navy;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(224, 28);
            this.toolStripMenuItem5.Text = "Rotate 90";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // rotate180ToolStripMenuItem
            // 
            this.rotate180ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotate180ToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.rotate180ToolStripMenuItem.Name = "rotate180ToolStripMenuItem";
            this.rotate180ToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.rotate180ToolStripMenuItem.Text = "Rotate 180";
            this.rotate180ToolStripMenuItem.Click += new System.EventHandler(this.rotate180ToolStripMenuItem_Click);
            // 
            // rotate270ToolStripMenuItem
            // 
            this.rotate270ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotate270ToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.rotate270ToolStripMenuItem.Name = "rotate270ToolStripMenuItem";
            this.rotate270ToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.rotate270ToolStripMenuItem.Text = "Rotate 270";
            this.rotate270ToolStripMenuItem.Click += new System.EventHandler(this.rotate270ToolStripMenuItem_Click);
            // 
            // menuStrip6
            // 
            this.menuStrip6.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip6.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaptiveThresholdingToolStripMenuItem});
            this.menuStrip6.Location = new System.Drawing.Point(0, 275);
            this.menuStrip6.Name = "menuStrip6";
            this.menuStrip6.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip6.Size = new System.Drawing.Size(1181, 55);
            this.menuStrip6.TabIndex = 7;
            this.menuStrip6.Text = "menuStrip6";
            // 
            // adaptiveThresholdingToolStripMenuItem
            // 
            this.adaptiveThresholdingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaptiveThresholdingToolStripMenuItem1,
            this.adaptiveThresholdingToolStripMenuItem2,
            this.adaptiveThresholdingMeanToolStripMenuItem});
            this.adaptiveThresholdingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaptiveThresholdingToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.adaptiveThresholdingToolStripMenuItem.Name = "adaptiveThresholdingToolStripMenuItem";
            this.adaptiveThresholdingToolStripMenuItem.Padding = new System.Windows.Forms.Padding(12);
            this.adaptiveThresholdingToolStripMenuItem.Size = new System.Drawing.Size(143, 51);
            this.adaptiveThresholdingToolStripMenuItem.Text = "Thresholding";
            // 
            // adaptiveThresholdingToolStripMenuItem1
            // 
            this.adaptiveThresholdingToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaptiveThresholdingToolStripMenuItem1.ForeColor = System.Drawing.Color.Navy;
            this.adaptiveThresholdingToolStripMenuItem1.Name = "adaptiveThresholdingToolStripMenuItem1";
            this.adaptiveThresholdingToolStripMenuItem1.Size = new System.Drawing.Size(339, 28);
            this.adaptiveThresholdingToolStripMenuItem1.Text = "Binarization Thresholding";
            this.adaptiveThresholdingToolStripMenuItem1.Click += new System.EventHandler(this.adaptiveThresholdingToolStripMenuItem1_Click);
            // 
            // adaptiveThresholdingToolStripMenuItem2
            // 
            this.adaptiveThresholdingToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaptiveThresholdingToolStripMenuItem2.ForeColor = System.Drawing.Color.Navy;
            this.adaptiveThresholdingToolStripMenuItem2.Name = "adaptiveThresholdingToolStripMenuItem2";
            this.adaptiveThresholdingToolStripMenuItem2.Size = new System.Drawing.Size(339, 28);
            this.adaptiveThresholdingToolStripMenuItem2.Text = "Adaptive Thresholding Gaussian";
            this.adaptiveThresholdingToolStripMenuItem2.Click += new System.EventHandler(this.adaptiveThresholdingToolStripMenuItem2_Click);
            // 
            // adaptiveThresholdingMeanToolStripMenuItem
            // 
            this.adaptiveThresholdingMeanToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaptiveThresholdingMeanToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.adaptiveThresholdingMeanToolStripMenuItem.Name = "adaptiveThresholdingMeanToolStripMenuItem";
            this.adaptiveThresholdingMeanToolStripMenuItem.Size = new System.Drawing.Size(339, 28);
            this.adaptiveThresholdingMeanToolStripMenuItem.Text = "Adaptive Thresholding Mean";
            this.adaptiveThresholdingMeanToolStripMenuItem.Click += new System.EventHandler(this.adaptiveThresholdingMeanToolStripMenuItem_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.panel3);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SlateBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(241, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(938, 517);
            this.bunifuGradientPanel1.TabIndex = 10;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(36, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 493);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(968, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 517);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1180, 10);
            this.panel4.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(3, 507);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1180, 10);
            this.panel6.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 517);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(479, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(424, 493);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Location = new System.Drawing.Point(0, 507);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1179, 10);
            this.panel2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1181, 517);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.menuStrip6);
            this.Controls.Add(this.menuStrip5);
            this.Controls.Add(this.menuStrip4);
            this.Controls.Add(this.menuStrip3);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "IP GUI Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.menuStrip4.ResumeLayout(false);
            this.menuStrip4.PerformLayout();
            this.menuStrip5.ResumeLayout(false);
            this.menuStrip5.PerformLayout();
            this.menuStrip6.ResumeLayout(false);
            this.menuStrip6.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem aaaaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip4;
        private System.Windows.Forms.ToolStripMenuItem bGRToGrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGR2YCrCbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGRHSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGRLuvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGRLabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGRHLSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cannyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplacianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.MenuStrip menuStrip5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.MenuStrip menuStrip6;
        private System.Windows.Forms.ToolStripMenuItem rotate180ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotate270ToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem adaptiveThresholdingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaptiveThresholdingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adaptiveThresholdingToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem adaptiveThresholdingMeanToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
    }
}

