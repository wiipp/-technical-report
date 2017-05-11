using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Aplicacao.ViewModel
{
    public class GrupoVm
    {
        public GrupoVm()
        {
            this.Tecnico = new List<TecnicoVm>();

        }

        public int cod_gru { get; set; }
        public string des_gru { get; set; }
        public string status_gru { get; set; }
        public string delete_gru { get; set; }
        public virtual ICollection<TecnicoVm> Tecnico { get; set; }


    }

 
}
