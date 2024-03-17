using System.Collections.Generic;
using software_design_principles_lab2_2.Model;

namespace othello
{
    public class History
    {
        public Queue<Grid> MatchHistory;

        public History()
        {
            
        }
        
        public void Update(Grid new_turn)
        {
            MatchHistory.Enqueue(new_turn);
        }

        public Grid Cancel()
        {
            return MatchHistory.Dequeue();
        }
    }
}