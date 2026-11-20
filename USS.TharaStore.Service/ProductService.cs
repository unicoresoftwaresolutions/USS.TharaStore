
using USS.Base.Service;
using USS.TharaStore.Model;

namespace USS.TharaStore.Service
{
    public class ProductService : BaseService<Product>
    {
        private readonly MainHTTPClient _http;
        public ProductService(MainHTTPClient http): base(http.client)
        {
            _http = http;
        }
    }
}
