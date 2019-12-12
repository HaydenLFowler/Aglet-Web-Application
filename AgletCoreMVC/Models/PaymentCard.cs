using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
/// <summary>
/// When placing an order the user must provide payment information,
/// this can apply to any staff that decide to also be a customer as well.
/// Joe
/// </summary>
///
namespace AgletCoreMVC.Models
{
public class PaymentCard 
    {

	public string PaymentCardID { get; set; }

    // Customers name
    [Required]
    [StringLength(30, ErrorMessage = "Errror"), DisplayName("Card Numnber")]
    public string CardName { get; set; }

    [Required]
    [StringLength(30, ErrorMessage = "Errror"), DisplayName("Card Numnber")]
    public string CardNumber { get; set;}

    
	//public int CustomerID;

   
	public int SecurityCode {get; set;}

    
    [Required, Range(1,12)]
	public int ExpiryMonth {get; set;}

    [Required, Range(2019, 2029)]
    public int ExpiryYear { get; set; }

        // Navigation
        //public virtual User UserID { get; set; }


    }
}
