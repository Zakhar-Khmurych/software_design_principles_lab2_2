namespace software_design_principles_lab2_2.Model
{
    public class Player
    {
        public string Name { get; }

        public Player(string username)
        {
            Name = username;
        }
    }
}