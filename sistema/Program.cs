using Sistema;

int x = 0;
string nome = "";

nome = Usuario.nome(nome);


// x = Usuario.Idade();

// Console.ForegroundColor = ConsoleColor.DarkGreen;
// Console.BackgroundColor = ConsoleColor.White;

// Console.WriteLine(nome);
// Console.WriteLine($"Sua idade é {x}");

// Console.ResetColor();



String[] name = {nome};

Random y = new Random();


     foreach(var v in name)
     {
        foreach(int k in v)
        {
            Console.WriteLine(k);
        }
     }


// foreach(string v in name)
// {
//     foreach(char letra in v)
//     {
//         Console.WriteLine(letra);
//     }
// }
