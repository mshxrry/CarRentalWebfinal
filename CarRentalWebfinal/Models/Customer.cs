using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace CarRentalWebfinal.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [StringLength(20, ErrorMessage = "The first name cannot exceed 20 characters")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        public string FirstMidName { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [StringLength(20, ErrorMessage = "The last name cannot exceed 20 characters")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public int ModelNumber { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
