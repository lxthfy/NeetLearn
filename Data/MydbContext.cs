using Microsoft.EntityFrameworkCore;

namespace Neet.Data // Pastikan namespace ini sesuai dengan Program.cs Anda
{
    public class MyDbContext : DbContext
    {
        public MyDbContext (DbContextOptions<MyDbContext> options) : base(options) { }

        // Definisikan DbSet properti di sini
        public DbSet<MyEntity> MyEntities { get; set; }
    }

    public class MyEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
