using System;
using System.Data;
using Recibos.Datos;
using Recibos.Entidades;

namespace Recibos.Negocio
{
    public class NBorradoresNC
    {
        public static string Existe(string documento, string empresa, string cliente)
        {
            return new DBorradoresNC().Existe(documento, empresa, cliente);
        }
        public static DataTable BuscarSerie(string planta)
        {
            return new DBorradoresNC().BuscarSerie(planta);
        }
        public static DataTable CargarAcum(string doc, string empresa)
        {
            return new DBorradoresNC().CargarAcum(doc, empresa);
        }
        public static DataTable Listar(string usuario, string tipo, string agente)
        {
            return new DBorradoresNC().Listar(usuario, tipo, agente);
        }
        public static DataTable ListarBorrAutoR(string status)
        {
            return new DBorradoresNC().ListarBorrAutoR(status);
        }
        public static DataTable ListarEmpr(string empresa)
        {
            return new DBorradoresNC().ListarEmpr(empresa);
        }
        public static DataTable ListarSeg(string usuario, string tipo, string agente)
        {
            return new DBorradoresNC().ListarSeg(usuario, tipo, agente);
        }
        public static DataTable ListarDetAbiertas(string empresa, string borrador)
        {
            return new DBorradoresNC().ListarDetAbiertas(empresa, borrador);
        }
        public static string Insertar(string idborr, DateTime fecha, string empresa, string idcliente, string nombre, string nit, string direccion, string correo, string total, string iduser, string agente, string moneda, DataTable detalles)
        {
            return new DBorradoresNC().Insertar(new BorradoresGen
            {
                ID_BORRADOR = idborr,
                FECHA = fecha,
                ID_EMPRESA = empresa,
                ID_CLIENTE = idcliente,
                NOMBRE = nombre,
                NIT = nit,
                DIRECCION = direccion,
                CORREO = correo,
                TOTAL = total,
                ID_USR = iduser,
                AGENTE = agente,
                MONEDA = moneda,
                Detalles = detalles
            });
        }
        public static string Autorizaciones(string empresa, string idborrador, string usuario, string tipo, string comentario)
        {
            return new DBorradoresNC().Autorizaciones(empresa, idborrador, usuario, tipo, comentario);
        }
    }
}