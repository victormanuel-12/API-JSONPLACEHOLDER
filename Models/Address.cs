using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PC3.Models
{
  public class Address
  {
    public string Street { get; set; }
    public string Suite { get; set; }
    public string City { get; set; }
    public string Zipcode { get; set; }
    public Geo Geo { get; set; }
  }
}