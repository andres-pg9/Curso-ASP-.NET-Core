using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DemoMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DemoMVC.Controllers
{
    public class ProductoController : Controller
    {
        //Variable global del controlador
        private readonly DataContext _context;
        public ProductoController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var producto = new Models.Producto{Id = 1, Nombre = "Producto", Descripcion = "Descripcion del producto 1", Precio = 100};
            
            var productos = _context.Productos.ToList();

            return View(productos);
        }

    }
}