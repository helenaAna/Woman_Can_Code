using System;
using System.Collections.Generic;
using System.Text;

namespace OrcamentoDomestico
{
    class Profissao : Parente
    {
        public string Cargo { get; set; }

        public float Salario { get; set; }

        public int AnosCarreira { get; set; }

    }
}
