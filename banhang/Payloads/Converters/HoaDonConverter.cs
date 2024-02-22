using banhang.Payloads.DataResponses;
using WA_1_1_api.ConText;
using WA_1_1_api.Entites;

namespace banhang.Payloads.Converters
{
    public class HoaDonConverter
    {
        private readonly AppDbContext _context;
        private readonly ChiTietConverter _converter;
        public HoaDonConverter()
        {
            _context = new AppDbContext();
            _converter = new ChiTietConverter();
        }
        public DataResponseHoaDon EntityToDTO(HoaDon hoaDon)
        {
            return new DataResponseHoaDon()
            {
                TenKhachHang = _context.KhachHangs.SingleOrDefault(x => x.Id == hoaDon.KhachHangId).TenKhachHang,
                TenHoaDon = hoaDon.TenHoaDon,
                GhiChu = hoaDon.GhiChu,
                MaGiaoDich = hoaDon.MaGiaoDich,
                ThoiGianTao = hoaDon.ThoiGianTao,
                ThoiGianCapNhat = hoaDon.ThoiGianCapNhat,
                TongTien = hoaDon.TongTien,
                DataResponseChiTiets = _context.ChiTietHoaDons.Where(x => x.HoaDonId == hoaDon.Id).Select(x => _converter.EntityToDTO(x)) 
            };
        }
    }
}
