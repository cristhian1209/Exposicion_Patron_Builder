using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBuilderV2.Model
{
    class CarroBuilder:VehiculoBuilder
    {

        public CarroBuilder()
        {
            vehiculo = new Vehiculo("Carro");
        }

        public override void BuildVelocidad()
        {
            vehiculo["velocidad"] = "200 Km/h";
        }

        public override void BuildLlantas()
        {
            vehiculo["llantas"] = "4";
        }

        public override void BuildPuertas()
        {
            vehiculo["puertas"] = "4";
        }
    }
}
