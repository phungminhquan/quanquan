using banhang.Payloads.DataRequests;
using banhang.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace banhang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoaDonController : ControllerBase
    {
        private readonly IHoaDonServices _ihoaDonServices;
        public HoaDonController(IHoaDonServices ihoaDonServices)
        {
            _ihoaDonServices = ihoaDonServices;
        }

        [HttpPost("ThemHoaDon")]
        public IActionResult ThemHoaDon(Request_ThemHoaDon request)
        {
            return Ok(_ihoaDonServices.ThemHoaDon(request));
        }

        [HttpPut("SuaHoaDon/")]
        public IActionResult SuaHoaDon(int hoadonId, Request_SuaHoaDon request)
        {
            return Ok(_ihoaDonServices.SuaHoaDon(hoadonId, request));
        }
        [HttpDelete("xoaHoaDon")]
        public IActionResult XoaHoaDon(int hoadonId)
        {
            return Ok(_ihoaDonServices.XoaHoaDon(hoadonId));
        }
        [HttpGet("hienThiHoaDon")]
        public IActionResult HienThiThongTinHoaDon(int? hoaDonId, int pageSize = -1, int pageNumber = 1)
        {
            return Ok(_ihoaDonServices.HienThiThongTinHoaDon(hoaDonId, pageSize, pageNumber));
        }
        [HttpGet("sapXepHoaDon")]
        public IActionResult SapXepHoaDon(int pageSize = -1, int pageNumber = 1)
        {
            return Ok(_ihoaDonServices.SapXepTheoThoiGian(pageSize, pageNumber));
        }
        [HttpGet("hienThihoaDonTheoThangnam")]
        public IActionResult HienThiHoaDonTheoThangnam(int? year, int? month, int pageSize = -1, int pageNumber = 1)
        {
            return Ok(_ihoaDonServices.LocHoaDonTheoThangNam(year, month, pageSize, pageNumber));
        }
        [HttpGet("hienThiHoaDonTheoKhoangNgay")]
        public IActionResult HienThiHoaDonTheoKhoangNgay(DateTime? fromDate, DateTime? toDate, int pageSize = -1, int pageNumber = 1)
        {
            return Ok(_ihoaDonServices.LocHoaDonTheoKhoangNgay(fromDate, toDate, pageSize, pageNumber));
        }
        [HttpGet("hienThiHoaDonTheoTongTien")]
        public IActionResult HienThiHoaDonTheoTongTien(int? minTongTien, int? maxTongTien, int pageSize = -1, int pageNumber = 1)
        {
            return Ok(_ihoaDonServices.LocHoaDonTheoTongTien(minTongTien, maxTongTien, pageSize, pageNumber));
        }

        [HttpGet("hienThiHoaDonTheoMaOrTen")]
        public IActionResult HienThiHoaDonTheoMaOrTen(string? str, int pageSize = -1, int pageNumber = 1)
        {
            return Ok(_ihoaDonServices.HienThiThongTinTheoMaOrTen(str, pageSize, pageNumber));
        }
    }
}
