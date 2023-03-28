using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EscolaDotNet.Models;
using EscolaDotNet.ViewModels;

namespace EscolaDotNet.Controllers;

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
            Conteudo = "1-Introdução. 2-Lógica. 3-Estruturas. 4-Vetores. 5-Funções. 6-Matrizes. 7-Estruturas de dados. 8-Resgistros.",
            CargaHoraria = 40,
            PrazoMeses = 1,
            Titulo = "Primeiros passos na programação"
        };
        ViewData["titulo"] = "Página Pricipal";
        ViewBag.Curso = curso;
        TempData["mensagem"] = "Mensagem vinda da Action Index";
        return View();
    }

    public IActionResult Mensagem(){

        return View();
    }

    public IActionResult Mensagem2(){

        return View();
    }

    public IActionResult ViewModel(){
        var curso = new Curso(){
            Id = 1,
            Nome = "Introdução à Programação",
            Descricao = "Fundamentos de programação e algoritmos estruturados",
            Perfil = "Estudantes e aprendizes no geral",
            PreRequisitos = "Informática básica",
            Conteudo = "1-Introdução. 2-Lógica. 3-Estruturas. 4-Vetores. 5-Funções. 6-Matrizes. 7-Estruturas de dados. 8-Resgistros.",
            CargaHoraria = 40,
            PrazoMeses = 1,
            Titulo = "Primeiros passos na programação"
        };

        var ViewModel = new DetalhesCursoViewModel{

            Curso = curso,
            TituloPagina = "Detalhes do Curso"
        };
        return View(ViewModel);


    }
}