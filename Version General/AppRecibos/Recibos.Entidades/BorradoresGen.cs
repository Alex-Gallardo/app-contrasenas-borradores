using System;
using System.Data;

namespace Recibos.Entidades
{

    public class BorradoresGen
    {
        public string ID_BORRADOR { get; set; }
        public DateTime FECHA { get; set; }
        public string ID_EMPRESA { get; set; }
        public string ID_CLIENTE { get; set; }
        public string NOMBRE { get; set; }
        public string NIT { get; set; }
        public string DIRECCION { get; set; }
        public string CORREO { get; set; }
        public string TOTAL { get; set; }
        public string ID_USR { get; set; }
        public string AGENTE { get; set; }
        public string STATUS { get; set; }
        public string USR_ANULA { get; set; }
        public string MONEDA { get; set; }
        public string MOTIVO { get; set; }
        public string USR_AUTO { get; set; }
        public DateTime FECHA_AUTO { get; set; }
        public string TIPO_AUTO { get; set; }
        public string MOT_AUTO { get; set; }
        public string REGISTRO { get; set; }
        public DataTable Detalles { get; set; }
    }
}
