using DesignPatternBase;
using TemplateMethodPattern.ConcreteClass;

namespace TemplateMethodPattern
{
    public class TemplateMethodExample : IDesignPatternClient
    {
        public string Name => "Template method example";
        public void Main()
        {
            var bread = new Bread();
            bread.Make();
            var cake = new Cake();
            cake.Make();
            var muffin = new Muffin();
            muffin.Make();
        }
    }
}