using Microsoft.EntityFrameworkCore;

namespace DemoMVC.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options) : base(options)
        {

        }

        //Tablas de cada clase (Db Sets)
        public DbSet<Models.Producto> Productos {get;set;}
        public DbSet<Models.Proveedor> Proveedores {get;set;}
        public DbSet<Models.Categoria> Categorias {get;set;}
    }
}