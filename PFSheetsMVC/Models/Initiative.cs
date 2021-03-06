﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PFSheetsMVC.Models
{
    public class Initiative
    {
        [Required, Key, ScaffoldColumn(false)]
        public int CharID { get; set; }

        public int Character { get; set; }

        public int DexMod { get; set; }

        public int FeatMod { get; set; }

        public int RaceMod { get; set; }

        public int MiscMod { get; set; }

        public int Total { get; set; }
    }
}