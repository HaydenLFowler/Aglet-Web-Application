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

        public Colours Colour { get; set; }

        // The users text for printing on the lace
        public string Print { get; set; }

        public Brands Brand { get; set; }

        [Range(5, 50)]
        public int Length { get; set; }

        public string ImageURL { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }


            // Navigation
        //public virtual ICollection<Item> Item { get; set; }
    }

    public enum Colours
    {
        White,
        Black,
        Green
    }

    public enum Brands
    {
        Addidas,
        Nike,
        UnderArmour
    }

    
}
