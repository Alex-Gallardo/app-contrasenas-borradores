namespace SistemaRecibos.Formularios
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recibosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borradoresNCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cxPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contraseñasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contabilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StBarraInferior = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracionToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.cxPToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(1371, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.administracionToolStripMenuItem.Text = "Administración";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem.Image")));
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recibosToolStripMenuItem,
            this.borradoresNCToolStripMenuItem,
            this.autorizacionesToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.operacionesToolStripMenuItem.Text = "CxC";
            this.operacionesToolStripMenuItem.Click += new System.EventHandler(this.operacionesToolStripMenuItem_Click);
            // 
            // recibosToolStripMenuItem
            // 
            this.recibosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("recibosToolStripMenuItem.Image")));
            this.recibosToolStripMenuItem.Name = "recibosToolStripMenuItem";
            this.recibosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.recibosToolStripMenuItem.Text = "Recibos de Caja";
            this.recibosToolStripMenuItem.Visible = false;
            this.recibosToolStripMenuItem.Click += new System.EventHandler(this.recibosToolStripMenuItem_Click);
            // 
            // borradoresNCToolStripMenuItem
            // 
            this.borradoresNCToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("borradoresNCToolStripMenuItem.Image")));
            this.borradoresNCToolStripMenuItem.Name = "borradoresNCToolStripMenuItem";
            this.borradoresNCToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.borradoresNCToolStripMenuItem.Text = "Borradores NC";
            this.borradoresNCToolStripMenuItem.Click += new System.EventHandler(this.borradoresNCToolStripMenuItem_Click);
            // 
            // autorizacionesToolStripMenuItem
            // 
            this.autorizacionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("autorizacionesToolStripMenuItem.Image")));
            this.autorizacionesToolStripMenuItem.Name = "autorizacionesToolStripMenuItem";
            this.autorizacionesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.autorizacionesToolStripMenuItem.Text = "Autorizaciones";
            this.autorizacionesToolStripMenuItem.Click += new System.EventHandler(this.autorizacionesToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorizadosToolStripMenuItem});
            this.reportesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportesToolStripMenuItem.Image")));
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // autorizadosToolStripMenuItem
            // 
            this.autorizadosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("autorizadosToolStripMenuItem.Image")));
            this.autorizadosToolStripMenuItem.Name = "autorizadosToolStripMenuItem";
            this.autorizadosToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.autorizadosToolStripMenuItem.Text = "Generales";
            this.autorizadosToolStripMenuItem.Click += new System.EventHandler(this.autorizadosToolStripMenuItem_Click);
            // 
            // cxPToolStripMenuItem
            // 
            this.cxPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contraseñasToolStripMenuItem,
            this.contabilidadToolStripMenuItem,
            this.pagosToolStripMenuItem,
            this.reportesToolStripMenuItem1});
            this.cxPToolStripMenuItem.Name = "cxPToolStripMenuItem";
            this.cxPToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.cxPToolStripMenuItem.Text = "CxP";
            // 
            // contraseñasToolStripMenuItem
            // 
            this.contraseñasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contraseñasToolStripMenuItem.Image")));
            this.contraseñasToolStripMenuItem.Name = "contraseñasToolStripMenuItem";
            this.contraseñasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.contraseñasToolStripMenuItem.Text = "Contraseñas";
            this.contraseñasToolStripMenuItem.Click += new System.EventHandler(this.contraseñasToolStripMenuItem_Click);
            // 
            // contabilidadToolStripMenuItem
            // 
            this.contabilidadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contabilidadToolStripMenuItem.Image")));
            this.contabilidadToolStripMenuItem.Name = "contabilidadToolStripMenuItem";
            this.contabilidadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.contabilidadToolStripMenuItem.Text = "Contabilidad";
            this.contabilidadToolStripMenuItem.Click += new System.EventHandler(this.contabilidadToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem1
            // 
            this.reportesToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("reportesToolStripMenuItem1.Image")));
            this.reportesToolStripMenuItem1.Name = "reportesToolStripMenuItem1";
            this.reportesToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.reportesToolStripMenuItem1.Text = "Reportes";
            this.reportesToolStripMenuItem1.Click += new System.EventHandler(this.reportesToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StBarraInferior});
            this.statusStrip.Location = new System.Drawing.Point(0, 648);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.Size = new System.Drawing.Size(1371, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // StBarraInferior
            // 
            this.StBarraInferior.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StBarraInferior.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StBarraInferior.Name = "StBarraInferior";
            this.StBarraInferior.Size = new System.Drawing.Size(154, 20);
            this.StBarraInferior.Text = "Desarrollado por K66";
            this.StBarraInferior.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pagosToolStripMenuItem.Image")));
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pagosToolStripMenuItem.Text = "Pagos";
            this.pagosToolStripMenuItem.Click += new System.EventHandler(this.pagosToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1371, 674);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Aplicaciones K66";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recibosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borradoresNCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel StBarraInferior;
        private System.Windows.Forms.ToolStripMenuItem autorizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorizadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cxPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contraseñasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contabilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
    }
}



