using System;
using System.Collections.Generic;
using System.Text;

namespace OOClasse
{
    class Programadora : Pessoa
    {
        public Programadora(int anosCarreira, bool possuiGraduacao)
        {
            Linguagens = new List<string>();
            AnosDeCarreira = anosCarreira;
            PossuiGraduacao = possuiGraduacao;

        }
        public List<string> Linguagens { get; set; }
        public int AnosDeCarreira { get; set; }
        public bool PossuiGraduacao { get; set; }
        public bool TrabalhaNaArea { get; set; }
        public decimal Salario { get; set; }
    }
}

//list serve para informar que será inserido mais de uma opção