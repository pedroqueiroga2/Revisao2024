﻿
using System.Reflection.PortableExecutable;
string valor;
var Random = new Random();
Console.WriteLine("informe a quantidade de caracter que você deseja");
while(true)
{
    if(int.TryParse(Console.ReadLine(), out int qnt))
    {
        Console.WriteLine("Deseja colocar caractere especial? ");
        string verif = Console.ReadLine();
        if(verif=="s")
        {

        Console.WriteLine("Deseja colocar quantos caractere especial? ");
        int.TryParse(Console.ReadLine(), out int qntespecial);

        int result= qnt-qntespecial;
    
        
            for(int i=0; i<=result;i++)
            {

            

            string indexspecial;
            

            
            string[] CaracterEspecial = {"!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "=", "+", "[", "{", "]", "}", "\\", "|", ";", ":", "'", "\"", ",", "<", ".", ">", "/", "?", "`", "~", };

            var randomspecialindex = Random.Next(CaracterEspecial.Length);
            indexspecial= CaracterEspecial[randomspecialindex];
            
            Console.Write(indexspecial);
            valor=indexspecial;
            }

            // Console.WriteLine("result: " + result);

            for(int j=1; j<=result; j++)
            {
                string index;
                string[] Caractere = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",  
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",  
                "0", "1", "2", "3", "4", "5", "6", "7", "8", "9",  
                };
                

                var randomIndex = Random.Next(Caractere.Length);
                index = Caractere[randomIndex];
                Console.Write(index);
                
                
                
            }
            
            
        } 

        else
        {
            for(int i=0; i<qnt; i++)
            {
                string index;
                string[] Caractere = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",  
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",  
                "0", "1", "2", "3", "4", "5", "6", "7", "8", "9",  
                };
                

                var randomIndex = Random.Next(Caractere.Length);
                index = Caractere[randomIndex];

                Console.Write(index);
            }
        }
            
        
    break;
    }
    else
    {
        Console.WriteLine("informe um valor válido");
    }
}