using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Aplicacao.ViewModel
{
   public class TecnicoVm
    {
        public TecnicoVm()
        {
            this.Rat = new List<RatVm>();
        }

        public int cod_tec { get; set; }
        public string nome_tec { get; set; }
        public string status_tec { get; set; }
        public Nullable<int> cod_gru { get; set; }
        public string a3_cod { get; set; }
        public string usuario { get; set; }
        public string email { get; set; }
        public Nullable<double> salario_tec { get; set; }
        public Nullable<double> fator_tec { get; set; }
        public Nullable<double> horas_tec { get; set; }
        public virtual GrupoVm Grupo { get; set; }
        // public virtual ICollection<pendencia> pendencias { get; set; }
        public virtual ICollection<RatVm> Rat { get; set; }
    }

}
