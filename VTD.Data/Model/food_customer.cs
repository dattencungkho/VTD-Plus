namespace VTD.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class food_customer
    {
        public long id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string username { get; set; }

        [StringLength(15)]
        public string password { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string address { get; set; }

        [StringLength(50)]
        public string contact { get; set; }

        [StringLength(50)]
        public string comfirm { get; set; }

        [StringLength(250)]
        public string image { get; set; }

        public int? user_group_id { get; set; }

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
    }
}
