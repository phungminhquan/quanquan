using Azure;
using Azure.Core;
using banhang.Payloads.Converters;
using banhang.Payloads.DataRequests;
using banhang.Payloads.DataResponses;
using banhang.Payloads.Responses;
using banhang.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using WA_1_1_api.ConText;
using WA_1_1_api.Entites;

namespace banhang.Services.Implements
{
    public class HoaDonServices : IHoaDonServices
    {
        private readonly AppDbContext _context;
        private readonly ResponseObject<DataResponseHoaDon> _responseObject;
        private readonly HoaDonConverter _converter;
        public HoaDonServices(ResponseObject<DataResponseHoaDon> responseObject, HoaDonConverter converter)
        {
            _context = new AppDbContext();
            _responseObject = responseObject;
            _converter = converter;
        }

        public ResponsePage<DataResponseHoaDon> HienThiThongTinHoaDon(int? hoaDonId, int pageSize, int pageNumber)
        {
            var lstHoaDon = _context.HoaDons.ToList();
            List<DataResponseHoaDon> lstRes = new List<DataResponseHoaDon>();
            Pagination pagination = new Pagination();
            pagination.PageSize = pageSize;
            pagination.PageNumber = pageNumber;
            if(hoaDonId is null)
            {
                foreach(var hoaDon in lstHoaDon)
                {
                    lstRes.Add(_converter.EntityToDTO(hoaDon));
                }
                var result = ResponsePage <DataResponseHoaDon>.ToPageResult(pagination, lstRes);
                pagination.TotalCount = lstRes.Count();
                return new ResponsePage<DataResponseHoaDon>(pagination, result);
            }
            else
            {
                var hoaDon = _context.HoaDons.SingleOrDefault(x => x.Id == hoaDonId);   
                if(hoaDon is null)
                {
                    lstRes.Add(null);
                }
                else
                {
                    lstRes.Add(_converter.EntityToDTO(hoaDon));
                }
                var result = ResponsePage<DataResponseChiTiet>.ToPageResult(pagination, lstRes);
                pagination.TotalCount = lstRes.Count();
                return new ResponsePage<DataResponseHoaDon>(pagination, result) ;
            }
        }

        public ResponsePage<DataResponseHoaDon> HienThiThongTinTheoMaOrTen(string? str, int pageSize, int pageNumber)
        {
            var lstHoaDon = _context.HoaDons.Where(i => i.MaGiaoDich.ToLower() == str.ToLower() || i.TenHoaDon.ToLower() == str.ToLower()).ToList();
            List<DataResponseHoaDon> lstRes = new List<DataResponseHoaDon>();
            Pagination pagination = new Pagination();
            pagination.PageSize = pageSize;
            pagination.PageNumber = pageNumber;
            foreach (var hoaDon in lstHoaDon)
            {
                lstRes.Add(_converter.EntityToDTO(hoaDon));
            }
            if (lstRes is null)
            {
                return null;
            }
            var result = ResponsePage<DataResponseHoaDon>.ToPageResult(pagination, lstRes);
            pagination.TotalCount = lstRes.Count();
            return new ResponsePage<DataResponseHoaDon>(pagination, result);
        }

        public ResponsePage<DataResponseHoaDon> LocHoaDonTheoKhoangNgay(DateTime? fromDate, DateTime? toDate, int pageSize, int pageNumber)
        {
            var lstHoaDon = _context.HoaDons.Where(i => i.ThoiGianTao >= fromDate && i.ThoiGianTao <= toDate).ToList();
            List<DataResponseHoaDon> lstRes = new List<DataResponseHoaDon>();
            Pagination pagination = new Pagination();
            pagination.PageSize = pageSize;
            pagination.PageNumber = pageNumber;
            foreach (var hoaDon in lstHoaDon)
            {
                lstRes.Add(_converter.EntityToDTO(hoaDon));
            }
            if (lstRes is null)
            {
                return null;
            }
            var result = ResponsePage<DataResponseHoaDon>.ToPageResult(pagination, lstRes);
            pagination.TotalCount = lstRes.Count();
            return new ResponsePage<DataResponseHoaDon>(pagination, result);
        }

