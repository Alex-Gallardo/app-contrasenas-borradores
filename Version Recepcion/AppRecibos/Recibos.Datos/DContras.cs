using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using Recibos.Entidades;

namespace Recibos.Datos
{
    public class DContras
    {
        public DataTable BuscarSerie(string empresa, string planta)
        {
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            DataTable result;
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("cxp_contras_series", SqlCon);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@empresa", SqlDbType.NVarChar).Value = empresa;
                sqlCommand.Parameters.Add("@planta", SqlDbType.NVarChar).Value = planta;
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
        public string Existe(string seriefel, string numerofel, string empresa, string proveedor)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("cxp_contras_existe", SqlCon);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@numfel", SqlDbType.NVarChar).Value = numerofel;
                sqlCommand.Parameters.Add("@seriefel", SqlDbType.NVarChar).Value = seriefel;
                sqlCommand.Parameters.Add("@empresa", SqlDbType.NVarChar).Value = empresa;
                sqlCommand.Parameters.Add("@proveedor", SqlDbType.NVarChar).Value = proveedor;
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
        public string Insertar(Contras Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("cxp_contras_insert", SqlCon);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@idcontra", SqlDbType.NVarChar).Value = Obj.ID_CONTRA;
                sqlCommand.Parameters.Add("@tipocontra", SqlDbType.NVarChar).Value = Obj.TIPO_CONTRA;
                sqlCommand.Parameters.Add("@empresa", SqlDbType.NVarChar).Value = Obj.ID_EMPRESA;
                sqlCommand.Parameters.Add("@fecha", SqlDbType.Date).Value = Obj.FECHA_CONTRA;
                sqlCommand.Parameters.Add("@idproveedor", SqlDbType.NVarChar).Value = Obj.COD_PROVEEDOR;
                sqlCommand.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = Obj.NOMBRE;
                sqlCommand.Parameters.Add("@nit", SqlDbType.NVarChar).Value = Obj.NIT;
                sqlCommand.Parameters.Add("@direccion", SqlDbType.NVarChar).Value = Obj.DIR_PROVEEDOR;
                sqlCommand.Parameters.Add("@moneda", SqlDbType.NVarChar).Value = Obj.MONEDA;
                sqlCommand.Parameters.Add("@condiciones", SqlDbType.NVarChar).Value = Obj.CONDICIONES;
                sqlCommand.Parameters.Add("@fechapago", SqlDbType.Date).Value = Obj.FECHA_PAGO;
                sqlCommand.Parameters.Add("@planta", SqlDbType.NVarChar).Value = Obj.PLANTA;
                sqlCommand.Parameters.Add("@totalfact", SqlDbType.Decimal).Value = Obj.TOTAL_FACT;
                sqlCommand.Parameters.Add("@totalreten", SqlDbType.Decimal).Value = Obj.TOTAL_RETEN;
                sqlCommand.Parameters.Add("@totalpago", SqlDbType.Decimal).Value = Obj.TOTAL_PAGO;
                sqlCommand.Parameters.Add("@idusr", SqlDbType.NVarChar).Value = Obj.USR_REGISTRO;
                sqlCommand.Parameters.Add("@detalles", SqlDbType.Structured).Value = Obj.Detalles;
                sqlCommand.Parameters.Add("@cat_liq", SqlDbType.NVarChar).Value = Obj.CAT_LIQUIDACION; //Agregamos el nuevo cmpo
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
        public DataTable Listar(string status, string planta)
        {
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            DataTable result;
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("cxp_contras_listar", SqlCon);
                sqlCommand.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;
                sqlCommand.Parameters.Add("@planta", SqlDbType.NVarChar).Value = planta;
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
        public string Anulacion(string empresa, string idcontra, string usuario, string comentario)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("cxp_contras_anular", SqlCon);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@idcontra", SqlDbType.NVarChar).Value = idcontra;
                sqlCommand.Parameters.Add("@usr", SqlDbType.NVarChar).Value = usuario;
                sqlCommand.Parameters.Add("@empresa", SqlDbType.NVarChar).Value = empresa;
                sqlCommand.Parameters.Add("@comentario", SqlDbType.NVarChar).Value = comentario;
                SqlCon.Open();
                Rpta = ((sqlCommand.ExecuteNonQuery() == 1) ? "OK" : "No se pudo anular el documento");
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
        public string Liquidar(string empresa, string idcontra, string usuario, DateTime fechaliq)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("cxp_contras_liquidar", SqlCon);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@idcontra", SqlDbType.NVarChar).Value = idcontra;
                sqlCommand.Parameters.Add("@usr", SqlDbType.NVarChar).Value = usuario;
                sqlCommand.Parameters.Add("@empresa", SqlDbType.NVarChar).Value = empresa;
                sqlCommand.Parameters.Add("@fliq", SqlDbType.Date).Value = fechaliq;
                SqlCon.Open();
                Rpta = ((sqlCommand.ExecuteNonQuery() == 1) ? "OK" : "No se pudo Liquidar el documento");
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
        public string LiqConta(string empresa, string idcontra, DateTime fecha,string usuario, string comentario, string status)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("cxp_contras_liqconta", SqlCon);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@idcontra", SqlDbType.NVarChar).Value = idcontra;
                sqlCommand.Parameters.Add("@usr", SqlDbType.NVarChar).Value = usuario;
                sqlCommand.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha;
                sqlCommand.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;
                sqlCommand.Parameters.Add("@empresa", SqlDbType.NVarChar).Value = empresa;
                sqlCommand.Parameters.Add("@comentario", SqlDbType.NVarChar).Value = comentario;
                SqlCon.Open();
                Rpta = ((sqlCommand.ExecuteNonQuery() == 1) ? "OK" : "No se pudo operar el documento");
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
        public DataTable ListarEstados(string uso)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("cxp_listar_estados", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@tipo", SqlDbType.NVarChar).Value = uso;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        public DataTable ListarContra(string contra)
        {
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            DataTable result;
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("cxp_contras_listar_conta", SqlCon);
                sqlCommand.Parameters.Add("@contra", SqlDbType.NVarChar).Value = contra;
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
        public string LiqPagos(string empresa, string idcontra, DateTime fecha, string usuario, string comentario, string status)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("cxp_contras_pagos", SqlCon);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@idcontra", SqlDbType.NVarChar).Value = idcontra;
                sqlCommand.Parameters.Add("@usr", SqlDbType.NVarChar).Value = usuario;
                sqlCommand.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha;
                sqlCommand.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;
                sqlCommand.Parameters.Add("@empresa", SqlDbType.NVarChar).Value = empresa;
                sqlCommand.Parameters.Add("@comentario", SqlDbType.NVarChar).Value = comentario;
                SqlCon.Open();
                Rpta = ((sqlCommand.ExecuteNonQuery() == 1) ? "OK" : "No se pudo operar el documento");
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