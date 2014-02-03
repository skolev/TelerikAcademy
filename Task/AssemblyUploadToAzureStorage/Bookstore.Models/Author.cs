using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        [Author("Svetoslav Kolev")]
        public string Name { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Book> Books { get; set; }

        public Author()
        {
            this.Reviews = new HashSet<Review>();
            this.Books = new HashSet<Book>();
        }
    }
}
