using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Trash_Collector.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Email { get; set;}
        public double TrashBalance { get; set; }

       
        [ForeignKey("Zipcode")]
        public int ZipcodeID { get; set; }
        public Zipcode Zipcode { get; set; }
       
        [ForeignKey("PickupDay")]
        public int PickupID { get; set; }
        public PickupDay PickupDay{ get; set; }

      
        





    }
}