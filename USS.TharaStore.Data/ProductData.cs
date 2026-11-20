
using USS.Base.Data;
using USS.TharaStore.Data.Interface;
using USS.TharaStore.Model;

namespace USS.TharaStore.Data
{
    public partial class ProductData : BaseData<Product>, IProductData
    {
        public ProductData(MainDBContext dBContext) : base(dBContext)
        {
        }
    }
}
