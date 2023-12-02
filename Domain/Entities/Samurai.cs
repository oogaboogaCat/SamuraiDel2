using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Samurai
    {
        public int Id { get; set; } 
        public string Name { get; set; } = string.Empty; 

        public EHairStyle SamuraiHair {  get; set; } 

        public Sitat sitat { get; set; } 

        public SecretIdentity SecretIdentity { get; set; }
        public BattleSamurai BattleSamurai { get; set; }

    }
}
