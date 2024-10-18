using DemoMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;

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
            
            var productos = _context.Productos.Include(p => p.Categoria).Include(p=>p.Proveedor).ToList();

            return View(productos);
        }

        [HttpGet]
        public async Task <IActionResult> Create()
        {
            ViewBag.Categorias = await _context.Categorias.ToListAsync();
            ViewBag.Proveedores = await _context.Proveedores.ToListAsync();

            return View();
        }

        [HttpPost] //Recibe el modelo producto y trabaja con los datos
        public async Task <IActionResult> Create( [Bind("Id,Nombre,Descripcion,Precio,CategoriaId,ProveedorId")]  Producto producto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Categorias = await _context.Categorias.ToListAsync();
            ViewBag.Proveedores = await _context.Proveedores.ToListAsync();

            return View(producto);
        }


        [HttpGet]
        public async Task <IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }

            ViewBag.Categorias = await _context.Categorias.ToListAsync();
            ViewBag.Proveedores = await _context.Proveedores.ToListAsync();

            return View(producto);
        }

        [HttpPost]
        public async Task <IActionResult> Edit(int id, [Bind("Id,Nombre,Descripcion,Precio,CategoriaId,ProveedorId")]  Producto producto)
        {
            if (id != producto.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Update(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(producto);
        }

    }
}