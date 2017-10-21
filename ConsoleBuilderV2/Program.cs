using ConsoleBuilderV2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBuilderV2
{
    class Program
    {
        static void Main(string[] args)
        {

            VehiculoBuilder builder;

           //Crear 
            Tienda tienda = new Tienda();

            
            builder = new BicicletaBuilder();
            tienda.Construct(builder);
            builder.Vehiculo.Show();

            builder = new CarroBuilder();
            tienda.Construct(builder);
            builder.Vehiculo.Show();

            builder = new MotoBuilder();
            tienda.Construct(builder);
            builder.Vehiculo.Show();

             
            Console.ReadKey();
        }
    }
}
