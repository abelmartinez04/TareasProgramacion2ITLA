using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaClassMapping1
{
    class Program
    {
        static void Main(string[] args)
        {
            //empezar aqui
            Persona persona1 = new Persona();
            persona1.Name = "Juan";
            Console.Write(persona1.Name);
        }
    }
    
    public class Persona
    {
        public string Name { get; set; }
    }
}
