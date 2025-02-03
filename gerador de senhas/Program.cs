
using System.Reflection.PortableExecutable;
string filePath = "C:\\Users\\Alunos\\OneDrive\\Documentos\\Nada_Oculto_permance\\Git_clones\\Revisao2024_pedro\\gerador de senhas\\Senha.txt";

var Random = new Random();

if (!File.Exists(filePath))
{
    File.WriteAllText(filePath, ""); // Cria o arquivo vazio
}
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("\nSenhas geradas anteriormente:");
Console.ResetColor();

// Lê e imprime o conteúdo do arquivo
Console.ForegroundColor = ConsoleColor.Green;
using (StreamReader reader = new StreamReader(filePath))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        Console.WriteLine(line + "\n");
    }
}
Console.ResetColor();

Console.WriteLine("\ninforme a quantidade de caracter que você deseja");
while (true)
{
    if (int.TryParse(Console.ReadLine(), out int qnt))
    {
        Console.WriteLine("Deseja colocar caractere especial? ");
        string verif = Console.ReadLine().ToLower();
        if (verif == "s" && verif == "sim")
        {
           
           
            Console.WriteLine("Deseja colocar quantos caractere especiais? ");
             Return:
            int.TryParse(Console.ReadLine(), out int qntespecial);


            if (qntespecial > qnt)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("error");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Informe um valor válido");
                Console.ResetColor();
                goto Return;

            }
            else
            {
                int result = qnt - qntespecial;

                using (StreamWriter escrever = new StreamWriter(filePath, true)) // Abre o arquivo para escrita
                {
                    escrever.WriteLine();
                    // Adiciona caracteres especiais
                    for (int i = 1; i <= qntespecial; i++)
                    {
                        string[] caracteresEspeciais = {
                            "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "=", "+",
                            "[", "{", "]", "}", "|", ";", ":", "'", "\"", ",", "<", ".", ">", "/", "?", "`", "~"
                        };

                        var randomSpecialIndex = new Random().Next(caracteresEspeciais.Length);
                        string indexSpecial = caracteresEspeciais[randomSpecialIndex];

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(indexSpecial);
                        escrever.Write(indexSpecial);
                        Console.ResetColor();
                    }

                    // Adiciona letras e números
                    for (int j = 1; j <= result; j++)
                    {
                        string[] caracteres = {
                            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
                            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
                            "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
                        };

                        var randomIndex = new Random().Next(caracteres.Length);
                        string index = caracteres[randomIndex];

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(index);
                        escrever.Write(index);
                        Console.ResetColor();
                    }
                }
            }

        }

        else
        {
            using (StreamWriter escrever = new StreamWriter(filePath, true)) // Abre o arquivo para escrita
            {
                // Apenas letras e números
                escrever.WriteLine();
                for (int i = 0; i < qnt; i++)
                {
                    string[] caracteres = {
                        "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
                        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
                        "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
                    };

                    var randomIndex = new Random().Next(caracteres.Length);
                    string index = caracteres[randomIndex];

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(index);
                    escrever.Write(index);
                    Console.ResetColor();
                }
            }

        }



        break;
    }
    else
    {
        Console.WriteLine("informe um valor válido");
    }
}








