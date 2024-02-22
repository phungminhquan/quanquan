using System.ComponentModel.DataAnnotations.Schema;

namespace WA_1_1_api.Entites
{
    [Table("HoaDon_tbl")]
    public class HoaDon
    {
        public int Id {  get; set; }
        public int KhachHangId {  get; set; }
        public string TenHoaDon {  get; set; } = string.Empty;
        public string? MaGiaoDich { get; set; } = string.Empty;
        public DateTime? ThoiGianTao { get; set; }
        public DateTime ThoiGianCapNhat { get; set; }
        public string GhiChu {  get; set; }
        public double? TongTien {  get; set; }
        public KhachHang? KhachHang { get; set; }
        public IEnumerable<ChiTietHoaDon>? ChiTietHoaDons { get; set; }
    }
}
