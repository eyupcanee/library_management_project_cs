using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Publisher : IEntity
    {
        public int ID { get; set; }

        public string PName { get; set; }

        public bool Status { get; set; }

        //Relations
        /*
        public ICollection<Book> Book { get; set; }
        */
    }
}
