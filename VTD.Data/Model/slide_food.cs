namespace VTD.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class slide_food
    {
        public long id { get; set; }

        [StringLength(100)]
        public string decription { get; set; }

        [StringLength(100)]
        public string image { get; set; }
    }
}
