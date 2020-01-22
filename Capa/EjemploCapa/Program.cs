using System;
using CapaDeDatos;
using CapaDeNegocios;
namespace EjemploCapa
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Usuario usuario = new Usuario()
            {
                Identificacion = "serw3erd",
                Nombre="Juanito Arcoiris",
                Clave = "wreer"
            };*/
            NegocioUsuario negocioUsuario = new NegocioUsuario();
            negocioUsuario.Usuario = new Usuario()
            {
                Identificacion = "serw3erd",
                Nombre = "Juanito Arcoiris",
                Clave = "wreer"
            };
            negocioUsuario.insertarUsuario(negocioUsuario.Usuario);
   
            foreach (Usuario item in negocioUsuario.listausuario())
            {
                Console.WriteLine(item.Nombre);
            }
            Console.ReadKey();
        }
        
    }
}
