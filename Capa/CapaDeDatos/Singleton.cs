using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeDatos
{
    public sealed class Singleton
    {

        protected Singleton( )
        {
            this.Usuario = new List<Usuario>();
        }
        private static Singleton intancia = null;
        public static Singleton Intancia
        {
            get
            {
                if (intancia == null) {
                    intancia = new Singleton();

                }
                return intancia;
            }
        }
       
        private List<Usuario> usuario;

        public List<Usuario> Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

    }
}
