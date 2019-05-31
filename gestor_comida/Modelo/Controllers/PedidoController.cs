using Modelo.Models;
using Modelo.Models.DTO;
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
    public class PedidoController : Controller
    {
        private readonly UnitOfWork _unitOfWork;
        private List<MenuDTO> menuDTOs;

        public ActionResult NewPedido()
        {
            MenuDTO menuDTO = new MenuDTO();
            menuDTO._menuDTOs = GetMenu();
            return View(menuDTO);
        }

        public ActionResult MenuDelDia()
        {
            return View(_unitOfWork.MenuRepository.GetAll());
        }
        public PedidoController()
        {
            this._unitOfWork = new UnitOfWork(new GestorComidaContext());
        }

        [System.Web.Http.HttpPost]
        public ActionResult Create(Menu menu)
        {
            InserMenu(menu);
            return RedirectToAction("index", "Pedido/NewPedido");
        }

        public void InserMenu(Menu menu)
        {
            _unitOfWork.MenuRepository.AddMenu(menu);
            _unitOfWork.Complete();
        }

        public ActionResult GetListPlatos()
        {
            return Json(new { data = _unitOfWork.PlatoRepository.GetAll() }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetListGuarniciones()
        {
            return Json(new { data = _unitOfWork.GuarnicionRepository.GetAll() }, JsonRequestBehavior.AllowGet);
        }

        public IEnumerable<MenuDTO> GetMenu()
        {
            menuDTOs = new List<MenuDTO>();
            
            IEnumerable<Plato> platos = _unitOfWork.PlatoRepository.GetAll();
            IEnumerable<Guarnicion> guarnicions = _unitOfWork.GuarnicionRepository.GetAll();
            List<String> list = new List<string>();

            foreach (Guarnicion g in guarnicions)
            {
                list.Add(g._NombreGuarnicion);
            }

            foreach (Plato p in platos)
            {
                MenuDTO menuDTO = new MenuDTO();
                menuDTO._Nombre = p._Nombre;
                menuDTO._Precio = p._Precio;
                menuDTO._ListaNombreGuarniciones = list;  
                menuDTOs.Add(menuDTO);
            }
            return menuDTOs;
        }
    }
}
