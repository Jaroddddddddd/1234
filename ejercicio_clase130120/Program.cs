using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ejercicio_clase130120
{
    class Program
    {
        static void Main(string[] args)
        {
            List<cliente> clientes = new List<cliente>
            {
                new cliente(){nombre="Pepito",apellido="Perez",ciudad="San Mateo beach",sueldo=1212.23},
                new cliente(){nombre="Josecito",apellido="Paz",ciudad="Manta",sueldo=50.30},
                new cliente(){nombre="Karlita",apellido="Fernandez",ciudad="Portoviejo",sueldo=530.60},
                new cliente(){nombre="Pablito",apellido="Garcia",ciudad="Manta",sueldo=700},
                new cliente(){nombre="Nauncito",apellido="Murillo",ciudad="San Mateo beach",sueldo=43032434},
                new cliente(){nombre="Rominita",apellido="De Losano",ciudad="Manta",sueldo=394}
            };
            //IEnumerable<cliente> consulta_cliente = (from cliente in clientes
            //     where cliente.ciudad.ToUpper() == "Manta".ToUpper() 
            //   orderby cliente.apellido ascending 
            //   select cliente).ToList();



            /* var consulta_cliente=
             (from cliente in clientes
             where cliente.sueldo>1000
             group cliente by cliente.sueldo > 1000?"Pescadores":"Obrero citadino"
             into clientex where clientex.Count()>1
             select clientex).ToList();
             */
            var consulta = (from cliente in clientes
                            where cliente.sueldo > 1000
                            select new { nombre_completo = cliente.nombre +" "+ cliente.apellido, mega_sueldo = cliente.sueldo * 100 });
            //foreach (cliente item in consulta_cliente)
            //{
            //  Console.WriteLine("{0} {1} {2} {3}", item.nombre,item.apellido,item.ciudad,item.sueldo);
            // }
            /*
             foreach (var item in consulta_cliente)
             {
                 Console.WriteLine();

                 Console.WriteLine( item.Key);

                 foreach (var item2 in item)
                 {
                     Console.WriteLine("{0} Sueldo: {1}",item2.nombre, item2.sueldo);

                 }
             }
 */
            foreach (var item in consulta)
            {
                Console.WriteLine("{0} {1}", item.nombre_completo, item.mega_sueldo);
            }
            Console.ReadKey();

        }
    }
}
