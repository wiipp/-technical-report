using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Dominio.Entidades
{
    public class ratorc
    {
        public int cod_ratorc { get; set; }
        public Nullable<int> cod_rat { get; set; }
        public string valor_orc { get; set; }
        public string pagto_orc { get; set; }
        public string fpagto_orc { get; set; }
        public string banco_orc { get; set; }
        public string prazo_orc { get; set; }
        public string imposto_orc { get; set; }
        public string garantia_orc { get; set; }
        public string frete_orc { get; set; }
        public string validade_orc { get; set; }
        public string servico_orc { get; set; }
        public string teste { get; set; }
        public virtual rat rat { get; set; }
    }
}
