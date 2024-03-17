using HotelApp.Data.Abstract;
using HotelApp.Services.Abstract;
using HotelManagementApp.Data.Entities;

namespace HotelApp.Services.Conctrete
{
    public class RoomService : IRoomService
    {
        private readonly IRoomClass _roomclass;

        public RoomService(IRoomClass roomclass)
        {
            _roomclass = roomclass;
        }

        public void TDelete(RoomEntity t)
        {
            _roomclass.Delete(t);
        }

        public RoomEntity TGetByID(int id)
        {
            return _roomclass.GetByID(id);
        }

        public List<RoomEntity> TGetList()
        {
            return _roomclass.GetList();
        }

        public void TInsert(RoomEntity t)
        {
            _roomclass.Insert(t);
        }

        public void TUpdate(RoomEntity t)
        {
            _roomclass.Update(t);
        }
    }
}
