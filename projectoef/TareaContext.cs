using Microsoft.EntityFrameworkCore;
using projectoef.Models;

namespace projectoef
{
    // Se implementa y configura EntityFramework
    public class TareaContext: DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Tarea> Tareas { get; set; }

        public TareaContext(DbContextOptions<TareaContext> options) : base(options) { }
    }
}
