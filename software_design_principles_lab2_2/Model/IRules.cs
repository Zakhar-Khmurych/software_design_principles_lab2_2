using System.Collections.Generic;

namespace software_design_principles_lab2_2.Model
{
    public interface IRules
    {
        bool WinCondition(Grid current_grid); 
        List<Cell> AvailableMoves(Grid current_grid, Player whose_turn);
    }
}