// See https://aka.ms/new-console-template for more information
Console.WriteLine("informe a quantidade de caracter que você deseja");
while(true)
{
    if(int.TryParse(Console.ReadLine(), out int qnt))
    {
        
    }
    else
    {
        Console.WriteLine("informe um valor válido");
    }
}