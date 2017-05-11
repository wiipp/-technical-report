using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Dominio.Entidades
{
    public class grupo
    {
        public grupo()
        {
            this.tecnicoes = new List<tecnico>();
        }

        public int cod_gru { get; set; }
        public string des_gru { get; set; }
        public string status_gru { get; set; }
        public string delete_gru { get; set; }
        public virtual ICollection<tecnico> tecnicoes { get; set; }
    }
}
