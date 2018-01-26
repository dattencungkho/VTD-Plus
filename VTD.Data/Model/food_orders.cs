namespace VTD.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class food_orders
    {
        public long id { get; set; }

        [StringLength(50)]
        public string description { get; set; }

        public TimeSpan? time { get; set; }

        public DateTime? date { get; set; }

        public bool? status { get; set; }

        public byte? deleted { get; set; }

        public int? total { get; set; }

        public int? customer_id { get; set; }

        public int? table_id { get; set; }

        public int? adults_num { get; set; }

        public int? children_num { get; set; }
    }
}
