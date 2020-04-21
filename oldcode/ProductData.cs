// using System.Collections.Generic;
// using System.Threading.Tasks;
// using Infrastructure.Models;
// using Dapper;

// namespace Infrastructure.Data
// {
//     public static class ProductData
//     {
//         public static async Task<Product> GetProductByIdAsync(this XTraxDataAccess dataAccess, int id)
//         {

//             return await dataAccess.QueryFirstOrDefaultAsync<Product>(
//                     " Select p.id, p.Name, p.ProductTypeId, t.Name ProductTypeName, p.ProductBrandId, b.Name ProductBrandName " +
//                     " from Product p " + 
//                     " INNER JOIN ProductType t ON p.ProductTypeId = t.Id " +
//                     " INNER JOIN ProductBrand b ON p.ProductBrandId = b.Id " +
//                     " WHERE p.id = @id", new { id });

//         }

//         public static async Task<IEnumerable<Product>> GetProductAsync(this XTraxDataAccess dataAccess)
//         {

//             var product = await dataAccess.QueryAsync<Product>(
//                  " Select p.id, p.Name, p.ProductTypeId, t.Name ProductTypeName, p.ProductBrandId, b.Name ProductBrandName " +
//                     " from Product p " +
//                     " INNER JOIN ProductType t ON p.ProductTypeId = t.Id " +
//                     " INNER JOIN ProductBrand b ON p.ProductBrandId = b.Id ");

//             return product;

//         }


//         public static async  Task<IEnumerable<ProductBrand>> GetProductBrandAsync(this XTraxDataAccess dataAccess)
//         {

//             var productBrand =  await dataAccess.QueryAsync<ProductBrand>("Select id, Name, DateCreated CreatedDate from ProductBrand");

//             return productBrand;

//         }

//         public static async Task<IEnumerable<ProductType>> GetProductTypeAsync(this XTraxDataAccess dataAccess)
//         {

//             var productType = await dataAccess.QueryAsync<ProductType>("Select id, Name, DateCreated CreatedDate from ProductType");

//             return productType;

//         }


      

//     }
// }