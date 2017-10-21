using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBuilderV2.Model
{
    class Tienda
    {
        public void Construct(VehiculoBuilder vehiculoBuilder)
        {
           
            vehiculoBuilder.BuildVelocidad();
            vehiculoBuilder.BuildLlantas();
            vehiculoBuilder.BuildPuertas();
        }
    }
}
