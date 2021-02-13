using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        //interface operasyonları Publictir yazmaya gerek yok
        List<ProductDetailDto> GetProductDetails();
        
    }
}
