
namespace DemoMVC.Models
{
    public class Categoria
    {
        public int Id {get; set;}

        public string Nombre {get; set;}

        public string Descripcion {get; set;}

        //Cada categoria cuenta con una lista de productos
        public List<Producto> Productos { get; set; } 

    }
}