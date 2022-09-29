﻿
namespace MissionPlanner
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
        /// <param //name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlNavigation = new BSE.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlDonnees = new BSE.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel1 = new BSE.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.DataGraphique = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlNavigation.SuspendLayout();
            this.pnlDonnees.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGraphique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1270, 124);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.AssociatedSplitter = null;
            this.pnlNavigation.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavigation.CaptionFont = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.pnlNavigation.CaptionHeight = 27;
            this.pnlNavigation.Controls.Add(this.textBox3);
            this.pnlNavigation.Controls.Add(this.button1);
            this.pnlNavigation.Controls.Add(this.textBox2);
            this.pnlNavigation.Controls.Add(this.textBox1);
            this.pnlNavigation.Controls.Add(this.pnlDonnees);
            this.pnlNavigation.Controls.Add(this.panel1);
            this.pnlNavigation.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.pnlNavigation.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.pnlNavigation.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.pnlNavigation.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlNavigation.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.pnlNavigation.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnlNavigation.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.pnlNavigation.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.pnlNavigation.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.pnlNavigation.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.pnlNavigation.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.pnlNavigation.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlNavigation.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlNavigation.Image = null;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 124);
            this.pnlNavigation.MinimumSize = new System.Drawing.Size(27, 27);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(200, 580);
            this.pnlNavigation.TabIndex = 1;
            this.pnlNavigation.Text = "Navigation";
            this.pnlNavigation.ToolTipTextCloseIcon = null;
            this.pnlNavigation.ToolTipTextExpandIconPanelCollapsed = null;
            this.pnlNavigation.ToolTipTextExpandIconPanelExpanded = null;
            this.pnlNavigation.CloseClick += new System.EventHandler<System.EventArgs>(this.pnlNavigation_CloseClick);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(14, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(173, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Resultat";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(69, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // pnlDonnees
            // 
            this.pnlDonnees.AssociatedSplitter = null;
            this.pnlDonnees.BackColor = System.Drawing.Color.Transparent;
            this.pnlDonnees.CaptionFont = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.pnlDonnees.CaptionHeight = 27;
            this.pnlDonnees.Controls.Add(this.btnExport);
            this.pnlDonnees.Controls.Add(this.dateTimePicker1);
            this.pnlDonnees.Controls.Add(this.lblDate);
            this.pnlDonnees.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.pnlDonnees.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.pnlDonnees.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.pnlDonnees.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlDonnees.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.pnlDonnees.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnlDonnees.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.pnlDonnees.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.pnlDonnees.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.pnlDonnees.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.pnlDonnees.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.pnlDonnees.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnlDonnees.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.pnlDonnees.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDonnees.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlDonnees.Image = null;
            this.pnlDonnees.Location = new System.Drawing.Point(1, 142);
            this.pnlDonnees.MinimumSize = new System.Drawing.Size(27, 27);
            this.pnlDonnees.Name = "pnlDonnees";
            this.pnlDonnees.Size = new System.Drawing.Size(198, 437);
            this.pnlDonnees.TabIndex = 1;
            this.pnlDonnees.Text = "Données";
            this.pnlDonnees.ToolTipTextCloseIcon = null;
            this.pnlDonnees.ToolTipTextExpandIconPanelCollapsed = null;
            this.pnlDonnees.ToolTipTextExpandIconPanelExpanded = null;
            this.pnlDonnees.CloseClick += new System.EventHandler<System.EventArgs>(this.pnlDonnees_CloseClick);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(12, 206);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(128, 31);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 180);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(8, 153);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 24);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            this.lblDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.AssociatedSplitter = null;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.CaptionFont = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.panel1.CaptionHeight = 27;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.panel1.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.panel1.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.panel1.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel1.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.panel1.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.panel1.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.panel1.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.panel1.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.panel1.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.panel1.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel1.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Image = null;
            this.panel1.Location = new System.Drawing.Point(4, 31);
            this.panel1.MinimumSize = new System.Drawing.Size(27, 27);
            this.panel1.Name = "panel1";
            this.panel1.ShowCaptionbar = false;
            this.panel1.Size = new System.Drawing.Size(192, 35);
            this.panel1.TabIndex = 0;
            this.panel1.Text = "panel1";
            this.panel1.ToolTipTextCloseIcon = null;
            this.panel1.ToolTipTextExpandIconPanelCollapsed = null;
            this.panel1.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(53, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(206, 130);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1064, 562);
            this.cartesianChart1.TabIndex = 2;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // DataGraphique
            // 
            this.DataGraphique.DataSource = typeof(MissionPlanner.Form1);
            this.DataGraphique.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(MissionPlanner.Form1);
            this.form1BindingSource.CurrentChanged += new System.EventHandler(this.form1BindingSource_CurrentChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1270, 704);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.pnlHeader);
            this.Name = "Form1";
            this.Text = "Delta Graphics";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlNavigation.ResumeLayout(false);
            this.pnlNavigation.PerformLayout();
            this.pnlDonnees.ResumeLayout(false);
            this.pnlDonnees.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGraphique)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private BSE.Windows.Forms.Panel pnlNavigation;
        private BSE.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private BSE.Windows.Forms.Panel pnlDonnees;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private GraphiquePlugin.HeaderControlUser headerControl1;
        private GraphiquePlugin.HeaderControlUser headerControl2;
        private System.Windows.Forms.BindingSource DataGraphique;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

