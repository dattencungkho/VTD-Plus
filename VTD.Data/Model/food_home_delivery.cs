namespace VTD.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class food_home_delivery
    {
        public long id { get; set; }

        [StringLength(100)]
        public string address { get; set; }

        [StringLength(100)]
        public string contact { get; set; }

        public int? customer_id { get; set; }

        public int? orders_id { get; set; }

        [StringLength(50)]
        public string payment_type { get; set; }
    }
}
