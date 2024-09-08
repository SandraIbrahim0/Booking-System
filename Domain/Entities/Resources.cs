using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Resources
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

    }
}
