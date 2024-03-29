﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;


namespace Assignment2.Models
{
    public class Team
    {
        [Required]
        public int TeamId { get; set; }


        [Required]
        public string TeamName { get; set; }  
        

        [Required]
        public string TeamCoach { get; set; }

        [Required]
        public string TeamLeague { get; set; }


        public List<Player>? Players { get; set; }

    }
}
