using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.DAL.Models {
    public class Route : IBaseEntity<long> {

            public long Id { get; set; }

            public string StartingPoint { get; set; }

            public string EndPoin{ get; set; }

            public string Transit { get; set; }
    }
}
