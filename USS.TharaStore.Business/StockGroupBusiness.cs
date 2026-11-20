
using USS.Base.Business;
using USS.TharaStore.Business.Interface;
using USS.TharaStore.Data.Interface;
using USS.TharaStore.Model;

namespace USS.TharaStore.Business
{
    public class StockGroupBusiness : BaseBusiness<StockGroup>, IStockGroupBusiness
    {
        public StockGroupBusiness(IStockGroupData data) : base(data)
        {

        }
    }
}
