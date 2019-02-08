using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Athentication.Models
{
    public  partial class UserDataPartial
    {
        [Required(ErrorMessage ="Filed Must not be empty")]
        public string Userid { get; set; }
        [Required(ErrorMessage = "Filed Must not be empty")]
        public string Password { get; set; }
    }

    [MetadataType(typeof(UserDataPartial))]
   public partial class UserData
    {

    }
}