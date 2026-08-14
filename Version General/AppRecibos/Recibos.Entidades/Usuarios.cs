using System;
using System.Data;

namespace Recibos.Entidades
{
    public class Usuarios
    {
        public string ID_USR { get; set; }
        public string NOMBRE { get; set; }
        public string CLAVE { get; set; }
        public string DEPARTAMENTO { get; set; }
        public string ROL { get; set; }
        public string EMAIL { get; set; }
        public string ESTADO { get; set; }
        public string PLANTA { get; set; }
    }
}
