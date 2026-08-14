using Microsoft.Reporting.WinForms;
using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace SistemaRecibos.Reportes
{
    public partial class FrmReporteContras : Form
    {
        public FrmReporteContras()
        {
            InitializeComponent();
        }
        private void EnviarReportePorCorreo(string destinatario, string asunto, string mensaje, string rutaRdlc, string nombrePdf)
        {
            try
            {

                byte[] pdfBytes;
                using (ReportViewer reportViewer = new ReportViewer())
                {
                    reportViewer.LocalReport.ReportPath = rutaRdlc; 
                    reportViewer.LocalReport.Refresh();                                                   
                    pdfBytes = reportViewer.LocalReport.Render("PDF");
                }
               
                using (MailMessage mm = new MailMessage("reportes@k-66.net", destinatario))
                {
                    mm.Subject = asunto;
                    mm.Body = mensaje;
                    mm.IsBodyHtml = true;
                    using (MemoryStream ms = new MemoryStream(pdfBytes))
                    {
                        mm.Attachments.Add(new Attachment(ms, nombrePdf + ".pdf"));
                    }             
                    using (SmtpClient smtp = new SmtpClient("reportes@k-66.net"))
                    {
                        smtp.Port = 587; 
                        smtp.EnableSsl = true;
                        smtp.Credentials = new NetworkCredential("reportes@k-66.net", "Rpt911It##@@k66_22");
                        smtp.Send(mm);
                    }
                }
                MessageBox.Show("El correo con el reporte se envió exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrmReporteContras_Load(object sender, EventArgs e)
        {
            CbbDirecciones.Text = Variables.Correo; //Se agrega el text al txt de correo
            CbbCopia.Text = "recepcion@K-66.net,pgarcia@k-66.net,pagos2@k-66.net,pagos3@k-66.net";
            mA_CxP_Contras_GeneralTableAdapter.Fill(dataSet1.MA_CxP_Contras_General, Variables.Empresa, Variables.IdContra);
            TxtAsunto.Text = "Contraseña de Pago - No. " + Variables.IdContra;
            this.reportViewer1.RefreshReport();
        }
        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            if (CbbDirecciones.Text == string.Empty)
            {
                MessageBox.Show("No hay Direcciones Seleccionadas para enviar su correo");
            }
            else
            {             
                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string filename_extension;

                byte[] bytes = reportViewer1.LocalReport.Render("PDF", null, out mimeType, out encoding, out filename_extension, out streamids, out warnings);

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("reportes@k-66.net");
                mail.To.Add(CbbDirecciones.Text); 
                mail.To.Add(CbbCopia.Text);
                mail.Subject = TxtAsunto.Text;
                mail.Body = TxtCuerpo.Text;

                MemoryStream ms = new MemoryStream(bytes);
                mail.Attachments.Add(new Attachment(ms, Variables.IdContra + ".pdf"));

                SmtpClient smtp = new SmtpClient("smtp-legacy.office365.com");
                smtp.Port = 587; 
                smtp.Credentials = new NetworkCredential("reportes@k-66.net", "Rpt911It##@@k66_22");
                smtp.EnableSsl = true; 

                try
                {
                    smtp.Send(mail);
                    MessageBox.Show("Correo electrónico enviado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al enviar el correo electrónico: " + ex.Message);
                }
            }
        }
    }
}
