using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SimuladorUnico.Models
{
    public class GrupoStatus : Cadastro
    {
        public int IdGrupoStatus { get; set; }

        [DisplayName("Grupo Status")]
        public string NmGrupoStatus { get; set; }

        [DisplayName("Ativo")]
        public bool DvAtivo { get; set; }

        public bool DvEditar { get; set; }
    }
}