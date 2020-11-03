using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;

namespace Northwind.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        [Required(ErrorMessage = "Company Name is Required")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Address is Required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "City is Required")]
        public string City { get; set; }
        public string Region { get; set; }
        [Required(ErrorMessage = "Postal Code is Required")]
        public string PostalCode { get; set; }
        [Required(ErrorMessage = "Country is Required")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Phone is Required")]
        public string Phone { get; set; }
        public string Fax { get; set; }
    }
}
