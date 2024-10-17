using System;

namespace DemoMVC.Models;

public class Producto
{
    public int Id {get;set;}
    public string Nombre {get;set;}
    public string Descripcion {get;set;}
    public decimal Precio {get;set;}

    //Cada producto pertenece a una categoria
    public int CategoriaId {get; set;}
    public Categoria Categoria {get; set;}

    //Cada producto cuenta con un proveedor
    public int ProveedorId {get; set;}
    public Proveedor Proveedor {get; set;}
}
