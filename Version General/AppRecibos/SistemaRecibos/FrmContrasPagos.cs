using Recibos.Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaRecibos
{
    public partial class FrmContrasPagos : Form
    {
        public string IdUsuario;
        public string Rol;
        public string Nombre;
        public string Depto;
        public string Correo;
        public string Estado;
        public string Planta;
        public FrmContrasPagos()
        {
            InitializeComponent();
        }
        private void ListarAct()
        {
            try
            {
                DgvListaContrasPagos.DataSource = NContras.Listar("L", "TODOS");
                this.Formato();              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Formato()
        {
            DgvListaContrasPagos.Columns[0].Width = 80;
            DgvListaContrasPagos.Columns[0].HeaderText = "Empresa";
            DgvListaContrasPagos.Columns[1].Width = 80;
            DgvListaContrasPagos.Columns[1].HeaderText = "Tipo";
            DgvListaContrasPagos.Columns[2].Width = 80;
            DgvListaContrasPagos.Columns[2].HeaderText = "Fecha";
            DgvListaContrasPagos.Columns[3].Width = 100;
            DgvListaContrasPagos.Columns[3].HeaderText = "#Contraseña";
            DgvListaContrasPagos.Columns[4].Width = 70;
            DgvListaContrasPagos.Columns[4].HeaderText = "Codigo";
            DgvListaContrasPagos.Columns[5].Width = 200;
            DgvListaContrasPagos.Columns[5].HeaderText = "Nombre";
            DgvListaContrasPagos.Columns[6].Width = 90;
            DgvListaContrasPagos.Columns[6].HeaderText = "NIT";
            DgvListaContrasPagos.Columns[7].Width = 90;
            DgvListaContrasPagos.Columns[7].HeaderText = "Moneda";
            DgvListaContrasPagos.Columns[8].Width = 90;
            DgvListaContrasPagos.Columns[8].HeaderText = "Total";
            DgvListaContrasPagos.Columns[9].Width = 100;
            DgvListaContrasPagos.Columns[9].HeaderText = "Registró";
            DgvListaContrasPagos.Columns[10].Width = 100;
            DgvListaContrasPagos.Columns[10].HeaderText = "Estado";
            DgvListaContrasPagos.Columns[11].Width = 100;
            DgvListaContrasPagos.Columns[11].HeaderText = "Planta";
            DgvListaContrasPagos.Columns[12].Width = 100;
            DgvListaContrasPagos.Columns[12].HeaderText = "Usr Conta";
            DgvListaContrasPagos.Columns[13].Width = 100;
            DgvListaContrasPagos.Columns[13].HeaderText = "F. Contabilizacion";
            DgvListaContrasPagos.Columns[14].Width = 200;
            DgvListaContrasPagos.Columns[14].HeaderText = "Observaciones";
        }
        private void CargarEstado()
        {
            try
            {
                CbbEstados.DataSource = NContras.ListarEstados("CONTABILIDAD");
                CbbEstados.DisplayMember = "DESCRIPCION";
                CbbEstados.ValueMember = "ESTADO";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Contraseñas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Contraseñas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FrmContrasPagos_Load(object sender, EventArgs e)
        {
            CbbEstados.SelectedIndex = -1;
            groupBox1.Visible = false;
        }
        private void BtnBuscarContra_Click(object sender, EventArgs e)
        {
            try
            {
                DgvListaContrasPagos.DataSource = NContras.ListarContra(TxtIdContraBuscar.Text);
                this.Formato();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void DgvListaContrasPagos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtidcontra.Text = Convert.ToString(DgvListaContrasPagos.CurrentRow.Cells["CONTRASEÑA"].Value);
                txtproveedor.Text = Convert.ToString(DgvListaContrasPagos.CurrentRow.Cells["NOMBRE"].Value);
                txtEmpresa.Text = Convert.ToString(DgvListaContrasPagos.CurrentRow.Cells["EMPRESA"].Value);
                DtpFContra.Value = Convert.ToDateTime(DgvListaContrasPagos.CurrentRow.Cells["FECHA"].Value);
                txttipocontra.Text = Convert.ToString(DgvListaContrasPagos.CurrentRow.Cells["TIPO"].Value);
                groupBox1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la Celda #Contraseña." + "| Error:" + ex.Message);
            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Rpta = "";
            DialogResult opcion;
            opcion = MessageBox.Show("Esta Seguro de continuar con la operacion?", "Contraseñas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opcion == DialogResult.OK)
            {
                if(txtcomentarios.Text == string.Empty)
                {
                    this.MensajeOk("Falta ingresar Comentarios al Rechazo");
                    txtcomentarios.Clear();
                    txtEmpresa.Clear();
                    txtidcontra.Clear();
                    DtpConta.ResetText();
                    DtpFContra.ResetText();
                    CbbEstados.SelectedIndex = -1;
                    groupBox1.Visible = false;
                    TxtIdContraBuscar.Clear();

                    DataTable dt = (DataTable)DgvListaContrasPagos.DataSource;
                    dt.Clear();
                    DgvListaContrasPagos.Refresh();
                    DgvListaContrasPagos.DataSource = "";
                }
                else { 

                        Rpta = NContras.LiqPagos(txtEmpresa.Text, txtidcontra.Text, IdUsuario, txtcomentarios.Text, DtpConta.Value, "R");
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se ha rechazado el documento");
                            txtcomentarios.Clear();
                            txtEmpresa.Clear();
                            txtidcontra.Clear();
                            DtpConta.ResetText();
                            DtpFContra.ResetText();
                            CbbEstados.SelectedIndex = -1;
                            groupBox1.Visible = false;
                            TxtIdContraBuscar.Clear();

                            DataTable dt = (DataTable)DgvListaContrasPagos.DataSource;
                            dt.Clear();
                            DgvListaContrasPagos.Refresh();
                            DgvListaContrasPagos.DataSource = "";
                        }
                        else
                        {
                            this.MensajeError(Rpta);
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtcomentarios.Clear();
            txtEmpresa.Clear();
            txtidcontra.Clear();
            DtpConta.ResetText();
            DtpFContra.ResetText();
            CbbEstados.SelectedIndex = -1;
            groupBox1.Visible = false;
            TxtIdContraBuscar.Clear();
            DataTable dt = (DataTable)DgvListaContrasPagos.DataSource;
            dt.Clear();
            DgvListaContrasPagos.Refresh();
            DgvListaContrasPagos.DataSource = "";
        }
    }
}
