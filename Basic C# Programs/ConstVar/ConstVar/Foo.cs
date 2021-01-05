using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVar
{
    public class Foo
    {
        public int id { get; set; }
        public string name { get; set; }

        // Chained constructors
        public Foo() : this(1, "Brooks")
        {
        }
        // Initial constructor
        public Foo(int id, string name)
        {
            this.id = 1;
            this.name = name;
        }
    }
}
