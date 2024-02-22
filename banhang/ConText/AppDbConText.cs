using Microsoft.EntityFrameworkCore;
using WA_1_1_api.Entites;

namespace WA_1_1_api.ConText
{
    public class AppDbContext : DbContext
    {
        public DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }

        //chuoi ket noi
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string connectionString = "Data source = LAPTOP-0B0KLT95\\SQLEXPRESS02; initial catalog = dbQLyBanHang; integrated security = sspi;";
            //optionsBuilder.UseSqlServer(connectionString);
            //optionsBuilder.UseSqlServer("Server = LAPTOP-0B0KLT95\\SQLEXPRESS02; Database = dbQlBanHangQuan123; Trusted_Connection = True;TrustServerCertificate=True");

            optionsBuilder.UseSqlServer("server = LAPTOP-0B0KLT95\\SQLEXPRESS02; Database = dbQlBanHangQuan123; integrated security = sspi; encrypt = true; trustservercertificate = true;");
        }
    }
}
