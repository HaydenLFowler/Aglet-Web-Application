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

    [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                            ErrorMessage = "Please enter a valid email address")]
    public string Email {get;set;}
	public string Phone {get; set;}


        // Navigation
	public virtual User UserID { get; set; }


}
}
