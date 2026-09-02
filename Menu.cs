using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2D262
{
    internal class Menu
    {
        public void Execute()
        {
            string name;
            Console.WriteLine("Hola!");
            name = GetName();
            Console.WriteLine($"Veo que te llamas {name}");
        }

        private string GetName()
        {
            string name="";
            while (name.Length == 0)
            {
                Console.WriteLine("Introduce tu nombre:");
                name = Console.ReadLine();
                if(name.Length==0)
                {
                    Console.WriteLine("El nombre no puede ser vacío");
                }
            }
            return name;
        }
    }
}
