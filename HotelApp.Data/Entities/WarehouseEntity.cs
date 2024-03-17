namespace HotelManagementApp.Data.Entities
{
    public class WarehouseEntity : BaseEntity
    {
        public string? Name { get; set; }
        public virtual ICollection<ProductEntity>? Products { get; set; }
        public virtual BuildingEntity? Buildings { get; set; }


    }
}
