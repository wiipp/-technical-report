using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Dominio.Entidades
{
    public class atendente
    {
        public atendente()
        {
            this.rats = new List<rat>();
        }

        public int cod_ate { get; set; }
        public string nome_ate { get; set; }
        public string status_ate { get; set; }
        public string email_ate { get; set; }
        public string usuario { get; set; }
        public string delete_ate { get; set; }
        public virtual ICollection<rat> rats { get; set; }
    }
}
