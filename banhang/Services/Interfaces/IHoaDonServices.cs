using banhang.Payloads.DataRequests;
using banhang.Payloads.DataResponses;
using banhang.Payloads.Responses;

namespace banhang.Services.Interfaces
{
    public interface IHoaDonServices
    {
        ResponseObject<DataResponseHoaDon> ThemHoaDon(Request_ThemHoaDon request);
        ResponseObject<DataResponseHoaDon> SuaHoaDon(int hoaDonId, Request_SuaHoaDon request);
        ResponseObject<DataResponseHoaDon> XoaHoaDon(int hoaDonId);
        ResponsePage<DataResponseHoaDon> HienThiThongTinHoaDon(int? hoaDonId, int pageSize, int pageNumber);
        ResponsePage<DataResponseHoaDon> SapXepTheoThoiGian(int pageSize, int pageNumber);
        ResponsePage<DataResponseHoaDon> LocHoaDonTheoThangNam(int? year, int? month, int pageSize, int pageNumber);
        ResponsePage<DataResponseHoaDon> LocHoaDonTheoKhoangNgay(DateTime? fromDate, DateTime? toDate, int pageSize, int pageNumber);
        ResponsePage<DataResponseHoaDon> LocHoaDonTheoTongTien(int? minTongTien, int? maxTongTien, int pageSize, int pageNumber);
        ResponsePage<DataResponseHoaDon> HienThiThongTinTheoMaOrTen(string? str, int pageSize, int pageNumber);

    }
}
