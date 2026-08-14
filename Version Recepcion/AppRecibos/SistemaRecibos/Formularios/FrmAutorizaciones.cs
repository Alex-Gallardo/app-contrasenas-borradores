using Recibos.Negocio;
using Sap.Data.Hana;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaRecibos.Formularios
{
    public partial class FrmAutorizaciones : Form
    {
        public string IdUsuario;
        public string Depto;
        public string Rol;
        public string Serie;
        public string Nombre;

        private DataTable RegistroID = new DataTable();
        private DataTable DtDetalles = new DataTable();
        public FrmAutorizaciones()
        {
            InitializeComponent();
        }
        protected void PagosFactSAP(string empresa)
        {
            try
            {
                if (empresa == "GRACO")
                {
                    HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
                    conn.Open();
                    string query = "";
                    query = "SELECT * FROM SBO_GRACO.INF_VRC_PAGOSCXC WHERE \"DocNum\" = ('" + TxtDoc.Text + "')";
                    HanaDataAdapter da = new HanaDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DtgvPagos.DataSource = dt;
                    this.FormatoPagos();
                    conn.Close();
                }
                else if (empresa == "FAES")
                {
                    HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
                    conn.Open();
                    string query = "";
                    query = "SELECT * FROM SBOESCOCESA.INF_VRC_PAGOSCXC WHERE \"DocNum\" = ('" + TxtDoc.Text + "')";
                    HanaDataAdapter da = new HanaDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DtgvPagos.DataSource = dt;
                    this.FormatoPagos();
                    conn.Close();
                }
                else if (empresa == "BOLIK")
                {
                    HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
                    conn.Open();
                    string query = "";
                    query = "SELECT * FROM SBOBOLIK.INF_VRC_PAGOSCXC WHERE \"DocNum\" = ('" + TxtDoc.Text + "')";
                    HanaDataAdapter da = new HanaDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DtgvPagos.DataSource = dt;
                    this.FormatoPagos();
                    conn.Close(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        protected void DetFactSAP(string empresa)
        {
            try
            {
                if (empresa == "GRACO")
                {
                    HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
                    conn.Open();
                    string query = "";
                    query = "SELECT * FROM SBO_GRACO.INF_VRC_FACDET WHERE \"DocNum\" = ('" + TxtDoc.Text + "')";
                    HanaDataAdapter da = new HanaDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DgvProductos.DataSource = dt;
                    this.FormatoFact();
                    conn.Close();
                }
                else if (empresa == "FAES")
                {
                    HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
                    conn.Open();
                    string query = "";
                    query = "SELECT * FROM SBOESCOCESA.INF_VRC_FACDET WHERE \"DocNum\" = ('" + TxtDoc.Text + "')";
                    HanaDataAdapter da = new HanaDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DgvProductos.DataSource = dt;
                    this.FormatoFact();
                    conn.Close();
                }
                else if (empresa == "BOLIK")
                {
                    HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
                    conn.Open();
                    string query = "";
                    query = "SELECT * FROM SBOBOLIK.INF_VRC_FACDET WHERE \"DocNum\" = ('" + TxtDoc.Text + "')";
                    HanaDataAdapter da = new HanaDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DgvProductos.DataSource = dt;
                    this.FormatoFact();
                    conn.Close(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        protected void DevNCSAP(string empresa)
        {
            try
            {
                if (empresa == "GRACO")
                {
                    HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
                    conn.Open();
                    string query = "";
                    query = "SELECT * FROM SBO_GRACO.INF_VRC_FACRNC WHERE \"Factura\" = ('" + TxtDoc.Text + "') AND \"Nota\" IS NOT NULL";
                    HanaDataAdapter da = new HanaDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DgvDevoluciones.DataSource = dt;
                    this.FormatoDevNC();
                    conn.Close();
                }
                else if (empresa == "FAES")
                {
                    HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
                    conn.Open();
                    string query = "";
                    query = "SELECT * FROM SBOESCOCESA.INF_VRC_FACRNC WHERE \"Factura\" = ('" + TxtDoc.Text + "') AND \"Nota\" IS NOT NULL";
                    HanaDataAdapter da = new HanaDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DgvDevoluciones.DataSource = dt;
                    this.FormatoDevNC();
                    conn.Close();
                }
                else if (empresa == "BOLIK")
                {
                    HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
                    conn.Open();
                    string query = "";
                    query = "SELECT * FROM SBOBOLIK.INF_VRC_FACRNC WHERE \"Factura\" = ('" + TxtDoc.Text + "') AND \"Nota\" IS NOT NULL";
                    HanaDataAdapter da = new HanaDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DgvDevoluciones.DataSource = dt;
                    this.FormatoDevNC();
                    conn.Close(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        protected void SaldoFact(string empresa)
        {
            try
            {
                string query = string.Empty;
                if (TxtIdEmpresa.Text == "GRACO")
                {
                    HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
                    conn.Open();
                    //query = "SELECT (\"DocTotal\"-\"PaidToDate\") as \"Saldo\" FROM SBO_GRACO.OINV WHERE \"DocNum\" = ('" + TxtDoc.Text + "')";
                    query = "SELECT CASE WHEN \"DocCur\"<> 'QTZ' THEN (\"DocTotalFC\" - \"PaidFC\") ELSE \"DocTotal\" - \"PaidToDate\" end as \"Saldo\" FROM SBO_GRACO.OINV WHERE \"DocNum\" =('" + TxtDoc.Text + "') ";
                    HanaCommand cmd = new HanaCommand(query, conn);
                    HanaDataReader reader = cmd.ExecuteReader();
                    CbbSaldo.DataSource = reader;
                    CbbSaldo.DisplayMember = "Saldo";
                    CbbSaldo.ValueMember = "Saldo";
                    conn.Close();
                }
                if (TxtIdEmpresa.Text == "BOLIK")
                {
                    HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
                    conn.Open();
                    query = "SELECT CASE WHEN \"DocCur\"<> 'QTZ' THEN (\"DocTotalFC\" - \"PaidFC\") ELSE \"DocTotal\" - \"PaidToDate\" end as \"Saldo\" FROM SBOBOLIK.OINV WHERE \"DocNum\" =('" + TxtDoc.Text + "') ";
                    HanaCommand cmd = new HanaCommand(query, conn);
                    HanaDataReader reader = cmd.ExecuteReader();
                    CbbSaldo.DataSource = reader;
                    CbbSaldo.DisplayMember = "Saldo";
                    CbbSaldo.ValueMember = "Saldo";
                    conn.Close();
                }

                if (TxtIdEmpresa.Text == "FAES")
                {
                    HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
                    conn.Open();
                    query = "SELECT CASE WHEN \"DocCur\"<> 'QTZ' THEN (\"DocTotalFC\" - \"PaidFC\") ELSE \"DocTotal\" - \"PaidToDate\" end as \"Saldo\" FROM SBOESCOCESA.OINV WHERE \"DocNum\" =('" + TxtDoc.Text + "') ";
                    HanaCommand cmd = new HanaCommand(query, conn);
                    HanaDataReader reader = cmd.ExecuteReader();
                    CbbSaldo.DataSource = reader;
                    CbbSaldo.DisplayMember = "Saldo";
                    CbbSaldo.ValueMember = "Saldo";
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Rutas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Rutas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ListarBorr()
        {
            try
            {
                DgvListaBorr.DataSource = NBorradoresNC.ListarBorrAutoR("A");
                this.Formato();
                label1total.Text = "Total Registros = " + Convert.ToString(DgvListaBorr.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void ListarBorrEmpr()
        {
            try
            {
                DgvListaBorr.DataSource = NBorradoresNC.ListarEmpr(CbbEmpresaListar.Text);
                this.Formato();
                label1total.Text = "Total Registros = " + Convert.ToString(DgvListaBorr.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void ListarDet()
        {
            try
            {
                dtgwDetalle.DataSource = NBorradoresNC.ListarDetAbiertas(TxtIdEmpresa.Text, TxtIdBorr.Text);
                this.FormatoDet();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Formato()
        {
            DgvListaBorr.Columns[0].Width = 80;
            DgvListaBorr.Columns[0].HeaderText = "Empresa";
            DgvListaBorr.Columns[1].Width = 80;
            DgvListaBorr.Columns[1].HeaderText = "Fecha";
            DgvListaBorr.Columns[2].Width = 120;
            DgvListaBorr.Columns[2].HeaderText = "# Borrador";
            DgvListaBorr.Columns[3].Width = 70;
            DgvListaBorr.Columns[3].HeaderText = "Codigo";
            DgvListaBorr.Columns[4].Width = 200;
            DgvListaBorr.Columns[4].HeaderText = "Nombre";
            DgvListaBorr.Columns[5].Width = 150;
            DgvListaBorr.Columns[5].HeaderText = "Agente";
            DgvListaBorr.Columns[6].Width = 90;
            DgvListaBorr.Columns[6].HeaderText = "Registró";
            DgvListaBorr.Columns[7].Width = 70;
            DgvListaBorr.Columns[7].HeaderText = "Moneda";
            DgvListaBorr.Columns[8].Width = 100;
            DgvListaBorr.Columns[8].HeaderText = "Total";
            DgvListaBorr.Columns[9].Visible = false;
            DgvListaBorr.Columns[9].Width = 100;
            DgvListaBorr.Columns[9].HeaderText = "Nit";
            DgvListaBorr.Columns[10].Visible = false;
            DgvListaBorr.Columns[10].Width = 100;
            DgvListaBorr.Columns[10].HeaderText = "Direccion";
        }
        private void FormatoDet()
        {
            dtgwDetalle.Columns[0].Width = 100;
            dtgwDetalle.Columns[0].HeaderText = "Concepto";
            dtgwDetalle.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgwDetalle.Columns[1].Width = 100;
            dtgwDetalle.Columns[1].HeaderText = "Fecha";
            dtgwDetalle.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgwDetalle.Columns[2].Width = 100;
            dtgwDetalle.Columns[2].HeaderText = "Documento";
            dtgwDetalle.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgwDetalle.Columns[3].Width = 100;
            dtgwDetalle.Columns[3].HeaderText = "Serie FEL";
            dtgwDetalle.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgwDetalle.Columns[4].Width = 100;
            dtgwDetalle.Columns[4].HeaderText = "Numero FEL";
            dtgwDetalle.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgwDetalle.Columns[5].Width = 80;
            dtgwDetalle.Columns[5].HeaderText = "Total";
            dtgwDetalle.Columns[5].DefaultCellStyle.Format = "n";
            dtgwDetalle.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtgwDetalle.Columns[6].Width = 500;
            dtgwDetalle.Columns[6].HeaderText = "Descripcion";
            dtgwDetalle.Columns[7].Width = 80;
            dtgwDetalle.Columns[7].HeaderText = "Importe";
            dtgwDetalle.Columns[7].DefaultCellStyle.Format = "n";
            dtgwDetalle.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void FormatoPagos()
        {
            DtgvPagos.Columns[0].Width = 80;
            DtgvPagos.Columns[0].HeaderText = "Factura";
            DtgvPagos.Columns[1].Width = 80;
            DtgvPagos.Columns[1].HeaderText = "Tipo";
            DtgvPagos.Columns[2].Width = 80;
            DtgvPagos.Columns[2].HeaderText = "No Pago";
            DtgvPagos.Columns[3].Width = 80;
            DtgvPagos.Columns[3].HeaderText = "Fecha";
            DtgvPagos.Columns[4].Width = 120;
            DtgvPagos.Columns[4].HeaderText = "Referencia";
            DtgvPagos.Columns[5].Width = 80;
            DtgvPagos.Columns[5].HeaderText = "Moneda";
            DtgvPagos.Columns[6].Width = 100;
            DtgvPagos.Columns[6].HeaderText = "Pago";
            DtgvPagos.Columns[6].DefaultCellStyle.Format = "n";
            DtgvPagos.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            DtgvPagos.Columns[7].Width = 300;
            DtgvPagos.Columns[7].HeaderText = "Cuenta";
        }
        private void FormatoFact()
        {
            DgvProductos.Columns[0].Width = 80;
            DgvProductos.Columns[0].HeaderText = "Factura";
            DgvProductos.Columns[1].Width = 80;
            DgvProductos.Columns[1].HeaderText = "Codigo";
            DgvProductos.Columns[2].Width = 300;
            DgvProductos.Columns[2].HeaderText = "Producto";
            DgvProductos.Columns[3].Width = 80;
            DgvProductos.Columns[3].HeaderText = "UMD";
            DgvProductos.Columns[4].Width = 100;
            DgvProductos.Columns[4].HeaderText = "Cantidad";
            DgvProductos.Columns[4].DefaultCellStyle.Format = "n";
            DgvProductos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvProductos.Columns[5].Width = 100;
            DgvProductos.Columns[5].HeaderText = "Monto";
            DgvProductos.Columns[5].DefaultCellStyle.Format = "n";
            DgvProductos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvProductos.Columns[6].Width = 80;
            DgvProductos.Columns[6].HeaderText = "Almacen";
            DgvProductos.Columns[7].Width = 100;
            DgvProductos.Columns[7].HeaderText = "Precio";
            DgvProductos.Columns[7].DefaultCellStyle.Format = "n";
            DgvProductos.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void FormatoDevNC()
        {
            DgvDevoluciones.Columns[0].Width = 80;
            DgvDevoluciones.Columns[0].HeaderText = "Tipo";
            DgvDevoluciones.Columns[1].Width = 80;
            DgvDevoluciones.Columns[1].HeaderText = "Factura";
            DgvDevoluciones.Columns[2].Width = 80;
            DgvDevoluciones.Columns[2].HeaderText = "Dev-NC";
            DgvDevoluciones.Columns[3].Width = 80;
            DgvDevoluciones.Columns[3].HeaderText = "Fecha";
            DgvDevoluciones.Columns[4].Width = 80;
            DgvDevoluciones.Columns[4].HeaderText = "Codigo";
            DgvDevoluciones.Columns[5].Width = 200;
            DgvDevoluciones.Columns[5].HeaderText = "Cliente";
            DgvDevoluciones.Columns[6].Width = 100;
            DgvDevoluciones.Columns[6].HeaderText = "Moneda";
            DgvDevoluciones.Columns[7].Width = 80;
            DgvDevoluciones.Columns[7].HeaderText = "Total";
            DgvDevoluciones.Columns[7].DefaultCellStyle.Format = "n";
            DgvDevoluciones.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvDevoluciones.Columns[8].Width = 200;
            DgvDevoluciones.Columns[8].HeaderText = "Origen";
            DgvDevoluciones.Columns[9].Width = 400;
            DgvDevoluciones.Columns[9].HeaderText = "Comentarios";


        }
        private void LimpiarEnc()
        {
            TxtIdCliente.Clear();
            TxtIdBorr.Clear();
            TxtNomCliente.Clear();
            TxtDirCliente.Clear();
            TxtMotivo.Clear();
            TxtNit.Clear();
            TxtIdEmpresa.Clear();
            DtpFechaBor.ResetText();
            CbbMoneda.SelectedItem = -1;
            TxtTototalBorr.Text = "0.00";
            BtnImprimir.Enabled = false;

            if (Depto == "AGENTE")
            {
                TxtAgente.Text = Nombre;
            }
            else { TxtAgente.Text = ""; }
        }
        private void LimpiarDet()
        {
            CbbConcepto.SelectedIndex = -1;
            TxtDoc.Clear();
            DtpFechaDoc.ResetText();
            TxtSerieFel.Clear();
            TxtNumFel.Clear();
            TxtMontoFact.Text = "0.00";
            TxtImporte.Text = "0.00";
            TxtComentarios.Clear();
            CbbSaldo.Text = "0.00";

            DataTable dt = (DataTable)dtgwDetalle.DataSource;
            dt.Clear();
        }
        private void LimpiarDGV()
        {
            DataTable dt2 = (DataTable)DgvProductos.DataSource;
            dt2.Clear();
            DgvProductos.Refresh();
            DgvProductos.DataSource = "";

            DataTable dt3 = (DataTable)DtgvPagos.DataSource;
            dt3.Clear();
            DtgvPagos.Refresh();
            DtgvPagos.DataSource = "";

            //DataTable dt4 = (DataTable)DgvDevoluciones.DataSource;
            //dt4.Clear();
            //DgvDevoluciones.Refresh();
            //DgvDevoluciones.DataSource = "";
        }
        private void CrearTabla()
        {
            this.DtDetalles.Columns.Clear();
            this.DtDetalles.Columns.Add("Empresa", System.Type.GetType("System.String"));
            this.DtDetalles.Columns.Add("Concepto", System.Type.GetType("System.String"));
            this.DtDetalles.Columns.Add("Fecha", System.Type.GetType("System.DateTime"));
            this.DtDetalles.Columns.Add("Documento", System.Type.GetType("System.String"));
            this.DtDetalles.Columns.Add("Serie_FEL", System.Type.GetType("System.String"));
            this.DtDetalles.Columns.Add("No_FEL", System.Type.GetType("System.String"));
            this.DtDetalles.Columns.Add("Total_Fact", System.Type.GetType("System.Decimal"));
            this.DtDetalles.Columns.Add("Descripcion", System.Type.GetType("System.String"));
            this.DtDetalles.Columns.Add("Importe", System.Type.GetType("System.Decimal"));

            dtgwDetalle.DataSource = this.DtDetalles;

            dtgwDetalle.Columns[0].Width = 80;
            dtgwDetalle.Columns[0].HeaderText = "Empresa";
            dtgwDetalle.Columns[1].Width = 120;
            dtgwDetalle.Columns[1].HeaderText = "Concepto";
            dtgwDetalle.Columns[2].Width = 70;
            dtgwDetalle.Columns[2].HeaderText = "Fecha";
            dtgwDetalle.Columns[3].Width = 100;
            dtgwDetalle.Columns[3].HeaderText = "Documento";
            dtgwDetalle.Columns[4].Width = 100;
            dtgwDetalle.Columns[4].HeaderText = "Serie_FEL";
            dtgwDetalle.Columns[5].Width = 100;
            dtgwDetalle.Columns[5].HeaderText = "No_FEL";
            dtgwDetalle.Columns[6].Width = 100;
            dtgwDetalle.Columns[6].HeaderText = "Total_Fact";
            dtgwDetalle.Columns[7].Width = 160;
            dtgwDetalle.Columns[7].HeaderText = "Descripcion";
            dtgwDetalle.Columns[8].Width = 100;
            dtgwDetalle.Columns[8].HeaderText = "Importe";
        }
        private void Recargar()
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            // this.Listar();
            this.CrearTabla();
            TxtIdEmpresa.Clear();
            CbbConcepto.SelectedIndex = -1;
            CbbMoneda.SelectedIndex = -1;
            CbbMoneda.Enabled = true;
            BtnImprimir.Enabled = false;
            DtpFechaBor.Enabled = true;
            TxtImporte.Text = "0.00";
        }
        private void FrmAutorizaciones_Load(object sender, EventArgs e)
        {
            TxtUsr.Text = IdUsuario;
            TxtMotivo.Enabled = false;
            BtnMotivo.Enabled = false;
            CrearTabla();
            TxtImporte.Text = "0.00";
            BtnImprimir.Enabled = false;
            ListarBorr();
            BtnDetalles.Enabled = false;
        }
        private void DgvListaBorr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BtnImprimir.Enabled = true;
                BtnNoAutorizar.Enabled = true;

                CbbMoneda.Enabled = false;
                tabControl1.SelectedIndex = 1;
                TxtIdBorr.Text = Convert.ToString(DgvListaBorr.CurrentRow.Cells["BORRADOR"].Value);
                TxtIdEmpresa.Text = Convert.ToString(DgvListaBorr.CurrentRow.Cells["EMPRESA"].Value);
                TxtNit.Text = Convert.ToString(DgvListaBorr.CurrentRow.Cells["NIT"].Value);
                TxtDirCliente.Text = Convert.ToString(DgvListaBorr.CurrentRow.Cells["DIRECCION"].Value);
                DtpFechaBor.Value = DateTime.Parse(DgvListaBorr.CurrentRow.Cells["FECHA"].Value.ToString());
                TxtIdCliente.Text = Convert.ToString(DgvListaBorr.CurrentRow.Cells["CODIGO"].Value);
                TxtNomCliente.Text = Convert.ToString(DgvListaBorr.CurrentRow.Cells["NOMBRE"].Value);
                TxtAgente.Text = Convert.ToString(DgvListaBorr.CurrentRow.Cells["AGENTE"].Value);
                CbbMoneda.Text = Convert.ToString(DgvListaBorr.CurrentRow.Cells["MONEDA"].Value);
                TxtTototalBorr.Text = Convert.ToString(DgvListaBorr.CurrentRow.Cells["TOTAL"].Value);
                //  TxtTototalBorr.TextAlign = HorizontalAlignment.Right;
                this.ListarDet();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la Celda #Borrador." + "| Error:" + ex.Message);
            }
        }
        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            Reportes.FrmReporteBorr reporte = new Reportes.FrmReporteBorr();
            Variables.IdRem = TxtIdBorr.Text;
            Variables.Empresa = TxtIdEmpresa.Text;
            reporte.ShowDialog();
        }
        private void dtgwDetalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CbbConcepto.Text = Convert.ToString(dtgwDetalle.CurrentRow.Cells["CONCEPTO"].Value);
                TxtDoc.Text = Convert.ToString(dtgwDetalle.CurrentRow.Cells["DOCUMENTO"].Value);
                DtpFechaDoc.Value = DateTime.Parse(dtgwDetalle.CurrentRow.Cells["FECHA_DOC"].Value.ToString());
                TxtSerieFel.Text = Convert.ToString(dtgwDetalle.CurrentRow.Cells["SERIE"].Value);
                TxtNumFel.Text = Convert.ToString(dtgwDetalle.CurrentRow.Cells["NUMERO"].Value);
                TxtMontoFact.Text = Convert.ToString(dtgwDetalle.CurrentRow.Cells["TOTAL_FACT"].Value);
                // TxtMontoFact.Text = string.Format(GlobalizationExtensions);
                TxtComentarios.Text = Convert.ToString(dtgwDetalle.CurrentRow.Cells["DESCRIPCION"].Value);
                TxtImporte.Text = Convert.ToString(dtgwDetalle.CurrentRow.Cells["IMPORTE"].Value);
                SaldoFact(TxtIdEmpresa.Text);
                BtnDetalles.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la Celda #Documento." + "| Error:" + ex.Message);
            }
        }
        private void BtnMotivo_Click(object sender, EventArgs e)
        {
            if (TxtMotivo.Text != string.Empty)
            {
                try
                {
                    string Rpta = "";
                    DialogResult opcion;
                    opcion = MessageBox.Show("Esta Seguro de Rechazar este Borrador?", "Borradores NC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (opcion == DialogResult.OK)
                    {
                        Rpta = NBorradoresNC.Autorizaciones(TxtIdEmpresa.Text, TxtIdBorr.Text, TxtUsr.Text, "RECHAZADO", TxtMotivo.Text);
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se ha rechazado el borrador");
                            BtnNoAutorizar.Enabled = false;
                            Reportes.FrmReporteBorr reporte = new Reportes.FrmReporteBorr();
                            Variables.IdRem = TxtIdBorr.Text;
                            Variables.Empresa = TxtIdEmpresa.Text;
                            reporte.ShowDialog();

                            LimpiarDet();
                            LimpiarEnc();

                            TxtMotivo.Enabled = false;
                            BtnMotivo.Enabled = false;
                            CrearTabla();
                            TxtImporte.Text = "0.00";
                            BtnImprimir.Enabled = false;
                            ListarBorr();
                            BtnDetalles.Enabled = false;
                            tabControl1.SelectedIndex = 0;
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
            else
            {
                this.MensajeOk("Se ha registrado un motivo para Rechazar el borrador");
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Recargar();
            LimpiarDet();
            LimpiarEnc();

            BtnImprimir.Enabled = false;
            BtnDetalles.Enabled = false;
            tabControl1.SelectedIndex = 0;
        }
        private void BtnAutorizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                DialogResult opcion;
                opcion = MessageBox.Show("Esta Seguro de Autorizar este Borrador?", "Borradores NC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    Rpta = NBorradoresNC.Autorizaciones(TxtIdEmpresa.Text, TxtIdBorr.Text, TxtUsr.Text, "AUTORIZADO", TxtMotivo.Text);
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se ha Autorizado el borrador");
                        Reportes.FrmReporteBorr reporte = new Reportes.FrmReporteBorr();
                        Variables.IdRem = TxtIdBorr.Text;
                        Variables.Empresa = TxtIdEmpresa.Text;
                        reporte.ShowDialog();
                        LimpiarDet();
                        LimpiarEnc();
                        TxtMotivo.Enabled = false;
                        BtnMotivo.Enabled = false;
                        CrearTabla();
                        TxtImporte.Text = "0.00";
                        BtnImprimir.Enabled = false;
                        ListarBorr();
                        BtnDetalles.Enabled = false;
                        tabControl1.SelectedIndex = 0;
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
        private void BtnNoAutorizar_Click_1(object sender, EventArgs e)
        {
            BtnMotivo.Enabled = true;
            TxtMotivo.Enabled = true;
        }
        private void BtnDetalles_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            DetFactSAP(TxtIdEmpresa.Text);
            PagosFactSAP(TxtIdEmpresa.Text);
            DevNCSAP(TxtIdEmpresa.Text);
        }
        private void CbbEmpresaListar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbbEmpresaListar.Text == "TODAS")
            {
                ListarBorr();
            }
            else
            {
                ListarBorrEmpr();
            }
        }
        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            LimpiarDGV();
        }
    }
}
