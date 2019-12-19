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

    // curren y annotations

    [Required]
    [RegularExpression(@"^\d+\.\d{0,2}$")]
    [Range(0, 9999.99)]
    public decimal Price {get; set;}

    public int LaceID { get; set; }

    public int OrderID { get; set; }

        // Navigation
	public virtual Order Order {get; set;}
	public virtual Lace Lace {get; set;}

}
    }
