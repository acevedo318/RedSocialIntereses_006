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
