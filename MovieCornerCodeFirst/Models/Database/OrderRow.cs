using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieCornerCodeFirst.Models.Database
{
    public class OrderRow
    {

        public int Id { get; set; }

        public int MovieId { get; set; }

        public int OrderId { get; set; }

        public Decimal Price { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual Order Order { get; set; }

    }
}