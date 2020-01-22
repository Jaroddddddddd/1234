using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDeDatos
{
   public class GestionUsuario
    {
        public void insertarUsuario(Usuario usuario)
        {
            Singleton.Intancia.Usuario.Add(usuario);
        }
        public List<Usuario> listaUsuario()
        {
            return Singleton.Intancia.Usuario;
        }
        public Usuario listaIndividualUsuario(string nombre) {
            return Singleton.Intancia.Usuario.Find(p=>p.Nombre==nombre);
        }
        public void eliminarUsuario(string nombre)
        {
            Singleton.Intancia.Usuario.Remove(listaIndividualUsuario(nombre));
        }
        public void ModificarUsuario(Usuario usuario)
        {
            Usuario Amodificar = listaIndividualUsuario(usuario.Nombre);
            Amodificar.Clave = usuario.Clave;
            Amodificar.Identificacion = usuario.Identificacion;
        }
    }
}
