using numeroCuadrado.Servicios;

namespace numeroCuadrado
{
    /// <summary>
    /// Clase principal,almacena el metodo main
    /// </summary>
    class program
    {
        /// <summary>
        /// Metodo main, que da inicio al programa y dicta el procedimiento de la aplicacion 
        /// </summary>
        /// <param name="args"></param>
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