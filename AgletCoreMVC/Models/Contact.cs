using System;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Joe/Hayden
/// </summary>
/// namespace AgletCoreMVC.Models
namespace AgletCoreMVC.Models
{
    public class Contact
    {
	    public int ContactID { get; set; }

        [DataType(DataType.EmailAddress), StringLength(100)]
        public string Email {get;set; }

       [Required, StringLength(20, ErrorMessage = "Phone Number must be filled in")]
       [Display (Name = "Phone Number")]
        public string Phone {get; set;}

    }
}
