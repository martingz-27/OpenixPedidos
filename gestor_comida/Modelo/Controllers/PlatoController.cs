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
    public class PlatoController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public ActionResult New()
        {
            return View();
        }
        public PlatoController()
        {
            this._unitOfWork = new UnitOfWork(new GestorComidaContext());
            //InserPlato();
        }

        [System.Web.Http.HttpPost]
        public ActionResult Create(Plato plato)
        {
            InserPlato(plato);
            
            return RedirectToAction("index","Plato/New");
        }

        public void InserPlato(Plato plato)
        {
            
           _unitOfWork.PlatoRepository.AddPlato(plato);
           _unitOfWork.Complete();
        }

        public void GetListPlatos()
        {
            _unitOfWork.PlatoRepository.GetAll();
        }

    }

}
