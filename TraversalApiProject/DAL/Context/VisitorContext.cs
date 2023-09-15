using Microsoft.EntityFrameworkCore;
using TraversalApiProject.DAL.Entities;

namespace TraversalApiProject.DAL.Context
{
    public class VisitorContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-DEQQ0OF8\\SQLEXPRESS;initial catalog=TraversalDbApi;integrated security=true;");
        }

        public DbSet<Visitor> Visitors { get; set; }
    }
}
