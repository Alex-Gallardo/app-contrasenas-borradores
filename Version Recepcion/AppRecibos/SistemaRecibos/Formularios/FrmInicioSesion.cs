using Recibos.Negocio;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;


namespace SistemaRecibos.Formularios
{
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
        }
        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Tabla = NUsuarios.Login(txtIdUsuario.Text.Trim(), txtClave.Text.Trim());
                if (Tabla.Rows.Count <= 0)
                {
                    MessageBox.Show("El Usuario o la Contraseñas es Incorecta", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Convert.ToString(Tabla.Rows[0][4]) == "ACTIVO")
                    {
                        MessageBox.Show("Usuario No está Activo", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //A.ID_USR, A.NOMBRE, A.ROL, A.DEPARTAMENTO, A.EMAIL,  A.ESTADO
                        FrmPrincipal frm = new FrmPrincipal();
                        frm.IdUsuario = Convert.ToString(Tabla.Rows[0][0]);
                        frm.NombreUsuario = Convert.ToString(Tabla.Rows[0][1]);
                        frm.IdRol = Convert.ToString(Tabla.Rows[0][2]);
                        frm.Depto = Convert.ToString(Tabla.Rows[0][3]);
                        frm.Correo = Convert.ToString(Tabla.Rows[0][4]);
                        frm.Estado = Convert.ToString(Tabla.Rows[0][5]);
                        frm.Planta = Convert.ToString(Tabla.Rows[0][6]);
                        frm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
