using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBQ.Model
{
    class QueueModel
    {

        public IEnumerable<string> CallTypeId { get; set; }
        public IEnumerable<string> CallersHolding { get; set; }
        public IEnumerable<string> HoldTime { get; set; }
        public IEnumerable<string> ServiceLevel { get; set; }
        public IEnumerable<string> CallType { get; set; }

    }
}
