
namespace Modulo2
{
    public class Programa1
    {
        public void cuadrado()
        {
            int lados = 0;
            decimal perimetro = 0;

            try
            {
                {
                    Console.WriteLine($"Ingrese el valor del lado");
                    lados = Convert.ToInt32(Console.ReadLine());

                    perimetro = (lados * 4);

                    Console.WriteLine($"El perimetro del cuadrado es igual a: {perimetro}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en el suministro de datos {ex.Message}");
            }

        }
    }
}
