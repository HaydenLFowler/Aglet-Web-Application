using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
/// <summary>
/// Hayden
/// </summary>

namespace AgletCoreMVC.Models
{
public class Item {


	public int ItemID {get; set;}

    [Required]
    [Range(1,99)]
	public int Quantity {get; set;}

    // current annotations

    [Required]
    [Range(0, 9999.99)]
    public decimal Total {get; set;}

    public int LaceID { get; set; }

    public int OrderID { get; set; }

        // Navigation
	public virtual Order Order {get; set;}
	public virtual Lace Lace {get; set;}

}
    }
