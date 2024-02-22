using System.ComponentModel.DataAnnotations.Schema;

namespace WA_1_1_api.Entites
{
    [Table("SanPham_tbl")]
    public class SanPham
    {
        public int Id {  get; set; }
        public int LoaiSanPhamId { get; set; }
        public string TenSanPham {  get; set; }
        public double GiaThanh {  get; set; }
        public string MoTa {  get; set; }
        public DateTime NgayHetHan { get; set; }
        public string KyHieuSanPham { get; set; }
        public IEnumerable<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public LoaiSanPham LoaiSanPham { get; set; }
    }
}
