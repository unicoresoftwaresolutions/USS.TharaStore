
using USS.Base.Business;
using USS.TharaStore.Business.Interface;
using USS.TharaStore.Data.Interface;
using USS.TharaStore.Model;

namespace USS.TharaStore.Business
{
    public class UOMBusiness : BaseBusiness<UOM>, IUOMBusiness
    {
        public UOMBusiness(IUOMData data) : base(data)
        {

        }
    }
}
