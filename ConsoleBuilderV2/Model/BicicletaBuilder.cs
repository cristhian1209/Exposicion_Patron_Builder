using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBuilderV2.Model
{
    class BicicletaBuilder:VehiculoBuilder
    {
        public BicicletaBuilder()
        {
            vehiculo = new Vehiculo("Bici");
        }

        public override void BuildVelocidad()
        {
            vehiculo["velocidad"] = "30 Km/h";
        }

        public override void BuildLlantas()
        {
            vehiculo["llantas"] = "2";
        }

        public override void BuildPuertas()
        {
            vehiculo["puertas"] = "0";
        }
    }
}
