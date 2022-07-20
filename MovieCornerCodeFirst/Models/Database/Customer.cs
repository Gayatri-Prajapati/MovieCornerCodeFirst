using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieCornerCodeFirst.Models.Database
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } // nvarchar(max)--> nvarchar(100)

        [Required]
        [StringLength(100)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required, StringLength(10)]
        [Display(Name = "Billing Address")]
        public string BillingAddress { get; set; }

        [Required]
        [Display(Name = "Blling Zip Code")]
        public int BillingZipCode { get; set; }

        [Required, StringLength(500)]
        [Display(Name = "Dilivery Address")]
        public string DiliveryAddress { get; set; }

        [Required]
        [Display(Name = "Dilivery Zip Code")]
        public int DiliveryZipCode { get; set; }

        [Required, StringLength(50)]
        [Display(Name = "Dilivery City Name")]
        public string DiliveryCityName { get; set; }

        [Required]
        [StringLength(255)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }


        public virtual ICollection<Order> Orders { get; set; } // Many relation with orders table

    }
}