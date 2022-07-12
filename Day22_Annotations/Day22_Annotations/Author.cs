using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22_Annotations
{
    public class Author
    {
        [Required(ErrorMessage = "{0} is mandatory to initialize")]
        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "First Name should be minimum 3 characters and a maximum of 50 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} is required or mandatory to initialize")]
        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "Last Name should be minimum 3 characters and a maximum of 50 characters")]
        public string LastName { get; set; }

        [Phone]
        [StringLength(10, MinimumLength = 10,
        ErrorMessage = "Phone should be exactly 10 numbers")]
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Range(10, 30, ErrorMessage = "Age should be between 10 to 30")]
        public int Age { get; set; }
    }
}
