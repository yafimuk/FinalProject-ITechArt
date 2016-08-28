using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.DAL.Models.Entities {

   public class ApplicationTicket {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TicketId { get; set; }
        public string Description { get; set; }
        public string Route { get; set; }
        public DateTime DateTime { get; set; }

        [Column(TypeName = "Money")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public decimal? Cost { get; set; }

        public int? Count { get; set; }

        public IEnumerable<ApplicationUser> Users { get; set; }
    }

}

