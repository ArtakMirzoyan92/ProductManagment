using System;
using System.Collections.Generic;

namespace DataAccessLayer.EntityModels;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public decimal? Price { get; set; }

    public bool? Available { get; set; }

    public string? Description { get; set; }

    public DateTime? DateCreated { get; set; }
}
