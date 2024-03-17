using HotelApp.Data.Abstract;
using HotelApp.Services.Abstract;
using HotelManagementApp.Data.Entities;

namespace HotelApp.Services.Conctrete
{
    public class BuildingService : IBuildingService
    {
        private readonly IBuildingClass _buildingclass;

        public BuildingService(IBuildingClass buildingclass)
        {
            _buildingclass = buildingclass;
        }

        public void TDelete(BuildingEntity t)
        {
            _buildingclass.Delete(t);
        }

        public BuildingEntity TGetByID(int id)
        {
            return _buildingclass.GetByID(id);
        }

        public List<BuildingEntity> TGetList()
        {
            return _buildingclass.GetList();
        }

        public void TInsert(BuildingEntity t)
        {
            _buildingclass.Insert(t);
        }

        public void TUpdate(BuildingEntity t)
        {
            _buildingclass.Update(t);
        }
    }
}
