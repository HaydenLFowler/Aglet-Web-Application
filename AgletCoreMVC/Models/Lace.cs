using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
/// <summary>
/// Conor
/// </summary>

namespace AgletCoreMVC.Models
{
    public class Lace
    {
        public int LaceID { get; set; }
        public string Colour { get; set; }
        public string Print { get; set; }
        public string Brand { get; set; }
        public double Length { get; set; }
        public string Image { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }


            // Navigation
        public virtual ICollection<Item> Item { get; set; }
    }
}
