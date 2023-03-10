using ExemploPOO.Models;
using ExemploPOO.Interfaces;

ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3, 9));

Computador c = new Computador();
Console.WriteLine(c.ToString());

Pessoa p1 = new Pessoa("Bruno Valentim");
Aluno a1 = new Aluno("Jefferson Caminhões");
a1.Apresentar();

Corrente c2 = new Corrente();

c2.Creditar(20);
c2.Creditar(20);
c2.ExibirSaldo();

ContaCorrente c1 = new ContaCorrente(123, 1000);

c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();

Pessoa p2 = new Pessoa();
Console.WriteLine("Digite o nome a ser apresentado:");
p2.Nome = Console.ReadLine();
p2.Idade = 22;

p2.Apresentar();
