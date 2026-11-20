

using USS.Base.Model;

namespace USS.TharaStore.Model
{
    public partial class StockGroup : BaseEntityModel
    {

        public string Name { get; set; }
        public string? Description { get; set; }
        public Guid? ParentId { get; set; }
        public string? Photo { get; set; }
    
    
    
    }
}
