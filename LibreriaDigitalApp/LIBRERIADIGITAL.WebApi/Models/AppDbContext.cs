using Microsoft.EntityFrameworkCore;

namespace LIBRERIADIGITAL.WebApi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }

        //protected override void Onmodelcreating(Modelbuilder modelbuilder)
        //{
        //    modelbuilder.entity<user>().totable("users");
        //    modelbuilder.entity<book>().totable("books");
        //}
    }
}
