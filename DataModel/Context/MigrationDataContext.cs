
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DataModel.Context
{
    public class MigrationDataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-AU8KPQ77\\MSSQLSERVER1;Database=RentalBook;Integrated Security=True;TrustServerCertificate=true");
            //optionsBuilder.UseSqlServer("Server=database.negox.com;Database=emacsoft_sf;Integrated Security=False; ;User ID=emacsoft_sf;Password=Y4i*8v51f; TrustServerCertificate=true");
            //optionsBuilder.UseSqlServer("Server=database.negox.com;Database=theglamour_store;Integrated Security=False; ;User ID=theglamour_store;Password=Y4i*8v51f; TrustServerCertificate=true");
            //optionsBuilder.UseSqlServer("\"Server=LAPTOP-AU8KPQ77\\\\MSSQLSERVER1;Database=RentalBook;Integrated Security=True;TrustServerCertificate=true\"");

            base.OnConfiguring(optionsBuilder);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            /*Through reflection, all classes that implement IEntityTypeConfiguration
             are scan and register each one automatically*/
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // NOTE: A query filter is applied to all the entities that inherit from 
            // IEntidadAuditableBase with the objective that when a result of the 
            // database is obtained, it automatically ignores the records that have 
            // the true value in "Borrado" field.  foreach (var type in modelBuilder.Model.GetEntityTypes()
            base.OnModelCreating(modelBuilder);
            //foreach (var t in modelBuilder.Model.GetEntityTypes())
            //{
            //    if (t.ClrType.BaseType == typeof(BaseEntity))
            //    {
                 
            //        modelBuilder.Entity(t.ClrType).Property(e=>e.);
            //    }
            //}
        }




    }
}
