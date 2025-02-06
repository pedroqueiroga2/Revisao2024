using Menu;

string opcao = "";


opcao = Calculadora.ImprimirMenu();

switch(opcao)
{
    case "+":
    Calculadora.adicao(Calculadora.ObterValor(), Calculadora.ObterValor());
    break;

    case "-":
    Calculadora.subtracao(Calculadora.ObterValor(), Calculadora.ObterValor());
    break;

    case "/":
    Calculadora.divisão(Calculadora.ObterValor(), Calculadora.ObterValor());
    break;

    case "*":
    Calculadora.multiplicacao(Calculadora.ObterValor(), Calculadora.ObterValor());
    break;
    
}
string mensagem = "";
Calculadora.Mensagem(mensagem);
