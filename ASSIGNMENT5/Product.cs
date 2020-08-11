namespace ASSIGNMENT5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public short productID { get; set; }

        [Column(TypeName = "money")]
        public decimal? cost { get; set; }

        [StringLength(255)]
        public string manufaacturer { get; set; }

        [StringLength(255)]
        public string model { get; set; }

        [StringLength(255)]
        public string screensize { get; set; }
    }
}
