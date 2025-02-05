namespace Menu
{
    public class Calculadora
    {
        public static string ImprimirMenu()
        {
            string opcao = "";
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("/");
            Console.WriteLine("*");
            return opcao = Console.ReadLine();
        }
        public static decimal ObterValor()
        {
            while (true)
            {
                if (decimal.TryParse(Console.ReadLine(), out decimal x))
                {
                    return x;
                    break;
                }
                else
                {
                    Console.WriteLine("Valor inválido");
                    
                }
            }
        }

        public static void calcular(decimal x, decimal y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }


    }
}