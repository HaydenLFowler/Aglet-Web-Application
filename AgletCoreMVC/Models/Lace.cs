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

        [Required]
        public Colours Colour { get; set; }

        // The users text for printing on the lace
        [StringLength(20, ErrorMessage = "Your print can't exceed 20 characters")]
        public string Print { get; set; }

        [Required]
        public Brands Brand { get; set; }

        [Required]
        [Range(5, 50)]
        public int Length { get; set; } //in mm

        [Required]
        public string ImageURL { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }


        [Required]
        [Range(0, 9999.99)]
        public decimal Price { get; set; }

        // Navigation
        //public virtual ICollection<Item> Item { get; set; }
    }

    public enum Colours
    {
        White,
        Black,
        Green,
        Blue,
        Red,
        Yellow,
        Pink,
        Grey,
        Cyan,
        Purple
    }

    public enum Brands
    {
        Adidas,
        Nike,
        UnderArmour,
        Puma,
        Fila,
        Champion,
        Ellesse,
        Jordan,
        Kappa,
        Lacoste,
        Reebok
    }

    
}
