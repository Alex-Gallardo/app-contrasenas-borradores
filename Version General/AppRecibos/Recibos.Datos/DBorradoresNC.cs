using System;
using System.Data;
using System.Data.SqlClient;
using Recibos.Entidades;

namespace Recibos.Datos
{
    public class DBorradoresNC
    {
        public string Existe(string documento, string empresa, string cliente)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("rec_borr_existe", SqlCon);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@documento", SqlDbType.NVarChar).Value = documento;
                sqlCommand.Parameters.Add("@empresa", SqlDbType.NVarChar).Value = empresa;
                sqlCommand.Parameters.Add("@cliente", SqlDbType.NVarChar).Value = cliente;
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@existe";
                ParExiste.SqlDbType = SqlDbType.Int;
                ParExiste.Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add(ParExiste);
                SqlCon.Open();
                sqlCommand.ExecuteNonQuery();
                Rpta = Convert.ToString(ParExiste.Value);
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return Rpta;
        }
        public DataTable BuscarSerie(string empresa)
        {
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            DataTable result;
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("rec_series_BN", SqlCon);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@empresa", SqlDbType.NVarChar).Value = empresa;
                SqlCon.Open();
                SqlDataReader Resultado = sqlCommand.ExecuteReader();
                Tabla.Load(Resultado);
                result = Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return result;
        }
        public DataTable CargarAcum(string doc, string empresa)
        {
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            DataTable result;
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("rec_borr_acum", SqlCon);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@doc", SqlDbType.NVarChar).Value = doc;
                sqlCommand.Parameters.Add("@empresa", SqlDbType.NVarChar).Value = empresa;
                SqlCon.Open();
                SqlDataReader Resultado = sqlCommand.ExecuteReader();
                Tabla.Load(Resultado);
                result = Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return result;
        }
        public DataTable Listar(string usuario, string tipo, string agente)
        {
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            DataTable result;
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("rec_borr_listar", SqlCon);
                sqlCommand.Parameters.Add("@usr", SqlDbType.NVarChar).Value = usuario;
                sqlCommand.Parameters.Add("@tipo", SqlDbType.NVarChar).Value = tipo;
                sqlCommand.Parameters.Add("@agente", SqlDbType.NVarChar).Value = agente;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                SqlDataReader Resultado = sqlCommand.ExecuteReader();
                Tabla.Load(Resultado);
                result = Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return result;
        }
        public DataTable ListarBorrAutoR(string status)
        {
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            DataTable result;
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("rec_auto_listar", SqlCon);
                sqlCommand.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                SqlDataReader Resultado = sqlCommand.ExecuteReader();
                Tabla.Load(Resultado);
                result = Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return result;
        }
        public DataTable ListarEmpr(string empresa)
        {
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            DataTable result;
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("rec_auto_listar_empr", SqlCon);
                sqlCommand.Parameters.Add("@empresa", SqlDbType.NVarChar).Value = empresa;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                SqlDataReader Resultado = sqlCommand.ExecuteReader();
                Tabla.Load(Resultado);
                result = Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return result;
        }
        public DataTable ListarSeg(string usuario, string tipo, string agente)
        {
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            DataTable result;
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("rec_borr_listar_seg", SqlCon);
                sqlCommand.Parameters.Add("@usr", SqlDbType.NVarChar).Value = usuario;
                sqlCommand.Parameters.Add("@tipo", SqlDbType.NVarChar).Value = tipo;
                sqlCommand.Parameters.Add("@agente", SqlDbType.NVarChar).Value = agente;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                SqlDataReader Resultado = sqlCommand.ExecuteReader();
                Tabla.Load(Resultado);
                result = Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return result;
        }
        public DataTable ListarDetAbiertas(string empresa, string borrador)
        {
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            DataTable result;
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("rec_borr_listardet", SqlCon);
                sqlCommand.Parameters.Add("@empresa", SqlDbType.NVarChar).Value = empresa;
                sqlCommand.Parameters.Add("@idBorr", SqlDbType.NVarChar).Value = borrador;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                SqlDataReader Resultado = sqlCommand.ExecuteReader();
                Tabla.Load(Resultado);
                result = Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return result;
        }
        public string Autorizaciones(string empresa, string idborrador, string usuario, string tipo, string comentario)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("rec_auto_borr", SqlCon);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@idborr", SqlDbType.NVarChar).Value = idborrador;
                sqlCommand.Parameters.Add("@usr", SqlDbType.NVarChar).Value = usuario;
                sqlCommand.Parameters.Add("@empresa", SqlDbType.NVarChar).Value = empresa;
                sqlCommand.Parameters.Add("@tipo", SqlDbType.NVarChar).Value = tipo;
                sqlCommand.Parameters.Add("@comentario", SqlDbType.NVarChar).Value = comentario;
                SqlCon.Open();
                Rpta = ((sqlCommand.ExecuteNonQuery() == 1) ? "OK" : "No se pudo tratar el borrador");
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return Rpta;
        }
        public string Insertar(BorradoresGen Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("rec_borr_insert", SqlCon);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@idborr", SqlDbType.NVarChar).Value = Obj.ID_BORRADOR;
                sqlCommand.Parameters.Add("@fecha", SqlDbType.DateTime).Value = Obj.FECHA;
                sqlCommand.Parameters.Add("@empresa", SqlDbType.NVarChar).Value = Obj.ID_EMPRESA;
                sqlCommand.Parameters.Add("@idcliente", SqlDbType.NVarChar).Value = Obj.ID_CLIENTE;
                sqlCommand.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = Obj.NOMBRE;
                sqlCommand.Parameters.Add("@nit", SqlDbType.NVarChar).Value = Obj.NIT;
                sqlCommand.Parameters.Add("@direccion", SqlDbType.NVarChar).Value = Obj.DIRECCION;
                sqlCommand.Parameters.Add("@correo", SqlDbType.NVarChar).Value = Obj.CORREO;
                sqlCommand.Parameters.Add("@total", SqlDbType.Decimal).Value = Obj.TOTAL;
                sqlCommand.Parameters.Add("@idusr", SqlDbType.NVarChar).Value = Obj.ID_USR;
                sqlCommand.Parameters.Add("@agente", SqlDbType.NVarChar).Value = Obj.AGENTE;
                sqlCommand.Parameters.Add("@moneda", SqlDbType.NVarChar).Value = Obj.MONEDA;
                sqlCommand.Parameters.Add("@detalle", SqlDbType.Structured).Value = Obj.Detalles;
                SqlCon.Open();
                sqlCommand.ExecuteNonQuery();
                Rpta = "OK";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return Rpta;
        }
    }
}
