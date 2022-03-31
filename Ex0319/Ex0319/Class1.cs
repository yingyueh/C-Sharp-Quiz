using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0319
{
    class Person
    {
        private string name;
        public string Title
        {
            get { return name; }
            set { name = value; }
        }
        public void Display() =>
            Console.WriteLine($"Hello! {Title}.");
    }


}
