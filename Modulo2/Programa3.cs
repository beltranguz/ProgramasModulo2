
namespace Modulo2
{
    public class Programa3
    {
        public void CuatroValores()
        {
            int valor1 = 0;
            int valor2 =0;
            int valor3 = 0;
            int valor4 = 0;
            decimal suma = 0;
            decimal promedio = 0;

            try
            {
                Console.WriteLine("Ingresar Primer Valor:");
                valor1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresar Segundo Valor:");
                valor2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresar Tercer Valor:");
                valor3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresar Cuarto Valor:");
                valor4 = Convert.ToInt32(Console.ReadLine());

                suma = (valor1 + valor2 + valor3 + valor4);
                promedio = suma / 4;
                
                Console.WriteLine($"El total de los valores es: {suma} y su promedio es {promedio}");
                

            }
            catch (Exception ex)
            {

                Console.WriteLine($" -- Error Verificar Datos -- {ex.Message}");
            }
        }

    }
}
