namespace Movie_Rental.Models
{
    public class RentalDetails
    {
        public int Id { get; set; }
        public int RentalId { get; set; }
        public int MovieId { get; set; }

        public Rental Rental { get; set; }
        public Movie Movie { get; set; }
    }
}
