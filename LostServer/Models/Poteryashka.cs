using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostServer.Models
{
    public class Poteryashka
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string AdditionalInfo { get; set; }
        public DateTime? Lost { get; set; }
        public DateTime? Found { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public bool IsFound { get; set; }
        public virtual ICollection<Seen> Seen { get; set; }
    }
}
