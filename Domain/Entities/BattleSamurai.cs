using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BattleSamurai
    {
        public int BattleId { get; set; }
        public Battle Battle { get; set; }
        public int SamuraiId { get; set; }
        public Samurai Samurai { get; set; }
    }
}
