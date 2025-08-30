using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila pila = new Pila();
            Helper.Llenar(pila);
            Console.WriteLine("--- Informando Pila ---");
            Helper.Informar(pila);
            
            Cola cola = new Cola();
            Helper.Llenar(cola);
            Console.WriteLine("\n--- Informando Cola ---");
            Helper.Informar(cola);

            ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
            Helper.Informar(multiple);
        }
    }
}
