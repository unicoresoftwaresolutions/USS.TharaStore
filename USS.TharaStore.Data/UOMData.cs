
using USS.Base.Data;
using USS.TharaStore.Data.Interface;
using USS.TharaStore.Model;

namespace USS.TharaStore.Data
{
    public partial class UOMData : BaseData<UOM>, IUOMData
    {
        public UOMData(MainDBContext dBContext) : base(dBContext)
        {
        }
    }
}
