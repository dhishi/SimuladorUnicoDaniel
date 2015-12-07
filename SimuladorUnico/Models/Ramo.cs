using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimuladorUnico.Models
{
    public class Ramo
    {
        
        public int IdRamo { get; set; }

        [DisplayName("Nº Ramo")]
        [Required]
        public int NrRamo { get; set; }

        [DisplayName("Status")]
        public string NmStatus { get; set; }

        [Required]
        public int IdStatus { get; set; }

        [Required]
        public int IdUsuario { get; set; }

        [DisplayName("Usuário Cadastro")]
        public string NmUsuario { get; set; }

        [ReadOnly(true)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public int DtCadastro { get; set; }

        [DisplayName("Ramo")]
        [Required]
        public string NmRamo { get; set; }
    }

}