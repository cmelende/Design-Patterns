using System;

namespace InterpreterPattern.DateInterpreter.Context
{
    public class Context
    {
        public Context(DateTime date)
        {
            Date = date;
        }

        public string Expression { get; set; }
        public DateTime Date { get; set; }
    }
}