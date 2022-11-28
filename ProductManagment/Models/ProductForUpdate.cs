namespace ProductManagment.Models
{
    public class ProductForUpdate
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public decimal? Price { get; set; }

        public bool? Available { get; set; }

        public string? Description { get; set; }
    }
}
