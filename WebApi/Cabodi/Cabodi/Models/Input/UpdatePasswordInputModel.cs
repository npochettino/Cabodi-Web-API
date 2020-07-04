using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cabodi.Models.Input
{
    public class UpdatePasswordInputModel
    {
        [Required]
        public string NroCuenta { get; set; }

        [Required]
        public string NewPassword { get; set; }
    }
}