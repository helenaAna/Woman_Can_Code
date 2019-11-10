using System;
using System.Collections.Generic;
using System.Text;

namespace Crushs
{
    class Comportamento
    {
        public string Descricao { get; set; }
        public int Intensidade { get; set; }


        public void IncluirIntensidade(int intensidade)
        {
            Intensidade += intensidade;
        }

        public void DiminuirIntensidade(int intensidade)
        {
            Intensidade -= intensidade;
        }
    }
}
