namespace VTD.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class food_user_group1
    {
        public long id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public bool? status { get; set; }
    }
}
