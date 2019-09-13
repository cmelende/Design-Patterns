using Adapter.Adaptees;
using DesignPatternBase;

namespace Adapter.Adapter
{
    //IDesignPatternClient is the 'Client Interface'
    public class ObjectClientAdapter : IDesignPatternClient
    {
        private readonly ITargetDesignPatternClient _target;

        public ObjectClientAdapter(ITargetDesignPatternClient target)
        {
            _target = target;
        }

        public string Name => _target.GetName();
        public void Main()
        {
            _target.Execute();
        }
    }
}