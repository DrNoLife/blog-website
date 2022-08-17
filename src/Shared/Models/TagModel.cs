using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models;

public class TagModel
{
    public int Id { get; set; }
    public string Tag { get; set; }
    public string HexColorCode { get; set; }
    public bool IsActive { get; set; }
}
