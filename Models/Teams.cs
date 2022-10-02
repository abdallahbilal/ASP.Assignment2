using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;


namespace Assignment2.Models
{
    public class Teams
    {
        [Required]
        public int TeamId { get; set; }


        [Required]
        public string TeamName { get; set; }  
        

        [Required]
        public string TeamCoach { get; set; }


        [Required]
        [DisplayFormat(DataFormatString = "{ 0 : c }")]
        public int Budget { get; set; }

    }
}
