using Microsoft.EntityFrameworkCore;

namespace FirstRiderWebApp.wwwroot.lib.DAL;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<Model.Kanban> Kanban { get; set; }   
    public DbSet<Model.Column> Column { get; set; }   
    public DbSet<Model.Card> Card { get; set; }   
}