using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBuilderV2.Model
{
    public  class Vehiculo
    {
        private string _vehiculoType;
        private Dictionary<string, string> _parts =
          new Dictionary<string, string>();

        // Constructor
        public Vehiculo(string vehiculoType)
        {
            this._vehiculoType = vehiculoType;
        }

       
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Tipo de Vehiculos: {0}", _vehiculoType);

            Console.WriteLine(" Velocidad : {0}", _parts["velocidad"]);
            Console.WriteLine(" #Llantas: {0}", _parts["llantas"]);
            Console.WriteLine(" #Puertas : {0}", _parts["puertas"]);
        }
    }
}
