namespace SistemaRecibos.Reportes
{
    partial class FrmReporteBorr
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCuerpo = new System.Windows.Forms.TextBox();
            this.TxtAsunto = new System.Windows.Forms.TextBox();
            this.CbbDirecciones = new System.Windows.Forms.ComboBox();
            this.mABorradorNCGenBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.mABorradorNCGenBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mABorradorNCGenBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mABorradorNCGenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new SistemaRecibos.Reportes.DataSet1();
            this.mA_BorradorNCGenTableAdapter = new SistemaRecibos.Reportes.DataSet1TableAdapters.MA_BorradorNCGenTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mABorradorNCGenBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mABorradorNCGenBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mABorradorNCGenBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mABorradorNCGenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BtnEnviar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtCuerpo);
            this.groupBox1.Controls.Add(this.TxtAsunto);
            this.groupBox1.Controls.Add(this.CbbDirecciones);
            this.groupBox1.Location = new System.Drawing.Point(68, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1268, 109);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Envio de Correo";
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnviar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEnviar.Location = new System.Drawing.Point(992, 51);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(152, 36);
            this.BtnEnviar.TabIndex = 7;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = false;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mensaje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Asunto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Para:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "* Agrega otra cuenta utilizando (,) coma.";
            // 
            // TxtCuerpo
            // 
            this.TxtCuerpo.Enabled = false;
            this.TxtCuerpo.Location = new System.Drawing.Point(597, 40);
            this.TxtCuerpo.Multiline = true;
            this.TxtCuerpo.Name = "TxtCuerpo";
            this.TxtCuerpo.Size = new System.Drawing.Size(335, 53);
            this.TxtCuerpo.TabIndex = 2;
            this.TxtCuerpo.Text = "****IMPORTANTE**** Este correo es informativo, favor no responder a esta direcció" +
    "n de correo, ya que no se encuentra habilitada para recibir mensajes.";
            // 
            // TxtAsunto
            // 
            this.TxtAsunto.Enabled = false;
            this.TxtAsunto.Location = new System.Drawing.Point(223, 71);
            this.TxtAsunto.Name = "TxtAsunto";
            this.TxtAsunto.Size = new System.Drawing.Size(352, 22);
            this.TxtAsunto.TabIndex = 1;
            // 
            // CbbDirecciones
            // 
            this.CbbDirecciones.FormattingEnabled = true;
            this.CbbDirecciones.Items.AddRange(new object[] {
            "creditos1@k-66.net , creditos3@k-66.net , creditos2@k-66.net , creditos4@k-66.net" +
                "",
            "creditos1@k-66.net",
            "creditos2@k-66.net",
            "creditos3@k-66.net",
            "creditos4@k-66.net"});
            this.CbbDirecciones.Location = new System.Drawing.Point(223, 40);
            this.CbbDirecciones.Name = "CbbDirecciones";
            this.CbbDirecciones.Size = new System.Drawing.Size(352, 24);
            this.CbbDirecciones.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.mABorradorNCGenBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaRecibos.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 144);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1359, 548);
            this.reportViewer1.TabIndex = 2;
            // 
            // mABorradorNCGenBindingSource
            // 
            this.mABorradorNCGenBindingSource.DataMember = "MA_BorradorNCGen";
            this.mABorradorNCGenBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.EnforceConstraints = false;
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mA_BorradorNCGenTableAdapter
            // 
            this.mA_BorradorNCGenTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteBorr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 704);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmReporteBorr";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Borrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReporteBorr_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mABorradorNCGenBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mABorradorNCGenBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mABorradorNCGenBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mABorradorNCGenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtAsunto;
        private System.Windows.Forms.ComboBox CbbDirecciones;
        private System.Windows.Forms.TextBox TxtCuerpo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.BindingSource mABorradorNCGenBindingSource2;
        private System.Windows.Forms.BindingSource mABorradorNCGenBindingSource3;
        private System.Windows.Forms.BindingSource mABorradorNCGenBindingSource4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource mABorradorNCGenBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.MA_BorradorNCGenTableAdapter mA_BorradorNCGenTableAdapter;
    }
}