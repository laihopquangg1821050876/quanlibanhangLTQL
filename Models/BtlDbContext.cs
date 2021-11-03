using System.Data.Entity;

namespace BTLLTQL.Models
{
    public partial class BtlDbContext : DbContext
    {
        private const bool V = false;

        public BtlDbContext() : base("name=BtlDbContext") { }


        public virtual DbSet<Khachhang> Khachhang { get; set; }
        public virtual DbSet<HangHoa> HangHoa { get; set; }
        public virtual DbSet<Account> nameID { get; set; }
        public virtual DbSet<phieunhap> MaPhieunhap { get; set; }
        public virtual DbSet<PhieuXuat> MaPhieuxuat { get; set; }
        public virtual DbSet<TonKho> STT { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Khachhang>()
.                        Property(x => x.Tenkhachhang)
.                        IsUnicode(false);
            modelBuilder.Entity<HangHoa>()
.                        Property(x => x.MaHang)
.                        IsUnicode(false);
            modelBuilder.Entity<Account>()
.                        Property(x => x.nameID)
.                        IsUnicode(false);
            modelBuilder.Entity<phieunhap>()
.                        Property(x => x.MaPhieunhap)
.                        IsUnicode(false);
            modelBuilder.Entity<PhieuXuat>()
.                        Property(x => x.MaPhieuXuat)
.                        IsUnicode(false);
            modelBuilder.Entity<TonKho>()
.                        Property(x => x.Mahang)
.                        IsUnicode(true);

        }
    }

}
