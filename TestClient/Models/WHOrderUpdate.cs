using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormTestClient.Models
{
    public class WHOrderUpdate
    {
        public string Instance { get; set; }

        public string SessionName { get; set; }

        public string ClOrdId { get; set; }

        public string SenderCompId { get; set; }

        public string TargetCompId { get; set; }

        public decimal OrderQty { get; set; }

        public string Symbol { get; set; }

        public decimal QtyExecuted { get; set; }

        public decimal AvgPx { get; set; }

        public string OrderStatus { get; set; }

        public string URL { get; set; }
    }
}
