using System;
using System.Collections.Generic;
using System.Text;
using CapaDeDatos;
namespace CapaDeNegocios
{
   public class NegocioUsuario
    {
        GestionUsuario gestionUsuario;
        public NegocioUsuario()
        {
            gestionUsuario = new GestionUsuario();
          
        }
        public void insertarUsuario(Usuario usuario)
        {
            gestionUsuario.insertarUsuario(this.Usuario);
        }

        public List<Usuario> listausuario()
        {
            return gestionUsuario.listaUsuario();
        }
        private Usuario usuario;

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

    }
}
