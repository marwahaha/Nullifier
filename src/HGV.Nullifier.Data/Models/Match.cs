﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HGV.Nullifier.Data.Models
{
    public class MatchSummary
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public long id { get; set; }

        [Index]
        public long match_number { get; set; }

        public double duration { get; set; }
        public int day_of_week { get; set; }
        public DateTime date { get; set; }

        public int victory_dire { get; set; }
        public int victory_radiant { get; set; }
    }
}
