using System;
using System.Data;
using Recibos.Datos;
using Recibos.Entidades;

namespace Recibos.Negocio
{
    public class NUsuarios
    {
        public static DataTable Listar()
        {
            return new DUsuarios().Listar();
        }
        public static DataTable Buscar(string valor)
        {
            return new DUsuarios().Buscar(valor);
        }
        public static DataTable Login(string Usuario, string Clave)
        {
            return new DUsuarios().Login(Usuario, Clave);
        }
        public static string Insertar(string IdUsuario, string Nombre, string Clave, string Departamento, string Rol, string Email, string planta)
        {
            DUsuarios Datos = new DUsuarios();
            if (Datos.Existe(Email).Equals("1"))
            {
                return "El Usuario ya Existe con este Email en La Base de Datos";
            }
            return Datos.Insertar(new Usuarios
            {
                ID_USR = IdUsuario,
                ROL = Rol,
                NOMBRE = Nombre,
                DEPARTAMENTO = Departamento,
                EMAIL = Email,
                CLAVE = Clave,
                PLANTA = planta
            });
        }
        public static string Actualizar(string IdUsuario, string Nombre, string Rol, string Depto, string Email, string Clave, string planta)
        {
            return new DUsuarios().Actualizar(new Usuarios
            {
                ID_USR = IdUsuario,
                ROL = Rol,
                NOMBRE = Nombre,
                DEPARTAMENTO = Depto,
                EMAIL = Email,
                CLAVE = Clave,
                PLANTA = planta
            });
        }
        public static string Eliminar(string IdUsr)
        {
            return new DUsuarios().Eliminar(IdUsr);
        }
        public static string Activar(string IdUsr)
        {
            return new DUsuarios().Activar(IdUsr);
        }
        public static string Desactivar(string IdUsr)
        {
            return new DUsuarios().Desactivar(IdUsr);
        }
    }
}
