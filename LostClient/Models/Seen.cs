using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostClient.Models
{
    public class Seen
    {
        public int Id { get; set; }
        public virtual Poteryashka Who { get; set; }
        public string Where { get; set; }
        public DateTime When { get; set; }
    }
}
