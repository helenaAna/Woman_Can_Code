using System;

namespace OrcamentoDomestico
{
    class Program
    {
        static void Main(string[] args)
        {
            Parente mae = new Parente();

            mae.Nome = "Maria";
            mae.Idade = 40;
            mae.MinhaProfissao = new Profissao();
            mae.MinhaProfissao.Cargo = "Advogada";
            mae.MinhaProfissao.Salario = 5000;
            mae.ResponsavelPor = new Financa();
            mae.ResponsavelPor.Alimentacao = 1000;
            mae.ResponsavelPor.Escola = 800;
            mae.ResponsavelPor.Energia = 200;
            
            Parente pai = new Parente();
            pai.Nome = "Jose";
            pai.Idade = 45;
            pai.MinhaProfissao = new Profissao();
            pai.MinhaProfissao.Cargo = "Médico";
            pai.MinhaProfissao.Salario = 10000;
            pai.ResponsavelPor = new Financa();
            pai.ResponsavelPor.Aluguel = 5000;
            pai.ResponsavelPor.Condominio = 1000;

            Parente filho = new Parente();
            filho.Nome = "Junior";
            filho.Idade = 16;
            filho.MinhaProfissao = new Profissao();
            filho.MinhaProfissao.Cargo = "Assistente";
            filho.MinhaProfissao.Salario = 1000;
            filho.ResponsavelPor = new Financa();
            filho.ResponsavelPor.Internet = 200;
            filho.ResponsavelPor.Agua = 100;

            float rendaTotal = mae.MinhaProfissao.Salario + pai.MinhaProfissao.Salario + filho.MinhaProfissao.Salario;
            float custoTotalmae = (mae.ResponsavelPor.Alimentacao + mae.ResponsavelPor.Escola + mae.ResponsavelPor.Energia);
            float custoTotalpai = (pai.ResponsavelPor.Aluguel + pai.ResponsavelPor.Condominio);
            float custoTotalfilho = (filho.ResponsavelPor.Internet + filho.ResponsavelPor.Agua);
            float custoTotalFamilia = (custoTotalmae+custoTotalpai+custoTotalfilho);
            float porcentagemMae = (custoTotalmae*100)/custoTotalFamilia;
            float porcentagemPai = (custoTotalpai*100)/custoTotalFamilia;
            float porcentagemFilho = (custoTotalfilho*100)/custoTotalFamilia;

            Console.WriteLine($"A Renda total da Familia é R${rendaTotal}");
            Console.WriteLine($"A Mãe, {mae.Nome} de {mae.Idade} anos, contribue com R${custoTotalmae} que equivale a {porcentagemMae}% do custo total da família");
            Console.WriteLine($"O Pai, {pai.Nome} de {pai.Idade} anos, contribue com R${custoTotalpai} que equivale a {porcentagemPai}% do custo total da família");
            Console.WriteLine($"A Mãe, {filho.Nome} de {filho.Idade} ano, contribue com R${custoTotalfilho} que equivale a {porcentagemFilho}% do custo total da família");
            System.Console.WriteLine($"O custo total da família é de R${custoTotalFamilia}");
        }
    }
}
