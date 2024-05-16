using Blazor.EntityFramework.Components;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Blazor.EntityFramework.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Game>().HasData(
                new Game
                {
                    Id = 1,
                    Name = "Super Mario Bros.",
                    Genre = "Platformer",
                    ReleaseDate = new DateTime(1985, 9, 13),
                    Description = "The classic platformer featuring Mario and Luigi.",
                    Rate = 4.5f
                },
                new Game
                {
                    Id = 2,
                    Name = "The Legend of Zelda",
                    Genre = "Action-Adventure",
                    ReleaseDate = new DateTime(1986, 2, 21),
                    Description = "The classic action-adventure game featuring Link.",
                    Rate = 4.5f
                },
                new Game
                {
                    Id = 3,
                    Name = "Metroid",
                    Genre = "Action-Adventure",
                    ReleaseDate = new DateTime(1986, 8, 6),
                    Description = "The classic action-adventure game featuring Samus Aran.",
                    Rate = 4.5f
                },
                new Game
                {
                    Id = 4,
                    Name = "Final Fantasy",
                    Genre = "Role-Playing",
                    ReleaseDate = new DateTime(1987, 12, 18),
                    Description = "The classic role-playing game featuring the Warriors of Light.",
                    Rate = 4.5f
                });
        }
    }
}
