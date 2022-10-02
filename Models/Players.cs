using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;


namespace Assignment2.Models
{
    public class Players
    {
        [Required]
        public int PlayerId { get; set; }


        [Required]
        public int TeamId { get; set; }


        [Required]
        public string PlayerName { get; set; }


        [Required]
        public string Country { get; set; }


        [Required]
        public int Age { get; set; }


        [Required]
        [DisplayFormat(DataFormatString = "{ 0 : c }")]
        public int PurchasePrice { get; set; }

        public Teams? Teams { get; set; }






    }
}
