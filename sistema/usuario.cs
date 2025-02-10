using Microsoft.VisualBasic;

namespace Sistema
{
    public class Usuario()
    {
        public static string nome(string nome)
        {
            Console.WriteLine("Informe seu nome");
            nome = Console.ReadLine();
            return nome;
        }
        public static int Idade()
        {
            Console.WriteLine("informe sua idade");
            while(true)
            {
                if(int.TryParse(Console.ReadLine(), out int x))
                {
                    return x;
                    
                }
                else
                {
                    Console.WriteLine("informe um valor válido");
                }
            }
        }        
    }

    public class Senhas()
    {

    }
}