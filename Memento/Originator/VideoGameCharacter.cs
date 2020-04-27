using System;
using MementoPattern.Memento;

namespace MementoPattern.Originator
{
    public class VideoGameCharacter

    {
        private string _name;
        private int _level;
        private int _gold;
        public int Level
        {
            get => _level;
            set
            {
                _level = value;
            }
        }

        // Gets or sets name
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        public int Gold
        {
            get => _gold;
            set
            {
                _gold = value;
            }
        }
        
        public CharacterMemento SaveMemento()
        {
            return new CharacterMemento(_name, _gold, _level);
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
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Level: {_level}");
            Console.WriteLine($"Gold: {_gold}");
        }
    }
}