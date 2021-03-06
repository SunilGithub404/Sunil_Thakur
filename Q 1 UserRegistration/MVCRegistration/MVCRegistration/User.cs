//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCRegistration
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class User
    {
        public int UserID { get; set; }

        [Required(ErrorMessage = "Please Provide User Name", AllowEmptyStrings = false)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please Provide Password", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Password must be 8 Char Long.")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Confirm Password does not match.")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please Provide First Name", AllowEmptyStrings = false)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Provide Last Name", AllowEmptyStrings = false)]
        public string LastName { get; set; }

        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$", ErrorMessage = "Please Provide Valid Email Address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Provide Phone No.", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.PhoneNumber)]
        [StringLength(10, ErrorMessage = "Phone No. must be 10 Char Long.")]
        public string Phone_No { get; set; }

        [Required(ErrorMessage = "Please Provide Your Location", AllowEmptyStrings = false)]
        public string Location { get; set; }
    }
}
