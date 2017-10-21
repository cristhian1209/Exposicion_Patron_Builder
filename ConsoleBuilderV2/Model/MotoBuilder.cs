using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBuilderV2.Model
{
    class MotoBuilder : VehiculoBuilder
    {
        public MotoBuilder()
        {
            vehiculo = new Vehiculo("Moto");
        }

        public override void BuildVelocidad()
        {
            vehiculo["velocidad"] = "500 Km/h";
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
