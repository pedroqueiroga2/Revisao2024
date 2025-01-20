// See https://aka.ms/new-console-template for more information
using System.Reflection.PortableExecutable;

Console.WriteLine("informe a quantidade de caracter que você deseja");
while(true)
{
    if(int.TryParse(Console.ReadLine(), out int qnt))
    {
        Console.WriteLine("Deseja colocar caractere especial? ");
        string verif = Console.ReadLine();
        
        for(int i=0; i<qnt;i++)
        {
        string index;
        var Random = new Random();
        
        string[] Caractere = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",  
"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",  
"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",  
"!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "=", "+", "[", "{", "]", "}", "\\", "|", ";", ":", "'", "\"", ",", "<", ".", ">", "/", "?", "`", "~", " "  
    };
    var randomIndex = Random.Next(Caractere.Length);
     index = Caractere[randomIndex];
     Console.Write(index);
     
        }

    break;
    }
    else
    {
        Console.WriteLine("informe um valor válido");
    }
}