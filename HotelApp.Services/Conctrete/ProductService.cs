using HotelApp.Data.Abstract;
using HotelApp.Services.Abstract;
using HotelManagementApp.Data.Entities;

namespace HotelApp.Services.Conctrete
{
    public class ProductService:IProductService
    {
        private readonly IProductClass _productclass;

        public ProductService(IProductClass productclass)
        {
            _productclass = productclass;
        }

        public void TDelete(ProductEntity t)
        {
            _productclass.Delete(t);
        }

        public ProductEntity TGetByID(int id)
        {
            return _productclass.GetByID(id);
        }

        public List<ProductEntity> TGetList()
        {
            return _productclass.GetList();
        }

        public void TInsert(ProductEntity t)
        {
            _productclass.Insert(t);
        }

        public void TUpdate(ProductEntity t)
        {
            _productclass.Update(t);
        }
    }
}

