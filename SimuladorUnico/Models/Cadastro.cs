using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimuladorUnico.Models
{
    public class Cadastro
    {
        public int IdUsuario { get; set; }

        [DisplayName("Usuário Cadastro")]
        [ReadOnly(true)]
        public string NmUsuario { get; set; }

        [DisplayName("Data de Cadastro")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DtCadastro { get; set; }
    }
}