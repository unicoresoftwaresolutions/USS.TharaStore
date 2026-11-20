
using USS.Base.Data;
using USS.TharaStore.Data.Interface;
using USS.TharaStore.Model;

namespace USS.TharaStore.Data
{
    public partial class StockGroupData : BaseData<StockGroup>, IStockGroupData
    {
        public StockGroupData(MainDBContext dBContext) : base(dBContext)
        {
        }
    }
}
