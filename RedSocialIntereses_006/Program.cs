using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocialIntereses_006
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }







        /// <summary>
        /// Solicita los datos de las personas
        /// </summary>
        /// <returns>Retorna una persona</returns>
        static Persona CrearPersona()
        {
            Console.WriteLine("Ingrese el nombre de la persona");
            String nombre = Console.ReadLine();
            Dictionary<TipoInteres, String> valors = new Dictionary<TipoInteres, string>();

            foreach (TipoInteres item in Enum.GetValues(typeof(TipoInteres)))
            {
                Console.WriteLine("Ingrese valor para tipo interes "+ item);
                valors.Add(item, Console.ReadLine());
            }

            return new Persona(nombre, valors);
        }
    }
}
