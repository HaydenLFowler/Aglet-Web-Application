using System;
/// <summary>
/// Sometimes a staff member will also have to provide address information, 
/// however this is due to whether or not they choose to be a customer too. 
/// This option will be based on the IsCustomer attribute.
/// - Hayden
/// </summary>

namespace AgletCoreMVC.Models
{
    public class Address
    {

        public int AddressID { get; set; }
        public string StreetAddress { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }

        public virtual User UserID { get; set; }

    }
}
