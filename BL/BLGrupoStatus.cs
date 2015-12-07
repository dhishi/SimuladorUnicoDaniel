using BL.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BL
{
    public class BLGrupoStatus
    {
        public bool Inserir(Tbl_Grupo_Status grupoStatus)
        {
            try
            {
                using (SimuladorUnicoEntities entity = new SimuladorUnicoEntities())
                {
                    bool bolRetorno = false;

                    entity.Configuration.LazyLoadingEnabled = false;
                    Tbl_Grupo_Status lGrupoStatus = entity.Tbl_Grupo_Status.Where(v => v.nm_grp_status == grupoStatus.nm_grp_status).FirstOrDefault();

                    if (lGrupoStatus == null)
                    {
                        entity.Tbl_Grupo_Status.Add(grupoStatus);
                        bolRetorno = true;
                        entity.SaveChanges();
                    }

                    entity.Dispose();

                    return bolRetorno;

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Alterar(Tbl_Grupo_Status grupoStatus)
        {
            try
            {
                using (SimuladorUnicoEntities entity = new SimuladorUnicoEntities())
                {
                    bool bolRetorno = true;

                    Tbl_Grupo_Status lGrupoStatus = entity.Tbl_Grupo_Status.Where(v => v.id_grp_status == grupoStatus.id_grp_status).FirstOrDefault();

                    lGrupoStatus.nm_grp_status = grupoStatus.nm_grp_status;

                    lGrupoStatus.dv_ativo = grupoStatus.dv_ativo;

                    entity.SaveChanges();

                    entity.Dispose();

                    return bolRetorno;

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(int id)
        {
            using (SimuladorUnicoEntities entity = new SimuladorUnicoEntities())
            {
                entity.Tbl_Grupo_Status.Remove(entity.Tbl_Grupo_Status.Where(v => v.id_grp_status == id).Single());

                entity.SaveChanges();
            }
        }

        public List<Tbl_Grupo_Status> Listar()
        {
            List<Tbl_Grupo_Status> lstGrupoStatus = new List<Tbl_Grupo_Status>();

            using(SimuladorUnicoEntities entity = new SimuladorUnicoEntities())
            {
                entity.Configuration.LazyLoadingEnabled = true;

                lstGrupoStatus = entity.Tbl_Grupo_Status.Include("Tbl_Usuario").ToList();

                entity.Dispose();
            }

            return lstGrupoStatus;
        }

       
        
    }
}
