using System.ComponentModel.DataAnnotations.Schema;

namespace WA_1_1_api.Entites
{
    [Table("LoaiSanPham_tbl")]
    public class LoaiSanPham
    {
        public int Id {  get; set; }
        public string TenLoaiSanPham {  get; set; }
        public IEnumerable<SanPham> SanPhams { get; set;}
    }
}
