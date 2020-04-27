namespace MementoPattern.Memento
{
    public class CharacterMemento
    {
        public CharacterMemento(string name, int gold, int level)
        {
            Name = name;
            Gold = gold;
            Level= level;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public int Gold { get; set; }
    }
}