using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
/// <summary>
/// Hew
/// </summary>

namespace AgletCoreMVC.Models
{
public class Item {


	public int ItemID {get; set;}

    [Display(Name = "Quantity"), ]
	public int Quantity {get; set;}

    [Required]// curren y annotations
    [Display(Name = "Price")]
	public decimal Price {get; set;}

    public int LaceID { get; set; }

    public int OrderID { get; set; }

        // Navigation
	public virtual Order Order {get; set;}
	public virtual Lace Lace {get; set;}

}
    }
