using System;
using DesignPatternBase;
using MementoPattern.Caretaker;
using MementoPattern.Originator;

namespace MementoPattern
{
    public class MementoAdventureExample : IDesignPatternClient
    {
        public string Name => "Memento example";

        public void Main()
        {

            var character = new VideoGameCharacter
            {
                Name = "Trogdor",
                Gold = 100,
                Level= 10
            };
            character.PrintStats();

            Console.WriteLine("You start in a dungeon, there are enemies and loot near by");
            Console.WriteLine("You fight through the dungeon for a while...");
            Console.WriteLine("You character goes through a dungeon and you gain 2 levels & 50 gold!");
            character.Level += 2;
            character.Gold += 50;
            character.PrintStats();

            // Store internal state
            var characterCaretaker = new CharacterCaretaker();
            characterCaretaker.Memento = character.SaveMemento();
            Console.WriteLine("Checkpoint saved...");

            Console.WriteLine("You fight some more and gain 1 level and another 20 gold");
            character.Level += 1;
            character.Gold += 20;
            character.PrintStats();

            Console.WriteLine("You died to a dragon, restoring to last checkpoint");
            // Restore saved state
            character.RestoreMemento(characterCaretaker.Memento);
            character.PrintStats();
        }
    }
}