using Recibos.Negocio;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace SistemaRecibos.Formularios
{
    public partial class FrmRecibos : Form
    {
        public string IdUsuario;
        public string Nombre;
        public string Serie;
        public string Depto;
        public string Rol;
        public decimal MontoAcum;

        private DataTable RegAcum = new DataTable();
        private DataTable RegistroID = new DataTable();
        private DataTable DtDetalleCobro = new DataTable();
        private DataTable DtDetalleDoc = new DataTable();
        public FrmRecibos()
        {
            InitializeComponent();
        }
        private void LimpiarEnc()
        {
            TxtIdRecibo.Clear();
            TxtIdCliente.Clear();
            TxtNomCliente.Clear();
            TxtDirCliente.Clear();
            TxtCorreo.Clear();
            TxtNit.Clear();

            DtpFechaRec.ResetText();
            CbbMoneda.SelectedIndex = -1;
            CbbEmpresa.SelectedIndex = -1;
            TxtSumRec.Text = "0.00";
            TxtSumTotalDoc.Text = "0.00";
            TxtTotal.Text = "0.00";
            CbbEmpresa.Enabled = true;
        }
        private void LimpiarDet()
        {
            CbbTipoCobro.SelectedIndex = -1;
            CbbMonCobro.SelectedIndex = -1;
            CbbBanco.SelectedIndex = -1;
            TxtDocCobro.Clear();
            TxtMontoCobro.Text = "0.00";
            DtpFechaCobro.ResetText();
            TxtAgente.Clear();
            CbbTipoDoc.SelectedIndex = -1;
            TxtFel.Clear();
            //TxtNumFel.Clear();  
            TxtDoc.Clear();
            CbbMonDoc.SelectedIndex = -1;
            TxtTotalDoc.Text = "0.00";
            TxtMontoApp.Text = "0.00";
        }
        private void CrearTablaCobros()
        {
            this.DtDetalleCobro.Columns.Clear();
            this.DtDetalleCobro.Columns.Add("Tipo", System.Type.GetType("System.String"));
            this.DtDetalleCobro.Columns.Add("Documento", System.Type.GetType("System.String"));
            this.DtDetalleCobro.Columns.Add("Moneda", System.Type.GetType("System.String"));
            this.DtDetalleCobro.Columns.Add("Banco", System.Type.GetType("System.String"));
            this.DtDetalleCobro.Columns.Add("Fecha", System.Type.GetType("System.DateTime"));
            this.DtDetalleCobro.Columns.Add("Monto", System.Type.GetType("System.Decimal"));


            DtgvCobros.DataSource = this.DtDetalleCobro;

            DtgvCobros.Columns[0].Width = 80;
            DtgvCobros.Columns[0].HeaderText = "Tipo";
            DtgvCobros.Columns[1].Width = 120;
            DtgvCobros.Columns[1].HeaderText = "Documento";
            DtgvCobros.Columns[2].Width = 70;
            DtgvCobros.Columns[2].HeaderText = "Moneda";
            DtgvCobros.Columns[3].Width = 100;
            DtgvCobros.Columns[3].HeaderText = "Banco";
            DtgvCobros.Columns[4].Width = 100;
            DtgvCobros.Columns[4].HeaderText = "Fecha";
            DtgvCobros.Columns[5].Width = 100;
            DtgvCobros.Columns[5].HeaderText = "Monto";

        }

        private void CrearTablaDetalle()
        {
            this.DtDetalleDoc.Columns.Clear();
            this.DtDetalleDoc.Columns.Add("Tipo", System.Type.GetType("System.String"));
            this.DtDetalleDoc.Columns.Add("Documento", System.Type.GetType("System.String"));
            this.DtDetalleDoc.Columns.Add("FEL", System.Type.GetType("System.String"));
            this.DtDetalleDoc.Columns.Add("Total Factura", System.Type.GetType("System.String"));
            this.DtDetalleDoc.Columns.Add("Fecha", System.Type.GetType("System.DateTime"));
            this.DtDetalleDoc.Columns.Add("Pagado", System.Type.GetType("System.Decimal"));
            this.DtDetalleDoc.Columns.Add("Tipo Cobro", System.Type.GetType("System.String"));
            this.DtDetalleDoc.Columns.Add("Total Cobro", System.Type.GetType("System.Decimal"));

            DgvDoctos.DataSource = this.DtDetalleDoc;

            DgvDoctos.Columns[0].Width = 80;
            DgvDoctos.Columns[0].HeaderText = "Tipo";
            DgvDoctos.Columns[1].Width = 120;
            DgvDoctos.Columns[1].HeaderText = "Documento";
            DgvDoctos.Columns[2].Width = 70;
            DgvDoctos.Columns[2].HeaderText = "FEL";
            DgvDoctos.Columns[3].Width = 100;
            DgvDoctos.Columns[3].HeaderText = "Total Factura";
            DgvDoctos.Columns[4].Width = 100;
            DgvDoctos.Columns[4].HeaderText = "Fecha";
            DgvDoctos.Columns[5].Width = 100;
            DgvDoctos.Columns[5].HeaderText = "Pagado";
            DgvDoctos.Columns[6].Width = 100;
            DgvDoctos.Columns[6].HeaderText = "Tipo Cobro";
            DgvDoctos.Columns[7].Width = 100;
            DgvDoctos.Columns[7].HeaderText = "Total Cobro";

        }//Cod Nuevo
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema AppK66", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Appk66", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FrmRecibos_Load(object sender, EventArgs e)
        {
            BtnBusDoc.Enabled = false;
            CbbMoneda.SelectedIndex = -1;
            CbbMonDoc.SelectedIndex = -1;
            CbbMonCobro.SelectedIndex = -1;
            CbbEmpresa.SelectedIndex = -1;
            CbbTipoCobro.SelectedIndex = -1;
            CbbBanco.SelectedIndex = -1;
            CbbTipoDoc.SelectedIndex = -1;
            TxtUsr.Text = IdUsuario;
            BtnBusDoc.Enabled = false;
            TxtSumRec.Text = "0.00";
            TxtSumTotalDoc.Text = "0.00";
            TxtTotal.Text = "0.00";
            TxtMontoCobro.Text = "0.00";
            TxtTotalDoc.Text = "0.00";
            TxtMontoApp.Text = "0.00";
            CrearTablaCobros();
            CrearTablaDetalle();

            if (Depto == "AGENTE")
            {
                TxtAgente.Text = Nombre;
            }
            else { TxtAgente.Text = ""; }
        }
        private void BtnClientes_Click(object sender, EventArgs e)
        {
            CbbEmpresa.Enabled = false;
            BtnBusDoc.Enabled = true;
            if (CbbEmpresa.Text == string.Empty)
            {
                this.MensajeError("Falta Seleccionar Datos para continuar con la accion.");
                errorIcono.SetError(CbbEmpresa, "Seleccione una empresa!");
            }
            else
            {
                Variables.Empresa = CbbEmpresa.Text;
                Variables.Agente = TxtAgente.Text;
                Variables.IdUsuario = TxtUsr.Text;
                FrmClientes ConsultaCliente = new FrmClientes();
                ConsultaCliente.ShowDialog();
                TxtIdCliente.Text = Variables.CodCliente;
                TxtNomCliente.Text = Variables.NombreCliente;
                TxtNit.Text = Variables.NIT;
                TxtDirCliente.Text = Variables.Direccion;
                CbbMoneda.Text = Variables.Moneda;
                CbbMonCobro.Text = Variables.Moneda;
                CbbMonDoc.Text = Variables.Moneda;
                TxtCorreo.Text = Variables.Correo;
                TxtAgente.Text = Variables.Agente;
                BtnBusDoc.Enabled = true;
            }
        }
        private void CbbTipoCobro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbbTipoCobro.Text == "EFECTIVO")
            {
                TxtDocCobro.Enabled = false;
                CbbBanco.Enabled = false;
            }
            else
            {
                CbbBanco.SelectedIndex = -1;
                TxtDocCobro.Clear();
                TxtDocCobro.Enabled = false;
                TxtDocCobro.Enabled = true;
                CbbBanco.Enabled = true;
                DtpFechaCobro.ResetText();
            }
        }
        private void CbbTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbbTipoDoc.Text == "ANTICIPO")
            {
                TxtDoc.Enabled = false;
                DtpFechaDoc.Enabled = false;
                // TxtNumFel.Enabled = false;
                TxtFel.Enabled = false;
                TxtTotalDoc.Enabled = false;
            }
            else
            {
                DtpFechaDoc.Enabled = false;
            }
        }
        private void BtnBusDoc_Click(object sender, EventArgs e)
        {
            if (TxtAgente.Text == string.Empty || CbbEmpresa.Text == string.Empty || CbbTipoDoc.Text == string.Empty)
            {
                this.MensajeError("Falta Ingresar Datos para Realizar Busqueda del Documento!");
            }
            else
            {
                FrmFacturarasCL_Recibos ConsultaFacturasRC = new FrmFacturarasCL_Recibos();
                Variables.Tipo = CbbTipoDoc.Text;
                Variables.Empresa = CbbEmpresa.Text;
                Variables.Agente = TxtAgente.Text;
                Variables.CodCliente = TxtIdCliente.Text;
                ConsultaFacturasRC.ShowDialog();
                if (Variables.Cantidad > 0)
                {
                    TxtDoc.Text = Variables.Factura;
                    DtpFechaDoc.Value = Variables.FechaFact;
                    TxtFel.Text = Convert.ToString(Variables.SerieFel + " - " + Variables.NoFel);
                    TxtTotalDoc.Text = Convert.ToString(Math.Round(Convert.ToDecimal(Variables.MontoFact), 2));
                    TxtMontoApp.Text = Convert.ToString(Math.Round((Convert.ToDecimal(Variables.MontoFact) - Variables.Pagado), 2));
                    TxtPagado.Text = Convert.ToString(Math.Round(Variables.Pagado, 2));
                    CbbMonDoc.Text = Variables.Moneda;
                }
                else
                {
                    this.MensajeOk("No hay documentos seleccionados del cliente");
                    LimpiarDet();
                }
            }
        }
        private void CbbTipoDoc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CbbTipoDoc.Text == "FACTURA" || CbbTipoDoc.Text == "PEDIDO")
            {
                BtnBusDoc.Enabled = true;
            }
            else { BtnBusDoc.Enabled = false; }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarDet();
            LimpiarEnc();
        }
        private void BtnAgregarCobro_Click(object sender, EventArgs e)
        {
            bool agregar = true;
            if (CbbTipoCobro.Text == string.Empty || CbbMonCobro.Text == string.Empty || TxtMontoCobro.Text == "0.00" || TxtMontoCobro.Text == string.Empty)
            {
                this.MensajeError("Faltan Ingresar Datos, Favor Llenar los Espacios Requeridos!");
            }
            else if (DtpFechaDoc.Value.Date <= DtpFechaRec.Value.Date)
            {
                string Resp = "";
                Resp = NRecibos.Existe(TxtDoc.Text, CbbEmpresa.Text, TxtIdCliente.Text, TxtIdCliente.Text);
                // if (Resp.Equals("0"))
                if (CbbTipoCobro.Text != "EFECTIVO")
                {
                    foreach (DataRow FilaTemp in DtDetalleCobro.Rows)
                    {
                        if (Convert.ToString(FilaTemp["Documento"]) == TxtDoc.Text)
                        {
                            agregar = false;
                            this.MensajeError("El Documento ya esta agregado en el Detalle");
                        }
                    }
                    if (agregar)
                    {
                        DataRow Fila = DtDetalleCobro.NewRow();
                        Fila["Tipo"] = CbbTipoCobro.Text;
                        Fila["Documento"] = TxtDocCobro.Text;
                        Fila["Moneda"] = CbbMonCobro.Text;
                        Fila["Banco"] = CbbBanco.Text;
                        Fila["Fecha"] = DtpFechaCobro.Value;
                        Fila["Monto"] = TxtMontoCobro.Text;
                        this.DtDetalleCobro.Rows.Add(Fila);
                        // TotalDocs();             
                    }
                    LimpiarDet();
                }
                else
                {
                    if (agregar)
                    {
                        DataRow Fila = DtDetalleCobro.NewRow();
                        Fila["Tipo"] = CbbTipoCobro.Text;
                        Fila["Documento"] = TxtDocCobro.Text;
                        Fila["Moneda"] = CbbMonCobro.Text;
                        Fila["Banco"] = CbbBanco.Text;
                        Fila["Fecha"] = DtpFechaCobro.Value;
                        Fila["Monto"] = TxtMontoCobro.Text;
                        this.DtDetalleCobro.Rows.Add(Fila);
                        // TotalDocs();             
                    }
                    LimpiarDet();
                }
            }

            //    else
            //    {
            //        if (CbbTipoCobro.Text != "EFECTIVO")
            //        {
            //            foreach (DataRow FilaTemp in DtDetalleCobro.Rows)
            //            {
            //                if (Convert.ToString(FilaTemp["Documento"]) == TxtDoc.Text)
            //                {
            //                    agregar = false;
            //                    this.MensajeError("El documento ya esta agregado en el Detalle");
            //                }
            //            }
            //            if (agregar)
            //            {
            //                DataRow Fila = DtDetalleCobro.NewRow();
            //                Fila["Tipo"] = CbbTipoCobro.Text;
            //                Fila["Documento"] = TxtDocCobro.Text;
            //                Fila["Moneda"] = CbbMonCobro.Text;
            //                Fila["Banco"] = CbbBanco.Text;
            //                Fila["Fecha"] = DtpFechaCobro.Value;
            //                Fila["Monto"] = TxtMontoCobro.Text;
            //                this.DtDetalleCobro.Rows.Add(Fila);
            //                // TotalDocs();
            //            }
            //            LimpiarDet();
            //        }
            //    }
            //}
            //else
            //{
            //    this.MensajeError("Fecha de pago no puede ser mayor a la fecha del Recibo");
            //    LimpiarDet();
            //}
        }

        private void BtnAgregarDoc_Click(object sender, EventArgs e)
        {
            bool agregar = true;
            if (CbbMonDoc.Text == string.Empty || TxtFel.Text == string.Empty ||
                CbbTipoDoc.Text == string.Empty || TxtTotalDoc.Text == string.Empty ||
                TxtPagado.Text == "0.00" || TxtDoc.Text == string.Empty || TxtTotalDoc.Text == "0.00" || TxtMontoApp.Text == string.Empty)
            {
                this.MensajeError("Faltan Ingresar Datos, Favor Llenar los Espacios Requeridos!");
            }


            if (agregar)
            {
                DataRow Fila = DtDetalleDoc.NewRow();
                Fila["Tipo"] = CbbTipoDoc.Text;
                Fila["Documento"] = TxtDoc.Text;
                Fila["FEL"] = TxtFel.Text;
                Fila["Total Factura"] = TxtTotalDoc.Text;
                Fila["Fecha"] = DtpFechaDoc.Value;
                Fila["Pagado"] = TxtPagado.Text;
                Fila["Tipo Cobro"] = CbbMonDoc.Text;
                Fila["Total Cobro"] = TxtMontoApp.Text;
                this.DtDetalleDoc.Rows.Add(Fila);
                // TotalDocs();             
            }
        }

        private void button5_Click(object sender, EventArgs e) { }/*     
            if (string.IsNullOrWhiteSpace(TxtNomCliente.Text) || string.IsNullOrWhiteSpace(TxtIdCliente.Text))
            {
                MessageBox.Show("Datos Incompletos", "Recibos App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Guardar Nuevo Registro", "App Recibos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            string sql = $@"
        INSERT INTO REC_CAJA_ENC (
            ID_RECIBO, ID_EMPRESA, ID_CLIENTE, NOMBRE_CLIENTE, DIRECCION, NIT, 
            AGENTE, CORREO, MONEDA, STATUS, MONTO_T_REC, MONTO_T_DOC, SALDO, 
            USUARIO, FECHA_RECIBO, FECHA_REGISTRO, REC_FISICO
        )
        VALUES (
            (SELECT (SERIE + RIGHT('0000' + CONVERT(NVARCHAR, (NUMERACION + 1), 0), 5)) 
             FROM [dbo].[REC_CAJA_SERIES] 
             WHERE EMPRESA = '{CbbEmpresa.Text}' AND DEPTO = '{txtDepto.Text}'),
            '{CbbEmpresa.Text}', '{TxtIdCliente.Text}', '{TxtNomCliente.Text}', '{TxtDirCliente.Text}', 
            '{TxtNit.Text}', '{TxtAgente.Text}', '{TxtCorreo.Text}', '{CbbMoneda.Text}', 'A',
            {Convert.ToDouble(txtTRec.Text)}, {Convert.ToDouble(TxtDoc.Text)}, {Convert.ToDouble(TxtMontoApp.Text)},
            '{TxtUsr.Text}', '{DtpFechaRec.Value.Date:yyyy-MM-dd}', SYSDATETIME(), '{txtRecFisico.Text}'
        );

        UPDATE [dbo].[REC_CAJA_SERIES] 
        SET NUMERACION = NUMERACION + 1 
        WHERE EMPRESA = '{CbbEmpresa.Text}' AND DEPTO = '{txtDepto.Text}';
    ";

            using (SqlConnection conect = new SqlConnection(obtenerconexion()))
            {
                conect.Open();

                using (SqlCommand comando = new SqlCommand(sql, conect))
                {
                    comando.ExecuteNonQuery();
                }

                SqlDataAdapter adaptador = new SqlDataAdapter(
                    $"SELECT TOP 1 ID_RECIBO, STATUS FROM REC_CAJA_ENC " +
                    $"WHERE USUARIO = '{txtusuario.Text}' AND ID_EMPRESA = '{txtIdEmpresa.Text}' " +
                    $"ORDER BY ID_RECIBO DESC",
                    obtenerconexion()
                );

                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    txtIdRecibo.Text = tabla.Rows[0]["ID_RECIBO"].ToString();
                    txtStatusRec.Text = tabla.Rows[0]["STATUS"].ToString();
                }
            }

            InsertarDet();
            InsertarDet2();

            MessageBox.Show("Registro Realizado", "App Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void InsertarEnc()
        {
        //SumaTotales();

        if (string.IsNullOrWhiteSpace(TxtNomCliente.Text) || string.IsNullOrWhiteSpace(TxtUsr.Text))
        {
            MessageBox.Show("Datos Incompletos", "Recibos App", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        else
        {
            DialogResult result = MessageBox.Show("Guardar Nuevo Registro", "App Recibos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            string sql = $@"
            INSERT INTO REC_CAJA_ENC (
                ID_RECIBO, ID_EMPRESA, ID_CLIENTE, NOMBRE_CLIENTE, DIRECCION, NIT, AGENTE, CORREO,
                MONEDA, STATUS, MONTO_T_REC, MONTO_T_DOC, SALDO, USUARIO, FECHA_RECIBO, FECHA_REGISTRO, REC_FISICO
            )
            VALUES (
                (SELECT (SERIE + RIGHT('0000' + CONVERT(NVARCHAR, (NUMERACION + 1), 0), 5)) 
                 FROM [dbo].[REC_CAJA_SERIES] 
                 WHERE EMPRESA = '{CbbEmpresa.Text}'),
                '{CbbEmpresa.Text}', '{TxtIdCliente.Text}', '{TxtNomCliente.Text}', '{TxtDirCliente.Text}', 
                '{TxtNit.Text}', '{TxtAgente.Text}', '{TxtCorreo.Text}', '{CbbMoneda.Text}', 'A',
                {Convert.ToDouble(TxtSumRec.Text)}, {Convert.ToDouble(TxtSumTotalDoc.Text)}, {Convert.ToDouble(TxtTotal.Text)},
                '{TxtUsr.Text}', '{DtpFechaRec.Value.Date:yyyy-MM-dd}', SYSDATETIME(),);

            UPDATE [dbo].[REC_CAJA_SERIES] 
            SET NUMERACION = NUMERACION + 1 
            WHERE EMPRESA = '{CbbEmpresa.Text}';
        ";

            using (SqlConnection conect = new SqlConnection(CrearConoexion()))
            {
                conect.Open();
                using (SqlCommand comando = new SqlCommand(sql, conect))
                {
                    comando.ExecuteNonQuery();
                }

                SqlDataAdapter adaptador = new SqlDataAdapter(
                    $"SELECT TOP 1 ID_RECIBO, STATUS FROM REC_CAJA_ENC WHERE USUARIO = '{txtusuario.Text}' AND ID_EMPRESA = '{txtIdEmpresa.Text}' ORDER BY ID_RECIBO DESC",
                    obtenerconexion()
                );

                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    txtIdRecibo.Text = tabla.Rows[0]["ID_RECIBO"].ToString();
                    txtStatusRec.Text = tabla.Rows[0]["STATUS"].ToString();
                }
            }

            InsertarDet();
            InsertarDet2();

            MessageBox.Show("Registro Realizado", "App Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public void InsertarDet()
    {
        using (SqlConnection conect = new SqlConnection(obtenerconexion()))
        {
            conect.Open();

            foreach (DataGridViewRow rw in dtgvRecibos.Rows)
            {
                if (rw.IsNewRow) continue;

                string sql = $@"
                INSERT INTO REC_CAJA_COBRO (ID_RECIBO, ID_EMPRESA, TIPO_COBRO, BANCO, FECHA_DOC, NO_DOCUMENTO, MONTO, MONEDA)
                VALUES (
                    (SELECT TOP 1 ID_RECIBO FROM REC_CAJA_ENC WHERE USUARIO = '{txtusuario.Text}' 
                        AND ID_EMPRESA = '{txtIdEmpresa.Text}' ORDER BY ID_RECIBO DESC),
                    '{txtIdEmpresa.Text}', '{rw.Cells[0].Value}', '{rw.Cells[1].Value}',
                    '{Convert.ToDateTime(rw.Cells[2].Value):yyyy-MM-dd}', '{rw.Cells[3].Value}', 
                    {Convert.ToDouble(rw.Cells[4].Value)}, '{rw.Cells[5].Value}'
                )";

                using (SqlCommand cmd = new SqlCommand(sql, conect))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

    public void InsertarDet2()
    {
        using (SqlConnection conect = new SqlConnection(obtenerconexion()))
        {
            conect.Open();

            foreach (DataGridViewRow rw in dtgvDetDoc.Rows)
            {
                if (rw.IsNewRow) continue;

                string sql = $@"
                INSERT INTO REC_CAJA_DET (
                    ID_RECIBO, ID_EMPRESA, TIPO_DOC, NO_DOCUMENTO, FECHA_DOC, STATUS, MONTO, MONEDA, MONTO_FACT, PAGADO
                )
                VALUES (
                    (SELECT TOP 1 ID_RECIBO FROM REC_CAJA_ENC WHERE USUARIO = '{txtusuario.Text}' 
                        AND ID_EMPRESA = '{txtIdEmpresa.Text}' ORDER BY ID_RECIBO DESC),
                    '{txtIdEmpresa.Text}', '{rw.Cells[0].Value}', '{rw.Cells[1].Value}',
                    '{Convert.ToDateTime(rw.Cells[2].Value):yyyy-MM-dd}', '{rw.Cells[4].Value}', 
                    {Convert.ToDouble(rw.Cells[3].Value)}, '{rw.Cells[5].Value}', 
                    {Convert.ToDouble(rw.Cells[6].Value)}, {Convert.ToDouble(rw.Cells[7].Value)}
                )";

                using (SqlCommand cmd = new SqlCommand(sql, conect))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
*/

}
   }
