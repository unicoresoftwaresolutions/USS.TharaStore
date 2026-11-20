
using USS.Base.Service;
using USS.TharaStore.Model;

namespace USS.TharaStore.Service
{
    public class StockGroupService : BaseService<StockGroup>
    {
        private readonly MainHTTPClient _http;
        public StockGroupService(MainHTTPClient http): base(http.client)
        {
            _http = http;
        }
    }
}
