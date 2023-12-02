using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BattleLog
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int BattleId { get; set; }
        public Battle? Battle { get; set; }

        public ICollection<BattleEvent> BattleEvents { get; set; }
    }
}
