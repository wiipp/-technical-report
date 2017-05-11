using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Digigraf.Rat.Aplicacao.ViewModel
{
  public  class RatVm : DadosPadroesVm
    {
        public RatVm()
        {
            DropListGrupo = new List<SelectListItem>{
                new SelectListItem {Text = "Indigo", Value = "3" },
                new SelectListItem {Text = "Scitex", Value = "8" },
                new SelectListItem {Text = "CBD" , Value = "10"}

            };

            DropListTecnico = new List<SelectListItem>{
                new SelectListItem {Text = "Ronald Lopes", Value = "5" },
                new SelectListItem {Text = "Roberta - Scitex", Value = "12" },
                new SelectListItem {Text = "Juliano Blanco" , Value = "19"},
                new SelectListItem {Text = "Emerson Zanella" , Value = "30"},
                new SelectListItem {Text = "Anderson Roberto" , Value = "38"},
                new SelectListItem {Text = "Daniel Pinheiro" , Value = "42"},
                new SelectListItem {Text = "Patrik Cardoso" , Value = "50"},
                new SelectListItem {Text = "Roberta - Indigo" , Value = "55"},
                new SelectListItem {Text = "Fernando Siqueira" , Value = "59"},
                new SelectListItem {Text = "Roberta - Ass.Tecnica" , Value = "61"},
                new SelectListItem {Text = "Eliene Santos" , Value = "62"},
                new SelectListItem {Text = "Roberta - Fotoba" , Value = "63"},
                new SelectListItem {Text = "Alexandre Romao" , Value = "68"},
                new SelectListItem {Text = "Marco Almeida" , Value = "70"},

            };

            DropListAtendente = new List<SelectListItem>{
                new SelectListItem {Text = "Eliene Santos", Value = "19" },
                new SelectListItem {Text = "Roberta", Value = "3" },
                new SelectListItem {Text = "Ronald" , Value = "14"}


            };
        }

        [Key]
        [Display(Name ="Cod.RAT")]
        public int? cod_rat { get; set; }

        [Required(ErrorMessage ="Campo Obrigatorio")]
        [Display(Name =" Cod.Cliente:")]
        public string a1_cod { get; set; }

        [ScaffoldColumn(false)]      
        [Display(Name = " Data do RAT:")]
        public string dt_rat { get; set; } // tem converter para string.

        [Display(Name = "Data Visita Rat:")]
        //[DisplayFormat(DataFormatString = "{MM/dd/yyyy}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")] // tem converter para string.
        public string dt_vis_rat { get; set; }

        //public DateTime? Dt_Fecha_Cham { get; set; }
        [Display(Name = "Abertura do Chamado HP:")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")] // tem converter para string.
        public string dt_abre_cham_hp { get; set; }

        [Display(Name = "Fechamento do Chamado HP:")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")] // tem converter para string.
        public string dt_fecha_cham_hp { get; set; }

        [Display(Name = "Hora Abre Chamado HP:")]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Time, ErrorMessage = "Hora em formato inválido")]
        public string hr_abre_cham_hp { get; set; }
                
        [Display(Name = "Hora Fecha Chamado HP:")]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Time, ErrorMessage = "Hora em formato inválido")]
        public string hr_fecha_cham_hp { get; set; }
                
        [Display(Name = "Solucao:")]
        public string solucao { get; set; }

        public string severidade { get; set; }
                
        [Display(Name = "Horario do RAT:")]
         public string hr_rat { get; set; }

        [Display(Name = "Hora Visita Incial:")]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Time, ErrorMessage = "Hora em formato inválido")]
        public string hr_vis_rat { get; set; }
                
        [Display(Name = "Hora Visita Final:")]
        [DataType(DataType.Time, ErrorMessage = "Hora em formato inválido")]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        public string hr_vis_fim_rat { get; set; }

        [Display(Name ="Numero de Serie")]
        public string n_serie_exp { get; set; }
        //public string F1_Doc { get; set; }
        //public string F2_Doc { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = " Atendente:")]
        public int cod_ate { get; set; } // padrao é AtendenteId
        public List<SelectListItem> DropListAtendente { get; set; }

        public virtual AtendenteVm Atendente { get; set; }
        
        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = " Tecnico:")]
        public int cod_tec { get; set; }
        public List<SelectListItem> DropListTecnico { get; set; }

        public virtual TecnicoVm Tecnico { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = " Grupo:")]
        public int? cod_gru { get; set; }
        public List<SelectListItem> DropListGrupo { get; set; }
                
        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = " Tipo Rat:")]
        public string tipo_rat { get; set; }

        [Display(Name = " Equipamento:")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio")]
        [Display(Name = " Codigo Produto:")]
        public string b1_cod { get; set; }

        //public string C5_Nac { get; set; }
         public string tipo_o_rat { get; set; }
         public string chamado { get; set; }

        [Display(Name = " Local:")]
        public string local_rat { get; set; }

        [Display(Name ="Servico Solicitado: ")]
        public string defeito_rat { get; set; }

        [Display(Name ="Defeito diagnosticado: ")]
        public string def_diag_rat { get; set; }

    
        [Display(Name = " Valor Rat:")]
         public decimal? valor_rat { get; set; }

        [Display(Name = " Mao de Obra:")]
        public decimal? m_obra_rat { get; set; }

        public string c5_num { get; set; }

        [Display(Name = " KM:")]
        public double? km_cli_rat { get; set; }

        [Display(Name = " Instalacao do Softaware:")]
        public string inst_sw { get; set; }

        [Display(Name ="Observações:")]
        public string obs_rat { get; set; }

        [Display(Name = " Empresa:")]
        public string empresa { get; set; }


        //public string Tp_Serv_Rat { get; set; }
        // public string Entregue_Rat { get; set; }
        //public string Data_Email { get; set; }

        [Display(Name = " Email do Cliente:")]
        [DataType(DataType.EmailAddress)]
        [StringLength(128)]
        public string email_cli_rat { get; set; }

        [Display(Name ="Pendências: ")]
        public string pendencia_rat { get; set; }

        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }

        [Display(Name ="Cliente")]
        public string A1_NOME { get; set; }

        [Display(Name = "Endereco")]
        public string A1_END { get; set; }

        [Display(Name = "Municipio")]
        public string A1_MUN { get; set; }

        [Display(Name = "Fax:")]
        public string A1_FAX { get; set; }

        [Display(Name = "Contato:")]
        public string A1_CONTATO { get; set; }

        [Display(Name = "Estado:")]
        public string A1_EST { get; set; }

        [Display(Name = "CEP:")]
        public string A1_CEP { get; set; }

        [Display(Name = "Telefone:")]
        public string A1_TEL { get; set; }
        //public string DescGrupo { get; set; }

        //public string DescAtendente { get; set; }

        //public string DescTecnico { get; set; }


    }
}
