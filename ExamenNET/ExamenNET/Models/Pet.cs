using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace ExamenNET.Models
{
    public class Pet
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "The name of the pet is required")]
        public string Name { get; set; }

        public string Breed { get; set; }

        [Required(ErrorMessage = "The date of bith of the pet is required")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "The state of the pet is required")]
        public State State { get; set; }

        public Animal Animal { get; set; }


    }

    public enum State
    {
        Adoption,
        Sale
    }

    public enum Animal
    {
        Dog,
        Cat,
        Hamster,
        Rabbit

    }

}
