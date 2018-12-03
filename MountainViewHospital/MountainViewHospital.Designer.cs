namespace MountainViewHospital
{
    partial class MountainViewHospital
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used. PLEASE WORK
        /// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MountainViewHospital));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPatient = new System.Windows.Forms.TabPage();
            this.tabRoom = new System.Windows.Forms.TabPage();
            this.tabItems = new System.Windows.Forms.TabPage();
            this.tabCostCenter = new System.Windows.Forms.TabPage();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.tabPatientBillReport = new System.Windows.Forms.TabPage();
            this.RoomUtilizationReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tabControl1.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabHome);
            this.tabControl1.Controls.Add(this.tabPatient);
            this.tabControl1.Controls.Add(this.tabRoom);
            this.tabControl1.Controls.Add(this.tabItems);
            this.tabControl1.Controls.Add(this.tabCostCenter);
            this.tabControl1.Controls.Add(this.tabReports);
            this.tabControl1.Controls.Add(this.tabPatientBillReport);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(790, 453);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.LightGray;
            this.tabHome.Controls.Add(this.linkLabel1);
            this.tabHome.Controls.Add(this.label1);
            this.tabHome.ForeColor = System.Drawing.Color.Navy;
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(782, 427);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.Click += new System.EventHandler(this.tabHome_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(620, 383);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(137, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click here to go to next tab.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is a home page for the mountain view community hospital navigation system";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPatient
            // 
            this.tabPatient.Location = new System.Drawing.Point(4, 22);
            this.tabPatient.Name = "tabPatient";
            this.tabPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatient.Size = new System.Drawing.Size(782, 427);
            this.tabPatient.TabIndex = 1;
            this.tabPatient.Text = "Patient";
            this.tabPatient.UseVisualStyleBackColor = true;
            // 
            // tabRoom
            // 
            this.tabRoom.Location = new System.Drawing.Point(4, 22);
            this.tabRoom.Name = "tabRoom";
            this.tabRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoom.Size = new System.Drawing.Size(782, 427);
            this.tabRoom.TabIndex = 2;
            this.tabRoom.Text = "Room";
            this.tabRoom.UseVisualStyleBackColor = true;
            // 
            // tabItems
            // 
            this.tabItems.Location = new System.Drawing.Point(4, 22);
            this.tabItems.Name = "tabItems";
            this.tabItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabItems.Size = new System.Drawing.Size(782, 427);
            this.tabItems.TabIndex = 3;
            this.tabItems.Text = "Items";
            this.tabItems.UseVisualStyleBackColor = true;
            // 
            // tabCostCenter
            // 
            this.tabCostCenter.Location = new System.Drawing.Point(4, 22);
            this.tabCostCenter.Name = "tabCostCenter";
            this.tabCostCenter.Padding = new System.Windows.Forms.Padding(3);
            this.tabCostCenter.Size = new System.Drawing.Size(782, 427);
            this.tabCostCenter.TabIndex = 4;
            this.tabCostCenter.Text = "Cost Centre";
            this.tabCostCenter.UseVisualStyleBackColor = true;
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.RoomUtilizationReportViewer);
            this.tabReports.Location = new System.Drawing.Point(4, 22);
            this.tabReports.Name = "tabReports";
            this.tabReports.Size = new System.Drawing.Size(782, 427);
            this.tabReports.TabIndex = 5;
            this.tabReports.Text = "Room Utilization Report";
            this.tabReports.UseVisualStyleBackColor = true;
            this.tabReports.Click += new System.EventHandler(this.tabReports_Click);
            // 
            // tabPatientBillReport
            // 
            this.tabPatientBillReport.Location = new System.Drawing.Point(4, 22);
            this.tabPatientBillReport.Name = "tabPatientBillReport";
            this.tabPatientBillReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatientBillReport.Size = new System.Drawing.Size(782, 427);
            this.tabPatientBillReport.TabIndex = 6;
            this.tabPatientBillReport.Text = "Patient Bill Report";
            this.tabPatientBillReport.UseVisualStyleBackColor = true;
            // 
            // RoomUtilizationReportViewer
            // 
            this.RoomUtilizationReportViewer.ActiveViewIndex = -1;
            this.RoomUtilizationReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoomUtilizationReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.RoomUtilizationReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomUtilizationReportViewer.Location = new System.Drawing.Point(0, 0);
            this.RoomUtilizationReportViewer.Name = "RoomUtilizationReportViewer";
            this.RoomUtilizationReportViewer.Size = new System.Drawing.Size(782, 427);
            this.RoomUtilizationReportViewer.TabIndex = 0;
            this.RoomUtilizationReportViewer.Load += new System.EventHandler(this.RoomUtilizationReportViewer_Load);
            // 
            // MountainViewHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MountainViewHospital";
            this.Text = "Mountain View Hospital ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.tabReports.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabPatient;
        private System.Windows.Forms.TabPage tabRoom;
        private System.Windows.Forms.TabPage tabItems;
        private System.Windows.Forms.TabPage tabCostCenter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.TabPage tabPatientBillReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer RoomUtilizationReportViewer;
    }
}

