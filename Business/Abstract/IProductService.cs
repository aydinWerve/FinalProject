using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;


// DataAccess + Entities
namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategoryId(int id); //Category id sine göre getir
        List<Product> GetByUnitPrice(decimal min, decimal max); //Şu fiyat aralığında olan ürünleri getir.
    }
}
