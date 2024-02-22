using System.ComponentModel.DataAnnotations.Schema;

namespace WA_1_1_api.Entites
{
    [Table("KhachHang_tbl")]
    public class KhachHang
    {
        public int Id {  get; set; }
        public string TenKhachHang {  get; set; } = string.Empty;
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; } = string.Empty;
        public IEnumerable<HoaDon> HoaDons { get; set; }
    }
}
