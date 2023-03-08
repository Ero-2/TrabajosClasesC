using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajosClasesC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                List<contacto> lista = new List<contacto>();
                bool salir = false; Console.WriteLine("¿Cuántos contactos désea guardar?");
                int i = int.Parse(Console.ReadLine()), a = 0;
                while (!salir)
                {
                    a++;

                }

                contacto x;
                x = new contacto();
                Console.WriteLine("Nombre");
                x.Nombre = Console.ReadLine();
                Console.WriteLine("Telefono");
                x.Telefono = Console.ReadLine();
                Console.WriteLine("Fecha de Nacimiento");
                x.FechaNacimiento = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("favor de ingresar un numero de telefono");
                x.Telefono = Console.ReadLine();
                lista.Add(x);
                if (i == a)
                {
                    salir = true;
                }
                Console.Clear();
                Console.WriteLine("nombre--Edad--Numero de telefono");
                foreach (contacto c in lista)
                {
                    Console.WriteLine(x.ToString());

                }

            }
            catch (FormatException e) { Console.WriteLine(e.Message); }
            Console.ReadKey();
        }
    }
}
