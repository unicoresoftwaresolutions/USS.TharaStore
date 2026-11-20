

using USS.Base.Model;

namespace USS.TharaStore.Model
{
    public partial class Product : BaseEntityModel
    {

        public string Name { get; set; }
        public string? Description { get; set; }
        public string? BarCode { get; set; }
        public decimal PurchageRate { get; set; }
        public decimal SaleRate { get; set; }
        public decimal MRP { get; set; }
        public int OPQty { get; set; }
        public Guid UOMId { get; set; }
        public Guid StockGroupId { get; set; }
        public string? Photo { get; set; }
    
    
    
    }
}
