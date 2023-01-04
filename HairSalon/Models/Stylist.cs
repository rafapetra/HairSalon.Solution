using System.Collections.Generic;

namespace ClaireSalon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string Name { get; set; }
    public string Specialty { get; set; }
    public List<Client> Clients { get; set; }
  }
}