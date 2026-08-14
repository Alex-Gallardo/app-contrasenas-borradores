using Sap.Data.Hana;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaRecibos.Formularios
{
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }
        private void ProveedorSap(string empresa)
        {
            HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
            conn.Open();
            string query = string.Empty;

            if (empresa == "GRACO")
            {
                query = "SELECT *  FROM SBO_GRACO.CXP_PROVEEDORES";
            }
            else if (empresa == "FAES")
            {
                query = "SELECT *  FROM SBOESCOCESA.CXP_PROVEEDORES";
            }
            else if (empresa == "BOLIK")
            {
                query = "SELECT *  FROM SBOBOLIK.CXP_PROVEEDORES";
            }
            HanaDataAdapter da = new HanaDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvListProveedores.DataSource = dt;
            this.Formato();
            conn.Close();
        }
        private void Listar()
        {
            string empresa = Variables.Empresa;
            try
            {
                ProveedorSap(empresa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Formato()
        {
            dgvListProveedores.Columns[0].Visible = true;
            dgvListProveedores.Columns[0].Width = 80;
            dgvListProveedores.Columns[0].HeaderText = "Empresa";
            dgvListProveedores.Columns[1].Visible = true;
            dgvListProveedores.Columns[1].Width = 100;
            dgvListProveedores.Columns[1].HeaderText = "Codigo";
            dgvListProveedores.Columns[2].Width = 200;
            dgvListProveedores.Columns[2].HeaderText = "Proveedor";
            dgvListProveedores.Columns[3].Width = 250;
            dgvListProveedores.Columns[3].HeaderText = "Direccion";
            dgvListProveedores.Columns[4].Width = 100;
            dgvListProveedores.Columns[4].HeaderText = "NIT";
            dgvListProveedores.Columns[5].Width = 100;
            dgvListProveedores.Columns[5].HeaderText = "Moneda";
            dgvListProveedores.Columns[6].Width = 100;
            dgvListProveedores.Columns[6].HeaderText = "Condiciones";
            dgvListProveedores.Columns[7].Width = 100;
            dgvListProveedores.Columns[7].HeaderText = "Correo";   //Agregamos la nueva casilla de la tabla
        } //Cambios Aqui
        private void Buscar()
        {
            try
            {
                if (Variables.Empresa == "GRACO")
                {
                    HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
                    conn.Open();
                    string query = "";

                    query = "SELECT * FROM SBO_GRACO.CXP_PROVEEDORES WHERE \"CardName\" LIKE ('%" + txtBuscar.Text + "%')";

                    HanaDataAdapter da = new HanaDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvListProveedores.DataSource = dt;
                    this.Formato();
                    conn.Close();
                }
                else if (Variables.Empresa == "FAES")
                {
                    HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
                    conn.Open();
                    string query = "";
                    query = "SELECT * FROM SBOESCOCESA.CXP_PROVEEDORES WHERE \"CardName\" LIKE ('%" + txtBuscar.Text + "%')";
                    HanaDataAdapter da = new HanaDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvListProveedores.DataSource = dt;
                    this.Formato();
                    conn.Close();
                }
                else if (Variables.Empresa == "BOLIK")
                {
                    HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
                    conn.Open();
                    string query = "";
                    query = "SELECT * FROM SBOBOLIK.CXP_PROVEEDORES WHERE \"CardName\" LIKE ('%" + txtBuscar.Text + "%')";
                    HanaDataAdapter da = new HanaDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvListProveedores.DataSource = dt;
                    this.Formato();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void dgvListProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.CodProveedor = Convert.ToString(dgvListProveedores.CurrentRow.Cells["CardCode"].Value);
            Variables.NombreProveedor = Convert.ToString(dgvListProveedores.CurrentRow.Cells["CardName"].Value);
            Variables.Direccion = Convert.ToString(dgvListProveedores.CurrentRow.Cells["Address"].Value);
            Variables.Moneda = Convert.ToString(dgvListProveedores.CurrentRow.Cells["Currency"].Value);
            Variables.Condiciones = Convert.ToString(dgvListProveedores.CurrentRow.Cells["Condiciones"].Value);
            Variables.NIT = Convert.ToString(dgvListProveedores.CurrentRow.Cells["LicTradNum"].Value);
            Variables.Correo = Convert.ToString(dgvListProveedores.CurrentRow.Cells["Correo"].Value); //Cambiar a variable de correo
            this.Close();
        } //Cambios Aqui
    }
}