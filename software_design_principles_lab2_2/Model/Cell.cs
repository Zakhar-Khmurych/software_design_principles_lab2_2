namespace software_design_principles_lab2_2.Model
{
    public class Cell
    {
        public Player Occupier { get; set; }

        public Cell()
        {
            Occupier = null;
        }

        public void MarkBy(Player player)
        {
            Occupier = player;
        }
    }
}