using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts.DTO
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "UserName can't be blank")]
        public string UserName { get; set; }

        [DataType(DataType.Password,ErrorMessage = "Password must be at least 5 characters long, must contain at least one lowercase letter, must contain at least 3 unique characters.")]
        [Required(ErrorMessage = "Password can't be blank")]
        public string Password { get; set; }

        [DataType(DataType.Password, ErrorMessage = "Password must be at least 5 characters long, must contain at least one lowercase letter, must contain at least 3 unique characters.")]
        [Compare("Password", ErrorMessage = "Password and confirm password do not match")]
        [Required(ErrorMessage = "ConfirmPassword can't be blank")]
        public string ConfirmPassword { get; set; }
    }
}
