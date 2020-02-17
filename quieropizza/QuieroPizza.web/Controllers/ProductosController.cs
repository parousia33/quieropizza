using QuieroPïzza.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuieroPizza.web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var productosBL = new  ProductosBL();
            var listaProdutos = productosBL.ObtenerProducto();

            return View(listaProdutos);
        }
    }
}