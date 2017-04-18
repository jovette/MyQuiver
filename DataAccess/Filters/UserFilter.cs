using MyQuiver.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyQuiver.DataAccess.Filters
{
    public class UserFilter
    {
        public int UserId { get; set; }

        public UserType? Type { get; set; }

        public UserStatus? Status { get; set; }

        [StringLength(48, ErrorMessage = "Please enter a shorter first name")]
        public string FirstName { get; set; }

        [StringLength(48, ErrorMessage = "Please enter a shorter last name")]
        public string LastName { get; set; }

        [StringLength(128, ErrorMessage = "Please enter a shorter e-mail"), Required]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-\+])+@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+(\s)*$")]
        public string PrimaryEmail { get; set; }
    }
}
