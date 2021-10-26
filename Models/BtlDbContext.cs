using System.Data.Entity;

namespace BTLLTQL.Models
{
    public partial class BtlDbContext : DbContext
    {
        private const bool V = false;

        public BtlDbContext() : base("name=BtlDbContext") { }


        public virtual DbSet<Khachhang> Khachhang { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Khachhang>()
.                        Property(x => x.Tenkhachhang)
.                        IsUnicode(false);
        }
    }
}