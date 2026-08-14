using Recibos.Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaRecibos.Formularios
{
    public partial class FrmBorradores : Form
    {
        public string IdUsuario;
        public string Depto;
        public string Rol;
        public string Serie;
        public string Nombre;
        public decimal MontoAcum;
        private DataTable RegAcum = new DataTable();
        private DataTable RegistroID = new DataTable();
        private DataTable DtDetalles = new DataTable();
        public FrmBorradores()
        {
            InitializeComponent();
        }
        protected void FacturasSAP(string Entidad)
        {
            //string query = string.Empty;
            //if (Entidad == "GRACO")
            //{
            //    HanaConnection conn = new HanaConnection("server=192.168.192.200:30015;UserID=SYSTEM;password=7*Oa7!D5ulu0");
            //    conn.Open();
            //    query = "  RC_FACTURAS_BORRNC   call SBO_GRACO.INF_RT_FACTURAS('" + TxtAgente.Text + "' , '" + TxtDoc.Text + "')";
            //    HanaCommand cmd = new HanaCommand(query, conn);
            //    //cmd.CommandType = CommandType.StoredProcedure;
            //    HanaDataReader reader = cmd.ExecuteReader();
            //    //92.168.192.200:30015
            //    while (reader.Read())
            //    {
            //        string values0 = reader.GetString(0); //tipo
            //        DateTime value1 = reader.GetDateTime(1); //fecha
            //        string value2 = reader.GetString(2); // factura
            //        string value3 = reader.GetString(3); // cod cliente
            //        string value4 = reader.GetString(4); // nombre cliente   
            //        string value5 = reader.GetString(5); //direccion fiscal
            //        string value6 = reader.GetString(6); // doc total
            //        string value7 = reader.GetString(7); // agente
            //        string value8 = reader.GetString(8); // dir despacho
            //        string value9 = reader.GetString(9); // cod_depacho
            //        string value10 = reader.GetString(10); //serie  fel                 
            //        string value11 = reader.GetString(11); //numero fel 
            //        string value12 = reader.GetString(12); //dirfac
            //        string value13 = reader.GetString(13); //dirdesp

            //        DtpFechaDoc.Value = value1;
            //        TxtDoc.Text = value2;
            //        txtCliente.Text = value4;
            //        txtAgente.Text = value7;
            //        txtMonto.Text = value6;
            //        txtNomDesp.Text = value9;
            //        txtDirDesp.Text = value8;
            //        txtSerieFel.Text = value10;
            //        txtNumFel.Text = value11;

            //    }
            //    reader.Close();
            //    conn.Close();
            //    cbbDocumento.Enabled = false;
            //    cbbTipo.Enabled = false;
            //    cbbEmpresa.Enabled = false;
            //}
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ListarSeg()
        {
            try
            {
                DgvSeguimiento.DataSource = NBorradoresNC.ListarSeg(IdUsuario, Depto, TxtAgente.Text);
                this.FormatoSeg();
                label19.Text = "Total Registros = " + Convert.ToString(DgvSeguimiento.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void ListarAct()
        {
            try
            {
                DgvListaBorr.DataSource = NBorradoresNC.Listar(IdUsuario, Depto, TxtAgente.Text);
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
                dtgwDetalle.DataSource = NBorradoresNC.ListarDetAbiertas(CbbEmpresa.Text, TxtIdBorr.Text);
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
            DgvListaBorr.Columns[8].DefaultCellStyle.Format = "n";
            DgvListaBorr.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvListaBorr.Columns[9].Visible = false;
            DgvListaBorr.Columns[9].Width = 100;
            DgvListaBorr.Columns[9].HeaderText = "Nit";
            DgvListaBorr.Columns[10].Visible = false;
            DgvListaBorr.Columns[10].Width = 100;
            DgvListaBorr.Columns[10].HeaderText = "Direccion";
        }
        private void FormatoSeg()
        {
            DgvSeguimiento.Columns[0].Width = 80;
            DgvSeguimiento.Columns[0].HeaderText = "Empresa";
            DgvSeguimiento.Columns[1].Width = 80;
            DgvSeguimiento.Columns[1].HeaderText = "Fecha";
            DgvSeguimiento.Columns[2].Width = 120;
            DgvSeguimiento.Columns[2].HeaderText = "# Borrador";
            DgvSeguimiento.Columns[3].Width = 70;
            DgvSeguimiento.Columns[3].HeaderText = "Codigo";
            DgvSeguimiento.Columns[4].Width = 200;
            DgvSeguimiento.Columns[4].HeaderText = "Nombre";
            DgvSeguimiento.Columns[5].Width = 150;
            DgvSeguimiento.Columns[5].HeaderText = "Agente";
            DgvSeguimiento.Columns[6].Width = 90;
            DgvSeguimiento.Columns[6].HeaderText = "Registró";
            DgvSeguimiento.Columns[7].Width = 70;
            DgvSeguimiento.Columns[7].HeaderText = "Moneda";
            DgvSeguimiento.Columns[8].Width = 100;
            DgvSeguimiento.Columns[8].HeaderText = "Total";
            DgvSeguimiento.Columns[8].DefaultCellStyle.Format = "n";
            DgvSeguimiento.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DgvSeguimiento.Columns[9].Visible = false;
            DgvSeguimiento.Columns[9].Width = 100;
            DgvSeguimiento.Columns[9].HeaderText = "Nit";
            DgvSeguimiento.Columns[10].Visible = false;
            DgvSeguimiento.Columns[10].Width = 100;
            DgvSeguimiento.Columns[10].HeaderText = "Direccion";
        }
        private void LimpiarEnc()
        {
            TxtIdCliente.Clear();
            TxtIdBorr.Clear();
            TxtNomCliente.Clear();
            TxtDirCliente.Clear();
            TxtNit.Clear();
            CbbEmpresa.SelectedItem = -1;
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
            TxtTotalAcum.Text = "0000";
            TxtMontoFact.Text = "0.00";
            TxtImporte.Text = "0.00";
            TxtComentarios.Clear();
            BtnQuitar.Enabled = true;
            errorIcono.Clear();
        }
        private void CrearTabla()
        {
            this.DtDetalles.Columns.Clear();
            this.DtDetalles.Columns.Add("Empresa", System.Type.GetType("System.String"));
            this.DtDetalles.Columns.Add("Concepto", System.Type.GetType("System.String"));
            this.DtDetalles.Columns.Add("Fecha", System.Type.GetType("System.DateTime"));
            this.DtDetalles.Columns.Add("Documento", System.Type.GetType("System.String"));
            this.DtDetalles.Columns.Add("Serie FEL", System.Type.GetType("System.String"));
            this.DtDetalles.Columns.Add("No FEL", System.Type.GetType("System.String"));
            this.DtDetalles.Columns.Add("Total Fact", System.Type.GetType("System.Decimal"));
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
            dtgwDetalle.Columns[4].HeaderText = "Serie FEL";
            dtgwDetalle.Columns[5].Width = 100;
            dtgwDetalle.Columns[5].HeaderText = "No FEL";
            dtgwDetalle.Columns[6].Width = 100;
            dtgwDetalle.Columns[6].HeaderText = "Total Fact";
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
            CbbEmpresa.SelectedIndex = -1;
            CbbConcepto.SelectedIndex = -1;
            CbbMoneda.SelectedIndex = -1;
            BtnQuitar.Enabled = true;
            CbbMoneda.Enabled = true;
            BtnImprimir.Enabled = false;
            DtpFechaBor.Enabled = true;
            TxtImporte.Text = "0.00";
        }
        private void TotalDocs()
        {

            for (int numColumna = 8; numColumna < dtgwDetalle.Columns.Count; numColumna++)
            {
                decimal sumTotal = 0;
                foreach (DataGridViewRow row in dtgwDetalle.Rows)
                {
                    sumTotal += Convert.ToDecimal(row.Cells[numColumna].Value);
                }
                TxtTototalBorr.Text = sumTotal.ToString();//Aqui en cada iteración del for deberia ser el textbox correspondiente
            }

        }
        private void FiltrarSerie()
        {
            try
            {
                RegistroID = NBorradoresNC.BuscarSerie(CbbEmpresa.Text);
                DataRow Fila = (DataRow)RegistroID.Rows[0];
                Serie = Convert.ToString(Fila["SERIE"]);

                TxtIdBorr.Text = Convert.ToString(Serie);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void CargarSumAcum()
        {
            try
            {
                RegAcum = NBorradoresNC.CargarAcum(TxtDoc.Text, CbbEmpresa.Text);
                DataRow Fila = (DataRow)RegAcum.Rows[0];
                MontoAcum = Convert.ToDecimal(Fila["MONTO"]);
                TxtTotalAcum.Text = Convert.ToString(MontoAcum);
            }
            catch (Exception ex)
            {
                TxtTotalAcum.Text = "0.00";

                //  MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void FrmBorradores_Load(object sender, EventArgs e)
        {
            TxtUsr.Text = IdUsuario;
            BtnDocumentos.Enabled = false;
            if (Depto == "AGENTE")
            {
                TxtAgente.Text = Nombre;
            }
            else { TxtAgente.Text = ""; }
            BtnAgregar.Enabled = false;
            CrearTabla();
            TxtImporte.Text = "0.00";
            BtnImprimir.Enabled = false;
            BtnClientes.Enabled = false;
            BtnDocumentos.Enabled = false;

            if (CbbEmpresa.Text != string.Empty)
            {
                BtnClientes.Enabled = true;
            }
            else
            {
                BtnClientes.Enabled = false;
            }
            if (CbbConcepto.Text != string.Empty)
            {
                BtnDocumentos.Enabled = true;
            }
            else { BtnDocumentos.Enabled = false; }
            ListarAct();
            ListarSeg();
        }
        private void BtnClientes_Click(object sender, EventArgs e)
        {
            CbbEmpresa.Enabled = false;
            BtnDocumentos.Enabled = true;
            if (CbbEmpresa.Text == string.Empty)
            {
                this.MensajeError("Falta Seleccionar Datos para continuar con la accion.");
                errorIcono.SetError(CbbEmpresa, "Seleccione una empresa!");
            }
            else
            {
                LimpiarDet();
                FrmClientes ConsultaCliente = new FrmClientes();
                //Variables.NombreCliente = txtNomDesp.Text;
                Variables.Empresa = CbbEmpresa.Text;
                Variables.Agente = TxtAgente.Text;
                Variables.IdUsuario = TxtUsr.Text;
                ConsultaCliente.ShowDialog();
                TxtIdCliente.Text = Variables.CodCliente;
                TxtNomCliente.Text = Variables.NombreCliente;
                TxtNit.Text = Variables.NIT;
                TxtDirCliente.Text = Variables.Direccion;
                CbbMoneda.Text = Variables.Moneda;
                TxtCorreo.Text = Variables.Correo;


                TxtAgente.Text = Variables.Agente;


            }
        }
        private void BtnDocumentos_Click(object sender, EventArgs e)
        {
            if (TxtAgente.Text == string.Empty || CbbEmpresa.Text == string.Empty)
            {
                this.MensajeError("Falta Ingresar Datos para Realizar Busqueda del Documento!");
            }
            else
            {
                FrmFacturasCL_BorrNC ConsultaFacturas = new FrmFacturasCL_BorrNC();
                Variables.Empresa = CbbEmpresa.Text;
                Variables.Agente = TxtAgente.Text;
                Variables.CodCliente = TxtIdCliente.Text;
                ConsultaFacturas.ShowDialog();
                if (Variables.Cantidad > 0)
                {
                    TxtDoc.Text = Variables.Factura;
                    DtpFechaDoc.Value = Variables.FechaFact;
                    TxtSerieFel.Text = Variables.SerieFel;
                    TxtNumFel.Text = Variables.NoFel;
                    TxtMontoFact.Text = Variables.MontoFact;
                    CbbMoneda.Text = Variables.Moneda;
                    BtnAgregar.Enabled = true;
                }
                else
                {
                    this.MensajeOk("No hay documentos seleccionados del cliente");
                    LimpiarDet();
                }
            }
            if (TxtDoc.Text == string.Empty)
            {

            }
            else { CargarSumAcum(); }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            bool agregar = true;

            if (CbbConcepto.Text == string.Empty || TxtDoc.Text == string.Empty || TxtImporte.Text == string.Empty || TxtComentarios.Text == string.Empty)
            {
                this.MensajeError("Faltan Ingresar Datos, Favor Llenar los Espacios Requeridos!");
            }
            else if (DtpFechaDoc.Value.Date <= DtpFechaBor.Value.Date)
            {
                string Resp = "";
                Resp = NBorradoresNC.Existe(TxtDoc.Text, CbbEmpresa.Text, TxtIdCliente.Text);

                if (Resp.Equals("0"))
                {
                    foreach (DataRow FilaTemp in DtDetalles.Rows)
                    {
                        if (Convert.ToString(FilaTemp["Documento"]) == TxtDoc.Text)
                        {
                            agregar = false;
                            this.MensajeError("El documento ya esta agregado en el Detalle");
                        }
                    }
                    if (agregar)
                    {
                        if ((Convert.ToDecimal(TxtMontoFact.Text) - (Convert.ToDecimal(TxtTotalAcum.Text) + Convert.ToDecimal(TxtImporte.Text))) < 0)
                        {
                            this.MensajeError("El importe sobrepasa el valor de la factura");
                            LimpiarDet();
                        }
                        else
                        {
                            DataRow Fila = DtDetalles.NewRow();

                            Fila["Empresa"] = CbbEmpresa.Text;
                            Fila["Concepto"] = CbbConcepto.Text;
                            Fila["Fecha"] = DtpFechaDoc.Value;
                            Fila["Documento"] = TxtDoc.Text;
                            Fila["Serie FEL"] = TxtSerieFel.Text;
                            Fila["No FEL"] = TxtNumFel.Text;
                            Fila["Total Fact"] = TxtMontoFact.Text;
                            Fila["Descripcion"] = TxtComentarios.Text;
                            Fila["Importe"] = TxtImporte.Text;
                            this.DtDetalles.Rows.Add(Fila);
                            TotalDocs();
                        }
                    }
                    LimpiarDet();
                }
                else
                {
                    if ((Convert.ToDecimal(TxtMontoFact.Text) - (Convert.ToDecimal(TxtTotalAcum.Text) + Convert.ToDecimal(TxtImporte.Text))) < 0)
                    {
                        this.MensajeError("El Documento ya existe en otro Borrador de NC y/o sobrepasa el valor de la factura");
                        LimpiarDet();
                    }
                    else
                    {
                        foreach (DataRow FilaTemp in DtDetalles.Rows)
                        {
                            if (Convert.ToString(FilaTemp["Documento"]) == TxtDoc.Text)
                            {
                                agregar = false;
                                this.MensajeError("El documento ya esta agregado en el Detalle");
                            }
                        }
                        if (agregar)
                        {
                            DataRow Fila = DtDetalles.NewRow();

                            Fila["Empresa"] = CbbEmpresa.Text;
                            Fila["Concepto"] = CbbConcepto.Text;
                            Fila["Fecha"] = DtpFechaDoc.Value;
                            Fila["Documento"] = TxtDoc.Text;
                            Fila["Serie FEL"] = TxtSerieFel.Text;
                            Fila["No FEL"] = TxtNumFel.Text;
                            Fila["Total Fact"] = TxtMontoFact.Text;
                            Fila["Descripcion"] = TxtComentarios.Text;
                            Fila["Importe"] = TxtImporte.Text;
                            this.DtDetalles.Rows.Add(Fila);
                            TotalDocs();
                        }
                        LimpiarDet();
                    }
                }
            }
            else
            {
                this.MensajeError("Fecha de documento no puede ser mayor a la fecha del Borrador");
                LimpiarDet();
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dtgwDetalle.DataSource;
            dt.Clear();
            dtgwDetalle.Refresh();
            dtgwDetalle.DataSource = "";
            Recargar();
            LimpiarDet();
            LimpiarEnc();
            ListarAct();
            ListarSeg();
            BtnImprimir.Enabled = false;
            tabControl1.SelectedIndex = 0;
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            this.FiltrarSerie();
            try
            {
                string Rpta = "";
                if (CbbEmpresa.Text == string.Empty || TxtIdCliente.Text == string.Empty || TxtAgente.Text == string.Empty || TxtUsr.Text == string.Empty || TxtNit.Text == string.Empty || dtgwDetalle.Rows.Count == 0 || CbbMoneda.Text == string.Empty)
                {
                    this.MensajeError("Faltan Ingresar Datos, Seran Remarcados.");
                    errorIcono.SetError(CbbEmpresa, "Seleecione Empresa!");
                    errorIcono.SetError(TxtIdCliente, "Ingrese un cliente!");
                    errorIcono.SetError(TxtAgente, "No hay Seleccionado un agente!");
                    errorIcono.SetError(TxtUsr, "Ingrese Usr!");
                    errorIcono.SetError(TxtNit, "Ingrese NIT!");
                    errorIcono.SetError(CbbMoneda, "Ingrese Moneda!");
                    errorIcono.SetError(dtgwDetalle, "Ingrese Alguna Linea!");
                }
                else
                {
                    Rpta = NBorradoresNC.Insertar(TxtIdBorr.Text, DtpFechaBor.Value, CbbEmpresa.Text, TxtIdCliente.Text, TxtNomCliente.Text, TxtNit.Text, TxtDirCliente.Text, TxtCorreo.Text, TxtTototalBorr.Text, TxtUsr.Text, TxtAgente.Text, CbbMoneda.Text, DtDetalles);
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se Inserto de Forma Correcta el Registro");

                        Reportes.FrmReporteBorr reporte = new Reportes.FrmReporteBorr();
                        Variables.IdRem = TxtIdBorr.Text;
                        Variables.Empresa = CbbEmpresa.Text;
                        reporte.ShowDialog();

                        BtnImprimir.Enabled = true;
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
                ListarAct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            if (dtgwDetalle.SelectedRows.Count > 0)
            {
                dtgwDetalle.Rows.Remove(dtgwDetalle.CurrentRow);

            }
            TotalDocs();
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarDet();
            LimpiarEnc();
            BtnImprimir.Enabled = false;
            DataTable dt = (DataTable)dtgwDetalle.DataSource;
            dt.Clear();
            dtgwDetalle.Refresh();
            dtgwDetalle.DataSource = "";
            Recargar();
            //BtnClientes.Enabled = false;
            CbbEmpresa.Enabled = true;
        }
        private void CbbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbbEmpresa.Text != string.Empty)
            {
                BtnClientes.Enabled = true;
            }
            else
            {
                BtnClientes.Enabled = false;
            }
        }
        private void CbbConcepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbbConcepto.Text != string.Empty)
            {
                BtnDocumentos.Enabled = true;
            }
            else { BtnDocumentos.Enabled = false; }
        }
        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            Reportes.FrmReporteBorr reporte = new Reportes.FrmReporteBorr();
            Variables.IdRem = TxtIdBorr.Text;
            Variables.Empresa = CbbEmpresa.Text;
            reporte.ShowDialog();
        }
        private void DgvListaBorr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BtnGuardar.Enabled = false;
                BtnImprimir.Enabled = true;
                BtnQuitar.Enabled = false;
                CbbEmpresa.Enabled = false;
                CbbMoneda.Enabled = false;
                tabControl1.SelectedIndex = 1;
                TxtIdBorr.Text = Convert.ToString(DgvListaBorr.CurrentRow.Cells["BORRADOR"].Value);
                CbbEmpresa.Text = Convert.ToString(DgvListaBorr.CurrentRow.Cells["EMPRESA"].Value);
                TxtNit.Text = Convert.ToString(DgvListaBorr.CurrentRow.Cells["NIT"].Value);
                TxtDirCliente.Text = Convert.ToString(DgvListaBorr.CurrentRow.Cells["DIRECCION"].Value);
                DtpFechaBor.Value = DateTime.Parse(DgvListaBorr.CurrentRow.Cells["FECHA"].Value.ToString());
                TxtIdCliente.Text = Convert.ToString(DgvListaBorr.CurrentRow.Cells["CODIGO"].Value);
                TxtNomCliente.Text = Convert.ToString(DgvListaBorr.CurrentRow.Cells["NOMBRE"].Value);
                TxtAgente.Text = Convert.ToString(DgvListaBorr.CurrentRow.Cells["AGENTE"].Value);
                CbbMoneda.Text = Convert.ToString(DgvListaBorr.CurrentRow.Cells["MONEDA"].Value);
                TxtTototalBorr.Text = Convert.ToString(DgvListaBorr.CurrentRow.Cells["TOTAL"].Value);
                this.ListarDet();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la Celda #Borrador." + "| Error:" + ex.Message);
            }
        }
        private void DgvSeguimiento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtBorrSeg.Text = Convert.ToString(DgvSeguimiento.CurrentRow.Cells["BORRADOR"].Value);
                TxtEmprSeg.Text = Convert.ToString(DgvSeguimiento.CurrentRow.Cells["EMPRESA"].Value);
                BtnImprSeg.Enabled = true;
                this.ListarDet();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la Celda #Borrador." + "| Error:" + ex.Message);
            }
        }
        private void BtnImprSeg_Click(object sender, EventArgs e)
        {
            Reportes.FrmReporteBorr reporte = new Reportes.FrmReporteBorr();
            Variables.IdRem = TxtBorrSeg.Text;
            Variables.Empresa = TxtEmprSeg.Text;
            reporte.ShowDialog();
            ListarSeg();
            BtnImprSeg.Enabled = false;
            TxtEmprSeg.Clear();
            TxtBorrSeg.Clear();
        }
    }
}