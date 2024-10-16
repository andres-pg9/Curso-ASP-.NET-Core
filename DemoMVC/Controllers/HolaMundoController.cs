using System;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers;

public class HolaMundoController : Controller
{
    public string Message(int id)
    {
        return $"Hola Mundo!!! id: {id}";
    }

    public IActionResult MessageView()
    {
        return View();
    }
}
