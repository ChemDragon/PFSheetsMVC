using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using PFSheetsMVC.Models;

namespace PFSheetsMVC.DAL
{
    public class SheetsContext : DbContext
    {

        #region Constructors

        public SheetsContext() : base("SheetsContext")
        {

        }

        #endregion 

        public DbSet<AbilityScore> AbilityScores { get; set; }
        public DbSet<ArmorClass> ArmorClasses { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<CharacterClass> Classes { get; set; }
        public DbSet<HitPoints> HP { get; set; }
        public DbSet<Initiative> Initiatives { get; set; }
        public DbSet<SavingThrow> SavingThrows { get; set; }
        public DbSet<Speed> Speeds { get; set; } 
    }
}