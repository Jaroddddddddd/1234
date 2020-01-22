using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeDatos
{
   public class Usuario
    {
        private string identificacion;

        public string Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string clave;
        
        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

    }
}
