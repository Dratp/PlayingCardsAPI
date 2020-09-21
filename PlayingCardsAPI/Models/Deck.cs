using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayingCardsAPI.Models
{
    public class Deck
    {
        public Card[] cards { get; set; }
        public string deck_id { get; set; }
        public bool shuffled { get; set; }
        public int remaining { get; set; }
        


    }
}
