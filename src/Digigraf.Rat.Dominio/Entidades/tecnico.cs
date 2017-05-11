using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Dominio.Entidades
{
    public class tecnico
    {
        public tecnico()
        {
            this.pendencias = new List<pendencia>();
            this.rats = new List<rat>();
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
        public virtual grupo grupo { get; set; }
        public virtual ICollection<pendencia> pendencias { get; set; }
        public virtual ICollection<rat> rats { get; set; }
    }
}
