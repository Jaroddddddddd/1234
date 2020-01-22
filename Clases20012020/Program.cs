using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases20012020
{
    
        class Program
        {

            static void Main(string[] args)
            {
            Contexto contexto = new Contexto();
            /*
           
            Categoria categoria = new Categoria()
            {
                Id = 2,
                Descripcion = "Invitado"
            };
            Usuario usuario = new Usuario()
            { Id = 1, Nombre = "Bart", categoria = categoria };
            contexto.Usuario.Add(usuario);
            contexto.Categoria.Add(categoria);
            contexto.SaveChanges();
            Console.WriteLine("Listo");
            */
            /*
            Categoria auxiliar = contexto.Categoria.Where(p => p.Id == 2).Single();
            auxiliar.Descripcion = "Cambio categoria";
            contexto.SaveChanges();
            foreach (var item in contexto.Categoria)
            {
                Console.WriteLine(item.Descripcion);
            }
            */
             contexto.Categoria.Remove(contexto.Categoria.Where(p => p.Id == 2).Single());
           
            contexto.SaveChanges();
            Console.WriteLine("Listo");
        }
        }
    
}
