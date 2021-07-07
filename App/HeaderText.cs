using System;

namespace App
{
    public class HeaderText
    {
        private readonly char _fillerChar;
        private readonly string _text;
        private Action _action;
        private readonly int _fillerAmount = 10;

        public HeaderText(char fillerChar, string text)
        {
            _fillerChar = fillerChar;
            _text = text;
        }

        public void Write()
        {
            Console.WriteLine($"{_text.PadBoth(_fillerAmount, _fillerChar)}");
            _action?.Invoke();
            Console.WriteLine(new string(_fillerChar, _text.Length + _fillerAmount * 2));
        }

        public HeaderText RunInBetween(Action action)
        {
            _action = action;
            return this;
        }
    }
}