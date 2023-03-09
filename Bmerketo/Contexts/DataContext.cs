using Microsoft.EntityFrameworkCore;

namespace Bmerketo.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
