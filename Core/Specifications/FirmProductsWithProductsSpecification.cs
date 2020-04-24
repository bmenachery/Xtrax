using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications
{
    public class FirmProductsWithProductsSpecification : BaseSpecification<FirmProduct>
    {
        public FirmProductsWithProductsSpecification(FirmProductSpecParams firmProductParams)
            : base(x =>
                     (string.IsNullOrEmpty(firmProductParams.Search) || x.Name.ToLower()
                         .Contains(firmProductParams.Search)) &&
                     (!firmProductParams.ProductId.HasValue || x.ProductId == firmProductParams.ProductId) 
                )

        {
            AddInclude(p => p.Product);
            AddInclude(p => p.Product.ProductType);
            AddInclude(p => p.Product.ProductBrand);
            AddOrderBy(x => x.Name);
            ApplyPaging(firmProductParams.PageSize * (firmProductParams.PageIndex - 1), firmProductParams.PageSize);

        
        }

        public FirmProductsWithProductsSpecification(int id)
            : base(x => x.Id == id)
        {
           
            AddInclude(p => p.Product);
            AddInclude(p => p.Product.ProductType);
            AddInclude(p => p.Product.ProductBrand);
        }

        public FirmProductsWithProductsSpecification(Expression<Func<FirmProduct, bool>> criteria) : base(criteria)
        {
        }
    }
}