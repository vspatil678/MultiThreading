using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading.Linq
{
    class Order
    {
        public int OrderId { get; set; }

        public int EmpId { get; set; }

        public DateTime OrderedOn { get; set; }

        public int Quantity { get; set; }
    }
}
