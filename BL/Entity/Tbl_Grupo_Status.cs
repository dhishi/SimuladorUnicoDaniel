//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BL.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Grupo_Status
    {
        public Tbl_Grupo_Status()
        {
            this.Tbl_Status = new HashSet<Tbl_Status>();
        }
    
        public int id_grp_status { get; set; }
        public string nm_grp_status { get; set; }
        public int id_usuario { get; set; }
        public System.DateTime dt_cadastro { get; set; }
        public bool dv_ativo { get; set; }
    
        public virtual Tbl_Usuario Tbl_Usuario { get; set; }
        public virtual ICollection<Tbl_Status> Tbl_Status { get; set; }
    }
}
