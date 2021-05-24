using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardGame
{
    
    public class WarGameParticipant
    {
        public Hand Deck { get; set; } = new Hand();
        public Hand Reserve { get; set; } = new Hand();
        public Hand InPlay { get; set; } = new Hand();
        public Hand WarZone { get; set; } = new Hand();
    }
}
