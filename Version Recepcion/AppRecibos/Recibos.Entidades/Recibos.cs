using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recibos.Entidades
{
    public class Recibos
    {
        public string ID_RECIBO { get; set; }
        public DateTime FECHA_RECIBO { get; set; }
        public string ID_EMPRESA { get; set; }
        public string ID_CLIENTE { get; set; }
        public string NOMBRE_CLIENTE { get; set; }
        public string DIRECCION { get; set; }
        public string NIT {get; set; }
        public string AGENTE { get; set; }
        public string CORREO { get; set; }
        public string MONEDA { get; set; }
        public string STATUS { get; set; }
        public Decimal MONTO_COBRO { get; set; }
        public Decimal MONTO_DOC { get; set; }
        public Decimal SALDO {get; set; }
        public string USR_REGISTRA { get; set; }
        public string MOTIVO { get; set; }  
        public string USR_ANULA { get; set; }
        public DataTable DetallesCobro { get; set; }
        public DataTable DetallesDoc { get; set; }
    }
}
