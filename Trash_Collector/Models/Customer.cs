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
        public int customerID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string address { get; set; }
        [ForeignKey("ZipcodeID")]
        public Zipcode Zipcode { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        [Display(Name = "Email")]
        public string email { get; set;}
        [ForeignKey("PickupID")]
        [Display(Name = "Regular pickup day")]
        public PickupDay PickupDay { get; set; }
        [ForeignKey("PickupID")] 
        [Display(Name = "Bonus pickup day")]
        public PickupDay BonusPickupDay { get; set; }







    }
}