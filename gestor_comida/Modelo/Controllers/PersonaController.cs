using Core.Models;
using Core.Models.Dominio;
using System.Web.Mvc;

namespace Modelo.Controllers
{
    public class PersonaController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public PersonaController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ActionResult NewPersona()
        {
            return View();
        }

        [System.Web.Http.HttpPost]
        public ActionResult Create(Persona persona)
        {
            InserPersona(persona);

            return RedirectToAction("index", "Persona/NewPersona");
        } 

        public void InserPersona(Persona persona)
        {
            _unitOfWork._PersonaRepo.AddPersona(persona);
            _unitOfWork.Complete();
        }
    }
}
