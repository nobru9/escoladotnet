using EscolaDotNet.Models;
namespace EscolaDotNet.ViewModels;

public class ListaCursoViewModel{

    public ICollection<Curso> Cursos { get; set; } = new List<Curso>();
}