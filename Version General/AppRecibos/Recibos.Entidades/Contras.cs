using System;
using System.Data;

namespace Recibos.Entidades
{
    public class Contras
    {
        public string ID_CONTRA { get; set; }
        public string TIPO_CONTRA { get; set; }
        public string ID_EMPRESA { get; set; }
        public DateTime FECHA_CONTRA { get; set; }
        public string COD_PROVEEDOR { get; set; }
        public string NOMBRE { get; set; }
        public string NIT { get; set; }
        public string DIR_PROVEEDOR { get; set; }
        public string MONEDA { get; set; }
        public string CONDICIONES { get; set; }
        public DateTime FECHA_PAGO { get; set; }
        public string PLANTA { get; set; }
        public decimal TOTAL_FACT { get; set; }
        public decimal TOTAL_RETEN { get; set; }
        public decimal TOTAL_PAGO { get; set; }
        public string USR_REGISTRO { get; set; }
        public DateTime FECHA_REGISTRO { get; set; }
        public string STATUS { get; set; }
        public DateTime F_ANULACION { get; set; }
        public string USR_ANULA { get; set; }
        public string MOTIVO { get; set; }
        public DataTable Detalles { get; set; }
        public string CAT_LIQUIDACION { get; set; } //Agregamos un nuevo dato que viene del procedimiento
    }
}
