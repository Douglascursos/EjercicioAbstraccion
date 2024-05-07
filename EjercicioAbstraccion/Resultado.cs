
///Clase Abstracta 
///Se crea
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    public class Resultado : Operaciones
    {  
        public double N1 { get; set; }
        public double N2 { get; set; }

        public override double Division()
        {
            return N1 / N2;
        }

        public override double Multiplicacion()
        {
            return N1 * N1;
        }

        public override double Resta()
        {
            return N1 - N1;
        }

        public override double Suma()
        {
            return N1 + N1;
        }


        public override void Imprimir()
        {
            Console.WriteLine($"Suma: {Suma()}");
            Console.WriteLine($"Resta: {Resta()}");
            Console.WriteLine($"Multiplicacion: {Multiplicacion()}");
            Console.WriteLine($"Division: {Division()}");
        }
    }
}
