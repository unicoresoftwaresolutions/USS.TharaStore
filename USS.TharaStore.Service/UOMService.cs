
using USS.Base.Service;
using USS.TharaStore.Model;

namespace USS.TharaStore.Service
{
    public class UOMService : BaseService<UOM>
    {
        private readonly MainHTTPClient _http;
        public UOMService(MainHTTPClient http): base(http.client)
        {
            _http = http;
        }
    }
}
