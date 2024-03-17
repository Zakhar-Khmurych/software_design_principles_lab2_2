using System.Collections.Generic;
using software_design_principles_lab2_2.Model;

namespace software_design_principles_lab2_2
{
    public class RuleSet : IRules
    {
        public bool WinCondition(Grid current_grid)
        {
            return false;
        }

        public List<Cell> AvailableMoves(Grid current_grid, Player whose_turn)
        {
            List<Cell> available = new List<Cell>();
            for (int i = 0; i < current_grid.Cells.Length; i++)
            {
                
            }

            return available;
        }
    }
}