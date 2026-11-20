

using USS.TharaStore.Business;
using USS.TharaStore.Business.Interface;
using USS.TharaStore.Data;
using USS.TharaStore.Data.Interface;

namespace USS.TharaStore.ApiService
{
    public static class ServiceDI
    {
        public static void AddServiceDI(this IServiceCollection services)
        {

            
            services.AddScoped<IProductData, ProductData>();
            services.AddScoped<IProductBusiness, ProductBusiness>();
            
            services.AddScoped<IStockGroupData, StockGroupData>();
            services.AddScoped<IStockGroupBusiness, StockGroupBusiness>();
            
            services.AddScoped<IUOMData, UOMData>();
            services.AddScoped<IUOMBusiness, UOMBusiness>();
            
        }
    }
}
