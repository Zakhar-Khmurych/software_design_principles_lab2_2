using System.CodeDom.Compiler;
using software_design_principles_lab2_2.Model;

namespace othello
{
    public class SessionTwoPlayers
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Grid CurrentGrid { get; set; }
        public History SessionHistory { get; set; }


        public SessionTwoPlayers(Player p1, Player p2, Grid grid)
        {
            
        }
        
    }
}