using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimuladorUnico.Models
{
    public class Status: Cadastro
    {
        
        public int IdStatus { get; set; }

        [DisplayName("Id Status")]
        public int IdStatusEx { get; set; }

        [DisplayName("Status")]
        public string NmStatus { get; set; }

        [DisplayName("Ativo")]
        public bool DvAtivo { get; set; }

        public int IdGrupoStatus { get; set; }

        public GrupoStatus oGrupoStatus { get; set; }

        public List<GrupoStatus> lstGrupoStatus { get; set; }

        public IEnumerable<SelectListItem> lstGrupoStatusItens { get { return new SelectList(lstGrupoStatus, "IdGrupoStatus", "NmGrupoStatus"); } }

        public Status()
        {
            oGrupoStatus = new GrupoStatus();
        }

    }
}