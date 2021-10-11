using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class BorrowedBook : IEntity
    {
        public int ID { get; set; }

        public DateTime Received { get; set; }

        public DateTime Delivery { get; set; }

        public bool Status { get; set; }

        public int BookID { get; set; }

        public int UserID { get; set; }

        //Relations
        /*
        public virtual Book Book { get; set; }

        public virtual User User { get; set; }
        */
    }
}
