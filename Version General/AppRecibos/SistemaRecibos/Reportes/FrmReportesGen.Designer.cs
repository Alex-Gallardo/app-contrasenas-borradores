namespace SistemaRecibos.Reportes
{
    partial class FrmReportesGen
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.mABorradorNCGenXFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new SistemaRecibos.Reportes.DataSet1();
            this.MA_BorradorNCGenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mABorradorNCGenXFechaAbiertosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DtpFinicial = new System.Windows.Forms.DateTimePicker();
            this.DtpFFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnInforAut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnInfBorrFormat = new System.Windows.Forms.Button();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtIdBorr = new System.Windows.Forms.TextBox();
            this.CbbEmpresa = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BtnAbiertos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label7 = new System.Windows.Forms.Label();
            this.DtpFinAbiertos = new System.Windows.Forms.DateTimePicker();
            this.DtpIniAbiertos = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.mA_BorradorNCGenXFechaTableAdapter = new SistemaRecibos.Reportes.DataSet1TableAdapters.MA_BorradorNCGenXFechaTableAdapter();
            this.mABorradorNCGenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mA_BorradorNCGenTableAdapter = new SistemaRecibos.Reportes.DataSet1TableAdapters.MA_BorradorNCGenTableAdapter();
            this.mABorradorNCGenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.MA_BorradorNCGenXFechaAbiertosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mA_BorradorNCGenXFechaAbiertosTableAdapter = new SistemaRecibos.Reportes.DataSet1TableAdapters.MA_BorradorNCGenXFechaAbiertosTableAdapter();
            this.mABorradorNCGenBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mABorradorNCGenXFechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MA_BorradorNCGenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mABorradorNCGenXFechaAbiertosBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mABorradorNCGenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mABorradorNCGenBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MA_BorradorNCGenXFechaAbiertosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mABorradorNCGenBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // mABorradorNCGenXFechaBindingSource
            // 
            this.mABorradorNCGenXFechaBindingSource.DataMember = "MA_BorradorNCGenXFecha";
            this.mABorradorNCGenXFechaBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MA_BorradorNCGenBindingSource
            // 
            this.MA_BorradorNCGenBindingSource.DataMember = "MA_BorradorNCGen";
            this.MA_BorradorNCGenBindingSource.DataSource = this.dataSet1;
            // 
            // mABorradorNCGenXFechaAbiertosBindingSource
            // 
            this.mABorradorNCGenXFechaAbiertosBindingSource.DataMember = "MA_BorradorNCGenXFechaAbiertos";
            this.mABorradorNCGenXFechaAbiertosBindingSource.DataSource = this.dataSet1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource7.Name = "DsBorrAutorizados";
            reportDataSource7.Value = this.mABorradorNCGenXFechaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaRecibos.Reportes.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 92);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1407, 624);
            this.reportViewer1.TabIndex = 0;
            // 
            // DtpFinicial
            // 
            this.DtpFinicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFinicial.Location = new System.Drawing.Point(121, 54);
            this.DtpFinicial.Name = "DtpFinicial";
            this.DtpFinicial.Size = new System.Drawing.Size(102, 22);
            this.DtpFinicial.TabIndex = 1;
            // 
            // DtpFFinal
            // 
            this.DtpFFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFFinal.Location = new System.Drawing.Point(329, 54);
            this.DtpFFinal.Name = "DtpFFinal";
            this.DtpFFinal.Size = new System.Drawing.Size(112, 22);
            this.DtpFFinal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Borradores Autorizados / Rechazados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Inicial";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(25, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1427, 751);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnInforAut);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.DtpFFinal);
            this.tabPage1.Controls.Add(this.DtpFinicial);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1419, 722);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Autorizaciones";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnInforAut
            // 
            this.BtnInforAut.Location = new System.Drawing.Point(467, 50);
            this.BtnInforAut.Name = "BtnInforAut";
            this.BtnInforAut.Size = new System.Drawing.Size(144, 30);
            this.BtnInforAut.TabIndex = 6;
            this.BtnInforAut.Text = "Generar Informe";
            this.BtnInforAut.UseVisualStyleBackColor = true;
            this.BtnInforAut.Click += new System.EventHandler(this.BtnInforAut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha Final";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnInfBorrFormat);
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.TxtIdBorr);
            this.tabPage2.Controls.Add(this.CbbEmpresa);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1419, 722);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Formato Borrador";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnInfBorrFormat
            // 
            this.BtnInfBorrFormat.Location = new System.Drawing.Point(514, 35);
            this.BtnInfBorrFormat.Name = "BtnInfBorrFormat";
            this.BtnInfBorrFormat.Size = new System.Drawing.Size(144, 30);
            this.BtnInfBorrFormat.TabIndex = 8;
            this.BtnInfBorrFormat.Text = "Generar Informe";
            this.BtnInfBorrFormat.UseVisualStyleBackColor = true;
            this.BtnInfBorrFormat.Click += new System.EventHandler(this.BtnInfBorrFormat_Click);
            // 
            // reportViewer2
            // 
            this.reportViewer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource8.Name = "DataSet1";
            reportDataSource8.Value = this.mABorradorNCGenBindingSource2;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "SistemaRecibos.Reportes.Report1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(6, 92);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1404, 624);
            this.reportViewer2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Empresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "No. Borrador";
            // 
            // TxtIdBorr
            // 
            this.TxtIdBorr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtIdBorr.Location = new System.Drawing.Point(355, 42);
            this.TxtIdBorr.Name = "TxtIdBorr";
            this.TxtIdBorr.Size = new System.Drawing.Size(153, 22);
            this.TxtIdBorr.TabIndex = 4;
            // 
            // CbbEmpresa
            // 
            this.CbbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbEmpresa.FormattingEnabled = true;
            this.CbbEmpresa.Items.AddRange(new object[] {
            "BOLIK",
            "FAES",
            "GRACO"});
            this.CbbEmpresa.Location = new System.Drawing.Point(123, 39);
            this.CbbEmpresa.Name = "CbbEmpresa";
            this.CbbEmpresa.Size = new System.Drawing.Size(121, 24);
            this.CbbEmpresa.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.BtnAbiertos);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.DtpFinAbiertos);
            this.tabPage3.Controls.Add(this.DtpIniAbiertos);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1419, 722);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Abiertos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // BtnAbiertos
            // 
            this.BtnAbiertos.Location = new System.Drawing.Point(467, 47);
            this.BtnAbiertos.Name = "BtnAbiertos";
            this.BtnAbiertos.Size = new System.Drawing.Size(144, 30);
            this.BtnAbiertos.TabIndex = 13;
            this.BtnAbiertos.Text = "Generar Informe";
            this.BtnAbiertos.UseVisualStyleBackColor = true;
            this.BtnAbiertos.Click += new System.EventHandler(this.BtnAbiertos_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha Final";
            // 
            // reportViewer3
            // 
            this.reportViewer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource9.Name = "DataSet1";
            reportDataSource9.Value = this.mABorradorNCGenXFechaAbiertosBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "SistemaRecibos.Reportes.Report3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(6, 89);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(1407, 624);
            this.reportViewer3.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fecha Inicial";
            // 
            // DtpFinAbiertos
            // 
            this.DtpFinAbiertos.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFinAbiertos.Location = new System.Drawing.Point(329, 51);
            this.DtpFinAbiertos.Name = "DtpFinAbiertos";
            this.DtpFinAbiertos.Size = new System.Drawing.Size(112, 22);
            this.DtpFinAbiertos.TabIndex = 9;
            // 
            // DtpIniAbiertos
            // 
            this.DtpIniAbiertos.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpIniAbiertos.Location = new System.Drawing.Point(121, 51);
            this.DtpIniAbiertos.Name = "DtpIniAbiertos";
            this.DtpIniAbiertos.Size = new System.Drawing.Size(102, 22);
            this.DtpIniAbiertos.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Borradores Abiertos";
            // 
            // mA_BorradorNCGenXFechaTableAdapter
            // 
            this.mA_BorradorNCGenXFechaTableAdapter.ClearBeforeFill = true;
            // 
            // mABorradorNCGenBindingSource
            // 
            this.mABorradorNCGenBindingSource.DataMember = "MA_BorradorNCGen";
            this.mABorradorNCGenBindingSource.DataSource = this.dataSet1;
            // 
            // mA_BorradorNCGenTableAdapter
            // 
            this.mA_BorradorNCGenTableAdapter.ClearBeforeFill = true;
            // 
            // mABorradorNCGenBindingSource1
            // 
            this.mABorradorNCGenBindingSource1.DataMember = "MA_BorradorNCGen";
            this.mABorradorNCGenBindingSource1.DataSource = this.dataSet1;
            // 
            // MA_BorradorNCGenXFechaAbiertosBindingSource
            // 
            this.MA_BorradorNCGenXFechaAbiertosBindingSource.DataMember = "MA_BorradorNCGenXFechaAbiertos";
            this.MA_BorradorNCGenXFechaAbiertosBindingSource.DataSource = this.dataSet1;
            // 
            // mA_BorradorNCGenXFechaAbiertosTableAdapter
            // 
            this.mA_BorradorNCGenXFechaAbiertosTableAdapter.ClearBeforeFill = true;
            // 
            // mABorradorNCGenBindingSource2
            // 
            this.mABorradorNCGenBindingSource2.DataMember = "MA_BorradorNCGen";
            this.mABorradorNCGenBindingSource2.DataSource = this.dataSet1;
            // 
            // FrmReportesGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 775);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmReportesGen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Autorizados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReportesGen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mABorradorNCGenXFechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MA_BorradorNCGenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mABorradorNCGenXFechaAbiertosBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mABorradorNCGenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mABorradorNCGenBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MA_BorradorNCGenXFechaAbiertosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mABorradorNCGenBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource mABorradorNCGenXFechaBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.MA_BorradorNCGenXFechaTableAdapter mA_BorradorNCGenXFechaTableAdapter;
        private System.Windows.Forms.DateTimePicker DtpFinicial;
        private System.Windows.Forms.DateTimePicker DtpFFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnInforAut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox CbbEmpresa;
        private System.Windows.Forms.Button BtnInfBorrFormat;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource mABorradorNCGenBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtIdBorr;
        private System.Windows.Forms.BindingSource MA_BorradorNCGenBindingSource;
        private DataSet1TableAdapters.MA_BorradorNCGenTableAdapter mA_BorradorNCGenTableAdapter;
        private System.Windows.Forms.BindingSource mABorradorNCGenBindingSource1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button BtnAbiertos;
        private System.Windows.Forms.Label label6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DtpFinAbiertos;
        private System.Windows.Forms.DateTimePicker DtpIniAbiertos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource mABorradorNCGenXFechaAbiertosBindingSource;
        private System.Windows.Forms.BindingSource MA_BorradorNCGenXFechaAbiertosBindingSource;
        private DataSet1TableAdapters.MA_BorradorNCGenXFechaAbiertosTableAdapter mA_BorradorNCGenXFechaAbiertosTableAdapter;
        private System.Windows.Forms.BindingSource mABorradorNCGenBindingSource2;
    }
}