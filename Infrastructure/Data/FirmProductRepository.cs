using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class FirmProductRepository : IFirmProductRepository
    {
        private readonly StoreContext _context;
        public FirmProductRepository(StoreContext context)
        {
            _context = context;
        }
        
        public async Task<IReadOnlyList<FirmProduct>> GetAllFirmProductsAsync()
        {
            return await _context.FirmProducts
            .Include(p => p.Product)
            .ToListAsync();
        }

        public async Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync()
        {
            return await _context.ProductBrands.ToListAsync();
        }

    }
}


