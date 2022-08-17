using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models;

public class CommentModel
{
    public int Id { get; set; }
    public string Comment { get; set; }
    public string Author { get; set; }
    public DateTime DateCreated { get; set; }
}
