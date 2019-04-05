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
        public string VTMCLH_NROCTA { get; set; }

        [Required]
        public string USR_VTMCLH_CONAPP { get; set; }
    }
}