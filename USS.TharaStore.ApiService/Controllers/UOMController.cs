
using Microsoft.AspNetCore.Mvc;
using USS.Base.ApiService.Controllers;
using USS.TharaStore.Business.Interface;
using USS.TharaStore.Model;

namespace USS.TharaStore.ApiService.Controllers
{
   
    [ApiController]
    public class UOMController : BaseAPIController<UOM>
    {
        public UOMController(IUOMBusiness business) : base(business)
        {
        }
    }
}
