using System;
using System.Windows.Forms;

namespace SistemaRecibos.Reportes
{
    public partial class FrmReportesGen : Form
    {
        public FrmReportesGen()
        {
            InitializeComponent();
        }
        private void FrmReportesGen_Load(object sender, EventArgs e)
        {


        }
        private void BtnInforAut_Click(object sender, EventArgs e)
        {
            this.mA_BorradorNCGenXFechaTableAdapter.Fill(this.dataSet1.MA_BorradorNCGenXFecha, DtpFinicial.Value, DtpFFinal.Value);
            this.reportViewer1.RefreshReport();
        }
        private void BtnInfBorrFormat_Click(object sender, EventArgs e)
        {
            if (CbbEmpresa.Text == string.Empty & TxtIdBorr.Text == string.Empty)
            {
                MessageBox.Show("Debe de llenar las casillas con informacion");
            }
            else
            {
                this.mA_BorradorNCGenTableAdapter.Fill(this.dataSet1.MA_BorradorNCGen, CbbEmpresa.Text, TxtIdBorr.Text);
                this.reportViewer2.RefreshReport();
            }
        }
        private void BtnAbiertos_Click(object sender, EventArgs e)
        {
            this.mA_BorradorNCGenXFechaAbiertosTableAdapter.Fill(this.dataSet1.MA_BorradorNCGenXFechaAbiertos, DtpIniAbiertos.Value, DtpFinAbiertos.Value);
            this.reportViewer3.RefreshReport();
        }
    }
}
