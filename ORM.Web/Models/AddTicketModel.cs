using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Web.Models {
   public class AddTicketModel {

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Cost { get; set; }

        [Required]
        public decimal Route { get; set; }

        [Required]
        public int Count { get; set; }

    }
}
