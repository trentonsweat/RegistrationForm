
namespace LabNumber20.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class RegistrationForm
    {
        public int UserID { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Address1 { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Address2 { get; set; }
        public string Zip { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Country { get; set; }
    }
}
