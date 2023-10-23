using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeroCuadrado.Servicios
{
    internal class NumeroImplementacion : NumeroInterfaz
    {
        public string solicitudNumero()
        {
            string numero;
            Console.WriteLine("Dame un numero");
            numero = Console.ReadLine();
            return numero;

        }

        
    }
}
