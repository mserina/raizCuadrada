using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeroCuadrado.Servicios
{
    /// <summary>
    /// Clase que contiene la logica de los metodos 
    /// msm - 251023
    /// </summary>
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
