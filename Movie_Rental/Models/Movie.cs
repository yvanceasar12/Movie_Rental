﻿namespace Movie_Rental.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string ReleaseDate { get; set; }
        public decimal Price { get; set; }

        public ICollection<RentalDetails> RentalDetails { get; set; }
    }
}
