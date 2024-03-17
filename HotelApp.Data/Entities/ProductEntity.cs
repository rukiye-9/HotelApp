namespace HotelManagementApp.Data.Entities
{
    public class ProductEntity : BaseEntity
    {
        public Guid WarehouseId { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Amonut { get; set; }

        public virtual WarehouseEntity? Warehouses { get; set; }
    }
}
