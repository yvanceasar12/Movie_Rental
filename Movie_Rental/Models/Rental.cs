using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie_Rental.Models
{
    public class Rental
    {
        [Key]
        public int RentalId { get; set; }

        [ForeignKey("Movies")]
        public int MovieId { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public DateTime RentalDate { get; set; }

        public DateTime ReturnDate { get;   set; }

        public Customer Customer { get; set; }

        public Movie Movies { get; set; }
    }
}
