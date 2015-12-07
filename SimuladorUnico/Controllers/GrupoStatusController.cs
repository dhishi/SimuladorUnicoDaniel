using SimuladorUnico.Interface;
using SimuladorUnico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace SimuladorUnico.Controllers
{
    public class GrupoStatusController : Controller
    {
        // GET: GrupoStatus
        public ActionResult _Lista()
        {

            return PartialView(new conectorGrupoStatus().Listar());
        }

        // GET: GrupoStatus/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GrupoStatus/Create
        public ActionResult _Criar()
        {
            GrupoStatus grpStatus = new GrupoStatus();

            grpStatus.NmUsuario = "João";

            grpStatus.IdUsuario = 1;

            return PartialView("_CriarEditar", grpStatus);
        }

        // POST: GrupoStatus/Create

        [HttpPost]
        public ActionResult Salvar(GrupoStatus grupo)
        {
            try
            {
                grupo.IdUsuario = 1;

                conectorGrupoStatus conector = new conectorGrupoStatus();

                bool bolSalvo = grupo.IdGrupoStatus > 0 ? conector.Alterar(grupo) : conector.Inserir(grupo);

                if (bolSalvo)
                    return PartialView("_Lista", conector.Listar());
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }

        // GET: GrupoStatus/Edit/5
        public ActionResult _Editar(int id)
        {
            conectorGrupoStatus conector = new conectorGrupoStatus();

            return PartialView("_CriarEditar", conector.Listar().Where(v => v.IdGrupoStatus == id).SingleOrDefault());

        }

        // POST: GrupoStatus/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: GrupoStatus/Delete/5
        public ActionResult Excluir(int id)
        {
            try
            {
                conectorGrupoStatus conector = new conectorGrupoStatus();

                conector.Excluir(id);

                return PartialView("_Lista", conector.Listar());
            }
            catch (Exception)
            {
                return null;
            }
        }

        // POST: GrupoStatus/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
