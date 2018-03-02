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
            Console.Title = "RedSocialIntereses_006";
            List<Persona> personas = new List<Persona>();
            int cantPerso;

            Console.WriteLine("Ingrese el numero de personas a crear");
            cantPerso = int.Parse(Console.ReadLine());
            for (int i = 0; i < cantPerso; i++)
            {
                personas.Add(CrearPersona());
            }


            Persona.imprimirListPersonas(personas);
            Console.WriteLine();
            imprimirCompatibilidades(personas);
            imprimirCompletamCompatibibles(personas);

            Console.Read();
        }







        /// <summary>
        /// Solicita los datos de las personas
        /// </summary>
        /// <returns>Retorna una persona</returns>
        static Persona CrearPersona()
        {
            Console.WriteLine();
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

        /// <summary>
        /// Imprime el nivel de compatibilidad entre personas
        /// </summary>
        /// <param name="personas"></param>
        static void imprimirCompatibilidades(List<Persona> personas)
        {
            if (personas.Count > 1) { 
            Console.WriteLine();
            String valorImprimir = "Compatibilidad \n";
                List<String> yaEvaluados = new List<string>();
            for (int i = 0; i < personas.Count; i++)
            {
                    for (int j = 0; j < personas.Count; j++)
                    {
                        if (!(i == j))
                        {
                            if (!yaEvaluados.Contains(i + "-" + j))
                            {
                                valorImprimir += Persona.EvaluarCompatibilidadPersonas(personas.ElementAt(i), personas.ElementAt(j)) + "\n";
                                yaEvaluados.Add(j + "-" + i);
                            }
                           
                        }
                        
                    }
                
            }
            Console.WriteLine(valorImprimir);
            
            }
            else
            {
                Console.WriteLine("No hay suficientes personas para evaluar");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Imprimir las personas 100% Compatibles
        /// </summary>
        /// <param name="personas"></param>
        static void imprimirCompletamCompatibibles(List<Persona> personas)
        {
            if (personas.Count > 1)
            {
                Console.WriteLine();
                String valorImprimir = "Compatibilidad 100% \n";
                List<String> yaEvaluados = new List<string>();
                for (int i = 0; i < personas.Count; i++)
                {
                    for (int j = 0; j < personas.Count; j++)
                    {
                        if (!(i == j))
                        {
                            if (!yaEvaluados.Contains(i + "-" + j))
                            {
                                if (Persona.EvaluarSiCompatibilidadPersonas(personas.ElementAt(i), personas.ElementAt(j)))
                                {
                                    valorImprimir += personas.ElementAt(i).nombre + " y "+  personas.ElementAt(j).nombre + "\n";
                                    yaEvaluados.Add(j + "-" + i);
                                }
                                
                            }

                        }

                    }

                }
                Console.WriteLine(valorImprimir);

            }
            else
            {
                Console.WriteLine("No hay suficientes personas para evaluar");
            }
            Console.WriteLine();
        }
    }

    
}

