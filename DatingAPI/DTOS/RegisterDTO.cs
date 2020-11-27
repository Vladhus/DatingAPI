using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAPI.DTOS
{
    public class RegisterDTO
    {  
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8,MinimumLength =4)]
        public string Password { get; set; }
    }

    public class LoginDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }

    public class UserDTO
    {
        public string Username { get; set; }
        public string Token { get; set; }
    }
}
