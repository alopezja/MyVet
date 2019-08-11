using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyVet.Data.Entities;
using MyVet.Web.Data.Entities;

namespace MyVet.Data
{
    public class DataContext : IdentityDbContext<User> 
    {
        //Create a constructor ctor Tab(x2)
        public DataContext(DbContextOptions<DataContext> options) : base(options) //DbContextOptions is a BD based on DataContext named options and object option go to the BD constructor
        {
        }

        //Matriculate tables

        public DbSet<Agenda> Agendas { get; set; }

        public DbSet<History> Histories { get; set; }

        public DbSet<Owner> Owners { get; set; } //Propiety DbSet, Model Owner and Colection Owners

        public DbSet<Manager> Managers { get; set; } //Propiety DbSet, Model Owner and Colection Owners

        public DbSet<Pet> Pets { get; set; }

        public DbSet<PetType> PetTypes { get; set; }

        public DbSet<ServiceType> ServiceTypes { get; set; }

        //Summary =>
        //We have a table Entity Owner with structure BD and our BD will have that structure


    }
}
