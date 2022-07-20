using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieCornerCodeFirst.Models.Database
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }

        // Customer_Id

        public virtual Customer Customer { get; set; } // FK Relation with Customer

        public virtual ICollection<OrderRow> OrderRows { get; set; }

    }
}