using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using MySql.Data.EntityFramework;

namespace WidgetMVC.Models
{
    public class Widget
    {
        public int ID { get; set; }

        [Display(Name="Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name="Type")]
        [Required]
        public string PrimaryType { get; set; }

        [Display(Name="Subtype")]
        [Required]
        public string SubType { get; set; }

        [Display(Name="Creation Date")]
        [Required]
        public DateTime Creation { get; set; }

    }

}
