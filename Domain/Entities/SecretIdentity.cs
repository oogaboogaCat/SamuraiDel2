using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SecretIdentity
    {
        public int Id { get; set; }
        public string RealName { get; set; }

        public int SamuraiId { get; set; }
        public Samurai samurai { get; set; }
    }
}
