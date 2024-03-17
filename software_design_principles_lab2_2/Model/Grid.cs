namespace software_design_principles_lab2_2.Model
{
    public class Grid
    {
        private Cell[,] cells;

        public Grid()
        { 
            cells = new Cell[8, 8]; 
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    cells[i, j] = new Cell();
                }
            }
        }

        public Cell[,] Cells
        {
            get { return cells; }
            set { cells = value; }
        }
    }
}