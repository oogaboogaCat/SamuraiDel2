using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BattleEvent
    {
        public int Id { get; set; }
        public int Order {  get; set; }
        public string Summary { get; set; }

        public int BattleLogId { get; set; }
        public BattleLog BattleLog { get; set; }
    }
}
