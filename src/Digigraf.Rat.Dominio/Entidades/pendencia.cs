using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Dominio.Entidades
{
    public class pendencia
    {
        public int cod_pen { get; set; }
        public string des_pen { get; set; }
        public string a1_cod { get; set; }
        public Nullable<int> cod_tec { get; set; }
        public string fecha_pen { get; set; }
        public Nullable<int> cod_rat { get; set; }
        public string empresa { get; set; }
        public virtual tecnico tecnico { get; set; }
    }
}
