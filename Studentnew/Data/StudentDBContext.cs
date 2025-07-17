using Microsoft.EntityFrameworkCore;
using Studentnew.Models;

namespace Studentnew.Data
{
  public class StudentDBContext:DbContext
  {
     public StudentDBContext(DbContextOptions<StudentDBContext> options):base (options) { }
    public DbSet<Student> students { get; set; }
  }
}
