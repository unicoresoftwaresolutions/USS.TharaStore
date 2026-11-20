namespace USS.TharaStore.Web
{
    public static class ServiceDI
    {
        public static void AddServiceDI(this IServiceCollection services)
        {
                        services.AddScoped<ProductService>();
            services.AddScoped<StockGroupService>();
            services.AddScoped<UOMService>();
        }
    }
}
