using System;
using System.Data;
using System.Data.SqlClient;
using Recibos.Entidades;

namespace Recibos.Datos
{
    public class DUsuarios
    {
        public DataTable Listar()
        {
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            DataTable result;
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("rec_usr_listar", SqlCon);
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
        public DataTable Buscar(string valor)
        {
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            DataTable result;
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("rec_usr_buscar", SqlCon);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@valor", SqlDbType.NVarChar).Value = valor;
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
        public string Existe(string Valor)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("rec_usr_existe", SqlCon);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@valor", SqlDbType.NVarChar).Value = Valor;
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
        public string Insertar(Usuarios Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("rec_usr_insertar", SqlCon);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@id_usr", SqlDbType.NVarChar).Value = Obj.ID_USR;
                sqlCommand.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = Obj.NOMBRE;
                sqlCommand.Parameters.Add("@clave", SqlDbType.NVarChar).Value = Obj.CLAVE;
                sqlCommand.Parameters.Add("@depto", SqlDbType.NVarChar).Value = Obj.DEPARTAMENTO;
                sqlCommand.Parameters.Add("@rol", SqlDbType.NVarChar).Value = Obj.ROL;
                sqlCommand.Parameters.Add("@email", SqlDbType.NVarChar).Value = Obj.EMAIL;
                sqlCommand.Parameters.Add("@planta", SqlDbType.NVarChar).Value = Obj.PLANTA;
                SqlCon.Open();
                Rpta = ((sqlCommand.ExecuteNonQuery() == 1) ? "OK" : "No se pudo Ingresar el Registro!");
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
        public string Actualizar(Usuarios Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("rec_usr_actualizar", SqlCon);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@id_usr", SqlDbType.NVarChar).Value = Obj.ID_USR;
                sqlCommand.Parameters.Add("@rol", SqlDbType.NVarChar).Value = Obj.ROL;
                sqlCommand.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = Obj.NOMBRE;
                sqlCommand.Parameters.Add("@depto", SqlDbType.NVarChar).Value = Obj.DEPARTAMENTO;
                sqlCommand.Parameters.Add("@email", SqlDbType.NVarChar).Value = Obj.EMAIL;
                sqlCommand.Parameters.Add("@clave", SqlDbType.NVarChar).Value = Obj.CLAVE;
                sqlCommand.Parameters.Add("@planta", SqlDbType.NVarChar).Value = Obj.PLANTA;
                SqlCon.Open();
                Rpta = ((sqlCommand.ExecuteNonQuery() == 1) ? "OK" : "No se pudo Actualizar el Registro!");
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
        public string Eliminar(string id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("usuarios_eliminar", SqlCon);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@id_usr", SqlDbType.NVarChar).Value = id;
                SqlCon.Open();
                Rpta = ((sqlCommand.ExecuteNonQuery() == 1) ? "OK" : "No se pudo Eliminar el Registro!");
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
        public string Activar(string id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("rec_usr_activar", SqlCon);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@id_usr", SqlDbType.NVarChar).Value = id;
                SqlCon.Open();
                Rpta = ((sqlCommand.ExecuteNonQuery() == 1) ? "OK" : "No se pudo Activar el Registro!");
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
        public string Desactivar(string id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("rec_usr_desactivar", SqlCon);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@id_usr", SqlDbType.NVarChar).Value = id;
                SqlCon.Open();
                Rpta = ((sqlCommand.ExecuteNonQuery() == 1) ? "OK" : "No se pudo Desactivar el Registro!");
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
        public DataTable Login(string Usuario, string Clave)
        {
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            DataTable result;
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand sqlCommand = new SqlCommand("rec_usr_login", SqlCon);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = Usuario;
                sqlCommand.Parameters.Add("@clave", SqlDbType.NVarChar).Value = Clave;
                SqlCon.Open();
                SqlDataReader Resultado = sqlCommand.ExecuteReader();
                Tabla.Load(Resultado);
                result = Tabla;
            }
            catch (Exception ex)
            {
                result = null;
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
    }
}
