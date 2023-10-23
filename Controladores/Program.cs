using numeroCuadrado.Servicios;

namespace numeroCuadrado
{
    class program
    {
        static void main(string[] args)
        {

            NumeroInterfaz nu = new NumeroImplementacion();
            string numeroAlmacenado;
            numeroAlmacenado = nu.solicitudNumero();
            bool esEntero;
            
            esEntero= double.TryParse(numeroAlmacenado, out double numeroAftherConversion);

            if (esEntero)
            {
                double raizCuadrada;
                raizCuadrada = Math.Sqrt(numeroAftherConversion);
                Console.WriteLine("La raiz cuadrada de " + numeroAftherConversion + "es " + raizCuadrada); 
            }
            else
            {
                Console.WriteLine("No se puede calcular la raiz cuadrada con numeros negativos");
            }
            
        }
    }
}