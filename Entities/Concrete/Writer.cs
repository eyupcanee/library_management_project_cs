using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Writer : IEntity
    {
        public int ID { get; set; }

        public bool Confirmation { get; set; }

        public bool Status { get; set; }

        public int UserID { get; set; }

    }
}
