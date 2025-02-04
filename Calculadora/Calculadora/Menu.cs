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
        
    }
}