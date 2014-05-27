using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBQ.Model
{
    class ProductModel
    {

        public string ProductName { get; set; }
        public IEnumerable<QueueModel> Queue { get; set; }
        
    }
   
}
