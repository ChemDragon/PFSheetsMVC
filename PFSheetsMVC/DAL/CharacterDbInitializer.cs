using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PFSheetsMVC.Models;


namespace PFSheetsMVC.DAL
{
    public class CharacterDbInitializer : DropCreateDatabaseAlways<SheetsContext>
    {
        protected override void Seed(SheetsContext context)
        {
            getCharacter().ForEach(s => context.Characters.Add(s));
            context.SaveChanges();
        }

        private List<Character> getCharacter()
        {
            var characters = new List<Character>
            {
                new Character
                {
                    PlayerName = "Dart",
                    CharName = "Dartasien",

                }
            };

            return characters;
        }
    }
}