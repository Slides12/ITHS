﻿using System;
using System.Collections.Generic;

namespace L008_DataGrid_and_TreeView;

public partial class Genre
{
    public int GenreId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Track> Tracks { get; set; } = new List<Track>();
}
