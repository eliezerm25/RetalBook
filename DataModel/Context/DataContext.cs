using DataModel.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Context
{
    public class DataContext:DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> context):base(context)
       {
       }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /*Through reflection, all classes that implement IEntityTypeConfiguration
             are scan and register each one automatically*/
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // NOTE: A query filter is applied to all the entities that inherit from 
            // IEntidadAuditableBase with the objective that when a result of the 
            // database is obtained, it automatically ignores the records that have 
            // the true value in "Borrado" field.  foreach (var type in modelBuilder.Model.GetEntityTypes()
            //foreach (var type in modelBuilder.Model.GetEntityTypes()
            //                       .Where(type => typeof(IEntityBase).IsAssignableFrom(type.ClrType)))
            //{
            //    modelBuilder.SetSoftDeleteFilter(type.ClrType);
            //}
        }

        public DbSet<Category> Category { get; set; }
       public DbSet<Author> Author { get; set; }
       public DbSet<Book> Book { get; set; }

    }
}
