namespace ConsoleApp1
{
    public class Card
    {
        public enum Suite
        {
            Heart = 0,
            Club = 1,
            Diamond = 2,
            Spade = 3
        }
        
        public enum Rank
        {
            Two = 0,
            Three = 1,
            Four = 2,
            Five = 3,
            Six = 4,
            Seven = 5,
            Eight = 6,
            Nine = 7,
            Ten = 8,
            Jack = 9,
            Queen = 10,
            King = 11,
            Ace = 12
        }

        public Rank rank;
        public Suite suite;

        public static bool operator <(Card a, Card b)
        {
            return a.rank < b.rank;
        }
        
        public static bool operator >(Card a, Card b)
        {
            return a.rank > b.rank;
        }
        
    }
}