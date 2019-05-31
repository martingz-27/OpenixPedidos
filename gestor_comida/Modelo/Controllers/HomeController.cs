
using Modelo.Models;
using Modelo.Models.PatronRepositorio;
using Modelo.Models.UnityOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Modelo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

      

        /*public ActionResult GetPlatos()
        {
            var unitofwork = new UnitOfWork(new GestorComidaContext());
            
            List<Plato> platos = new List<Plato>();
            platos.Add(unitofwork.platos.get(5));
            unitofwork.Complete();
            return Json(platos, JsonRequestBehavior.AllowGet);
        }*/
    }
}