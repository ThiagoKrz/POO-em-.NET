using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        
        public Professor(string nome) :base(nome)
        {

        }
       public decimal Salario { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos de Idade, meu salário é de R${Salario}.00!");
        } 
    }
}