using WA_1_1_api.Entites;

namespace banhang.Payloads.DataResponses
{
    public class DataResponseHoaDon
    {
        public string TenKhachHang { get; set; }
        public string TenHoaDon { get; set; } 
        public string? MaGiaoDich { get; set; } 
        public DateTime? ThoiGianTao { get; set; }
        public DateTime ThoiGianCapNhat { get; set; }
        public string GhiChu { get; set; }
        public double? TongTien { get; set; }
        public IQueryable<DataResponseChiTiet>? DataResponseChiTiets { get; set; }
    }
}
