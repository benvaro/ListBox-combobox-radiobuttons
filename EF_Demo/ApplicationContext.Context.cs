//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_Demo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Around_the_world_for_80_daysEntities : DbContext
    {
        public Around_the_world_for_80_daysEntities()
            : base("name=Around_the_world_for_80_daysEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<CitiesData> CitiesDatas { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientTour> ClientTours { get; set; }
        public virtual DbSet<Country> Countrys { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<History> Histories { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }
        public virtual DbSet<PlaceToVisit> PlaceToVisits { get; set; }
        public virtual DbSet<TourHotel> TourHotels { get; set; }
        public virtual DbSet<TourPlace> TourPlaces { get; set; }
        public virtual DbSet<Tour> Tours { get; set; }
        public virtual DbSet<Transport_Tours> Transport_Tours { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
    }
}
