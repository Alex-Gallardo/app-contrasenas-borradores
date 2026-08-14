using System;
using System.Data.SqlClient;

namespace Recibos.Datos
{

    public class Conexion
    {
        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Data Source=192.168.192.227;Initial Catalog=APK66;User ID=SISTEMAS;Password=K66@AdminWeb";
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }
        public static Conexion getInstancia()
        {
            if (Conexion.Con == null)
            {
                Conexion.Con = new Conexion();
            }
            return Conexion.Con;
        }
        private static Conexion Con;
    }
}
