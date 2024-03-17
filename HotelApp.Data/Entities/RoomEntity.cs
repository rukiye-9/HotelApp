namespace HotelManagementApp.Data.Entities
{
    public class RoomEntity : BaseEntity
    {
        public string? Name { get; set; }
        public virtual BuildingEntity? Buildings { get; set; }
    }
}
