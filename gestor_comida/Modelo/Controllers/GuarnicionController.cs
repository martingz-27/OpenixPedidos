using Core.Models;
using Core.Models.Dominio;
using System.Web.Mvc;

namespace Modelo.Controllers
{
    public class GuarnicionController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ActionResult NewGuarnicion()
        {
            return View();
        }
        public GuarnicionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        

        [System.Web.Http.HttpPost]
        public ActionResult Create(Guarnicion guarnicion)
        {
            Insert(guarnicion);

            return RedirectToAction("index", "Guarnicion/NewGuarnicion");
        }

        public void Insert(Guarnicion guarnicion)
        {
            _unitOfWork._GuarnicionRepo.AddGuarnicion(guarnicion);
            _unitOfWork.Complete();
        }


    }
}
