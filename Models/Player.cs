using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;


namespace Assignment2.Models
{
    public class Player
    {
        [Required]
        public int PlayerId { get; set; }


        [Required]
        public string TeamId { get; set; }

        

        [Required]
        public string PlayerName { get; set; }


        [Required]
        public string Country { get; set; }


        [Required]
        public int Age { get; set; }



        public Team? Teams { get; set; }






    }
}
