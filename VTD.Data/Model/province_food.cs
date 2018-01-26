namespace VTD.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class province_food
    {
        public long id { get; set; }

        [StringLength(200)]
        public string name_province { get; set; }
    }
}
