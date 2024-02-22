using WA_1_1_api.Entites;

namespace banhang.Payloads.DataRequests
{
    public class Request_ThemChiTietHoaDon
    {
        public int SanPhamId { get; set; }
        public int SoLuong { get; set; }
        public string DVT { get; set; }
    }
}
