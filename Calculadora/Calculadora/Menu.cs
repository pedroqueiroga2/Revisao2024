namespace Menu
{
    public class Calculadora
    {
        public static string ImprimirMenu()
        {
            string opcao = "";
            Console.WriteLine("Escolha qual operação você deseja fazer");
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
                if (!decimal.TryParse(Console.ReadLine(), out decimal x))
                {
                    Console.WriteLine("Valor inválido");
                    
                }
                else
                {
                    return x;
                    break;
                    
                }
            }
        }

        public static void adicao(decimal x, decimal y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public static void subtracao(decimal x, decimal y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public static void divisão(decimal x, decimal y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public static void multiplicacao(decimal x, decimal y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }


    }
}