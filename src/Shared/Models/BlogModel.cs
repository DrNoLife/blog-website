﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models;

public class BlogModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Abstract { get; set; }
    public string Blog { get; set; }
    public DateTime DateCreated { get; set; }
    public string Author { get; set; }
}
