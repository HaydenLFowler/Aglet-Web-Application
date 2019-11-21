using System;
/// <summary>
/// Hew
/// </summary>

namespace AgletCoreMVC.Models
{
public class Item {
	public int ItemID {get; set;}
	public int Quantity {get; set;}
	public string Price {get; set;}
	public string Specifications {get; set;}

	public virtual Order Order {get; set;}

	public virtual Lace Lace {get; set;}
	public virtual User UserID {get; set;}

}
    }
