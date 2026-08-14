using Sap.Data.Hana;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaRecibos.Formularios
{
    public partial class FrmFacturasCL_BorrNC : Form
    {
        public FrmFacturasCL_BorrNC()
        {
            InitializeComponent();
        }
        private void FacturaSAP(string empresa, string agente, string cliente)
        {
            HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
            conn.Open();
            string query = string.Empty;

            if (empresa == "GRACO")
            {
                query = "SELECT* FROM SBO_GRACO.RC_FACTURAS_BORRNC WHERE \"SlpName\" = '" + TxtAgente.Text + "' and \"CardCode\" = '" + cliente + "'";

            }
            else if (empresa == "FAES")
            {
                query = "SELECT* FROM SBOESCOCESA.RC_FACTURAS_BORRNC WHERE \"SlpName\" = '" + TxtAgente.Text + "' and \"CardCode\" = '" + cliente + "'";

            }
            else if (empresa == "BOLIK")
            {
                query = "SELECT* FROM SBOBOLIK.RC_FACTURAS_BORRNC WHERE \"SlpName\" = '" + TxtAgente.Text + "' and \"CardCode\" = '" + cliente + "'";

            }
            HanaDataAdapter da = new HanaDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvListFacturas.DataSource = dt;
            this.Formato();
            conn.Close();
        }
        private void Listar()
        {
            string empresa = Variables.Empresa;
            string cliente = Variables.CodCliente;
            TxtAgente.Text = Variables.Agente;
            try
            {
                FacturaSAP(empresa, TxtAgente.Text, cliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Formato()
        {
            dgvListFacturas.Columns[0].Visible = true;
            dgvListFacturas.Columns[0].Width = 80;
            dgvListFacturas.Columns[0].HeaderText = "Empresa";
            dgvListFacturas.Columns[1].Visible = true;
            dgvListFacturas.Columns[1].Width = 100;
            dgvListFacturas.Columns[1].HeaderText = "Agente";
            dgvListFacturas.Columns[2].Width = 80;
            dgvListFacturas.Columns[2].HeaderText = "Factura";
            dgvListFacturas.Columns[3].Width = 80;
            dgvListFacturas.Columns[3].HeaderText = "Serie FEL";
            dgvListFacturas.Columns[4].Width = 80;
            dgvListFacturas.Columns[4].HeaderText = "Numero FEL";

            dgvListFacturas.Columns[5].Width = 80;
            dgvListFacturas.Columns[5].HeaderText = "Fecha";
            dgvListFacturas.Columns[6].Width = 80;
            dgvListFacturas.Columns[6].HeaderText = "Codigo";
            dgvListFacturas.Columns[7].Width = 150;
            dgvListFacturas.Columns[7].HeaderText = "Cliente";

            dgvListFacturas.Columns[8].Width = 80;
            dgvListFacturas.Columns[8].HeaderText = "Moneda";

            dgvListFacturas.Columns[9].DefaultCellStyle.Format = "n";
            dgvListFacturas.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvListFacturas.Columns[9].Width = 80;
            dgvListFacturas.Columns[9].HeaderText = "Total";

            dgvListFacturas.Columns[10].DefaultCellStyle.Format = "n";
            dgvListFacturas.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvListFacturas.Columns[10].Width = 80;
            dgvListFacturas.Columns[10].HeaderText = "Pagado";
        }
        private void Buscar()
        {
            string cliente = Variables.CodCliente;
            try
            {
                if (Variables.Empresa == "GRACO")
                {
                    HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
                    conn.Open();
                    string query = "";
                    query = "SELECT * FROM SBO_GRACO.RC_FACTURAS_BORRNC WHERE \"DocNum\" LIKE ('%" + txtBuscar.Text + "%') AND \"SlpName\" = ('" + TxtAgente.Text + "') AND \"CardCode\" = ('" + cliente + "')";
                    HanaDataAdapter da = new HanaDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvListFacturas.DataSource = dt;
                    this.Formato();
                    conn.Close();
                }
                else if (Variables.Empresa == "FAES")
                {
                    HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
                    conn.Open();
                    string query = "";
                    query = "SELECT * FROM SBOESCOCESA.RC_FACTURAS_BORRNC WHERE \"DocNum\" LIKE ('%" + txtBuscar.Text + "%') AND \"SlpName\" = ('" + TxtAgente.Text + "') AND \"CardCode\" = ('" + cliente + "')";
                    HanaDataAdapter da = new HanaDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvListFacturas.DataSource = dt;
                    this.Formato();
                    conn.Close();
                }
                else if (Variables.Empresa == "BOLIK")
                {
                    HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
                    conn.Open();
                    string query = "";
                    query = "SELECT * FROM SBOBOLIK.RC_FACTURAS_BORRNC WHERE \"DocNum\" LIKE ('%" + txtBuscar.Text + "%') AND \"SlpName\" = ('" + TxtAgente.Text + "') AND \"CardCode\" = ('" + cliente + "')";
                    HanaDataAdapter da = new HanaDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvListFacturas.DataSource = dt;
                    this.Formato();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void FrmFacturasCL_BorrNC_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void dgvListFacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListFacturas.Rows.Count > 0)
            {
                Variables.Cantidad = dgvListFacturas.Rows.Count;
                Variables.Factura = Convert.ToString(dgvListFacturas.CurrentRow.Cells["DocNum"].Value);
                Variables.SerieFel = Convert.ToString(dgvListFacturas.CurrentRow.Cells["U_SERIE_FACE"].Value);
                Variables.NoFel = Convert.ToString(dgvListFacturas.CurrentRow.Cells["U_NUMERO_DOCUMENTO"].Value);
                Variables.FechaFact = Convert.ToDateTime(dgvListFacturas.CurrentRow.Cells["DocDate"].Value);
                Variables.Moneda = Convert.ToString(dgvListFacturas.CurrentRow.Cells["DocCur"].Value);
                Variables.MontoFact = Convert.ToString(dgvListFacturas.CurrentRow.Cells["DocTotal"].Value);
                this.Close();
            }
            else
            {
                Variables.FechaFact = DateTime.Today;
                this.Close();
            }
        }
    }
}
