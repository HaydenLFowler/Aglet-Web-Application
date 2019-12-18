using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        [StringLength(30, ErrorMessage = "Street Address must be filled in."), DisplayName("Street")]
        public string StreetAddress { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Town must be filled in.")]
        public string Town { get; set; }
        [Required (ErrorMessage = "Can not be left blank.")]
        public Countries Country { get; set; }

        [Required]
        [RegularExpression(@"^(?i)([A-PR-UWYZ](([0-9](([0-9]|[A-HJKSTUW])?)?)|([A-HK-Y][0-9]([0-9]|[ABEHMNPRVWXY])?)) [0-9][ABD-HJLNP-UW-Z]{2})|GIR 0AA$", 
            ErrorMessage = "Enter a valid Postcode")]
        [DataType(DataType.PostalCode)] 
        public string PostCode { get; set; }

            // Navigation
        //public virtual User UserID { get; set; }

    }

    public enum Countries
    {
        GB,
        US,
        IT,
        FR,
        CN,
        DE,

    }
}
