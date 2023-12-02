using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Sitat
    {
        public int Id { get; set; }
        public string Text { get; set; } 

        public ESitatStil? ESitatStil { get; set; }

        public int SamuraiId { get; set; }
        public Samurai Samurai { get; set; }
    }
}
