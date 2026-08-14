using Recibos.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SistemaRecibos.Formularios
{
    public partial class FrmContrasConta : Form
    {
        public string IdUsuario;
        public string Rol;
        public string Nombre;
        public string Depto;
        public string Correo;
        public string Estado;
        public string Planta;
        public FrmContrasConta()
        {
            InitializeComponent();
        }
        private void ListarAct()
        {
            try
            {
                DgvListaContrasConta.DataSource = NContras.Listar("L", "TODOS");
                this.Formato();

                label1total.Text = "Total Registros = " + Convert.ToString(DgvListaContrasConta.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Formato()
        {
            DgvListaContrasConta.Columns[0].Width = 80;
            DgvListaContrasConta.Columns[0].HeaderText = "Empresa";
            DgvListaContrasConta.Columns[1].Width = 80;
            DgvListaContrasConta.Columns[1].HeaderText = "Fecha";
            DgvListaContrasConta.Columns[2].Width = 100;
            DgvListaContrasConta.Columns[2].HeaderText = "#Contraseña";
            DgvListaContrasConta.Columns[3].Width = 70;
            DgvListaContrasConta.Columns[3].HeaderText = "Codigo";
            DgvListaContrasConta.Columns[4].Width = 200;
            DgvListaContrasConta.Columns[4].HeaderText = "Nombre";
            DgvListaContrasConta.Columns[5].Width = 90;
            DgvListaContrasConta.Columns[5].HeaderText = "NIT";
            DgvListaContrasConta.Columns[6].Width = 90;
            DgvListaContrasConta.Columns[6].HeaderText = "Moneda";
            DgvListaContrasConta.Columns[7].Width = 90;
            DgvListaContrasConta.Columns[7].HeaderText = "Total";
            DgvListaContrasConta.Columns[8].Width = 100;
            DgvListaContrasConta.Columns[8].HeaderText = "Registró";
            DgvListaContrasConta.Columns[9].Width = 100;
            DgvListaContrasConta.Columns[9].HeaderText = "Estado";
            DgvListaContrasConta.Columns[10].Width = 100;
            DgvListaContrasConta.Columns[10].HeaderText = "Planta";
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
        private void FrmContrasConta_Load(object sender, EventArgs e)
        {
            ListarAct();
            CargarEstado();
            CbbEstados.SelectedIndex = -1;
            txtcomentarios.Visible = false;
            label6.Visible = false;
            groupBox1.Visible = false; 
        }
        private void DgvListaContrasConta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtidcontra.Text = Convert.ToString(DgvListaContrasConta.CurrentRow.Cells["CONTRASEÑA"].Value);
                txtproveedor.Text = Convert.ToString(DgvListaContrasConta.CurrentRow.Cells["NOMBRE"].Value);
                txtEmpresa.Text = Convert.ToString(DgvListaContrasConta.CurrentRow.Cells["EMPRESA"].Value);
                DtpFContra.Value = Convert.ToDateTime(DgvListaContrasConta.CurrentRow.Cells["FECHA"].Value);
                groupBox1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la Celda #Contraseña." + "| Error:" + ex.Message);
            }
        }
        private void CbbEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbbEstados.Text.ToString() == "RECHAZADO") 
            { 
                txtcomentarios.Visible = true;
                label6.Visible = true;
               CbbEstados.SelectedValue.ToString();
            }
            else
            {
                txtcomentarios.Visible = false;
                label6.Visible = false;
                txtcomentarios.Clear();
              //  txttipocontra.Text = CbbEstados.SelectedValue.ToString();
            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Rpta = "";
            DialogResult opcion;
            opcion = MessageBox.Show("Esta Seguro de continuar con la operacion?", "Contraseñas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opcion == DialogResult.OK)
            {
                Rpta = NContras.LiqConta(txtEmpresa.Text, txtidcontra.Text, IdUsuario, txtcomentarios.Text,DtpConta.Value, CbbEstados.SelectedValue.ToString());
                if (Rpta.Equals("OK"))
                {
                    this.MensajeOk("Se ha Liquidado el documento");
                    txtcomentarios.Clear();
                    txtEmpresa.Clear();
                    txtidcontra.Clear();
                    DtpConta.ResetText();
                    DtpFContra.ResetText();
                    CbbEstados.SelectedIndex = -1;
                    groupBox1.Visible = false;
                    
                    ListarAct();
                }
                else
                {
                    this.MensajeError(Rpta);
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
        }
    }
}
