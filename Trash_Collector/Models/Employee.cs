using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Trash_Collector.Models
{
    public class Employee
    {
        [Key]

        public int EmployeeId { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [ForeignKey("Zipcode")]
        public int ZipcodeID { get; set; }
        public Zipcode Zipcode { get; set; }

        [ForeignKey("PickupDay")]
        public int PickupID { get; set; }
        public PickupDay PickupDay { get; set; }


    }
}