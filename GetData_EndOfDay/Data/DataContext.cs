using GetData_EndOfDay.Models;
using Microsoft.EntityFrameworkCore;

namespace GetData_EndOfDay.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<DataOrderDTO> DataOrderDTOs { get; set; }
    }
}
