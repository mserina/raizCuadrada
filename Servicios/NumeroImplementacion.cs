using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeroCuadrado.Servicios
{
    internal class NumeroImplementacion : NumeroInterfaz
    {
        public double  solicitudNumero()
        {
            double  numero;
            Console.WriteLine("Dame nunmero");
            numero = double.Parse(Console.ReadLine());
            return numero;

        }

        

        
    }
}
