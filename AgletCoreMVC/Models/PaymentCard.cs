using System;
/// <summary>
/// When placing an order the user must provide payment information,
/// this can apply to any staff that decide to also be a customer as well.
/// Joe
/// </summary>
///
public class PaymentCard {
	public int PaymentCardID;
	public int CardNumber;
	public int CustomerID;
	public int SecurityCode;
	public string ExpiryDate;

	private User customer_needs_payment_card_before_order2;

}
