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
        var curso = new Curso(){
            Id = 1,
            Nome = "Introdução à Programação",
            Descricao = "Fundamentos de programação e algoritmos estruturados",
            Perfil = "Estudantes e aprendizes no geral",
            PreRequisitos = "Informática básica",
            Conteudo = "1 - Introdução. 2 - Lógica. 3 - Estruturas. 4 - Vetores. 5 - Funções. 6 - Matrizes. 7 - Estruturas de dados. 8 - Resgistros.",
            CargaHoraria = 40,
            PrazoMeses = 1,
            Titulo = "Primeiros passos na programação"
        };

        ViewData["curso"] = curso;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
