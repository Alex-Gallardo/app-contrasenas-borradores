using System;
using System.Windows.Forms;

namespace SistemaRecibos.Reportes
{
    public partial class FrmReportesCxP : Form
    {
        public string IdUsuario;
        public string Nombre;
        public string Serie;
        public string Planta;
        public string Rol;
        public string Depto;
        public string Categoria;
        public FrmReportesCxP()
        {
            InitializeComponent();
        }
        private void FrmReportesCxP_Load(object sender, EventArgs e)
        {
            CbbPlanta.Text = Planta;
            if (Depto != "RECEPCION")
            {
                CbbPlanta.Enabled = true;
            }
            else
            {
                CbbPlanta.Enabled = false;
            }
            /*this.reportViewer4.RefreshReport();
            this.reportViewer4.RefreshReport();*/
        }
        private void BtnContras1_Click(object sender, EventArgs e)
        {
            this.mA_CXP_CONTRASTableAdapter.Fill(dataSet1.MA_CXP_CONTRAS, DtpFinicial.Value, DtpFFinal.Value, CbbPlanta.Text, IdUsuario, Depto);
            this.reportViewer1.RefreshReport();
        }
        private void BtnLiquidaciones_Click(object sender, EventArgs e)
        {
            this.mA_CXP_CONTRAS_LIQ_CATTableAdapter.Fill(dateSetCat.MA_CXP_CONTRAS_LIQ_CAT, DtpFLiq1.Value, DtpFLiq2.Value, CbbPlantaLiq.Text, IdUsuario, Depto, CbbCategoria.Text);
            this.reportViewer2.RefreshReport();
        }

        private void BtnConta_Click(object sender, EventArgs e)
        {
            this.mA_CXP_CONTRAS_CONTATableAdapter.Fill(dataSet1.MA_CXP_CONTRAS_CONTA, dtpf1Conta.Value, dtpf2Conta.Value, CbbPlantaConta.Text, IdUsuario, Depto);
            this.reportViewer3.RefreshReport();
        }

      
    }
}
