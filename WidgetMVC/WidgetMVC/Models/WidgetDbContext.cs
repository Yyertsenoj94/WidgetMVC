using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MySql.Data.EntityFramework;

namespace WidgetMVC.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class WidgetDbContext : DbContext
    {
           public DbSet<Widget> Hammers { get; set; }

           public DbSet<Type> Types { get; set; }
    }
}