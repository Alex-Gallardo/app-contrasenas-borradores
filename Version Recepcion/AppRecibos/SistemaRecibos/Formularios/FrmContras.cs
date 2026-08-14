using Recibos.Negocio;
using System;
using System.Data;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SistemaRecibos.Formularios
{
    public partial class FrmContras : Form
    {
        public FrmContras()
        {
            InitializeComponent();
        }
        public string IdUsuario;
        public string Planta;
        public string Rol;
        public string Serie;
        public string Nombre;
        public string Depto;
        public decimal MontoAcum;

        private DataTable RegAcum = new DataTable();
        private DataTable RegistroID = new DataTable();
        private DataTable DtDetalles = new DataTable();
        protected void CalculoISR()
        {
            TxtTotalDet.Text = Convert.ToString(Convert.ToDecimal(TxtMontoFact.Text) - Convert.ToDecimal(TxtMontoNC.Text));
            double ISR;
            if (CbbtipoContra.Text == "PROVEEDORES")
            {
                switch (CbbRegimen.Text)
                {
                    case "PEQUEÑO CONTRIBUYENTE":
                        TxtISR.Text = "0.00";
                        break;
                    case "PEQUEÑO CONTRIBUYENTE - ELECTRONICO":
                        TxtISR.Text = "0.00";
                        break;
                    /*PARA GRACO 80 % Y LOS DEMAS 15%*/
                    case "RETENCION DEFINITIVA":
                        if ((Convert.ToDecimal(TxtTotalDet.Text) * Convert.ToDecimal(TxtTipoCambio.Text) >= 2800) & (Convert.ToDecimal(TxtTotalDet.Text) * Convert.ToDecimal(TxtTipoCambio.Text) <= 33600))
                        {

                            ISR = (((Convert.ToDouble(TxtTotalDet.Text) * Convert.ToDouble(TxtTipoCambio.Text)) / 1.12) * 0.05) / Convert.ToDouble(TxtTipoCambio.Text);
                            TxtISR.Text = Convert.ToString(Math.Round(ISR, 3));
                        }
                        else if ((Convert.ToDecimal(TxtTotalDet.Text) * Convert.ToDecimal(TxtTipoCambio.Text)) > 33600)
                        {
                            ISR = (((((Convert.ToDouble(TxtTotalDet.Text) * Convert.ToDouble(TxtTipoCambio.Text)) / 1.12) - 30000) * 0.07) + 1500) / Convert.ToDouble(TxtTipoCambio.Text);
                            TxtISR.Text = Convert.ToString(Math.Round(ISR, 3));
                        }
                        else
                        {
                            ISR = 0.00;
                            TxtISR.Text = Convert.ToString(Math.Round(ISR, 3));
                        }
                        break;
                    case "RETENCION DEFINITIVA - 2989":
                        TxtISR.Text = "0.00";
                        break;
                    case "RETENCION DEFINITIVA - AGENTE RETENEDOR":
                        if ((Convert.ToDecimal(TxtTotalDet.Text) * Convert.ToDecimal(TxtTipoCambio.Text) >= 2800) & (Convert.ToDecimal(TxtTotalDet.Text) * Convert.ToDecimal(TxtTipoCambio.Text) <= 33600))
                        {

                            ISR = (((Convert.ToDouble(TxtTotalDet.Text) * Convert.ToDouble(TxtTipoCambio.Text)) / 1.12) * 0.05) / Convert.ToDouble(TxtTipoCambio.Text);
                            TxtISR.Text = Convert.ToString(Math.Round(ISR, 3));
                        }
                        else if ((Convert.ToDecimal(TxtTotalDet.Text) * Convert.ToDecimal(TxtTipoCambio.Text)) > 33600)
                        {
                            ISR = (((((Convert.ToDouble(TxtTotalDet.Text) * Convert.ToDouble(TxtTipoCambio.Text)) / 1.12) - 30000) * 0.07) + 1500) / Convert.ToDouble(TxtTipoCambio.Text);
                            TxtISR.Text = Convert.ToString(Math.Round(ISR, 3));
                        }
                        else
                        {
                            ISR = 0.00;
                            TxtISR.Text = Convert.ToString(Math.Round(ISR, 3));
                        }
                        break;
                    case "SUJETO A PAGOS TRIMESTRALES":
                        TxtISR.Text = "0.00";
                        break;
                    case "SUJETO A PAGOS TRIMESTRALES - 2989":
                        TxtISR.Text = "0.00";
                        break;
                    case "SUJETO A PAGOS TRIMESTRALES - AGENTE RETENEDOR":
                        TxtISR.Text = "0.00";
                        break;
                    case "-":
                        TxtISR.Text = "0.00";
                        break;
                    case "NO RESIDENTES": //Nuevo Regimen, solo quita el 5% ISR
                        ISR = (((Convert.ToDouble(TxtTotalDet.Text) * Convert.ToDouble(TxtTipoCambio.Text))) * 0.05) / Convert.ToDouble(TxtTipoCambio.Text);
                        TxtISR.Text = Convert.ToString(Math.Round(ISR, 3));
                        break;

                }
            } else if (CbbtipoContra.Text == "IMPORTACIONES")
                switch (CbbRegimen.Text)
                {
                    case "PEQUEÑO CONTRIBUYENTE":
                        TxtISR.Text = "0.00";
                        break;
                    case "PEQUEÑO CONTRIBUYENTE - ELECTRONICO":
                        TxtISR.Text = "0.00";
                        break;
                    /*PARA GRACO 80 % Y LOS DEMAS 15%*/
                    case "RETENCION DEFINITIVA":
                        if ((Convert.ToDecimal(TxtTotalDet.Text) * Convert.ToDecimal(TxtTipoCambio.Text) >= 2800) & (Convert.ToDecimal(TxtTotalDet.Text) * Convert.ToDecimal(TxtTipoCambio.Text) <= 33600))
                        {

                            ISR = (((Convert.ToDouble(TxtTotalDet.Text) * Convert.ToDouble(TxtTipoCambio.Text)) / 1.12) * 0.05) / Convert.ToDouble(TxtTipoCambio.Text);
                            TxtISR.Text = Convert.ToString(Math.Round(ISR, 3));
                        }
                        else if ((Convert.ToDecimal(TxtTotalDet.Text) * Convert.ToDecimal(TxtTipoCambio.Text)) > 33600)
                        {
                            ISR = (((((Convert.ToDouble(TxtTotalDet.Text) * Convert.ToDouble(TxtTipoCambio.Text)) / 1.12) - 30000) * 0.07) + 1500) / Convert.ToDouble(TxtTipoCambio.Text);
                            TxtISR.Text = Convert.ToString(Math.Round(ISR, 3));
                        }
                        else
                        {
                            ISR = 0.00;
                            TxtISR.Text = Convert.ToString(Math.Round(ISR, 3));
                        }
                        break;
                    case "RETENCION DEFINITIVA - 2989":
                        TxtISR.Text = "0.00";
                        break;
                    case "RETENCION DEFINITIVA - AGENTE RETENEDOR":
                        if ((Convert.ToDecimal(TxtTotalDet.Text) * Convert.ToDecimal(TxtTipoCambio.Text) >= 2800) & (Convert.ToDecimal(TxtTotalDet.Text) * Convert.ToDecimal(TxtTipoCambio.Text) <= 33600))
                        {

                            ISR = (((Convert.ToDouble(TxtTotalDet.Text) * Convert.ToDouble(TxtTipoCambio.Text)) / 1.12) * 0.05) / Convert.ToDouble(TxtTipoCambio.Text);
                            TxtISR.Text = Convert.ToString(Math.Round(ISR, 3));
                        }
                        else if ((Convert.ToDecimal(TxtTotalDet.Text) * Convert.ToDecimal(TxtTipoCambio.Text)) > 33600)
                        {
                            ISR = (((((Convert.ToDouble(TxtTotalDet.Text) * Convert.ToDouble(TxtTipoCambio.Text)) / 1.12) - 30000) * 0.07) + 1500) / Convert.ToDouble(TxtTipoCambio.Text);
                            TxtISR.Text = Convert.ToString(Math.Round(ISR, 3));
                        }
                        else
                        {
                            ISR = 0.00;
                            TxtISR.Text = Convert.ToString(Math.Round(ISR, 3));
                        }
                        break;
                    case "SUJETO A PAGOS TRIMESTRALES":
                        TxtISR.Text = "0.00";
                        break;
                    case "SUJETO A PAGOS TRIMESTRALES - 2989":
                        TxtISR.Text = "0.00";
                        break;
                    case "SUJETO A PAGOS TRIMESTRALES - AGENTE RETENEDOR":
                        TxtISR.Text = "0.00";
                        break;
                    case "-":
                        TxtISR.Text = "0.00";
                        break;
                    case "NO RESIDENTES": //Nuevo Regimen, solo quita el 5% ISR
                        ISR = (((Convert.ToDouble(TxtTotalDet.Text) * Convert.ToDouble(TxtTipoCambio.Text))) * 0.05) / Convert.ToDouble(TxtTipoCambio.Text);
                        TxtISR.Text = Convert.ToString(Math.Round(ISR, 3));
                        break;

                }
            else{ TxtISR.Text = "0.00"; }
        } // Proveedores
        protected void CalculoIVA()
        {
            double IVA;
            if (CbbtipoContra.Text == "PROVEEDORES")
            {
                switch (CbbRegimen.Text)
                {
                    case "PEQUEÑO CONTRIBUYENTE":
                        if ((Convert.ToDouble(TxtTotalDet.Text) * Convert.ToDouble(TxtTipoCambio.Text)) >= 2500.01)
                        {
                            IVA = ((((Convert.ToDouble(TxtTotalDet.Text) * Convert.ToDouble(TxtTipoCambio.Text)) * 0.05)) / Convert.ToDouble(TxtTipoCambio.Text));
                            TxtIVA.Text = Convert.ToString(Math.Round(IVA, 2));
                        }
                        else
                        {
                            TxtIVA.Text = "0.00";
                        }
                        break;
                    case "PEQUEÑO CONTRIBUYENTE - ELECTRONICO":
                        TxtIVA.Text = "0.00";
                        break;
                    case "RETENCION DEFINITIVA":
                        if (CbbEmpresa.Text == "GRACO")
                        {
                            if ((Convert.ToDecimal(TxtTotalDet.Text) * Convert.ToDecimal(TxtTipoCambio.Text)) >= 2500)
                            {
                                IVA = (((((Convert.ToDouble(TxtTotalDet.Text) * Convert.ToDouble(TxtTipoCambio.Text)) / 1.12) * 0.12) * 0.8) / Convert.ToDouble(TxtTipoCambio.Text));
                                TxtIVA.Text = Convert.ToString(Math.Round(IVA, 2));
                            }
                            else { TxtIVA.Text = "0.00"; }
                        }
                        else if (CbbEmpresa.Text == "FAES" || CbbEmpresa.Text == "BOLIK")
                        {
                            if ((Convert.ToDecimal(TxtTotalDet.Text) * Convert.ToDecimal(TxtTipoCambio.Text)) >= 2500)
                            {
                                IVA = (((((Convert.ToDouble(TxtTotalDet.Text) * Convert.ToDouble(TxtTipoCambio.Text)) / 1.12) * 0.12) * 0.15) / Convert.ToDouble(TxtTipoCambio.Text));
                                TxtIVA.Text = Convert.ToString(Math.Round(IVA, 2));
                            }
                            else { TxtIVA.Text = "0.00"; }
                        }
                        else { TxtIVA.Text = "0.00"; }
                        break;
                    case "RETENCION DEFINITIVA - 2989":
                        TxtIVA.Text = "0.00";
                        break;
                    case "RETENCION DEFINITIVA - AGENTE RETENEDOR":
                        TxtIVA.Text = "0.00";
                        break;
                    case "SUJETO A PAGOS TRIMESTRALES":
                        if (CbbEmpresa.Text == "GRACO")
                        {
                            if ((Convert.ToDecimal(TxtTotalDet.Text) * Convert.ToDecimal(TxtTipoCambio.Text)) >= 2500)
                            {
                                IVA = (((((Convert.ToDouble(TxtTotalDet.Text) * Convert.ToDouble(TxtTipoCambio.Text)) / 1.12) * 0.12) * 0.8) / Convert.ToDouble(TxtTipoCambio.Text));
                                TxtIVA.Text = Convert.ToString(Math.Round(IVA, 2));
                            }
                            else { TxtIVA.Text = "0.00"; }
                        }
                        else if (CbbEmpresa.Text == "FAES" || CbbEmpresa.Text == "BOLIK")
                        {
                            if ((Convert.ToDecimal(TxtTotalDet.Text) * Convert.ToDecimal(TxtTipoCambio.Text)) >= 2500)
                            {
                                IVA = (((((Convert.ToDouble(TxtTotalDet.Text) * Convert.ToDouble(TxtTipoCambio.Text)) / 1.12) * 0.12) * 0.15) / Convert.ToDouble(TxtTipoCambio.Text));
                                TxtIVA.Text = Convert.ToString(Math.Round(IVA, 2));
                            }
                            else { TxtIVA.Text = "0.00"; }
                        }
                        else { TxtIVA.Text = "0.00"; }
                        break;
                    case "SUJETO A PAGOS TRIMESTRALES - 2989":
                        TxtIVA.Text = "0.00";
                        break;
                    case "SUJETO A PAGOS TRIMESTRALES - AGENTE RETENEDOR":
                        TxtIVA.Text = "0.00";
                        break;
                    case "-":
                        TxtIVA.Text = "0.00";
                        break;
                }
            }
            else if (CbbtipoContra.Text == "IMPORTACIONES")
                switch (CbbRegimen.Text)
                {
                    case "PEQUEÑO CONTRIBUYENTE":
                        if ((Convert.ToDouble(TxtTotalDet.Text) * Convert.ToDouble(TxtTipoCambio.Text)) >= 2500.01)
                        {
                            IVA = ((((Convert.ToDouble(TxtTotalDet.Text) * Convert.ToDouble(TxtTipoCambio.Text)) * 0.05)) / Convert.ToDouble(TxtTipoCambio.Text));
                            TxtIVA.Text = Convert.ToString(Math.Round(IVA, 2));
                        }
                        else
                        {
                            TxtIVA.Text = "0.00";
                        }
                        break;
                    case "PEQUEÑO CONTRIBUYENTE - ELECTRONICO":
                        TxtIVA.Text = "0.00";
                        break;
                    case "RETENCION DEFINITIVA":
                        if (CbbEmpresa.Text == "GRACO")
                        {
                            if ((Convert.ToDecimal(TxtTotalDet.Text) * Convert.ToDecimal(TxtTipoCambio.Text)) >= 2500)
                            {
                                IVA = (((((Convert.ToDouble(TxtTotalDet.Text) * Convert.ToDouble(TxtTipoCambio.Text)) / 1.12) * 0.12) * 0.8) / Convert.ToDouble(TxtTipoCambio.Text));
                                TxtIVA.Text = Convert.ToString(Math.Round(IVA, 2));
                            }
                            else { TxtIVA.Text = "0.00"; }
                        }
                        else if (CbbEmpresa.Text == "FAES" || CbbEmpresa.Text == "BOLIK")
                        {
                            if ((Convert.ToDecimal(TxtTotalDet.Text) * Convert.ToDecimal(TxtTipoCambio.Text)) >= 2500)
                            {
                                IVA = (((((Convert.ToDouble(TxtTotalDet.Text) * Convert.ToDouble(TxtTipoCambio.Text)) / 1.12) * 0.12) * 0.15) / Convert.ToDouble(TxtTipoCambio.Text));
                                TxtIVA.Text = Convert.ToString(Math.Round(IVA, 2));
                            }
                            else { TxtIVA.Text = "0.00"; }
                        }
                        else { TxtIVA.Text = "0.00"; }
                        break;
                    case "RETENCION DEFINITIVA - 2989":
                        TxtIVA.Text = "0.00";
                        break;
                    case "RETENCION DEFINITIVA - AGENTE RETENEDOR":
                        TxtIVA.Text = "0.00";
                        break;
                    case "SUJETO A PAGOS TRIMESTRALES":
                        if (CbbEmpresa.Text == "GRACO")
                        {
                            if ((Convert.ToDecimal(TxtTotalDet.Text) * Convert.ToDecimal(TxtTipoCambio.Text)) >= 2500)
                            {
                                IVA = (((((Convert.ToDouble(TxtTotalDet.Text) * Convert.ToDouble(TxtTipoCambio.Text)) / 1.12) * 0.12) * 0.8) / Convert.ToDouble(TxtTipoCambio.Text));
                                TxtIVA.Text = Convert.ToString(Math.Round(IVA, 2));
                            }
                            else { TxtIVA.Text = "0.00"; }
                        }
                        else if (CbbEmpresa.Text == "FAES" || CbbEmpresa.Text == "BOLIK")
                        {
                            if ((Convert.ToDecimal(TxtTotalDet.Text) * Convert.ToDecimal(TxtTipoCambio.Text)) >= 2500)
                            {
                                IVA = (((((Convert.ToDouble(TxtTotalDet.Text) * Convert.ToDouble(TxtTipoCambio.Text)) / 1.12) * 0.12) * 0.15) / Convert.ToDouble(TxtTipoCambio.Text));
                                TxtIVA.Text = Convert.ToString(Math.Round(IVA, 2));
                            }
                            else { TxtIVA.Text = "0.00"; }
                        }
                        else { TxtIVA.Text = "0.00"; }
                        break;
                    case "SUJETO A PAGOS TRIMESTRALES - 2989":
                        TxtIVA.Text = "0.00";
                        break;
                    case "SUJETO A PAGOS TRIMESTRALES - AGENTE RETENEDOR":
                        TxtIVA.Text = "0.00";
                        break;
                    case "-":
                        TxtIVA.Text = "0.00";
                        break;
                }
            else{ TxtIVA.Text = "0.00"; }
        } // Proveedores
        protected void SumaRetenciones()
        {
            TxtRetenciones.Text = Convert.ToString(Math.Round(Convert.ToDecimal(TxtIVA.Text) + Convert.ToDecimal(TxtISR.Text), 2));
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Contraseñas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Contraseñas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ListarAct()
        {
            try
            {
                DgvListaContras.DataSource = NContras.Listar("A", TxtPlanta.Text);
                this.Formato();
                DgvAbiertasLiq.DataSource = NContras.Listar("A", TxtPlanta.Text);
                this.FormatoLiq();
                DgvRechazados.DataSource = NContras.Listar("R", TxtPlanta.Text);
                this.FormatoRec();
                label1total.Text = "Total Registros = " + Convert.ToString(DgvListaContras.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Formato()
        {
            DgvListaContras.Columns[0].Width = 80;
            DgvListaContras.Columns[0].HeaderText = "Empresa";
            DgvListaContras.Columns[1].Width = 80;
            DgvListaContras.Columns[1].HeaderText = "Fecha";
            DgvListaContras.Columns[2].Width = 100;
            DgvListaContras.Columns[2].HeaderText = "#Contraseña";
            DgvListaContras.Columns[3].Width = 70;
            DgvListaContras.Columns[3].HeaderText = "Codigo";
            DgvListaContras.Columns[4].Width = 200;
            DgvListaContras.Columns[4].HeaderText = "Nombre";
            DgvListaContras.Columns[5].Width = 90;
            DgvListaContras.Columns[5].HeaderText = "NIT";
            DgvListaContras.Columns[6].Width = 90;
            DgvListaContras.Columns[6].HeaderText = "Moneda";
            DgvListaContras.Columns[7].Width = 90;
            DgvListaContras.Columns[7].HeaderText = "Total";
            DgvListaContras.Columns[8].Width = 100;
            DgvListaContras.Columns[8].HeaderText = "Registró";
            DgvListaContras.Columns[9].Width = 100;
            DgvListaContras.Columns[9].HeaderText = "Estado";
            DgvListaContras.Columns[10].Width = 100;
            DgvListaContras.Columns[10].HeaderText = "Planta";
        }
        private void FormatoLiq()
        {
            DgvAbiertasLiq.Columns[0].Width = 80;
            DgvAbiertasLiq.Columns[0].HeaderText = "Empresa";
            DgvAbiertasLiq.Columns[1].Width = 80;
            DgvAbiertasLiq.Columns[1].HeaderText = "Fecha";
            DgvAbiertasLiq.Columns[2].Width = 100;
            DgvAbiertasLiq.Columns[2].HeaderText = "#Contraseña";
            DgvAbiertasLiq.Columns[3].Width = 70;
            DgvAbiertasLiq.Columns[3].HeaderText = "Codigo";
            DgvAbiertasLiq.Columns[4].Width = 200;
            DgvAbiertasLiq.Columns[4].HeaderText = "Nombre";
            DgvAbiertasLiq.Columns[5].Width = 90;
            DgvAbiertasLiq.Columns[5].HeaderText = "NIT";
            DgvAbiertasLiq.Columns[6].Width = 90;
            DgvAbiertasLiq.Columns[6].HeaderText = "Moneda";
            DgvAbiertasLiq.Columns[7].Width = 90;
            DgvAbiertasLiq.Columns[7].HeaderText = "Total";
            DgvAbiertasLiq.Columns[8].Width = 100;
            DgvAbiertasLiq.Columns[8].HeaderText = "Registró";
            DgvAbiertasLiq.Columns[9].Width = 100;
            DgvAbiertasLiq.Columns[9].HeaderText = "Estado";
            DgvAbiertasLiq.Columns[10].Width = 100;
            DgvAbiertasLiq.Columns[10].HeaderText = "Planta";
        }
        private void FormatoRec()
        {
            DgvRechazados.Columns[0].Width = 80;
            DgvRechazados.Columns[0].HeaderText = "Empresa";
            DgvRechazados.Columns[1].Width = 80;
            DgvRechazados.Columns[1].HeaderText = "Fecha";
            DgvRechazados.Columns[2].Width = 100;
            DgvRechazados.Columns[2].HeaderText = "#Contraseña";
            DgvRechazados.Columns[3].Width = 70;
            DgvRechazados.Columns[3].HeaderText = "Codigo";
            DgvRechazados.Columns[4].Width = 200;
            DgvRechazados.Columns[4].HeaderText = "Nombre";
            DgvRechazados.Columns[5].Width = 90;
            DgvRechazados.Columns[5].HeaderText = "NIT";
            DgvRechazados.Columns[6].Width = 90;
            DgvRechazados.Columns[6].HeaderText = "Moneda";
            DgvRechazados.Columns[7].Width = 90;
            DgvRechazados.Columns[7].HeaderText = "Total";
            DgvRechazados.Columns[8].Width = 100;
            DgvRechazados.Columns[8].HeaderText = "Registró";
            DgvRechazados.Columns[9].Width = 100;
            DgvRechazados.Columns[9].HeaderText = "Estado";
            DgvRechazados.Columns[10].Width = 100;
            DgvRechazados.Columns[10].HeaderText = "Planta";
        }
        private void LimpiarEnc()
        {
            TxtNit.Clear();
            CbbEmpresa.SelectedIndex = -1;
            CbbtipoContra.SelectedIndex = -1;
            DtpFechaContra.ResetText();
            CbbMoneda.SelectedIndex = -1;
            CbbLiquidacion.SelectedIndex = -1;
            TxtIdProveedor.Clear();
            TxtNomProveedor.Clear();
            TxtNit.Clear();
            TxtDir.Clear();
            TxtCondiciones.Clear();
            DtpFechaPago.ResetText();
            TxtTotalDoc.Clear();
            TxtTotalReten.Clear();
            TxtTotalContra.Clear();
            TxtIdContra.Clear();
            TxtCorreo.Clear();
            BtnImprimir.Enabled = false;
            CbbEmpresa.Enabled = true;
            CbbtipoContra.Enabled = true;
            CbbLiquidacion.Enabled = true;
        } //Limpiamos nuestro nuevo txt
        private void LimpiarDet()
        {
            DtpFechaFac.ResetText();
            DtpNotaC.ResetText();
            TxtSerieFact.Clear();
            TxtNumFact.Clear();
            CbbRegimen.SelectedIndex = -1;
            TxtSerieNC.Clear();
            TxtNumNC.Clear();
            TxtIngreso.Clear();
            TxtCorreo.Clear();
            TxtTotalIngreso.Text = "0.00";
            TxtIVA.Text = "0.00";
            TxtISR.Text = "0.00";
            TxtRetenciones.Text = "0.00";
            TxtMontoFact.Text = "0.00";
            TxtTotalDet.Text = "0.00";
            CcbNotas.Checked = false;
            TxtMontoNC.Text = "0.00";
            BtnQuitar.Enabled = true;
        } //Limpiamos el txt de correos
        private void CrearTabla()
        {
            this.DtDetalles.Columns.Clear();
            this.DtDetalles.Columns.Add("Fecha", System.Type.GetType("System.DateTime"));
            this.DtDetalles.Columns.Add("Serie FEL", System.Type.GetType("System.String"));
            this.DtDetalles.Columns.Add("Numero FEL", System.Type.GetType("System.String"));
            this.DtDetalles.Columns.Add("Valor", System.Type.GetType("System.Decimal"));
            this.DtDetalles.Columns.Add("Regimen", System.Type.GetType("System.String"));
            this.DtDetalles.Columns.Add("NC", System.Type.GetType("System.Boolean"));
            this.DtDetalles.Columns.Add("Fecha NC", System.Type.GetType("System.DateTime"));
            this.DtDetalles.Columns.Add("Serie", System.Type.GetType("System.String"));
            this.DtDetalles.Columns.Add("Numero", System.Type.GetType("System.String"));
            this.DtDetalles.Columns.Add("Valor NC", System.Type.GetType("System.Decimal"));
            this.DtDetalles.Columns.Add("Total Doc", System.Type.GetType("System.Decimal"));
            this.DtDetalles.Columns.Add("IVA", System.Type.GetType("System.Decimal"));
            this.DtDetalles.Columns.Add("ISR", System.Type.GetType("System.Decimal"));
            this.DtDetalles.Columns.Add("Total Reten", System.Type.GetType("System.Decimal"));
            this.DtDetalles.Columns.Add("Ingreso", System.Type.GetType("System.String"));
            this.DtDetalles.Columns.Add("Valor Ingreso", System.Type.GetType("System.Decimal"));
            this.DtDetalles.Columns.Add("TC", System.Type.GetType("System.Decimal"));

            dtgwDetalle.DataSource = this.DtDetalles;

            dtgwDetalle.Columns[0].Width = 90;
            dtgwDetalle.Columns[0].HeaderText = "Fecha";

            dtgwDetalle.Columns[1].Width = 110;
            dtgwDetalle.Columns[1].HeaderText = "Serie FEL";

            dtgwDetalle.Columns[2].Width = 110;
            dtgwDetalle.Columns[2].HeaderText = "Numero FEL";

            dtgwDetalle.Columns[3].Width = 90;
            dtgwDetalle.Columns[3].HeaderText = "Valor";
            dtgwDetalle.Columns[3].DefaultCellStyle.Format = "n";
            dtgwDetalle.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dtgwDetalle.Columns[4].Width = 180;
            dtgwDetalle.Columns[4].HeaderText = "Regimen";

            dtgwDetalle.Columns[5].Width = 80;
            dtgwDetalle.Columns[5].HeaderText = "NC";

            dtgwDetalle.Columns[6].Width = 80;
            dtgwDetalle.Columns[6].HeaderText = "Fecha NC";

            dtgwDetalle.Columns[7].Width = 110;
            dtgwDetalle.Columns[7].HeaderText = "Serie";

            dtgwDetalle.Columns[8].Width = 110;
            dtgwDetalle.Columns[8].HeaderText = "Numero";

            dtgwDetalle.Columns[9].Width = 90;
            dtgwDetalle.Columns[9].HeaderText = "Valor NC";
            dtgwDetalle.Columns[9].DefaultCellStyle.Format = "n";
            dtgwDetalle.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dtgwDetalle.Columns[10].Width = 90;
            dtgwDetalle.Columns[10].HeaderText = "Total Doc";
            dtgwDetalle.Columns[10].DefaultCellStyle.Format = "n";
            dtgwDetalle.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dtgwDetalle.Columns[11].Width = 90;
            dtgwDetalle.Columns[11].HeaderText = "IVA";
            dtgwDetalle.Columns[11].DefaultCellStyle.Format = "n";
            dtgwDetalle.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dtgwDetalle.Columns[12].Width = 90;
            dtgwDetalle.Columns[12].HeaderText = "ISR";
            dtgwDetalle.Columns[12].DefaultCellStyle.Format = "n";
            dtgwDetalle.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dtgwDetalle.Columns[13].Width = 90;
            dtgwDetalle.Columns[13].HeaderText = "Total Reten";
            dtgwDetalle.Columns[13].DefaultCellStyle.Format = "n";
            dtgwDetalle.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dtgwDetalle.Columns[14].Width = 100;
            dtgwDetalle.Columns[14].HeaderText = "Ingreso";

            dtgwDetalle.Columns[15].Width = 90;
            dtgwDetalle.Columns[15].HeaderText = "Valor Ingreso";
            dtgwDetalle.Columns[15].DefaultCellStyle.Format = "n";
            dtgwDetalle.Columns[15].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dtgwDetalle.Columns[16].Width = 90;
            dtgwDetalle.Columns[16].HeaderText = "TC";
            dtgwDetalle.Columns[16].DefaultCellStyle.Format = "n";
            dtgwDetalle.Columns[16].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void Recargar()
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            // this.Listar();
            this.CrearTabla();
            CbbEmpresa.SelectedIndex = -1;
            CbbMoneda.SelectedIndex = -1;
            BtnQuitar.Enabled = true;
            CbbMoneda.Enabled = true;
            BtnImprimir.Enabled = false;
            DtpFechaContra.Enabled = true;
            TxtTotalDet.Text = "0.00";
        }
        private void TotalDocs()
        {
            decimal suma = 0;
            decimal suma2 = 0;

            foreach (DataGridViewRow fila in dtgwDetalle.Rows)
            {
                if (!fila.IsNewRow && fila.Cells["Total Doc"].Value != null)
                {
                    suma += Convert.ToDecimal(fila.Cells["Total Doc"].Value);
                }
            }
            foreach (DataGridViewRow fila in dtgwDetalle.Rows)
            {
                if (!fila.IsNewRow && fila.Cells["Total Reten"].Value != null)
                {
                    suma2 += Convert.ToDecimal(fila.Cells["Total Reten"].Value);
                }
            }
            TxtTotalDoc.Text = suma.ToString();
            TxtTotalReten.Text = suma2.ToString();
            TxtTotalContra.Text = (suma - suma2).ToString();
        }
        private void FiltrarSerie()
        {
            try
            {
                RegistroID = NContras.BuscarSerie(CbbEmpresa.Text, TxtPlanta.Text);
                DataRow Fila = (DataRow)RegistroID.Rows[0];
                Serie = Convert.ToString(Fila["SERIE"]);
                TxtIdContra.Text = Convert.ToString(Serie);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void FrmContras_Load(object sender, EventArgs e)
        {
            TxtUsr.Text = IdUsuario;
            TxtPlanta.Text = Planta;      
            CrearTabla();
            ListarAct();
            CbbtipoContra.SelectedIndex = 0;

            if(Depto!= "RECEPCION")
            {
                CbbplantaLiq.Enabled = true;
                CbbPlantaListar.Enabled = true;
                TxtPlanta.Enabled = true;
                cbbPlantaRecha.Enabled = true;
            }
            else
            {
                CbbplantaLiq.Enabled= false;
                CbbPlantaListar.Enabled= false; 
                TxtPlanta.Enabled= false;
                cbbPlantaRecha.Enabled= false;
            }  
        }
        private void CcbNotas_CheckedChanged(object sender, EventArgs e)
        {
            if (CcbNotas.Checked == true)
            {
                DtpNotaC.Enabled = true;
                TxtSerieNC.Enabled = true;
                TxtNumNC.Enabled = true;
                TxtMontoNC.Enabled = true;
            }
            else
            {
                DtpNotaC.Enabled = false;
                TxtSerieNC.Enabled = false;
                TxtNumNC.Enabled = false;
                TxtMontoNC.Enabled = false;

                DtpNotaC.ResetText();
                TxtSerieNC.Clear();
                TxtNumNC.Clear();
                TxtMontoNC.Text = "0.00";
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarDet();
            LimpiarEnc();

            if (dtgwDetalle.SelectedRows.Count > 0)
            {
                DataTable dt = (DataTable)dtgwDetalle.DataSource;
                dt.Clear();
                dtgwDetalle.Refresh();
                dtgwDetalle.DataSource = "";
            }
            tabControl1.SelectedIndex = 0;
            CrearTabla();
        }
        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            CbbEmpresa.Enabled = false;
            CbbtipoContra.Enabled = false;
            CbbLiquidacion.Enabled = false;
            BtnDocumentos.Enabled = true;
            if (CbbEmpresa.Text == string.Empty)
            {
                this.MensajeError("Falta Seleccionar Datos para continuar con la accion.");
                errorIcono.SetError(CbbEmpresa, "Seleccione una empresa!");
            }
            else
            {
                LimpiarDet();
                FrmProveedores ConsultaProveedor = new FrmProveedores();
                Variables.Empresa = CbbEmpresa.Text;
                Variables.IdUsuario = TxtUsr.Text;
                ConsultaProveedor.ShowDialog();
                TxtIdProveedor.Text = Variables.CodProveedor;
                TxtNomProveedor.Text = Variables.NombreProveedor;
                TxtNit.Text = Variables.NIT;
                TxtDir.Text = Variables.Direccion;
                CbbMoneda.Text = Variables.Moneda;
                TxtCondiciones.Text = Variables.Condiciones;
                TxtCorreo.Text = Variables.Correo;  //Se agrega la variable de correo
            }
        } //Correos Cambios Aqui
        private void BtnDocumentos_Click(object sender, EventArgs e)
        {
            if (CbbEmpresa.Text == string.Empty || TxtIdProveedor.Text == string.Empty)
            {
                this.MensajeError("Falta Seleccionar Datos para continuar con la accion.");
                errorIcono.SetError(CbbEmpresa, "Seleccione una empresa!");
            }
            else
            {
                // LimpiarDet();
                FrmIngresosProv ConsultaIngresos = new FrmIngresosProv();
                Variables.Empresa = CbbEmpresa.Text;
                Variables.CodProveedor = TxtIdProveedor.Text;
                ConsultaIngresos.ShowDialog();
                TxtIngreso.Text = Variables.Factura;

                if (Variables.MontoFact == string.Empty)
                { TxtTotalIngreso.Text = "0.00"; }
                else { TxtTotalIngreso.Text = Variables.MontoFact; }
            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            bool agregar = true;
            if (TxtSerieFact.Text == string.Empty || TxtNumFact.Text == string.Empty || TxtMontoFact.Text == string.Empty || CbbRegimen.Text == string.Empty)
            {
                this.MensajeError("Faltan Ingresar Datos, Favor Llenar los Espacios Requeridos!");
            }
            else
            {
                string Resp = "0";
                Resp = NContras.Existe(TxtSerieFact.Text, TxtNumFact.Text, CbbEmpresa.Text, TxtIdProveedor.Text);
                if (Resp.Equals("0"))
                {
                    foreach (DataRow FilaTemp in DtDetalles.Rows)
                    {
                        if (Convert.ToString(FilaTemp["Serie FEL"]) == TxtSerieFact.Text && Convert.ToString(FilaTemp["Numero FEL"]) == TxtNumFact.Text)
                        {
                            agregar = false;
                            this.MensajeError("El documento ya esta agregado en el Detalle");
                        }
                    }
                    if (agregar)
                    {
                        DataRow Fila = DtDetalles.NewRow();
                        Fila["Fecha"] = DtpFechaFac.Value;
                        Fila["Serie FEL"] = TxtSerieFact.Text;
                        Fila["Numero FEL"] = TxtNumFact.Text;
                        Fila["Valor"] = TxtMontoFact.Text;
                        Fila["Regimen"] = CbbRegimen.Text;
                        Fila["NC"] = CcbNotas.Checked;
                        Fila["Fecha NC"] = DtpNotaC.Text;
                        Fila["Serie"] = TxtSerieNC.Text;
                        Fila["Numero"] = TxtNumNC.Text;
                        Fila["Valor NC"] = TxtMontoNC.Text;
                        Fila["Total Doc"] = (TxtTotalDet.Text);
                        Fila["IVA"] = TxtIVA.Text;
                        Fila["ISR"] = TxtISR.Text;
                        Fila["Total Reten"] = TxtRetenciones.Text;
                        Fila["Ingreso"] = TxtIngreso.Text;
                        Fila["Valor Ingreso"] = TxtTotalIngreso.Text;
                        Fila["TC"] = TxtTipoCambio.Text;
                        this.DtDetalles.Rows.Add(Fila);
                    }
                    TotalDocs();
                    LimpiarDet();
                    //   LimpiarDet();
                }

                else if (Resp.Equals("1"))
                {
                    this.MensajeError("Este documento ya existe en otra contraseña");
                }
                TotalDocs();
                LimpiarDet();
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
        private void CbbRegimen_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculoISR();
            CalculoIVA();
            SumaRetenciones();
        }
        private void BtnGuardar_Click(object sender, EventArgs e) //Se validad que el combo no este vacio.
        {
            this.FiltrarSerie();
            try
            {
                string Rpta = "";
                if (CbbEmpresa.Text == string.Empty || CbbtipoContra.Text == string.Empty || TxtIdProveedor.Text == string.Empty || TxtNit.Text == string.Empty || dtgwDetalle.Rows.Count == 0 || CbbMoneda.Text == string.Empty || CbbLiquidacion.Text == string.Empty )
                {
                    this.MensajeError("Faltan Ingresar Datos, Seran Remarcados.");
                    errorIcono.SetError(CbbEmpresa, "Seleecione Empresa!");
                    errorIcono.SetError(TxtIdProveedor, "Ingrese un cliente!");
                    errorIcono.SetError(TxtNomProveedor, "No hay Seleccionado un agente!");
                    errorIcono.SetError(TxtUsr, "Ingrese Usr!");
                    errorIcono.SetError(TxtNit, "Ingrese NIT!");
                    errorIcono.SetError(CbbMoneda, "Ingrese Moneda!");
                    errorIcono.SetError(CbbLiquidacion, "Ingrese Categoria de Liquidacion!");
                    errorIcono.SetError(dtgwDetalle, "Ingrese Alguna Linea!");
                }
                else
                {
                    Rpta = NContras.Insertar(TxtIdContra.Text, CbbtipoContra.Text, CbbEmpresa.Text, DtpFechaContra.Value, TxtIdProveedor.Text, TxtNomProveedor.Text, TxtNit.Text, TxtDir.Text, CbbMoneda.Text, TxtCondiciones.Text, DtpFechaPago.Value, Convert.ToDecimal(TxtTotalDoc.Text), Convert.ToDecimal(TxtTotalReten.Text), Convert.ToDecimal(TxtTotalContra.Text), TxtPlanta.Text, TxtUsr.Text, DtDetalles, CbbLiquidacion.Text); //Agregamos el nuevo campo a guardar
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se Inserto de Forma Correcta el Registro");
                        Reportes.FrmReporteContras reporte = new Reportes.FrmReporteContras();
                        Variables.IdContra = TxtIdContra.Text;
                        Variables.Empresa = CbbEmpresa.Text;
                        reporte.ShowDialog();
                        BtnImprimir.Enabled = true;
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
                LimpiarDet();
                LimpiarEnc();
                ListarAct();
                CrearTabla();
                if (dtgwDetalle.SelectedRows.Count > 0)
                {
                    DataTable dt = (DataTable)dtgwDetalle.DataSource;
                    dt.Clear();
                    dtgwDetalle.Refresh();
                    dtgwDetalle.DataSource = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void CbbMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbbMoneda.Text != "QTZ")
            {
                TxtTipoCambio.Enabled = true;
            }
            else
            {
                TxtTipoCambio.Enabled = false;
                TxtTipoCambio.Text = "1.00";
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarDet();
        }
        private void DgvListaContras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tabControl1.SelectedIndex = 2;
                TxtContraSeg.Text = Convert.ToString(DgvListaContras.CurrentRow.Cells["CONTRASEÑA"].Value);
                TxtEmprSeg.Text = Convert.ToString(DgvListaContras.CurrentRow.Cells["EMPRESA"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la Celda #Contraseña." + "| Error:" + ex.Message);
            }
        }
        private void BtnImprSeg_Click(object sender, EventArgs e)
        {
            if (TxtContraSeg.Text == string.Empty || TxtEmprSeg.Text == string.Empty)
            {
                this.MensajeOk("Se Inserto de Forma Correcta el Registro");
            }
            else
            {
                Reportes.FrmReporteContras reporte = new Reportes.FrmReporteContras();
                Variables.IdContra = TxtContraSeg.Text;
                Variables.Empresa = TxtEmprSeg.Text;
                reporte.ShowDialog();
                BtnImprimir.Enabled = true;
            }
        }
        private void BtnAnularSeg_Click(object sender, EventArgs e)
        {
            if (TxtComentarioAnula.Text == string.Empty)
            {
                TxtComentarioAnula.Visible = true;
                TxtComentarioAnula.Enabled = true;
            }
            else
            {
                string Rpta = "";

                DialogResult opcion;
                opcion = MessageBox.Show("Esta Seguro de Anular este Documento?", "Contraseñas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    Rpta = NContras.Anular(TxtEmprSeg.Text, TxtContraSeg.Text, TxtUsr.Text, TxtComentarioAnula.Text);

                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se ha Anulado el documento");

                        Reportes.FrmReporteContras reporte = new Reportes.FrmReporteContras();
                        Variables.IdContra = TxtContraSeg.Text;
                        Variables.Empresa = TxtEmprSeg.Text;
                        reporte.ShowDialog();
                        ListarAct();
                        tabControl1.SelectedIndex = 0;
                        TxtEmprSeg.Clear();
                        TxtContraSeg.Clear();
                        TxtComentarioAnula.Clear();
                        TxtComentarioAnula.Enabled = false;
                        TxtComentarioAnula.Visible = false;
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            errorIcono.Clear();
            LimpiarDet();
            LimpiarEnc();
            CrearTabla();
            ListarAct();
        }
        private void BtnSegLimpiar_Click(object sender, EventArgs e)
        {
            TxtContraSeg.Clear();
            TxtEmprSeg.Clear();
            TxtComentarioAnula.Clear();
            TxtComentarioAnula.Enabled = false;
            tabControl1.SelectedIndex = 0;
            LimpiarDet();
            LimpiarEnc();

            if (dtgwDetalle.SelectedRows.Count > 0)
            {
                DataTable dt = (DataTable)dtgwDetalle.DataSource;
                dt.Clear();
                dtgwDetalle.Refresh();
                dtgwDetalle.DataSource = "";
            }
            CrearTabla();
        }
        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            if (TxtIdContra.Text == string.Empty || CbbEmpresa.Text == string.Empty)
            {
                this.MensajeOk("Se Inserto de Forma Correcta el Registro");
            }
            else
            {
                Reportes.FrmReporteContras reporte = new Reportes.FrmReporteContras();
                Variables.IdContra = TxtContraSeg.Text;
                Variables.Empresa = TxtEmprSeg.Text;
                reporte.ShowDialog();
                BtnImprimir.Enabled = true;
            }
        }
        private void DgvAbiertasLiq_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                groupBox4.Visible = true;
                txtliqIdContra.Text = Convert.ToString(DgvAbiertasLiq.CurrentRow.Cells["CONTRASEÑA"].Value);
                TxtLiqProveedor.Text = Convert.ToString(DgvAbiertasLiq.CurrentRow.Cells["NOMBRE"].Value);
                DtpFContraLiq.Value = Convert.ToDateTime(DgvAbiertasLiq.CurrentRow.Cells["FECHA"].Value);
                txtEmpresaLiq.Text = Convert.ToString(DgvAbiertasLiq.CurrentRow.Cells["EMPRESA"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la Celda #Contraseña." + "| Error:" + ex.Message);
            }
        }
        private void BtnCancelarLiq_Click(object sender, EventArgs e)
        {
            errorIcono.Clear();
            groupBox4.Visible=false;
           txtliqIdContra.Clear();  
           TxtLiqProveedor.Clear();
            DtpFContraLiq.ResetText();
            dtpLiquidacion.ResetText();
            ListarAct();
        }
        private void BtnLiquidar_Click(object sender, EventArgs e)
        {
                string Rpta = "";
                DialogResult opcion;
                opcion = MessageBox.Show("Esta Seguro de Liquidar este Documento a Contabilidad?", "Contraseñas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    Rpta = NContras.Liquidar(txtEmpresaLiq.Text, txtliqIdContra.Text, TxtUsr.Text, dtpLiquidacion.Value);
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se ha Liquidado el documento");
                    groupBox4.Visible = false;
                    txtliqIdContra.Clear();
                    TxtLiqProveedor.Clear();
                    DtpFContraLiq.ResetText();
                    dtpLiquidacion.ResetText();
                    ListarAct();
                }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
        }
        private void DgvRechazados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tabControl1.SelectedIndex = 2;
                TxtContraSeg.Text = Convert.ToString(DgvRechazados.CurrentRow.Cells["CONTRASEÑA"].Value);
                TxtEmprSeg.Text = Convert.ToString(DgvRechazados.CurrentRow.Cells["EMPRESA"].Value);
                TxtLiqProveedor.Text = Convert.ToString(DgvRechazados.CurrentRow.Cells["NOMBRE"].Value);
                DtpFContraLiq.Value = Convert.ToDateTime(DgvRechazados.CurrentRow.Cells["FECHA"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione desde la Celda #Contraseña." + "| Error:" + ex.Message);
            }
        }
        private void CbbplantaLiq_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DgvAbiertasLiq.DataSource = NContras.Listar("A", CbbplantaLiq.Text);
                this.FormatoLiq();
                label1total.Text = "Total Registros = " + Convert.ToString(DgvListaContras.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void CbbPlantaListar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DgvListaContras.DataSource = NContras.Listar("A", CbbPlantaListar.Text);
                this.Formato();
                label1total.Text = "Total Registros = " + Convert.ToString(DgvListaContras.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void cbbPlantaRecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DgvRechazados.DataSource = NContras.Listar("R", cbbPlantaRecha.Text);
                this.FormatoRec();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            txtliqIdContra.Text = TxtContraSeg.Text;           
            txtEmpresaLiq.Text = TxtEmprSeg.Text;
            tabControl1.SelectedIndex = 3;

            TxtContraSeg.Clear();
            TxtEmprSeg.Clear();
            TxtComentarioAnula.Clear();
            TxtComentarioAnula.Enabled = false;
            LimpiarDet();
            LimpiarEnc();
        }
    }
}