using System;
using System.Collections.Generic;
/// <summary>
/// Conor
/// </summary>
public class Lace {
    public int LaceID{get; set;}
	public string Colour { get; set; }
    public string Print { get; set; }
    public string Brand { get; set; }
    public double Length { get; set; }
    public string Image { get; set; }
    public string Description { get; set; }

    private ICollection<Item> Item { get; set; }
}
