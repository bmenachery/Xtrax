using System.Collections.Generic;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class FirmProductsController: BaseApiController
    {
        private readonly IGenericRepository<FirmProduct> _firmProductsRepo;
        private readonly IGenericRepository<ProductBrand> _productBrandRepo;

        private readonly IMapper _mapper;

        public FirmProductsController(IGenericRepository<FirmProduct> firmProductsRepo, 
                                     IGenericRepository<ProductBrand> productBrandRepo, 
                                     IMapper mapper)
        {
            _firmProductsRepo = firmProductsRepo;
            _productBrandRepo = productBrandRepo;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<FirmProductToReturnDto>>> GetFirmProducts(
             [FromQuery] FirmProductSpecParams firmProductParams)
        {

            var spec = new FirmProductsWithProductsSpecification(firmProductParams);

            var totalItems = await _firmProductsRepo.CountAsync(spec);
            
             var firmproducts = await _firmProductsRepo.ListAsync(spec);

            var data = _mapper.Map<IReadOnlyList<FirmProduct>, IReadOnlyList<FirmProductToReturnDto>>(firmproducts);

            return Ok(data);

            //return Ok(firmproducts);

        }

       
    }
}