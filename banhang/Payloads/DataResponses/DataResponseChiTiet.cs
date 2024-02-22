using WA_1_1_api.Entites;

namespace banhang.Payloads.DataResponses
{
    public class DataResponseChiTiet
    {
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
        public string DVT { get; set; }
        public double? ThanhTien { get; set; }
    }
}
