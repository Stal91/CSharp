using CalcCSHARP.Divisao;
using CalcCSHARP.Multiplicacao;
using CalcCSHARP.Soma;
using CalcCSHARP.Subtracao;
using CalcCSHARP.Utilitario;

Console.WriteLine("Calculadora C#");

Somar soma = new Somar();
soma.num1 = 10;
soma.num2 = 5;
Metodos somando = new Metodos();
Console.WriteLine("Somando :"+somando.Somando(soma.num1, soma.num2));

Subtracao subtracao = new Subtracao();
subtracao.num1 = 10;
subtracao.num2 = 5;
Metodos subtraindo = new Metodos();
Console.WriteLine("Subtraindo :"+subtraindo.Subtraindo(subtracao.num1, subtracao.num2));

Multiplicacao multiplicacao = new Multiplicacao();
multiplicacao.num1 = 10;
multiplicacao.num2 = 5;
Metodos multiplicando = new Metodos();
Console.WriteLine("Multiplicando :"+multiplicando.Multiplicando(multiplicacao.num1,multiplicacao.num2));


Divisao divisao = new Divisao();
divisao.num1 = 10;
divisao.num2 = 5;
Metodos dividindo = new Metodos();
Console.WriteLine("Dividindo :"+dividindo.Dividindo(divisao.num1,divisao.num2));