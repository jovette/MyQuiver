using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MyQuiver.Common;

namespace MyQuiver.DataAccess.Model
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        public UserType Type { get; set; }

        public UserStatus Status { get; set; }

        public AuthenicationProvider Provider { get; set; }

        public string ProviderToken { get; set; }

        [StringLength(48, ErrorMessage = "Please enter a shorter first name"), Required]
        public string FirstName { get; set; }

        [StringLength(48, ErrorMessage = "Please enter a shorter last name"), Required]
        public string LastName { get; set; }

        [StringLength(128, ErrorMessage = "Please enter a shorter e-mail"), Required]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-\+])+@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+(\s)*$")]
        public string PrimaryEmail { get; set; }

        [StringLength(2)]
        public string State { get; set; }

        [StringLength(8)]
        public string PostalCode { get; set; }

        [Range(1, 100)]
        public int? Age { get; set; }

        public BowType? PreferredStyle { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Updated { get; set; }
    }
}
