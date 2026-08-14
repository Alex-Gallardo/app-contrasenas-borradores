using System;
using System.Data;
using Recibos.Datos;
using Recibos.Entidades;

namespace Recibos.Negocio
{
    public class NContras
    {
        public static string Existe(string seriefel, string numfel, string empresa, string proveedor)
        {
            DContras Datos = new DContras();
            return  Datos.Existe(seriefel, numfel, empresa, proveedor);
        }
        public static DataTable BuscarSerie(string empresa, string planta)
        {
            return new DContras().BuscarSerie(empresa, planta);
        }
        public static string Insertar(string idcontra, string tipocontra, string empresa, DateTime fechacontra, string codproveedor, string nombre, string nit, string direccion, string moneda, string condiciones, DateTime fechapago, decimal totalfact, decimal totalreten, decimal totalpago, string planta, string usr, DataTable detalles, string catliquidacion) //Agregamos campo nuevo
        {
            return new DContras().Insertar(new Contras
            {
                ID_CONTRA = idcontra,
                TIPO_CONTRA = tipocontra,
                ID_EMPRESA = empresa,
                FECHA_CONTRA = fechacontra,
                COD_PROVEEDOR = codproveedor,
                NOMBRE = nombre,
                NIT = nit,
                DIR_PROVEEDOR = direccion,
                MONEDA = moneda,
                CONDICIONES = condiciones,
                FECHA_PAGO = fechapago,
                PLANTA = planta,
                TOTAL_FACT = totalfact,
                TOTAL_RETEN = totalreten,
                TOTAL_PAGO = totalpago,
                USR_REGISTRO = usr,
                Detalles = detalles,
                CAT_LIQUIDACION = catliquidacion //Agregamos el nuevo campo
            });
        }
        public static DataTable Listar(string status, string planta)
        {
            return new DContras().Listar(status, planta);
        }
        public static string Anular(string empresa, string idcontra, string usuario, string comentario)
        {
            return new DContras().Anulacion(empresa, idcontra, usuario, comentario);
        }
        public static string Liquidar(string empresa, string idcontra, string usuario, DateTime fechaliq)
        {
            return new DContras().Liquidar(empresa, idcontra, usuario, fechaliq);
       }
        public static DataTable ListarEstados(string uso)
        {
            DContras Datos = new DContras();
            return Datos.ListarEstados(uso);
        }
        public static string LiqConta(string empresa, string idcontra, string usuario, string comentario, DateTime fecha, string status)
        {
            return new DContras().LiqConta(empresa, idcontra,fecha, usuario, comentario, status);
        }
        public static DataTable ListarContra(string contra)
        {
            return new DContras().ListarContra(contra);
        }
        public static string LiqPagos(string empresa, string idcontra, string usuario, string comentario, DateTime fecha, string status)
        {
            return new DContras().LiqPagos(empresa, idcontra, fecha, usuario, comentario, status);
        }
    }
}
