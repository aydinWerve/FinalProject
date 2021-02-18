using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;


// DataAccess + Entities
namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IResult Add(Product product);
        IDataResult<List<Product>> GetByCategoryId(int id); //Category id sine göre getir
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max); //Şu fiyat aralığında olan ürünleri getir.
        IDataResult<Product> GetById(int productId);
        IDataResult<List<ProductDetailDTO>> GetProductDetailDTOs();
    }
}
