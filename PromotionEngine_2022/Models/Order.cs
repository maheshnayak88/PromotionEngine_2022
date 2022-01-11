using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine_2022
{
  public class Order
  {
    public List<Item> Items { get; set; }
    public double TotalAmount { get; set; }
  }
}
