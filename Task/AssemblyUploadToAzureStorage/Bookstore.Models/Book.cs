using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; }

        public string ISBN { get; set; }

        public decimal? Price { get; set; }

        public string Url { get; set; }

        public int PublisherId { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Author> Authors { get; set; }

        public virtual Publisher Publisher { get; set; }

        public Book()
        {
            this.Reviews = new HashSet<Review>();
            this.Authors = new HashSet<Author>();
        }
    }
}
