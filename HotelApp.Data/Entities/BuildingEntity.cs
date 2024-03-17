namespace HotelManagementApp.Data.Entities
{
    public class BuildingEntity : BaseEntity
    {
        public Guid WarehouseId { get; set; }
        public Guid RoomId { get; set; }
        public string? Name { get; set; }
        public virtual ICollection<WarehouseEntity>? Warehouses { get; set; }
        public virtual ICollection<RoomEntity>? Rooms { get; set; }

    }
}
