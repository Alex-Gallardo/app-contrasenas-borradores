namespace SistemaRecibos
{
    partial class FrmContrasPagos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIdContraBuscar = new System.Windows.Forms.TextBox();
            this.BtnBuscarContra = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DtpConta = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.DtpFContra = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.CbbEstados = new System.Windows.Forms.ComboBox();
            this.txtcomentarios = new System.Windows.Forms.TextBox();
            this.txtproveedor = new System.Windows.Forms.TextBox();
            this.txttipocontra = new System.Windows.Forms.TextBox();
            this.txtidcontra = new System.Windows.Forms.TextBox();
            this.DgvListaContrasPagos = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaContrasPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(25, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1398, 750);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TxtIdContraBuscar);
            this.tabPage1.Controls.Add(this.BtnBuscarContra);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.DgvListaContrasPagos);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1390, 721);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Revision";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "# Contraseña";
            // 
            // TxtIdContraBuscar
            // 
            this.TxtIdContraBuscar.Location = new System.Drawing.Point(173, 49);
            this.TxtIdContraBuscar.Name = "TxtIdContraBuscar";
            this.TxtIdContraBuscar.Size = new System.Drawing.Size(172, 22);
            this.TxtIdContraBuscar.TabIndex = 12;
            // 
            // BtnBuscarContra
            // 
            this.BtnBuscarContra.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnBuscarContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarContra.Location = new System.Drawing.Point(366, 44);
            this.BtnBuscarContra.Name = "BtnBuscarContra";
            this.BtnBuscarContra.Size = new System.Drawing.Size(112, 32);
            this.BtnBuscarContra.TabIndex = 11;
            this.BtnBuscarContra.Text = "Buscar";
            this.BtnBuscarContra.UseVisualStyleBackColor = false;
            this.BtnBuscarContra.Click += new System.EventHandler(this.BtnBuscarContra_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtEmpresa);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.DtpConta);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DtpFContra);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnGuardar);
            this.groupBox1.Controls.Add(this.CbbEstados);
            this.groupBox1.Controls.Add(this.txtcomentarios);
            this.groupBox1.Controls.Add(this.txtproveedor);
            this.groupBox1.Controls.Add(this.txttipocontra);
            this.groupBox1.Controls.Add(this.txtidcontra);
            this.groupBox1.Location = new System.Drawing.Point(74, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1241, 226);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(391, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 57;
            this.label9.Text = "Empresa";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Enabled = false;
            this.txtEmpresa.Location = new System.Drawing.Point(388, 47);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(135, 22);
            this.txtEmpresa.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 58;
            this.label8.Text = "Fecha Rech.:";
            // 
            // DtpConta
            // 
            this.DtpConta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpConta.Location = new System.Drawing.Point(118, 112);
            this.DtpConta.Name = "DtpConta";
            this.DtpConta.Size = new System.Drawing.Size(109, 22);
            this.DtpConta.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(705, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 16);
            this.label7.TabIndex = 56;
            this.label7.Text = "Fecha Contraseña";
            // 
            // DtpFContra
            // 
            this.DtpFContra.Enabled = false;
            this.DtpFContra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFContra.Location = new System.Drawing.Point(710, 45);
            this.DtpFContra.Name = "DtpFContra";
            this.DtpFContra.Size = new System.Drawing.Size(109, 22);
            this.DtpFContra.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Comentario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Proveedor";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(846, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tipo Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "# Contraseña";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(846, 78);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(112, 32);
            this.BtnGuardar.TabIndex = 10;
            this.BtnGuardar.Text = "Aplicar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // CbbEstados
            // 
            this.CbbEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbEstados.FormattingEnabled = true;
            this.CbbEstados.Items.AddRange(new object[] {
            "RECHAZADO"});
            this.CbbEstados.Location = new System.Drawing.Point(699, 111);
            this.CbbEstados.Name = "CbbEstados";
            this.CbbEstados.Size = new System.Drawing.Size(120, 24);
            this.CbbEstados.TabIndex = 9;
            // 
            // txtcomentarios
            // 
            this.txtcomentarios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcomentarios.Location = new System.Drawing.Point(118, 143);
            this.txtcomentarios.Multiline = true;
            this.txtcomentarios.Name = "txtcomentarios";
            this.txtcomentarios.Size = new System.Drawing.Size(701, 63);
            this.txtcomentarios.TabIndex = 3;
            // 
            // txtproveedor
            // 
            this.txtproveedor.Enabled = false;
            this.txtproveedor.Location = new System.Drawing.Point(118, 78);
            this.txtproveedor.Name = "txtproveedor";
            this.txtproveedor.Size = new System.Drawing.Size(701, 22);
            this.txtproveedor.TabIndex = 2;
            // 
            // txttipocontra
            // 
            this.txttipocontra.Enabled = false;
            this.txttipocontra.Location = new System.Drawing.Point(234, 47);
            this.txttipocontra.Name = "txttipocontra";
            this.txttipocontra.Size = new System.Drawing.Size(135, 22);
            this.txttipocontra.TabIndex = 1;
            // 
            // txtidcontra
            // 
            this.txtidcontra.Enabled = false;
            this.txtidcontra.Location = new System.Drawing.Point(118, 47);
            this.txtidcontra.Name = "txtidcontra";
            this.txtidcontra.Size = new System.Drawing.Size(101, 22);
            this.txtidcontra.TabIndex = 0;
            // 
            // DgvListaContrasPagos
            // 
            this.DgvListaContrasPagos.AllowUserToAddRows = false;
            this.DgvListaContrasPagos.AllowUserToDeleteRows = false;
            this.DgvListaContrasPagos.AllowUserToOrderColumns = true;
            this.DgvListaContrasPagos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListaContrasPagos.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListaContrasPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.DgvListaContrasPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListaContrasPagos.DefaultCellStyle = dataGridViewCellStyle17;
            this.DgvListaContrasPagos.GridColor = System.Drawing.Color.CadetBlue;
            this.DgvListaContrasPagos.Location = new System.Drawing.Point(74, 98);
            this.DgvListaContrasPagos.Name = "DgvListaContrasPagos";
            this.DgvListaContrasPagos.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListaContrasPagos.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.DgvListaContrasPagos.RowHeadersVisible = false;
            this.DgvListaContrasPagos.RowHeadersWidth = 51;
            this.DgvListaContrasPagos.RowTemplate.Height = 24;
            this.DgvListaContrasPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaContrasPagos.Size = new System.Drawing.Size(1241, 180);
            this.DgvListaContrasPagos.TabIndex = 5;
            this.DgvListaContrasPagos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaContrasPagos_CellDoubleClick);
            // 
            // FrmContrasPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 783);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmContrasPagos";
            this.ShowIcon = false;
            this.Text = "Contraseñas - Pagos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmContrasPagos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaContrasPagos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DtpConta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DtpFContra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.ComboBox CbbEstados;
        private System.Windows.Forms.TextBox txtcomentarios;
        private System.Windows.Forms.TextBox txtproveedor;
        private System.Windows.Forms.TextBox txttipocontra;
        private System.Windows.Forms.TextBox txtidcontra;
        private System.Windows.Forms.DataGridView DgvListaContrasPagos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIdContraBuscar;
        private System.Windows.Forms.Button BtnBuscarContra;
    }
}