using EscolaDotNet.Models;
using Microsoft.EntityFrameworkCore;
using EscolaDotNet.EntityConfigs;
namespace EscolaDotNet.Contexts;

public class AppDbContext : DbContext{

    public DbSet<Curso> Cursos => Set<Curso>();

    protected override void OnConfiguring(DbContextOptionsBuilder builder){

        builder.UseSqlServer(@"Server=LAPTOP-EJAN6D2A\SQLEXPRESS;DataBase=EscolaDotNet;Integrated Security=True;TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder builder){
        builder.ApplyConfiguration(new CursoEntityConfig());
    }
}