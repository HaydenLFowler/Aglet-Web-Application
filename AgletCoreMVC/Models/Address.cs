using System;
/// <summary>
/// Sometimes a staff member will also have to provide address information, 
/// however this is due to whether or not they choose to be a customer too. 
/// This option will be based on the IsCustomer attribute.
/// - Hayden
/// </summary>
public class Address {
	public int AddressID;
	public string StreetAddress;
	public string Region;
	public string Country;
	public string PostCode;

	private User customer_needs_address_for_order2;

}
