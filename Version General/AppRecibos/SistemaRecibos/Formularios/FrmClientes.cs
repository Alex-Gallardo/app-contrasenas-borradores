using Sap.Data.Hana;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaRecibos.Formularios
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }
        private void ClientesSap(string empresa, string agente)
        {
            HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
            conn.Open();
            string query = string.Empty;

            if (empresa == "GRACO")
            {
                query = "CALL SBO_GRACO.INF_CLIENTES_REC('" + agente + "')";
            }
            else if (empresa == "FAES")
            {
                query = "CALL SBOESCOCESA.INF_CLIENTES_REC('" + agente + "')";
            }
            else if (empresa == "BOLIK")
            {
                query = "CALL SBOBOLIK.INF_CLIENTES_REC('" + agente + "')";
            }
            HanaDataAdapter da = new HanaDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvListClientes.DataSource = dt;
            this.Formato();
            conn.Close();
        }
        private void ClientesExpo(string empresa)
        {
            try
            {
                if (Variables.Empresa == "GRACO")
                {
                    HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
                    conn.Open();
                    string query = "";
                    query = "SELECT * FROM SBO_GRACO.RC_CLIENTES WHERE  \"SlpName\" IN ('EXPORTACION','ABEL RIOS')";
                    HanaDataAdapter da = new HanaDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvListClientes.DataSource = dt;
                    this.Formato();
                    conn.Close();
                }
                else if (Variables.Empresa == "FAES")
                {
                    HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
                    conn.Open();
                    string query = "";
                    query = "SELECT * FROM SBOESCOCESA.RC_CLIENTES WHERE \"SlpName\" IN ('EXPORTACION','ABEL RIOS')";
                    HanaDataAdapter da = new HanaDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvListClientes.DataSource = dt;
                    this.Formato();
                    conn.Close();
                }
                else if (Variables.Empresa == "BOLIK")
                {
                    HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
                    conn.Open();
                    string query = "";
                    query = "SELECT * FROM SBOBOLIK.RC_CLIENTES WHERE \"SlpName\" IN ('EXPORTACION','ABEL RIOS')";
                    HanaDataAdapter da = new HanaDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvListClientes.DataSource = dt;
                    this.Formato();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Listar()
        {
            string empresa = Variables.Empresa;
            TxtAgente.Text = Variables.Agente;
            try
            {
                if (Variables.IdUsuario == "BLUCAS" || Variables.IdUsuario == "ARIOS")
                {
                    ClientesExpo(empresa);
                }
                else
                {
                    ClientesSap(empresa, TxtAgente.Text);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Formato()
        {
            dgvListClientes.Columns[0].Visible = true;
            dgvListClientes.Columns[0].Width = 80;
            dgvListClientes.Columns[0].HeaderText = "Empresa";
            dgvListClientes.Columns[1].Visible = true;
            dgvListClientes.Columns[1].Width = 100;
            dgvListClientes.Columns[1].HeaderText = "Codigo";
            dgvListClientes.Columns[2].Width = 200;
            dgvListClientes.Columns[2].HeaderText = "Nombre";
            dgvListClientes.Columns[3].Width = 250;
            dgvListClientes.Columns[3].HeaderText = "Direccion";
            dgvListClientes.Columns[4].Width = 100;
            dgvListClientes.Columns[4].HeaderText = "Agente";

            dgvListClientes.Columns[5].Width = 100;
            dgvListClientes.Columns[5].HeaderText = "NIT";
            dgvListClientes.Columns[6].Width = 100;
            dgvListClientes.Columns[6].HeaderText = "Moneda";
            dgvListClientes.Columns[7].Width = 100;
            dgvListClientes.Columns[7].HeaderText = "Correo";
        }
        private void BuscarExpo()
        {
            try
            {
                if (Variables.Empresa == "GRACO")
                {
                    HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
                    conn.Open();
                    string query = "";
                    query = "SELECT * FROM SBO_GRACO.RC_CLIENTES WHERE \"CardName\" LIKE ('%" + txtBuscar.Text + "%') AND \"SlpName\" IN ('EXPORTACION','ABEL RIOS')";
                    HanaDataAdapter da = new HanaDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvListClientes.DataSource = dt;
                    this.Formato();
                    conn.Close();
                }
                else if (Variables.Empresa == "FAES")
                {
                    HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
                    conn.Open();
                    string query = "";
                    query = "SELECT * FROM SBOESCOCESA.RC_CLIENTES WHERE \"CardName\" LIKE ('%" + txtBuscar.Text + "%') AND \"SlpName\" IN ('EXPORTACION','ABEL RIOS')";
                    HanaDataAdapter da = new HanaDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvListClientes.DataSource = dt;
                    this.Formato();
                    conn.Close();
                }
                else if (Variables.Empresa == "BOLIK")
                {
                    HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
                    conn.Open();
                    string query = "";
                    query = "SELECT * FROM SBOBOLIK.RC_CLIENTES WHERE \"CardName\" LIKE ('%" + txtBuscar.Text + "%') AND \"SlpName\" IN ('EXPORTACION','ABEL RIOS')";
                    HanaDataAdapter da = new HanaDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvListClientes.DataSource = dt;
                    this.Formato();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Buscar()
        {
            try
            {
                if (Variables.Empresa == "GRACO")
                {
                    HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
                    conn.Open();
                    string query = "";
                    if (TxtAgente.Text == string.Empty)
                    {
                        query = "SELECT * FROM SBO_GRACO.RC_CLIENTES WHERE \"CardName\" LIKE ('%" + txtBuscar.Text + "%')";
                    }
                    else
                    {
                        query = "SELECT * FROM SBO_GRACO.RC_CLIENTES WHERE \"CardName\" LIKE ('%" + txtBuscar.Text + "%') AND \"SlpName\" = ('" + TxtAgente.Text + "')";
                    }

                    HanaDataAdapter da = new HanaDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvListClientes.DataSource = dt;
                    this.Formato();
                    conn.Close();
                }
                else if (Variables.Empresa == "FAES")
                {
                    HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
                    conn.Open();
                    string query = "";
                    if (TxtAgente.Text == string.Empty)
                    {
                        query = "SELECT * FROM SBOESCOCESA.RC_CLIENTES WHERE \"CardName\" LIKE ('%" + txtBuscar.Text + "%')";
                    }
                    else
                    {
                        query = "SELECT * FROM SBOESCOCESA.RC_CLIENTES WHERE \"CardName\" LIKE ('%" + txtBuscar.Text + "%') AND \"SlpName\" = ('" + TxtAgente.Text + "')";
                    }
                    HanaDataAdapter da = new HanaDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvListClientes.DataSource = dt;
                    this.Formato();
                    conn.Close();
                }
                else if (Variables.Empresa == "BOLIK")
                {
                    HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
                    conn.Open();
                    string query = "";
                    if (TxtAgente.Text == string.Empty)
                    {
                        query = "SELECT * FROM SBOBOLIK.RC_CLIENTES WHERE \"CardName\" LIKE ('%" + txtBuscar.Text + "%')";
                    }
                    else
                    {
                        query = "SELECT * FROM SBOBOLIK.RC_CLIENTES WHERE \"CardName\" LIKE ('%" + txtBuscar.Text + "%') AND \"SlpName\" = ('" + TxtAgente.Text + "')";
                    }
                    HanaDataAdapter da = new HanaDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvListClientes.DataSource = dt;
                    this.Formato();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void FrmClentes_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Variables.IdUsuario == "BLUCAS" || Variables.IdUsuario == "ARIOS")
            {
                BuscarExpo();
            }
            else
            {
                Buscar();
            }

        }
        private void dgvListClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.CodCliente = Convert.ToString(dgvListClientes.CurrentRow.Cells["CardCode"].Value);
            Variables.NombreCliente = Convert.ToString(dgvListClientes.CurrentRow.Cells["CardName"].Value);
            Variables.Agente = Convert.ToString(dgvListClientes.CurrentRow.Cells["SlpName"].Value);
            Variables.Direccion = Convert.ToString(dgvListClientes.CurrentRow.Cells["Address"].Value);
            Variables.Moneda = Convert.ToString(dgvListClientes.CurrentRow.Cells["Currency"].Value);
            Variables.Correo = Convert.ToString(dgvListClientes.CurrentRow.Cells["E_Mail"].Value);
            Variables.NIT = Convert.ToString(dgvListClientes.CurrentRow.Cells["LicTradNum"].Value);
            this.Close();
        }
    }
}