namespace HotelManagementApp.Data.Entities
{
    public class BaseEntity
    {
        public Guid Id{ get; set; }
        public bool IsActive  { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }

    }
}
