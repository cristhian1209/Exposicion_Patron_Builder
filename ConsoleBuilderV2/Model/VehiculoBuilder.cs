using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBuilderV2.Model
{
    public abstract class VehiculoBuilder
    {
        protected Vehiculo vehiculo;


        public Vehiculo Vehiculo
        {
            get { return vehiculo; }
        }

        // Metodos Abstractos
         
     
        public abstract void BuildVelocidad();
        public abstract void BuildLlantas();
        public abstract void BuildPuertas();
    }
}
