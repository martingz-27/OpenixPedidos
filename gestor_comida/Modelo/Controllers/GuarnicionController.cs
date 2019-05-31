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
    public class GuarnicionController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public ActionResult NewGuarnicion()
        {
            return View();
        }
        public GuarnicionController()
        {
            this._unitOfWork = new UnitOfWork(new GestorComidaContext());

        }

        [System.Web.Http.HttpPost]
        public ActionResult Create(Guarnicion guarnicion)
        {
            Insert(guarnicion);

            return RedirectToAction("index", "Guarnicion/NewGuarnicion");
        }

        public void Insert(Guarnicion guarnicion)
        {
            _unitOfWork.GuarnicionRepository.AddGuarnicion(guarnicion);
            _unitOfWork.Complete();
        }


    }
}
