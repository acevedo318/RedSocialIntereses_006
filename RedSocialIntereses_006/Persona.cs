using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocialIntereses_006
{
    class Persona
    {
        public String nombre{ get; }
        public Dictionary<TipoInteres, String> intereses { get; } //new Dictionary<TipoInteres, string>();


        public Persona(String nombre,Dictionary<TipoInteres,String> interess)
        {
            this.nombre = nombre;
            this.intereses = interess;
        }

        /// <summary>
        /// Evaluar Personas
        /// </summary>
        /// <param name="uno"></param>
        /// <param name="dos"></param>
        /// <returns>String con el nombre de la persona y porcentaje compatibilidad</returns>
        public static String EvaluarCompatibilidadPersonas(Persona uno,Persona dos)
        {
            int cantCompati = 0;
            for (int i = 0; i < uno.intereses.Count; i++)
            {
                if (uno.intereses.ElementAt(i).Equals(dos.intereses.ElementAt(i)))
                {
                    cantCompati++;
                }
            }

            return uno.nombre +" y "+dos.nombre+ " son " + cantCompati*100/uno.intereses.Count + "% " + "compatibles"; 
        }

        /// <summary>
        /// Evaluar Personas
        /// </summary>
        /// <param name="uno"></param>
        /// <param name="dos"></param>
        /// <returns>Booleano con true si son 100% compatibles de lo contrario
        /// retornara false</returns>
        public static Boolean EvaluarSiCompatibilidadPersonas(Persona uno, Persona dos)
        {
            int cantCompati = 0;
            bool compatibles = false;
            for (int i = 0; i < uno.intereses.Count; i++)
            {
                if (uno.intereses.ElementAt(i).Equals(dos.intereses.ElementAt(i)))
                {
                    cantCompati++;
                }
            }

            if (cantCompati == uno.intereses.Count)
            {
                compatibles = true;
            }

            return compatibles;
        }

        public override string ToString()
        {
            String interes = "{";
            foreach (var item in this.intereses)
            {
                interes += item.Key +"-"+ item.Value + ",";
            }
            interes += "}";
            return "nombre: " + nombre + "\n" + interes;
        }

    }
}
