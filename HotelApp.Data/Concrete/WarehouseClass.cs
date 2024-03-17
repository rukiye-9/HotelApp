using HotelApp.Data.Abstract;
using HotelApp.Data.Repositories;
using HotelManagementApp.Data.Entities;

namespace HotelApp.Data.Concrete
{
    public class WarehouseClass : GenericRepository<WarehouseEntity>, IWarehouseClass
    {
    }
}
