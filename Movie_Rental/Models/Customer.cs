namespace Movie_Rental.Models
{
    public class Customer
    {
        
        public int CostumerId { get; set; }
        public required string Name { get; set; }
        public string? Email { get; set; }
        public ICollection<Rental> Rental { get; set; }

    }
}
