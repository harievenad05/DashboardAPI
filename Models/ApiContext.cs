using Microsoft.EntityFrameworkCore;

namespace Dashboard.API.Models
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }
    }
}