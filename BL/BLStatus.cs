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
    public class BLStatus
    {
        public bool Inserir(Tbl_Status status)
        {
            try
            {
                using (SimuladorUnicoEntities entity = new SimuladorUnicoEntities())
                {
                    bool bolRetorno = false;

                    entity.Configuration.LazyLoadingEnabled = false;
                    Tbl_Status lStatus = entity.Tbl_Status.Where(v => v.nm_status == status.nm_status && v.id_grp_status == status.id_grp_status).FirstOrDefault();

                    if (lStatus == null)
                    {
                        entity.Tbl_Status.Add(status);
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

        public bool Alterar(Tbl_Status status)
        {
            try
            {
                using (SimuladorUnicoEntities entity = new SimuladorUnicoEntities())
                {
                    bool bolRetorno = true;

                    Tbl_Status lStatus = entity.Tbl_Status.Where(v => v.id_status == status.id_status).FirstOrDefault();

                    lStatus.id_grp_status = status.id_grp_status;

                    lStatus.dv_ativo = status.dv_ativo;

                    lStatus.id_status_ex = status.id_status_ex;

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

        public List<Tbl_Status> Listar()
        {
            List<Tbl_Status> lstStatus = new List<Tbl_Status>();

            using(SimuladorUnicoEntities entity = new SimuladorUnicoEntities())
            {
                entity.Configuration.LazyLoadingEnabled = true;

                lstStatus = entity.Tbl_Status.Include("Tbl_Usuario").Include("Tbl_Grupo_Status").ToList();

                entity.Dispose();
            }

            return lstStatus;
        }

       
        
    }
}
