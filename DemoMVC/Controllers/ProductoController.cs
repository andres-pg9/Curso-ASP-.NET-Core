using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DemoMVC.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            var producto = new Models.Producto{Id = 1, Nombre = "Producto", Descripcion = "Descripcion del producto 1", Precio = 100};
            
            return View(producto);
        }

    }
}