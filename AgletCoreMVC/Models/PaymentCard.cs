using System;
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
	public string PaymentCardID;
	public int CardNumber { get; set;}
	public int CustomerID;
	public int SecurityCode {get; set;}
	public string ExpiryDate {get; set;}

	public virtual User UserID;


}
}
