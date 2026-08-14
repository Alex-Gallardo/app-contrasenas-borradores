using Recibos.Negocio;
using System;
using System.Windows.Forms;

namespace SistemaRecibos.Formularios
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            try
            {
                dgvListUsuarios.DataSource = NUsuarios.Listar();
                this.Formato();
                label1total.Text = "Total Registros = " + Convert.ToString(dgvListUsuarios.Rows.Count);
                this.Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Formato()
        {
            dgvListUsuarios.Columns[0].Width = 100;
            dgvListUsuarios.Columns[0].HeaderText = "ID";
            dgvListUsuarios.Columns[1].Width = 100;
            dgvListUsuarios.Columns[1].HeaderText = "Nombre";
            dgvListUsuarios.Columns[2].Width = 100;
            dgvListUsuarios.Columns[2].HeaderText = "Depto";
            dgvListUsuarios.Columns[3].Width = 100;
            dgvListUsuarios.Columns[3].HeaderText = "Rol";
            dgvListUsuarios.Columns[4].Width = 100;
            dgvListUsuarios.Columns[4].HeaderText = "Email";
            dgvListUsuarios.Columns[5].Width = 80;
            dgvListUsuarios.Columns[5].HeaderText = "Status";
            dgvListUsuarios.Columns[6].Width = 80;
            dgvListUsuarios.Columns[6].HeaderText = "Planta";
        }
        private void Buscar()
        {
            try
            {
                dgvListUsuarios.DataSource = NUsuarios.Buscar(txtBuscar.Text);
                this.Formato();
                label1total.Text = "Total Registros = " + Convert.ToString(dgvListUsuarios.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Limpiar()
        {
            txtBuscar.Clear();
            txtIdUsuario.Clear();
            cboPlanta.Text = "";
            txtNombre.Clear();
            txtEmail.Clear();
            txtClave.Clear();
            cboRol.Text = "";
            btnInsertar.Enabled = true;
            btnInsertar.Visible = true;
            errorIcono.Clear();
            btnActualizar.Visible = false;
            dgvListUsuarios.Columns[0].Visible = false;
            btnEliminar.Visible = false;
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Rutas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtIdUsuario.Text == string.Empty || txtNombre.Text == string.Empty || txtClave.Text == string.Empty || txtEmail.Text == string.Empty || cboPlanta.Text == string.Empty)
                {
                    this.MensajeError("Faltan Ingresar Datos, Seran Remarcados.");
                    errorIcono.SetError(txtIdUsuario, "Ingrese Usuario!");
                    errorIcono.SetError(txtNombre, "Ingrese Nombre!");
                    errorIcono.SetError(txtClave, "Ingrese Clave!");
                    errorIcono.SetError(txtEmail, "Ingrese Email!");
                    errorIcono.SetError(cboPlanta, "Ingrese Departamento!");
                }
                else
                {
                    Rpta = NUsuarios.Insertar(txtIdUsuario.Text, txtNombre.Text.Trim(), txtClave.Text.Trim(), cboPlanta.Text.Trim(), cboRol.Text.Trim(), txtEmail.Text.Trim(), CbbPlanta.Text);
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se Inserto de Forma Correcta el Registro");
                        this.Listar();
                        Limpiar();
                        TabGeneral.SelectedIndex = 0;
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void dgvListUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                btnActualizar.Visible = true;
                btnInsertar.Visible = false;
                txtIdUsuario.Text = Convert.ToString(dgvListUsuarios.CurrentRow.Cells["ID"].Value);
                cboRol.Text = Convert.ToString(dgvListUsuarios.CurrentRow.Cells["Rol"].Value);
                txtNombre.Text = Convert.ToString(dgvListUsuarios.CurrentRow.Cells["Nombre"].Value);
                cboPlanta.Text = Convert.ToString(dgvListUsuarios.CurrentRow.Cells["Depto"].Value);
                txtEmail.Text = Convert.ToString(dgvListUsuarios.CurrentRow.Cells["Email"].Value);
                //this.EmailAnt = Convert.ToString(dgvListUsuarios.CurrentRow.Cells["EMAIL"].Value);
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la Celda Nombre." + "| Error:" + ex.Message);
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtIdUsuario.Text == string.Empty || txtNombre.Text == string.Empty || txtEmail.Text == string.Empty || cboPlanta.Text == string.Empty)
                {
                    this.MensajeError("Faltan Ingresar Datos, Seran Remarcados.");
                    errorIcono.SetError(txtIdUsuario, "Ingrese Usuario!");
                    errorIcono.SetError(txtNombre, "Ingrese Nombre!");
                    errorIcono.SetError(txtClave, "Ingrese Clave!");
                    errorIcono.SetError(txtEmail, "Ingrese Email!");
                    errorIcono.SetError(cboPlanta, "Ingrese Departamento");
                }
                else
                {
                    Rpta = NUsuarios.Actualizar(txtIdUsuario.Text, txtNombre.Text.Trim(), cboRol.Text.Trim(), cboPlanta.Text.Trim(), txtEmail.Text.Trim(), txtClave.Text.Trim(), CbbPlanta.Text);
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se Actualizo de Forma Correcta el Registro");
                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Listar();
            TabGeneral.SelectedIndex = 0;
        }
    }

}
