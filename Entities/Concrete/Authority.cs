using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Authority : IEntity
    {
        public int ID { get; set; }

        public string AutName { get; set; }

        public bool Status { get; set; }

        //Relations
        /*
        public ICollection<User> User { get; set; }
        */
    }
}
