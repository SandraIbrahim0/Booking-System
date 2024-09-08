using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int BookedQuantity { get; set; }
        public virtual Resources Resource { get; set; }
    }
}
