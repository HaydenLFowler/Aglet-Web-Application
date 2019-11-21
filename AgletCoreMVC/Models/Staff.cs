using System;
/// <summary>
/// Hew
/// </summary>
namespace AgletCoreMVC.Models
{
public class Staff {
	public string Department;
	public string Salary;
	public string JobTitle;

	public virtual User UserID {get; set;}

}
    }