        public ResponsePage<DataResponseHoaDon> LocHoaDonTheoThangNam(int? year, int? month, int pageSize, int pageNumber)
        {
            var lstHoaDon = _context.HoaDons.Where(i => i.ThoiGianTao.Value.Year == year && i.ThoiGianTao.Value.Month == month).ToList();
            List<DataResponseHoaDon> lstRes = new List<DataResponseHoaDon>();
            Pagination pagination = new Pagination();
            pagination.PageSize = pageSize;
            pagination.PageNumber = pageNumber;
            foreach(var hoaDon in lstHoaDon)
            {
                lstRes.Add(_converter.EntityToDTO(hoaDon));
            }
            if(lstRes is null)
            {
                return null;
            }
            var result = ResponsePage<DataResponseHoaDon>.ToPageResult(pagination, lstRes);
            pagination.TotalCount = lstRes.Count();
            return new ResponsePage<DataResponseHoaDon>(pagination, result);
        }

        public ResponsePage<DataResponseHoaDon> LocHoaDonTheoTongTien(int? minTongTien, int? maxTongTien, int pageSize, int pageNumber)
        {
            var lstHoaDon = _context.HoaDons.Where(i => i.TongTien >= minTongTien && i.TongTien <= maxTongTien).ToList();
            List<DataResponseHoaDon> lstRes = new List<DataResponseHoaDon>();
            Pagination pagination = new Pagination();
            pagination.PageSize = pageSize;
            pagination.PageNumber = pageNumber;
            foreach (var hoaDon in lstHoaDon)
            {
                lstRes.Add(_converter.EntityToDTO(hoaDon));
            }
            if (lstRes is null)
            {
                return null;
            }
            var result = ResponsePage<DataResponseHoaDon>.ToPageResult(pagination, lstRes);
            pagination.TotalCount = lstRes.Count();
            return new ResponsePage<DataResponseHoaDon>(pagination, result);
        }

        public ResponsePage<DataResponseHoaDon> SapXepTheoThoiGian(int pageSize, int pageNumber)
        {
            var lstHoaDon = _context.HoaDons.OrderByDescending(x => x.ThoiGianTao).ToList();
            List<DataResponseHoaDon> lstRes = new List<DataResponseHoaDon>();
            Pagination pagination = new Pagination();
            pagination.PageSize = pageSize;
            pagination.PageNumber = pageNumber;
            foreach (var hoaDon in lstHoaDon)
            {
                lstRes.Add(_converter.EntityToDTO(hoaDon));
            }
            if (lstRes is null)
            {
                return null;
            }
            var result = ResponsePage<DataResponseHoaDon>.ToPageResult(pagination, lstRes);
            pagination.TotalCount = lstRes.Count();
            return new ResponsePage<DataResponseHoaDon>(pagination, result);
        }

