using Core.Models;
using Core.Models.Dominio;
using Modelo.Models;
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
        private readonly IUnitOfWork _unitOfWork;
 
        
        public PlatoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ActionResult New()
        {
            return View();
        }
        [System.Web.Http.HttpPost]
        public ActionResult Create(Plato plato)
        {
            InserPlato(plato);
            
            return RedirectToAction("index","Plato/New");
        }

        public void InserPlato(Plato plato)
        {
            
           _unitOfWork._PlatoRepo.AddPlato(plato);
           _unitOfWork.Complete();
        }

        public void GetListPlatos()
        {
            _unitOfWork._PlatoRepo.GetAll();
        }

    }

}
