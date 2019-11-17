﻿namespace Tims.WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class ReceptionType
    {
        [Key]
        public int ReceptionTypeId { get; set; }

        [Display(Name = "Forma Llegada")]
        public string ReceptionTypeName { get; set; }

        public virtual List<Billing> Billings { get; set; }  
    }
}
