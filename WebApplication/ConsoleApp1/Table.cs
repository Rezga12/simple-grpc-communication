using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Table
    {
        private List<Card> CommonCards = new List<Card>();

        public Table()
        {    
            var a = new Card()
            {
                suite = Card.Suite.Club,
                rank = Card.Rank.Ace,
            };
            
            CommonCards.Add(a);
            CommonCards.Add(a);
            CommonCards.Add(a);
            CommonCards.Add(a);
            CommonCards.Add(a);
            
            
            CommonCards.Sort();
            
           // CommonCards.TakeWhile((card,index) => )
        }
    }
}