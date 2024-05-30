using Microsoft.EntityFrameworkCore;

namespace ZeldaApi.Database {
    internal class ZeldaApiContext : DbContext {
        public DbSet<ApiItem> ApiItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            // enter absolute path to the db before starting app
            optionsBuilder.UseSqlite($"Data Source= ZeldaApiDB.db");
        }
    }
}
