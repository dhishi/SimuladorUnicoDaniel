using SimuladorUnico.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BL;
using BL.Entity;

namespace SimuladorUnico.Interface
{
    public class conectorGrupoStatus
    {
        public bool Inserir(SimuladorUnico.Models.GrupoStatus grupoStatus)
        {
            Tbl_Grupo_Status eGrupoStatus = new Tbl_Grupo_Status();

            eGrupoStatus.nm_grp_status = grupoStatus.NmGrupoStatus;

            eGrupoStatus.id_usuario = grupoStatus.IdUsuario;

            eGrupoStatus.dt_cadastro = DateTime.Now;

            eGrupoStatus.dv_ativo = grupoStatus.DvAtivo;

            return new BL.BLGrupoStatus().Inserir(eGrupoStatus);
        }

        public void Excluir(int id)
        {
            new BL.BLGrupoStatus().Excluir(id);
        }

        public bool Alterar (SimuladorUnico.Models.GrupoStatus grupoStatus)
        {
            Tbl_Grupo_Status eGrupoStatus = new Tbl_Grupo_Status();

            eGrupoStatus.id_grp_status = grupoStatus.IdGrupoStatus;

            eGrupoStatus.nm_grp_status = grupoStatus.NmGrupoStatus;

            eGrupoStatus.id_usuario = grupoStatus.IdUsuario;

            eGrupoStatus.dv_ativo = grupoStatus.DvAtivo;

            return new BL.BLGrupoStatus().Alterar(eGrupoStatus);
        }

        public List<GrupoStatus> Listar()
        {
            List<Tbl_Grupo_Status> lstGrupoStatusEntity = new BLGrupoStatus().Listar();

            List<GrupoStatus> lstGrupoStatus = new List<GrupoStatus>();

            lstGrupoStatusEntity.ForEach(v => lstGrupoStatus.Add(new GrupoStatus { DtCadastro = v.dt_cadastro, DvAtivo = v.dv_ativo, IdGrupoStatus = v.id_grp_status, NmGrupoStatus = v.nm_grp_status, IdUsuario = v.id_usuario, NmUsuario = v.Tbl_Usuario.nm_usuario }));

            return lstGrupoStatus;
        }

    }
}