using System;
using System.Collections.Generic;

namespace OOClasse
{
    class Projeto
    {
        static void Main(string[] args)
        {
            Programadora cSharper = new Programadora(9, true);
            cSharper.AnosDeCarreira = 1;

            cSharper.Linguagens = new List<string>();
            cSharper.Linguagens.Add("C#");
            cSharper.Linguagens.Add("Javascript");

            cSharper.PossuiGraduacao = true;
            cSharper.Salario = 2000;
            cSharper.TrabalhaNaArea = true;
            
            cSharper.Idade = 26;
            cSharper.Nome = "Giuliana";
            cSharper.NomeDaMae = "Vania";
            
            cSharper.MeuEndereco = new Endereco();
            cSharper.MeuEndereco.Cidade = "Osasco";
            cSharper.MeuEndereco.Estado = "São Paulo";
            cSharper.MeuEndereco.Bairro = "Jaguaribe";

            Console.WriteLine
                (
                $"Olá {cSharper.Nome}," +
                $"você mora no bairro " +
                $"{cSharper.MeuEndereco.Bairro} " +
                $"e tem {cSharper.Idade} anos"
                );

        }
    }
}

//$ = interpolação, serve para colocar variaveis no meio