using Modelo.Core.DTO;
using System.Collections.Generic;
using System.Web.Mvc;
using Modelo.Core.Models.Dominio;
using Modelo.Core.Models;

namespace Modelo.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        //private IEnumerable<Plato> platos { get; set; }

        public PedidoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ActionResult NewPedido()
        {
            MenuDTO menuDTO = new MenuDTO();
            menuDTO.menus = GetMenu();
            return View(menuDTO);
        }

        public ActionResult MenuDelDia()
        {
            return View(_unitOfWork._MenuRepo.GetAll());
        }
        

        [System.Web.Http.HttpPost]
        public ActionResult Create(Menu menu)
        {
            /*var menu = new Menu();
            menu.idPlato = menuDTO.Platos.id;*/
            InserMenu(menu);
            return RedirectToAction("index", "Pedido/NewPedido");
        }

        public void InserMenu(Menu menu)
        {
            _unitOfWork._MenuRepo.AddMenu(menu);
            _unitOfWork.Complete();
        }

    /*    public ActionResult GetListPlatos()
        {
            return Json(new { data = _unitOfWork._PlatoRepo.GetAll() }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetListGuarniciones()
        {
            return Json(new { data = _unitOfWork._GuarnicionRepo.GetAll() }, JsonRequestBehavior.AllowGet);
        }*/

        public IEnumerable<MenuDTO> GetMenu()
        {
            List<MenuDTO> menuDTOs = new List<MenuDTO>();
           // platos = _unitOfWork._PlatoRepo.GetAll();
           // IEnumerable<Guarnicion> guarnicions = _unitOfWork._GuarnicionRepo.GetAll();
            /*foreach (Plato p in platos)
            {
                MenuDTO menuDTO = new MenuDTO();
                menuDTO.idPlatoDTO = p.id;
                menuDTO.nombrePlatoDTO = p._Nombre;
                menuDTO.precioPlatoDTO = p._Precio;
                menuDTO._ListaNombreGuarniciones = guarnicions;  
                menuDTOs.Add(menuDTO);
            }*/
            return menuDTOs;
        }
    }
}
