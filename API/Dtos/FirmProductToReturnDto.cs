using Core.Entities;

namespace API.Dtos
{
    public class FirmProductToReturnDto
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public string ProductPrice { get; set; }

        public string ProductUrl { get; set; }

        public string ProductType { get; set; }
        public string ProductBrand { get; set; }
   

    }
}