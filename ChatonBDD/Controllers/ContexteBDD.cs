using ChatonBDD.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatonBDD.Controllers
{
    public class ContexteBDD : DbContext
    {
        public DbSet<Categorie>Categories { get; set; }
        public DbSet<Chaton>Chatons { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //en vrai il ne faudrai pas mettre la chaine de connexion ici mais dans les pparamètres appsetings
            //todo mettre la chaine de connexion ailleurs
            options.UseSqlite("Data Source = chatons.db");
        }
        
    }
}