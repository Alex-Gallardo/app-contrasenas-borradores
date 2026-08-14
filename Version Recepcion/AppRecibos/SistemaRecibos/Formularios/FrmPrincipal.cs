using SistemaRecibos.Reportes;
using System;
using System.Windows.Forms;

namespace SistemaRecibos.Formularios
{
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;
        public string IdUsuario;
        public string IdRol;
        public string NombreUsuario;
        public string Depto;
        public string Correo;
        public string Estado;
        public string Planta;

        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            StBarraInferior.Text = "K-66 | Usuario: " + this.NombreUsuario;

            if (Depto == "RECEPCION"|| Depto == "CONTABILIDAD" || Depto =="PAGOS")
            {
                cxPToolStripMenuItem.Visible = true;
                operacionesToolStripMenuItem.Visible = false;
                administracionToolStripMenuItem.Visible = false;
            }
            if (Depto == "SISTEMAS" | Depto == "GERENCIA")
            {
                administracionToolStripMenuItem.Visible = true;
                cxPToolStripMenuItem.Visible = true;
                operacionesToolStripMenuItem.Visible = true;
                //recibosToolStripMenuItem.Visible = true; //Agregar nuevo apartado de recibos
            }          
            else
            {
                administracionToolStripMenuItem.Visible = false;
            }
            if (Depto == "SECRETARIAS" | Depto == "CREDITOS" | Depto == "AGENTE")
            {
                cxPToolStripMenuItem.Visible = false;
                operacionesToolStripMenuItem.Visible = true;
                administracionToolStripMenuItem.Visible = false;
                //recibosToolStripMenuItem.Enabled = true; //Agregar nuevo apartado de recibos
            }
        }
        private void recibosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRecibos frm = new FrmRecibos();
            frm.MdiParent = this;
            frm.IdUsuario = IdUsuario;
            frm.Depto = Depto;
            frm.Nombre = NombreUsuario;
            frm.Rol = IdRol;
            frm.Show();
        }
        private void borradoresNCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBorradores frm = new FrmBorradores();
            frm.MdiParent = this;
            frm.IdUsuario = IdUsuario;
            frm.Depto = Depto;
            frm.Nombre = NombreUsuario;
            frm.Rol = IdRol;
            frm.Show();
        }
        private void autorizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Depto == "SISTEMAS" || Depto == "GERENCIA")
            {
                FrmAutorizaciones frm = new FrmAutorizaciones();
                frm.MdiParent = this;
                frm.IdUsuario = IdUsuario;
                frm.Depto = Depto;
                frm.Nombre = NombreUsuario;
                frm.Rol = IdRol;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Su Usuario No tiene permisos para este modulo");
            }
        }
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Depto != "SISTEMAS")
            {
                MessageBox.Show("Su Usuario No tiene permisos para este modulo");
            }
            else
            {
                FrmUsuarios frm = new FrmUsuarios();
                frm.MdiParent = this;
                frm.Show();
            }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea Salir del Sistema?", "Sistema de Recibos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcion == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void autorizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Depto != "AGENTE" || Depto != "SECRETARIAS")
            {
                FrmReportesGen frm = new FrmReportesGen();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Su Usuario No tiene permisos para este modulo");
            }
        }
        private void contraseñasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Depto == "SISTEMAS" || Depto == "GERENCIA" || Depto == "ADMINISTRACION" || Depto == "RECEPCION")
            {
                FrmContras frm = new FrmContras();
                frm.MdiParent = this;
                frm.IdUsuario = IdUsuario;
                frm.Planta = Planta;
                frm.Nombre = NombreUsuario;
                frm.Rol = IdRol;
                frm.Depto = Depto;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Su Usuario No tiene permisos para este modulo");
            }
        }
        private void operacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void reportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Depto == "SISTEMAS" || Depto == "GERENCIA" || Depto == "ADMINISTRACION" || Depto == "RECEPCION"|| Depto == "CONTABILIDAD" || Depto == "PAGOS")
            {
                FrmReportesCxP frm = new FrmReportesCxP();
                frm.MdiParent = this;
                frm.IdUsuario = IdUsuario;
                frm.Planta = Planta;
                frm.Nombre = NombreUsuario;
                frm.Rol = IdRol;
                frm.Depto = Depto;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Su Usuario No tiene permisos para este modulo");
            }
        }
        private void contabilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Depto == "SISTEMAS" || Depto == "GERENCIA" || Depto == "ADMINISTRACION" || Depto == "CONTABILIDAD")
            {
                FrmContrasConta frm = new FrmContrasConta();
                frm.MdiParent = this;
                frm.IdUsuario = IdUsuario;
                frm.Planta = Planta;
                frm.Nombre = NombreUsuario;
                frm.Rol = IdRol;
                frm.Depto = Depto;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Su Usuario No tiene permisos para este modulo");
            }
        }
        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Depto == "SISTEMAS" || Depto == "GERENCIA" || Depto == "ADMINISTRACION" || Depto == "PAGOS")
            {
                FrmContrasPagos frm = new FrmContrasPagos();
                frm.MdiParent = this;
                frm.IdUsuario = IdUsuario;
                frm.Planta = Planta;
                frm.Nombre = NombreUsuario;
                frm.Rol = IdRol;
                frm.Depto = Depto;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Su Usuario No tiene permisos para este modulo");
            }
        }
    }
}