        public ResponseObject<DataResponseHoaDon> SuaHoaDon(int hoaDonId, Request_SuaHoaDon request)
        {
            var hoaDon = _context.HoaDons.SingleOrDefault(x =>  x.Id == hoaDonId);
            if (hoaDon is null)
            {
                return _responseObject.ResponseError(StatusCodes.Status404NotFound, "Khong tim thay hoa don!", null);
            }
            hoaDon.ChiTietHoaDons = SuaListChiTiet(hoaDonId, request.suaChiTietHoaDons);
            if(hoaDon.ChiTietHoaDons is null)
            {
                return _responseObject.ResponseError(StatusCodes.Status404NotFound, "San pham khong ton tai!", null);
            }
            hoaDon.ThoiGianCapNhat = DateTime.Now;
            _context.HoaDons.Update(hoaDon);
            _context.SaveChanges();
            double? tongTien = 0;
            foreach(var item in hoaDon.ChiTietHoaDons)
            {
                tongTien += item.ThanhTien;
            }
            hoaDon.TongTien = tongTien;
            _context.HoaDons.Update(hoaDon);
            _context.SaveChanges();
            return _responseObject.ResponseSuccess("Sua hoa don thanh cong", _converter.EntityToDTO(hoaDon));
        }
        public List<ChiTietHoaDon> SuaListChiTiet(int hoaDonId, List<Request_SuaChiTietHoaDon> requets)
        {
            var hoaDon = _context.ChiTietHoaDons.Where(x => x.Id == hoaDonId).ToList();
            if (hoaDon is null)
            {
                return null;
            }
            List<ChiTietHoaDon> list = new List<ChiTietHoaDon>();
            foreach (var request in requets)
            {
                foreach (var cthoaDons in hoaDon)
                {
                    if (cthoaDons.Id == request.SanPhamId)
                    {
                        var sanPham = _context.SanPhams.SingleOrDefault(x => x.Id == request.SanPhamId);
                        cthoaDons.SanPhamId = request.SanPhamId;
                        cthoaDons.DVT = request.DVT;
                        cthoaDons.SoLuong = request.SoLuong;
                        cthoaDons.ThanhTien = sanPham.GiaThanh * request.SoLuong;
                        list.Add(cthoaDons);
                        break;
                    }
                    else
                    {
                        ChiTietHoaDon ct = new ChiTietHoaDon();
                        var sanPham = _context.SanPhams.SingleOrDefault(x => x.Id == request.SanPhamId);
                        var checkCTHD = _context.ChiTietHoaDons.Where(x => x.Id == request.SanPhamId && x.HoaDonId == hoaDonId);
                        if (sanPham is null)
                        {
                            break;
                        }
                        if (checkCTHD is null)
                        {
                            break;
                        }
                        ct.HoaDonId = hoaDonId;
                        ct.SanPhamId = request.SanPhamId;
                        ct.SoLuong = request.SoLuong;
                        ct.DVT = request.DVT;
                        ct.ThanhTien = sanPham.GiaThanh * request.SoLuong;
                        _context.ChiTietHoaDons.Add(ct);
                        _context.SaveChanges();
                        break;
                    }

                }
            }
            _context.ChiTietHoaDons.UpdateRange(list);
            _context.SaveChanges();
            return list;
        }
        public ResponseObject<DataResponseHoaDon> ThemHoaDon(Request_ThemHoaDon request)
        {
            var khachHang = _context.KhachHangs.SingleOrDefault(x => x.Id == request.KhachHangId);
            if(khachHang == null)
            {
                return _responseObject.ResponseError(StatusCodes.Status404NotFound, "Khong tim thay khach hang", null);
            }
            HoaDon hoaDon = new HoaDon();
            hoaDon.TenHoaDon = request.TenHoaDon;
            hoaDon.KhachHangId = request.KhachHangId;
            hoaDon.MaGiaoDich = new Random().Next(100000, 999999).ToString();
            hoaDon.ThoiGianTao = DateTime.Now;
            hoaDon.ThoiGianCapNhat = DateTime.Now;
            hoaDon.GhiChu = request.GhiChu;
            hoaDon.TongTien = 0;
            hoaDon.ChiTietHoaDons = null;
            _context.HoaDons.Add(hoaDon);
            _context.SaveChanges();
            hoaDon.ChiTietHoaDons = ThemListChiTiet(hoaDon.Id, request.themChiTietHoaDons);
            _context.HoaDons.Update(hoaDon);
            _context.SaveChanges();
            double? tongTien = 0;
            foreach(var item in hoaDon.ChiTietHoaDons)
            {
                tongTien += item.ThanhTien;
            }
            hoaDon.TongTien = tongTien;
            _context.HoaDons.Update(hoaDon);
            _context.SaveChanges();
            return _responseObject.ResponseSuccess("Them Hoa Don Thanh Cong", _converter.EntityToDTO(hoaDon));
        }

        public ResponseObject<DataResponseHoaDon> XoaHoaDon(int hoaDonId)
        {
           var hoaDon = _context.HoaDons.Find(hoaDonId);
            var ctHoaDon = _context.ChiTietHoaDons.Find(hoaDonId);
            if(hoaDon is null)
            {
                return _responseObject.ResponseSuccess("Khong Tin Thay Hoa Don!", null);
            }
            _context.ChiTietHoaDons.RemoveRange(ctHoaDon);
            _context.HoaDons.RemoveRange(hoaDon);
            _context.SaveChanges();
            return _responseObject.ResponseSuccess("Xoa hoa don thanh cong", _converter.EntityToDTO(hoaDon));
        }

        private List<ChiTietHoaDon> ThemListChiTiet(int hoaDonId, List<Request_ThemChiTietHoaDon> requests)
        {
            var hoaDon = _context.HoaDons.SingleOrDefault(x => x.Id == hoaDonId);
            if(hoaDon is  null)
            {
                return null;
            }
            List<ChiTietHoaDon> list = new List<ChiTietHoaDon>();
            foreach (var request in requests)
            {
                ChiTietHoaDon ct = new ChiTietHoaDon();
                var sanPham = _context.SanPhams.SingleOrDefault(x => x.Id == request.SanPhamId);
                if (sanPham is null)
                {
                    throw new Exception("San Pham Khong Ton Tai");
                }
                ct.HoaDonId = hoaDonId;
                ct.SanPhamId = request.SanPhamId;
                ct.DVT = request.DVT;
                ct.SoLuong = request.SoLuong;
                ct.ThanhTien = sanPham.GiaThanh * request.SoLuong;
                list.Add(ct);
            }
            _context.ChiTietHoaDons.AddRange(list);
            _context.SaveChanges();
            return list;
        }
    }
}
