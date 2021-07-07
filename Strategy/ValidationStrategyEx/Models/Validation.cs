using System;
using System.Collections.Generic;

namespace Strategy.ValidationStrategyEx.Models
{
    public class Validation
    {
        private readonly IList<Tuple<string, string>> _errorMessages = new List<Tuple<string, string>>();

        public void AddError(string property, string message)
        {
            _errorMessages.Add(new Tuple<string, string>(property, message));
        }
    }
}