
using numeroCuadrado.Servicios;

namespace numeroCuadrado
{
    class program
    {

        static void Main(string[] args)
        {
            double raizCuadrada;
            NumeroInterfaz nu = new NumeroImplementacion();
            double numero= nu.solicitudNumero();
            raizCuadrada = Math.Sqrt(numero);
           
         
            if (EsEntero(raizCuadrada))
            {
                Console.WriteLine("La raiz cuadrada es entera, la raiz es: " + raizCuadrada);
            }
            else
            {
                Console.WriteLine("La raiz no es entero");
            }

            static bool EsEntero(double numero)
            {
                return numero % 1 == 0;
            }



        }
    }
}