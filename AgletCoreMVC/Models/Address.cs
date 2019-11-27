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

        [Required]
        public string StreetAddress { get; set; }

        [Required]
        public string Region { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string PostCode { get; set; }

            // Navigation
        public virtual User UserID { get; set; }

    }
}
