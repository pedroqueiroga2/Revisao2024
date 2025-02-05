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
        public static void calcular(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x+y}");
        }
        
    }
}