using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WidgetMVC.Models
{
    public class CreateWidgetVM
    {
        public Widget Widget { get; set; }

        public List<Type> Types { get; set; }

        public List<string> PrimaryTypes { get; set; }

    }
}