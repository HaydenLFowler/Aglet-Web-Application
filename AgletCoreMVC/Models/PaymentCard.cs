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
    [StringLength(30, ErrorMessage = "Please Enter a vaild card number"), DisplayName("Card Numnber")]
    public string CardName { get; set; }

    [Required]
    [StringLength(30, ErrorMessage = "Please Enter a valid Card number"), DisplayName("Card Numnber")]
    public string CardNumber { get; set;}

    
	//public int CustomerID;

   [Required, Range(200,900)]
   [StringLength(30, ErrorMessage = "Please Enter a valid Card number"), DisplayName("Card Numnber")]
        public int SecurityCode {get; set;}

    
    [Required, Range(1,12)]
        [StringLength(30, ErrorMessage = "Please Enter a valid Card number"), DisplayName("Card Numnber")]
        public int ExpiryMonth {get; set;}

    [Required, Range(2019, 2029)]
        [StringLength(30, ErrorMessage = "Please Enter a valid Card number"), DisplayName("Card Numnber")]

        public int ExpiryYear { get; set; }

        // Navigation
        //public virtual User UserID { get; set; }


    }
}
