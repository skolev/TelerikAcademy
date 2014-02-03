using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Bookstore.Models
{


    [AttributeUsage(AttributeTargets.Property |
      AttributeTargets.Class,
      AllowMultiple = true)]
    public class AuthorAttribute : System.Attribute
    {
        public string Name { get; private set; }

        public AuthorAttribute(string name)
        {
            this.Name = name;
        }
    }
}
