using Microsoft.AspNetCore.Mvc;
using EscolaDotNet.Contexts;
using EscolaDotNet.ViewModels;
using EscolaDotNet.Models;

namespace EscolaDotNet.Controllers;


public class CursoController:Controller{

    
        private readonly AppDbContext _context;

        public CursoController(AppDbContext context){
         _context = context;    
        }

    

    public IActionResult Index(){

        var cursos = _context.Cursos.ToList();

        var ViewModel = new ListaCursoViewModel{ Cursos = cursos};
        return View(ViewModel);
    }


    public IActionResult Delete(int Id){
        var curso = _context.Cursos.Find(Id);
        if (curso is null)
        {
            return NotFound();
        }
        _context.Remove(curso);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
        }

    public IActionResult Create(){
        ViewData["Title"] = "Cadastrar Curso";
        return View();
    }
    [HttpPost]
    public IActionResult Create(CreateCursoViewModel data){
        var curso = new Curso (data.Nome,
                                data.Titulo,
                                data.Descricao,
                                data.Perfil,
                                data.PreRequisitos,
                                data.Conteudo,
                                data.Recursos,
                                data.CargaHoraria,
                                data.PrazoMeses);

        _context.Add(curso);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

}
/*<div class="row">
    <div class="Col">
        <h1 class="text-center">@ViewData["titulo"]</h1>
        <form>
            <div class="form-group">
                <div class="mb-3">
                    <label for="exampleFormControlInput1" class="form-label">Endereço de email</label>
                    <input type="email" class="form-control" id="exampleFormControlInput1"
                        placeholder="name@example.com">
                    <small id="emailHelp" class="form-text text-muted">Nós não compartilharemos o seu email
                        com ninguém</small>
                </div>
            </div>
            <div class="form-group">
                <label for="inputPassword5" class="form-label">Senha</label>
                <input type="password" id="inputPassword5" class="form-control" aria-labelledby="passwordHelpBlock"
                    placeholder="Senha">
                <div id="passwordHelpBlock" class="form-text">
                    Sua senha precisa ter de 8 à 20 caracteres, contendo letras e números. Não pode conter espaço,
                    caractere especial ou emoji.
                </div>
                <div class="form-group form-check">
                    <input type="checkbox" class="form-check-input" id="exampleCheck1"><label class="form-check-label"
                        for="exampleCheck1">Lembrar de mim</label>
                </div>
                <button type="submit" class="btn btn-primary">Avançar</button>
            </div>
        </form>
    </div>
</div>*/