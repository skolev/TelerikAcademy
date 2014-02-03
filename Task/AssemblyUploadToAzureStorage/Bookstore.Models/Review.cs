using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.Models
{
    public class Review
    {
        public int ReviewId { get; set; }

        public string Content { get; set; }

        public DateTime Date { get; set; }

        public int? AuthorId { get; set; }

        public int BookId { get; set; }

        public virtual Author Author { get; set; }
        public virtual Book Book { get; set; }
    }
}
