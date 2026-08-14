namespace SistemaRecibos.Reportes
{
    partial class FrmReportesCxP
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource13 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource14 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource15 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.mACXPCONTRASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new SistemaRecibos.Reportes.DataSet1();
            this.mACXPCONTRASLIQBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mACXPCONTRASCONTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MA_CXP_CONTRAS_LIQ_CATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateSetCat = new SistemaRecibos.DateSetCat();
            this.MA_CXP_CONTRAS_CONTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mA_CXP_CONTRASTableAdapter = new SistemaRecibos.Reportes.DataSet1TableAdapters.MA_CXP_CONTRASTableAdapter();
            this.MA_CXP_CONTRAS_LIQBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mA_CXP_CONTRAS_LIQTableAdapter = new SistemaRecibos.Reportes.DataSet1TableAdapters.MA_CXP_CONTRAS_LIQTableAdapter();
            this.mA_CXP_CONTRAS_CONTATableAdapter = new SistemaRecibos.Reportes.DataSet1TableAdapters.MA_CXP_CONTRAS_CONTATableAdapter();
            this.mACXPCONTRASLIQCATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mA_CXP_CONTRAS_LIQ_CATTableAdapter = new SistemaRecibos.DateSetCatTableAdapters.MA_CXP_CONTRAS_LIQ_CATTableAdapter();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpf1Conta = new System.Windows.Forms.DateTimePicker();
            this.dtpf2Conta = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnConta = new System.Windows.Forms.Button();
            this.CbbPlantaConta = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.DtpFLiq1 = new System.Windows.Forms.DateTimePicker();
            this.DtpFLiq2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnLiquidaciones = new System.Windows.Forms.Button();
            this.CbbPlantaLiq = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.CbbCategoria = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpFinicial = new System.Windows.Forms.DateTimePicker();
            this.DtpFFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnContras1 = new System.Windows.Forms.Button();
            this.CbbPlanta = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.mACXPCONTRASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACXPCONTRASLIQBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACXPCONTRASCONTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MA_CXP_CONTRAS_LIQ_CATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSetCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MA_CXP_CONTRAS_CONTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MA_CXP_CONTRAS_LIQBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACXPCONTRASLIQCATBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mACXPCONTRASBindingSource
            // 
            this.mACXPCONTRASBindingSource.DataMember = "MA_CXP_CONTRAS";
            this.mACXPCONTRASBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.EnforceConstraints = false;
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mACXPCONTRASLIQBindingSource
            // 
            this.mACXPCONTRASLIQBindingSource.DataMember = "MA_CXP_CONTRAS_LIQ";
            this.mACXPCONTRASLIQBindingSource.DataSource = this.dataSet1;
            // 
            // mACXPCONTRASCONTABindingSource
            // 
            this.mACXPCONTRASCONTABindingSource.DataMember = "MA_CXP_CONTRAS_CONTA";
            this.mACXPCONTRASCONTABindingSource.DataSource = this.dataSet1;
            // 
            // MA_CXP_CONTRAS_LIQ_CATBindingSource
            // 
            this.MA_CXP_CONTRAS_LIQ_CATBindingSource.DataMember = "MA_CXP_CONTRAS_LIQ_CAT";
            this.MA_CXP_CONTRAS_LIQ_CATBindingSource.DataSource = this.dateSetCat;
            // 
            // dateSetCat
            // 
            this.dateSetCat.DataSetName = "DateSetCat";
            this.dateSetCat.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MA_CXP_CONTRAS_CONTABindingSource
            // 
            this.MA_CXP_CONTRAS_CONTABindingSource.DataMember = "MA_CXP_CONTRAS_CONTA";
            this.MA_CXP_CONTRAS_CONTABindingSource.DataSource = this.dataSet1;
            // 
            // mA_CXP_CONTRASTableAdapter
            // 
            this.mA_CXP_CONTRASTableAdapter.ClearBeforeFill = true;
            // 
            // MA_CXP_CONTRAS_LIQBindingSource
            // 
            this.MA_CXP_CONTRAS_LIQBindingSource.DataMember = "MA_CXP_CONTRAS_LIQ";
            this.MA_CXP_CONTRAS_LIQBindingSource.DataSource = this.dataSet1;
            // 
            // mA_CXP_CONTRAS_LIQTableAdapter
            // 
            this.mA_CXP_CONTRAS_LIQTableAdapter.ClearBeforeFill = true;
            // 
            // mA_CXP_CONTRAS_CONTATableAdapter
            // 
            this.mA_CXP_CONTRAS_CONTATableAdapter.ClearBeforeFill = true;
            // 
            // mACXPCONTRASLIQCATBindingSource
            // 
            this.mACXPCONTRASLIQCATBindingSource.DataMember = "MA_CXP_CONTRAS_LIQ_CAT";
            this.mACXPCONTRASLIQCATBindingSource.DataSource = this.dateSetCat;
            // 
            // mA_CXP_CONTRAS_LIQ_CATTableAdapter
            // 
            this.mA_CXP_CONTRAS_LIQ_CATTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.CbbPlantaConta);
            this.tabPage3.Controls.Add(this.BtnConta);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.dtpf2Conta);
            this.tabPage3.Controls.Add(this.dtpf1Conta);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1377, 657);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Contabilizados";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(417, 24);
            this.label13.TabIndex = 12;
            this.label13.Text = "Contabilización de Contraseñas por Fecha y Usuario";
            // 
            // dtpf1Conta
            // 
            this.dtpf1Conta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpf1Conta.Location = new System.Drawing.Point(127, 62);
            this.dtpf1Conta.Name = "dtpf1Conta";
            this.dtpf1Conta.Size = new System.Drawing.Size(102, 22);
            this.dtpf1Conta.TabIndex = 10;
            // 
            // dtpf2Conta
            // 
            this.dtpf2Conta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpf2Conta.Location = new System.Drawing.Point(335, 62);
            this.dtpf2Conta.Name = "dtpf2Conta";
            this.dtpf2Conta.Size = new System.Drawing.Size(112, 22);
            this.dtpf2Conta.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Fecha Inicial";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(253, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Fecha Final";
            // 
            // BtnConta
            // 
            this.BtnConta.Location = new System.Drawing.Point(653, 58);
            this.BtnConta.Name = "BtnConta";
            this.BtnConta.Size = new System.Drawing.Size(144, 30);
            this.BtnConta.TabIndex = 15;
            this.BtnConta.Text = "Generar Informe";
            this.BtnConta.UseVisualStyleBackColor = true;
            this.BtnConta.Click += new System.EventHandler(this.BtnConta_Click);
            // 
            // CbbPlantaConta
            // 
            this.CbbPlantaConta.FormattingEnabled = true;
            this.CbbPlantaConta.Items.AddRange(new object[] {
            "ANEXA",
            "CR",
            "PC",
            "PALIN",
            "TODOS"});
            this.CbbPlantaConta.Location = new System.Drawing.Point(517, 60);
            this.CbbPlantaConta.Name = "CbbPlantaConta";
            this.CbbPlantaConta.Size = new System.Drawing.Size(121, 24);
            this.CbbPlantaConta.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(464, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Planta";
            // 
            // reportViewer3
            // 
            this.reportViewer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource13.Name = "DataSet1";
            reportDataSource13.Value = this.mACXPCONTRASCONTABindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource13);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "SistemaRecibos.Reportes.Report7.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(19, 124);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(1342, 512);
            this.reportViewer3.TabIndex = 18;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CbbCategoria);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.CbbPlantaLiq);
            this.tabPage2.Controls.Add(this.BtnLiquidaciones);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.DtpFLiq2);
            this.tabPage2.Controls.Add(this.DtpFLiq1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1377, 657);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Liquidaciones";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(280, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Liquidaciones por Fecha y Usuario";
            // 
            // DtpFLiq1
            // 
            this.DtpFLiq1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFLiq1.Location = new System.Drawing.Point(145, 67);
            this.DtpFLiq1.Name = "DtpFLiq1";
            this.DtpFLiq1.Size = new System.Drawing.Size(102, 22);
            this.DtpFLiq1.TabIndex = 10;
            // 
            // DtpFLiq2
            // 
            this.DtpFLiq2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFLiq2.Location = new System.Drawing.Point(253, 67);
            this.DtpFLiq2.Name = "DtpFLiq2";
            this.DtpFLiq2.Size = new System.Drawing.Size(112, 22);
            this.DtpFLiq2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha Liquidacion";
            // 
            // BtnLiquidaciones
            // 
            this.BtnLiquidaciones.Location = new System.Drawing.Point(861, 48);
            this.BtnLiquidaciones.Name = "BtnLiquidaciones";
            this.BtnLiquidaciones.Size = new System.Drawing.Size(151, 48);
            this.BtnLiquidaciones.TabIndex = 15;
            this.BtnLiquidaciones.Text = "Generar Informe";
            this.BtnLiquidaciones.UseVisualStyleBackColor = true;
            this.BtnLiquidaciones.Click += new System.EventHandler(this.BtnLiquidaciones_Click);
            // 
            // CbbPlantaLiq
            // 
            this.CbbPlantaLiq.FormattingEnabled = true;
            this.CbbPlantaLiq.Items.AddRange(new object[] {
            "ANEXA",
            "CR",
            "PC",
            "PALIN",
            "TODOS"});
            this.CbbPlantaLiq.Location = new System.Drawing.Point(431, 66);
            this.CbbPlantaLiq.Name = "CbbPlantaLiq";
            this.CbbPlantaLiq.Size = new System.Drawing.Size(121, 24);
            this.CbbPlantaLiq.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Planta";
            // 
            // reportViewer2
            // 
            this.reportViewer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource14.Name = "DataSet1";
            reportDataSource14.Value = this.MA_CXP_CONTRAS_LIQ_CATBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource14);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "SistemaRecibos.Reportes.Report8.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(19, 124);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1342, 512);
            this.reportViewer2.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Inicial";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Final";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(564, 71);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(129, 16);
            this.label20.TabIndex = 21;
            this.label20.Text = "Categoria Liquidado";
            // 
            // CbbCategoria
            // 
            this.CbbCategoria.FormattingEnabled = true;
            this.CbbCategoria.Items.AddRange(new object[] {
            "CONTA",
            "COSTOS",
            "IMPO",
            "PET",
            "TODOS"});
            this.CbbCategoria.Location = new System.Drawing.Point(699, 66);
            this.CbbCategoria.Name = "CbbCategoria";
            this.CbbCategoria.Size = new System.Drawing.Size(98, 24);
            this.CbbCategoria.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.CbbPlanta);
            this.tabPage1.Controls.Add(this.BtnContras1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.DtpFFinal);
            this.tabPage1.Controls.Add(this.DtpFinicial);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1377, 657);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Contraseñas Por Usuario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresos de Contraseñas por Fecha y Usuario";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Inicial";
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
            // BtnContras1
            // 
            this.BtnContras1.Location = new System.Drawing.Point(647, 50);
            this.BtnContras1.Name = "BtnContras1";
            this.BtnContras1.Size = new System.Drawing.Size(144, 30);
            this.BtnContras1.TabIndex = 6;
            this.BtnContras1.Text = "Generar Informe";
            this.BtnContras1.UseVisualStyleBackColor = true;
            this.BtnContras1.Click += new System.EventHandler(this.BtnContras1_Click);
            // 
            // CbbPlanta
            // 
            this.CbbPlanta.FormattingEnabled = true;
            this.CbbPlanta.Items.AddRange(new object[] {
            "ANEXA",
            "CR",
            "PC",
            "PALIN",
            "TODOS"});
            this.CbbPlanta.Location = new System.Drawing.Point(511, 52);
            this.CbbPlanta.Name = "CbbPlanta";
            this.CbbPlanta.Size = new System.Drawing.Size(121, 24);
            this.CbbPlanta.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(458, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Planta";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource15.Name = "DataSet1";
            reportDataSource15.Value = this.mACXPCONTRASBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource15);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaRecibos.Reportes.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 116);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1342, 512);
            this.reportViewer1.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1385, 686);
            this.tabControl1.TabIndex = 6;
            // 
            // FrmReportesCxP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 710);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmReportesCxP";
            this.ShowIcon = false;
            this.Text = "Reportes Contraseñas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReportesCxP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mACXPCONTRASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACXPCONTRASLIQBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACXPCONTRASCONTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MA_CXP_CONTRAS_LIQ_CATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSetCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MA_CXP_CONTRAS_CONTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MA_CXP_CONTRAS_LIQBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mACXPCONTRASLIQCATBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource mACXPCONTRASBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.MA_CXP_CONTRASTableAdapter mA_CXP_CONTRASTableAdapter;
        private System.Windows.Forms.BindingSource MA_CXP_CONTRAS_LIQBindingSource;
        private System.Windows.Forms.BindingSource mACXPCONTRASLIQBindingSource;
        private DataSet1TableAdapters.MA_CXP_CONTRAS_LIQTableAdapter mA_CXP_CONTRAS_LIQTableAdapter;
        private System.Windows.Forms.BindingSource mACXPCONTRASCONTABindingSource;
        private System.Windows.Forms.BindingSource MA_CXP_CONTRAS_CONTABindingSource;
        private DataSet1TableAdapters.MA_CXP_CONTRAS_CONTATableAdapter mA_CXP_CONTRAS_CONTATableAdapter;
        private System.Windows.Forms.BindingSource MA_CXP_CONTRAS_LIQ_CATBindingSource;
        private DateSetCat dateSetCat;
        private System.Windows.Forms.BindingSource mACXPCONTRASLIQCATBindingSource;
        private DateSetCatTableAdapters.MA_CXP_CONTRAS_LIQ_CATTableAdapter mA_CXP_CONTRAS_LIQ_CATTableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CbbPlantaConta;
        private System.Windows.Forms.Button BtnConta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpf2Conta;
        private System.Windows.Forms.DateTimePicker dtpf1Conta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox CbbCategoria;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbbPlantaLiq;
        private System.Windows.Forms.Button BtnLiquidaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DtpFLiq2;
        private System.Windows.Forms.DateTimePicker DtpFLiq1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CbbPlanta;
        private System.Windows.Forms.Button BtnContras1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpFFinal;
        private System.Windows.Forms.DateTimePicker DtpFinicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}