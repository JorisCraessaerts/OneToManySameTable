using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTestProject
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SchoolDB;Integrated Security=True");
            //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;") ;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne<Student>(s => s.Parent)
                .WithMany(p => p.Students)
                .HasForeignKey(s => s.ParentId);

            modelBuilder.Entity<Student>(s =>
            {
                s.HasData(new Student()
                {
                    StudentId = 1,
                    Name = "Joris",
                });
            });
            
        }

        //entities
        public DbSet<Student> Students { get; set; }

    }
}
