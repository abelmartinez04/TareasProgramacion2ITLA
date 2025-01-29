//Abel Eduardo Martinez Robles (2024-0227)

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
            Console.WriteLine("Este es el mapa de clases");
        }
    }
    public class Persona
    {
  
    }


    public class MiembroDeLaComunidad : Persona
    {
    }

    public class Estudiante : MiembroDeLaComunidad
    {
    }

    public class ExAlumno : Estudiante
    {
    }

    public class Empleado : MiembroDeLaComunidad
    {
    }

    public class Administrativo : Empleado
    {
    }

    public class Docente : Empleado
    {
    }

    public class Maestro : Docente
    {
    }

  
    public class Administrador : Docente
    {
        
    }
}
