namespace VTD.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class district_food
    {
        public long id { get; set; }

        public string name_district { get; set; }

        public long? id_province { get; set; }
    }
}
