using System;
/// <summary>
/// The order retrieves the relevant information on the customer and 
/// their delivery details based on their user ID.
/// - Conor Bailey
/// </summary>
public class Order {
	public int OrderID;
	public string Date;
	public string Status;
	public string SubTotal;

	private Item[] item_is_put_into_order2;
	private User customer_places_order2;

}
