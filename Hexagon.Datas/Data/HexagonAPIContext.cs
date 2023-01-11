using Microsoft.EntityFrameworkCore;

namespace Hexagon.Datas.Data
{
    public class HexagonAPIContext : DbContext
    {
        public HexagonAPIContext(DbContextOptions<HexagonAPIContext> options)
            : base(options)
        {
        }
        public HexagonAPIContext() { }

        public DbSet<Domains.Pessoa> Pessoa { get; set; } = default!;
    }
}
