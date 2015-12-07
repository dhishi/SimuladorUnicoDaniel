using SimuladorUnico.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BL;
using BL.Entity;

namespace SimuladorUnico.Interface
{
    public class conectorStatus
    {
        public bool Inserir(SimuladorUnico.Models.Status status)
        {
            Tbl_Status eStatus = new Tbl_Status();

            eStatus.nm_status = status.NmStatus;

            eStatus.id_usuario = status.IdUsuario;

            eStatus.dt_cadastro = DateTime.Now;

            eStatus.dv_ativo = status.DvAtivo;

            eStatus.id_status_ex = status.IdStatusEx;

            eStatus.id_grp_status = status.IdGrupoStatus;

            eStatus.Tbl_Grupo_Status.id_grp_status = status.IdGrupoStatus;

            return new BL.BLStatus().Inserir(eStatus);
        }

        public void Excluir(int id)
        {
            new BL.BLGrupoStatus().Excluir(id);
        }

        public bool Alterar(SimuladorUnico.Models.Status status)
        {
            Tbl_Status eStatus = new Tbl_Status();

            eStatus.id_status = status.IdStatus;

            eStatus.id_grp_status = status.IdGrupoStatus;

            eStatus.dv_ativo = status.DvAtivo;

            eStatus.nm_status = status.NmStatus;

            eStatus.id_status_ex = status.IdStatusEx;

            return new BL.BLStatus().Alterar(eStatus);
        }

        public List<Status> Listar()
        {
            List<Tbl_Status> lstStatusEntity = new BLStatus().Listar();

            List<Status> lstStatus = new List<Status>();

            lstStatusEntity.ForEach(v => lstStatus.Add(new Status
            {
                DtCadastro = v.dt_cadastro
                ,
                DvAtivo = v.dv_ativo
                ,
                IdGrupoStatus = v.id_grp_status
                ,
                oGrupoStatus = new GrupoStatus { NmGrupoStatus = v.Tbl_Grupo_Status.nm_grp_status }
                ,
                IdUsuario = v.id_usuario
                ,
                NmUsuario = v.Tbl_Usuario.nm_usuario
                ,
                NmStatus = v.nm_status,
                IdStatus = v.id_status,
                IdStatusEx = (v.id_status_ex ?? 0)

            }));

            return lstStatus;
        }

    }
}