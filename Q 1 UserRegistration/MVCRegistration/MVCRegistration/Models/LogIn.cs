namespace MVCRegistration.Models
{
    using System;
    using System.Linq;
    using System.Web;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class LogIn
    {       
            public int UserID { get; set; }
            public string FullName { get; set; }

            [Required(ErrorMessage = "Please Provide Username", AllowEmptyStrings = false)]
            public string Username { get; set; }

            [Required(ErrorMessage = "Please provide password", AllowEmptyStrings = false)]
            [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
            public string Password { get; set; }
       
    }
}