using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Book : IEntity
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Piece { get; set; }

        public int Page { get; set; }

        public bool Status { get; set; }

        public int PublisherID { get; set; }

        public int WriterID { get; set; }

    }
}
