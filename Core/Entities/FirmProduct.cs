namespace Core.Entities
{
    public class FirmProduct: BaseEntity
    {
        public string Name { get; set; }

        public virtual Product Product { get; set; }

        public int ProductId { get; set; }
    }

}