namespace VTD.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class food_items
    {
        public long id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public decimal? price { get; set; }

        [StringLength(50)]
        public string description { get; set; }

        [StringLength(250)]
        public string image { get; set; }

        [StringLength(10)]
        public string menu_id { get; set; }

        [StringLength(100)]
        public string creator_code { get; set; }

        [StringLength(10)]
        public string created_at { get; set; }

        [StringLength(100)]
        public string updator_code { get; set; }

        public DateTime? updated_at { get; set; }

        [StringLength(100)]
        public string deletor_code { get; set; }

        public DateTime? deleted_at { get; set; }

        public int? lock_version { get; set; }

        public bool? status { get; set; }

        public int? sale_detail_id { get; set; }
    }
}
