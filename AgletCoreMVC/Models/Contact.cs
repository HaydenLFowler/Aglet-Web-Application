using System;

/// <summary>
/// Joe Champion
/// </summary>
/// namespace AgletCoreMVC.Models
namespace AgletCoreMVC.Models
{
public class Contact
{
	public int ContactID;
	public string Email {get;set;}
	public string Phone {get; set;}

	public virtual User UserID;


}
}
