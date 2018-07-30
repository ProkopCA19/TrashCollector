using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Trash_Collector.Models
{
    public class PickupDay
    {
        [Key]
       public int PickupID { get; set; }
       public double Charge { get; set; }
       public string Name { get; set; }

       

    }
}