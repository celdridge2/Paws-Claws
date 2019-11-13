using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PawsClaws.Models
{
    public class Pet
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [Display(Name = "At Our Shelter?")]
        public string AtShelter { get; set; }
        public string Species {get; set;}
        public string Breed {get; set;}
        public string Sex {get; set;}
        public string Size {get; set;}

        [Display(Name = "Spayed/Neutered?")]
        public string Spay_Neuter {get; set;}

        [Display(Name = "Up-to-Date on Shots?")]
        public string ShotsUTD {get; set;}
        public string Color {get; set;}

        [Display(Name = "Fur Length")]
        public string FurLength {get; set;}

        [DataType(DataType.Date)]
        public DateTime DateOfBirth {get; set;}

        public int Age {get; set;}
        public string Description {get; set;}
    }
}
