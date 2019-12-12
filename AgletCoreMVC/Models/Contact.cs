using System;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Joe
/// </summary>
/// namespace AgletCoreMVC.Models
namespace AgletCoreMVC.Models
{
public class Contact
{
	public int ContactID;

    [DataType(DataType.EmailAddress), StringLength(100)]
    public string Email {get;set; }

   [Required, StringLength(20)]
    public string Phone {get; set;}


        // Navigation
	//public virtual User UserID { get; set; }


}
}
