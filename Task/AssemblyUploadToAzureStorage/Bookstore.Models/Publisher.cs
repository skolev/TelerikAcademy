using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class Publisher
    {
        public int PublisherId { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        public Publisher()
        {
            this.Books = new HashSet<Book>();
        }
    }
}
