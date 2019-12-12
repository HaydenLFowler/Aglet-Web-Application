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

        public OrderStatus Status { get; set; }


        public string SubTotal { get; set; }


        // Navigation
        public virtual ICollection<Item> Item {get; set;}

        public virtual User UserID { get; set; }

    }

    public enum OrderStatus
    {
        received,
        delivered,
        intransit,
        canceled
    }
}
