using System.Collections.Generic;
using Prototype.Prototype;

namespace Prototype.PrototypeManager
{
    class ColorManager
    {
        private readonly Dictionary<string, IColorPrototype> _colors =
            new Dictionary<string, IColorPrototype>();

        public IColorPrototype this[string key]
        {
            get => _colors[key];
            set => _colors.Add(key, value);
        }
    }
}
