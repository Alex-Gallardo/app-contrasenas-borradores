namespace SistemaRecibos.Reportes
{
    partial class FrmReporteContras
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
            this.mACxPContrasGeneralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new SistemaRecibos.Reportes.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbbDirecciones = new System.Windows.Forms.TextBox();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCuerpo = new System.Windows.Forms.TextBox();
            this.TxtAsunto = new System.Windows.Forms.TextBox();
            this.mA_CxP_Contras_GeneralTableAdapter = new SistemaRecibos.Reportes.DataSet1TableAdapters.MA_CxP_Contras_GeneralTableAdapter();
            this.CbbCopia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mACxPContrasGeneralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mACxPContrasGeneralBindingSource
            // 
            this.mACxPContrasGeneralBindingSource.DataMember = "MA_CxP_Contras_General";
            this.mACxPContrasGeneralBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.EnforceConstraints = false;
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "ContrasGen";
            reportDataSource1.Value = this.mACxPContrasGeneralBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaRecibos.Reportes.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 155);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1489, 623);
            this.reportViewer1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CbbCopia);
            this.groupBox1.Controls.Add(this.CbbDirecciones);
            this.groupBox1.Controls.Add(this.BtnEnviar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtCuerpo);
            this.groupBox1.Controls.Add(this.TxtAsunto);
            this.groupBox1.Location = new System.Drawing.Point(133, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1268, 109);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Envio de Correo";
            // 
            // CbbDirecciones
            // 
            this.CbbDirecciones.Location = new System.Drawing.Point(223, 20);
            this.CbbDirecciones.Name = "CbbDirecciones";
            this.CbbDirecciones.Size = new System.Drawing.Size(352, 22);
            this.CbbDirecciones.TabIndex = 8;
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
            this.label3.Location = new System.Drawing.Point(141, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Asunto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Para:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, -1);
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
            this.TxtAsunto.Location = new System.Drawing.Point(223, 74);
            this.TxtAsunto.Name = "TxtAsunto";
            this.TxtAsunto.Size = new System.Drawing.Size(352, 22);
            this.TxtAsunto.TabIndex = 1;
            // 
            // mA_CxP_Contras_GeneralTableAdapter
            // 
            this.mA_CxP_Contras_GeneralTableAdapter.ClearBeforeFill = true;
            // 
            // CbbCopia
            // 
            this.CbbCopia.Location = new System.Drawing.Point(223, 47);
            this.CbbCopia.Name = "CbbCopia";
            this.CbbCopia.Size = new System.Drawing.Size(352, 22);
            this.CbbCopia.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Copia a:";
            // 
            // FrmReporteContras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 790);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReporteContras";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte Contraseñas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReporteContras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mACxPContrasGeneralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCuerpo;
        private System.Windows.Forms.TextBox TxtAsunto;
        private System.Windows.Forms.BindingSource mACxPContrasGeneralBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.MA_CxP_Contras_GeneralTableAdapter mA_CxP_Contras_GeneralTableAdapter;
        private System.Windows.Forms.TextBox CbbDirecciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CbbCopia;
    }
}