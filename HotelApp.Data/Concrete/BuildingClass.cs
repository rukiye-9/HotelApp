using HotelApp.Data.Abstract;
using HotelApp.Data.Repositories;
using HotelManagementApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Data.Concrete
{
    public class BuildingClass : GenericRepository<BuildingEntity>, IBuildingClass
    {
    }
}
