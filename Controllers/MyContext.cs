using Microsoft.EntityFrameworkCore;

namespace BeltExam2.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users {get;set;}
        public DbSet<Activityclass> Activities {get;set;}
        public DbSet<Participate> Participations {get;set;}
    }
}