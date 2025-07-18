using Microsoft.EntityFrameworkCore;
using ChoirManager.Models;

namespace ChoirManager.Data
{
    public class ChoirDbContext(DbContextOptions<ChoirDbContext> options) : DbContext(options)
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<SoloAssignment> SoloAssignments { get; set; }
        public DbSet<Mass> Masses { get; set; }
        public DbSet<Attendance> AttendanceRecords { get; set; }
        public DbSet<Rehearsal> Rehearsals { get; set; }
    }
}
