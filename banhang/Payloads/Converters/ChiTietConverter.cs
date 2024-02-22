using banhang.Payloads.DataResponses;
using WA_1_1_api.ConText;
using WA_1_1_api.Entites;

namespace banhang.Payloads.Converters
{
    public class ChiTietConverter
    {
        private readonly AppDbContext _context;
        public ChiTietConverter()
        {
            _context = new AppDbContext();
        }
        public DataResponseChiTiet EntityToDTO(ChiTietHoaDon chiTietHoaDon)
        {
            return new DataResponseChiTiet()
            {
                DVT = chiTietHoaDon.DVT,
                SoLuong = chiTietHoaDon.SoLuong,
                TenSanPham = _context.SanPhams.SingleOrDefault(x => x.Id == chiTietHoaDon.SanPhamId).TenSanPham,
                ThanhTien = chiTietHoaDon.ThanhTien
            };
        }
    }
}
