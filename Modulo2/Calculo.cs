
using System;

namespace Modulo2
{
    public class Calculo
    {
        public void CuatroNumeros()
        {
            int Numero1 = 0;
            int Numero2 = 0;
            int Numero3 = 0;
            int Numero4 = 0;
            decimal suma = 0;
            decimal producto = 0;

            try
            {
                Console.WriteLine("Digite el Numero1:");
                Numero1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el Numero2:");
                Numero2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el Numero3:");
                Numero3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el Numero4:");
                Numero4 = Convert.ToInt32(Console.ReadLine());

                suma = (Numero1 + Numero2);
                producto = (Numero3 * Numero4);

                {
                    Console.WriteLine($"La suma del Numero1 y el Numero2 es: {suma}");
                    Console.WriteLine($"El producto del Numero 3 y el Numero 4 es: {producto}");
                }

            }

            catch (Exception ex)
            {

                Console.WriteLine($"A Ocurrido un error en el tipo de dato {ex.Message}");
            }

        }
    
    }
}
