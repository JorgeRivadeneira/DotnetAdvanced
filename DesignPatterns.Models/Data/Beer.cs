﻿using System;
using System.Collections.Generic;

namespace DesignPatterns.Models.Data;

public partial class Beer
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Style { get; set; }

    public Guid BrandId { get; set; }

    public virtual Brand Brand { get; set; } = null!;
}
