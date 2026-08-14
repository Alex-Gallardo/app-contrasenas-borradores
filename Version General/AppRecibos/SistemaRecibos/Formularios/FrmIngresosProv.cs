using Sap.Data.Hana;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaRecibos.Formularios
{
    public partial class FrmIngresosProv : Form
    {
        public FrmIngresosProv()
        {
            InitializeComponent();
        }
        private void IngresosSAP(string empresa, string proveedor)
        {
            HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
            conn.Open();
            string query = string.Empty;

            if (empresa == "GRACO")
            {
                query = "SELECT* FROM SBO_GRACO.MA_CXP_INGRESOS WHERE \"CardCode\" = '" + proveedor + "' ";

            }
            else if (empresa == "FAES")
            {
                query = "SELECT* FROM SBOESCOCESA.MA_CXP_INGRESOS WHERE \"CardCode\" = '" + proveedor + "' ";

            }
            else if (empresa == "BOLIK")
            {
                query = "SELECT* FROM SBOBOLIK.MA_CXP_INGRESOS WHERE \"CardCode\" = '" + proveedor + "' ";

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
            string proveedor = Variables.CodProveedor;

            try
            {
                IngresosSAP(empresa, proveedor);
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
            dgvListFacturas.Columns[1].HeaderText = "Codigo";
            dgvListFacturas.Columns[2].Width = 80;
            dgvListFacturas.Columns[2].HeaderText = "Proveedor";
            dgvListFacturas.Columns[3].Width = 80;
            dgvListFacturas.Columns[3].HeaderText = "Fecha";
            dgvListFacturas.Columns[4].Width = 80;
            dgvListFacturas.Columns[4].HeaderText = "Numero de Ingreso";
            dgvListFacturas.Columns[5].Width = 80;
            dgvListFacturas.Columns[5].HeaderText = "Moneda";
            dgvListFacturas.Columns[6].Width = 80;
            dgvListFacturas.Columns[6].HeaderText = "Total";
            dgvListFacturas.Columns[6].DefaultCellStyle.Format = "n";
            dgvListFacturas.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void FrmIngresosProv_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void dgvListFacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListFacturas.Rows.Count > 0)
            {
                Variables.Factura = Convert.ToString(dgvListFacturas.CurrentRow.Cells["DocNum"].Value);
                Variables.MontoFact = Convert.ToString(dgvListFacturas.CurrentRow.Cells["DocTotal"].Value);
                this.Close();
            }
            else
            {
                Variables.FechaFact = DateTime.Today;
                Variables.MontoFact = "0.00";
                this.Close();
            }
        }
    }
}
