﻿using WA_1_1_api.Entites;

namespace banhang.Payloads.DataRequests
{
    public class Request_ThemHoaDon
    {
        public int KhachHangId { get; set; }
        public string TenHoaDon { get; set; }
        public string GhiChu { get; set; }
        public List<Request_ThemChiTietHoaDon> themChiTietHoaDons { get; set; }
    }
}
