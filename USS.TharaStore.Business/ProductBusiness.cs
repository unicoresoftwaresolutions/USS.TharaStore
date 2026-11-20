
using USS.Base.Business;
using USS.TharaStore.Business.Interface;
using USS.TharaStore.Data.Interface;
using USS.TharaStore.Model;

namespace USS.TharaStore.Business
{
    public class ProductBusiness : BaseBusiness<Product>, IProductBusiness
    {
        public ProductBusiness(IProductData data) : base(data)
        {

        }
    }
}
