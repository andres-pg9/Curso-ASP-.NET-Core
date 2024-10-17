
namespace DemoMVC.Models
{
    public class Proveedor
    {
        public int Id {get; set;}

        public string Nombre {get; set;}

        //Cada proveedor tiene una lista de productos
        public List<Producto> Productos { get; set; }
    }
}