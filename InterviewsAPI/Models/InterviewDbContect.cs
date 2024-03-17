using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace InterviewsAPI.Models
{
    public class InterviewDbContect : DbContext
    {
        public InterviewDbContect(DbContextOptions<InterviewDbContect> options) : base(options) { }

        public DbSet<Questions> Questions { get; set; }
        public DbSet<Participant> Participants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=InterviewDb;Username=postgres;Password=kjh65gf");
        }
    }
}
