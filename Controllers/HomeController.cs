using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EscolaDotNET.Models;

namespace EscolaDotNET.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        int ch = 40;
        
        ViewData["nome"] = "TI Essencial";
        ViewData["titulo"] = "Uma visão geral da TI";
        ViewData["ch"] = $"Teremos {ch} horas de imersão nos fundamentos da TI";
        ViewData["descricao"] = "Nesse curso você vai aprender os primeiros passos na tecnologia da infromação, conhecer o hardware, software, redes, protocolos e conhecimentos básicos para depois mergulhar no mundo do desenvolvimento de software da Microsoft.";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
