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
    /// <summary>
    /// PaymentCardID has been changed from string to int
    /// CardNumber has been changed from long to string
    /// int cannot have StringLength, just Range
    /// </summary>
    public class PaymentCard 
    {
	    public int PaymentCardID { get; set; }

        // Customers name
        [Required]
        [StringLength(30, ErrorMessage = "Please Enter a valid name on the card"), DisplayName("Card Name")]
        public string CardName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 16, ErrorMessage = "Please Enter a 16 digit valid Card number"), DisplayName("Card Number")]
        public string CardNumber { get; set;}
 
        [Required, Range(100,999)]
        [DisplayName("Security Code")]
         public int SecurityCode {get; set;}

        [Required, Range(1,12)]
        [DisplayName("Exipry Month")]
        public int ExpiryMonth {get; set;}

        [Required, Range(2019, 2029)]
        [DisplayName("Expiry Year")]
        public int ExpiryYear { get; set; }

    }
}
