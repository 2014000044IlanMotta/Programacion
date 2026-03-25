internal class Program
{
    private static void Main(string[] args)
    {
        {
            int a;
            Console.WriteLine("===NUMEROS POSITIVOS Y NEGATIVOS===");
            Console.WriteLine("Escribe un numero entero: ");
            a = int.Parse(Console.ReadLine());
            if (a >= 0)
            {
                Console.WriteLine("Numero Positivo ");
            }
            else
            {
                Console.WriteLine("Numero Negativo ");
            }

        }
    }
}