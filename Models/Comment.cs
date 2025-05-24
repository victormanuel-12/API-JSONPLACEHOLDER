using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PC3.Models
{
  public class Comment
  {
    public int Id { get; set; }
    public int PostId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Body { get; set; }
  }
}