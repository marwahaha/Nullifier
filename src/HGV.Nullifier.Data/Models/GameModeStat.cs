namespace HGV.Nullifier.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GameModeStat
    {
        [Key]
        public int id { get; set; }

        [Index(IsUnique = true)]
        public int mode { get; set; }

        public string name { get; set; }

        public int picks { get; set; }
    }
}