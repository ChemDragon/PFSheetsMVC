using System.ComponentModel.DataAnnotations;

namespace PFSheetsMVC.Models
{
    public class CharacterClass
    {
        [Required, Key, ScaffoldColumn(false)]
        public int CharID { get; set; }

        public int Character { get; set; }

        public string Class1 { get; set; }

        public int Level1 { get; set; }

        public string Class2 { get; set; }

        public int Level2 { get; set; }

        public string Class3 { get; set; }

        public int Level3 { get; set; }

        public string Class4 { get; set; }

        public int Level4 { get; set; }

        public string Class5 { get; set; }

        public int Level5 { get; set; }
    }
}