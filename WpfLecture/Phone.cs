using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLecture
{
    public class Phone
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public override string ToString()
        {
            return $"Phone: {this.Name}; price: {this.Price}";
        }
    }
}
