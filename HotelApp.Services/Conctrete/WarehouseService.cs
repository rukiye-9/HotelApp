using HotelApp.Data.Abstract;
using HotelApp.Services.Abstract;
using HotelManagementApp.Data.Entities;

namespace HotelApp.Services.Conctrete
{
    public class WarehouseService : IWarehouseService
    {
        private readonly IWarehouseClass _warehouseclass;

        public WarehouseService(IWarehouseClass warehouseclass)
        {
            _warehouseclass = warehouseclass;
        }

        public void TDelete(WarehouseEntity t)
        {
            _warehouseclass.Delete(t);
        }

        public WarehouseEntity TGetByID(int id)
        {
            return _warehouseclass.GetByID(id);
        }

        public List<WarehouseEntity> TGetList()
        {
            return _warehouseclass.GetList();
        }

        public void TInsert(WarehouseEntity t)
        {
            _warehouseclass.Insert(t);
        }

        public void TUpdate(WarehouseEntity t)
        {
            _warehouseclass.Update(t);
        }
    }
}
