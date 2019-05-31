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
    public class PersonaController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public ActionResult NewPersona()
        {
            return View();
        }
        public PersonaController()
        {
            this._unitOfWork = new UnitOfWork(new GestorComidaContext());
            
        }

        [System.Web.Http.HttpPost]
        public ActionResult Create(Persona persona)
        {
            InserPersona(persona);

            return RedirectToAction("index", "Persona/NewPersona");
        } 

        public void InserPersona(Persona persona)
        {
            _unitOfWork.PersonaRepository.AddPersona(persona);
            _unitOfWork.Complete();
        }
    }
}
