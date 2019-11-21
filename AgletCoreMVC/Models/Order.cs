using System;
using System.Collections.Generic;
/// <summary>
/// The order retrieves the relevant information on the customer and 
/// their delivery details based on their user ID.
/// - Conor
/// </summary>
namespace AgletCoreMVC.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }
        public string SubTotal { get; set; }

        public virtual ICollection<Item> Item {get; set;}
        public virtual User UserID { get; set; }

    }
}
