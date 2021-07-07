using System;
using MementoPattern.Memento;

namespace MementoPattern.Originator
{
    public class VideoGameCharacter

    {
        public int Level { get; set; }

        // Gets or sets name
        public string Name { get; set; }

        public int Gold { get; set; }

        public CharacterMemento SaveMemento()
        {
            return new CharacterMemento(Name, Gold, Level);
        }

        public void RestoreMemento(CharacterMemento memento)
        {
            Name = memento.Name;
            Gold = memento.Gold;
            Level = memento.Level;
        }

        public void PrintStats()
        {
            Console.WriteLine("------Character stats------");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Gold: {Gold}");
        }
    }
}