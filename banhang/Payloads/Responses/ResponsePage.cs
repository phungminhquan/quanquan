using banhang.Payloads.DataResponses;
using System.Net.NetworkInformation;

namespace banhang.Payloads.Responses
{
    public class ResponsePage<T>
    {
        public Pagination Pagination { get; set; }
        public List<DataResponseHoaDon> Data {  get; set; }
        public ResponsePage() { }
        public ResponsePage(Pagination pagination, List<DataResponseHoaDon> data) 
        {
            Pagination = pagination;
            Data = data;
        }
        public static List<DataResponseHoaDon> ToPageResult(Pagination pagination, List<DataResponseHoaDon> data) 
        {
            pagination.PageNumber = pagination.PageNumber < 1 ? 1 : pagination.PageNumber;
            data = data.Skip(pagination.PageSize * (pagination.PageNumber - 1)).Take(pagination.PageSize).ToList();
            return data;
        }
    }
}
