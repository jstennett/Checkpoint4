using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blow_Out.Models
{
    [Table("Customer")]
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerID { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        public string City { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        public string State { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        [EmailAddress (ErrorMessage = "Please Enter a Valid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        [RegularExpression(@"((?:\(?[2-9](?(?=1)1[02-9]|(?(?=0)0[1-9]|\d{2}))\)?\D{0,3})(?:\(?[2-9](?(?=1)1[02-9]|\d{2})\)?\D{0,3})\d{4})", ErrorMessage = "PhoneNumber should contain only numbers")]
        public string Phone { get; set; }
        [Required (ErrorMessage = "First Zipcode")]
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip")]
        public string Zipcode { get; set; }
    }
}