using System;
using System.Collections.Generic;
using System.Text;

namespace FormTestClient
{
    public class OrderData
    {
        public string Status { get; set; }
        public string ClOrdId { get; set; }

        public string Side { get; set; }

        public string Symbol { get; set; }

        public double OrderQty { get; set; }

        public double? QtyExecuted { get; set; }

        public double? AvgPx { get; set; }

        public double? LeavesQty { get; set; }

        public int NewOrderSingleId { get; set; }
    }
}
