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
        //it is a attrivute which specifies dtafild is requires and it intializes the new variable
        [Required(ErrorMessage = "{0} is mandatory to initialize")]
        //it specifies the minimum and maximum length of character that are allowed in the datafield
        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "First Name should be minimum 3 characters and a maximum of 50 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} is required or mandatory to initialize")]
        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "Last Name should be minimum 3 characters and a maximum of 50 characters")]
        public string LastName { get; set; }

        [Phone]//this data field value shoul be like phone number fromate
        [StringLength(10, MinimumLength = 10,
        ErrorMessage = "Phone should be exactly 10 numbers")]
        public string Phone { get; set; }

        [EmailAddress]//this valida an email
        public string Email { get; set; }
        //it will specifies the range for the value of the datafields
        [Range(10, 30, ErrorMessage = "Age should be between 10 to 30")]
        public int Age { get; set; }
    }
}
