﻿namespace ConsoleApp22;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<product> Products { get; set; }
}
