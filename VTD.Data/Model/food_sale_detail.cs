namespace VTD.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class food_sale_detail
    {
        public long id { get; set; }

        public DateTime date { get; set; }

        public int daily { get; set; }

        public int? weekly { get; set; }

        public int? monthly { get; set; }

        [StringLength(100)]
        public string description { get; set; }

        [StringLength(50)]
        public string name { get; set; }
    }
}
