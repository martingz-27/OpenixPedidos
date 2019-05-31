using Modelo.Models;
using Modelo.Models.UnityOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Modelo.Controllers
{
    public class GestorComidaController : ApiController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Prueba()
        {
            var unitofwork = new UnitOfWork(new GestorComidaContext());
            unitofwork.platos.AddPlato(new Plato("fideos", 150));
            unitofwork.Complete();
            return View();
        }


    }
}
