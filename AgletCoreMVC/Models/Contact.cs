using System;

/// <summary>
/// Joe
/// </summary>
/// namespace AgletCoreMVC.Models
namespace AgletCoreMVC.Models
{
public class Contact
{
	public int ContactID;
	public string Email {get;set;}
	public string Phone {get; set;}


        // Navigation
	public virtual User UserID { get; set; }


}
}
