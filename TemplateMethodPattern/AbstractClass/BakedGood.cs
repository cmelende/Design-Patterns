namespace TemplateMethodPattern.AbstractClass
{
    public abstract class BakedGood
    {
        protected abstract void DoMixIngredients();
        protected abstract void DoBake();
        protected abstract void DoSlice();
        
        public void Make()
        {
            DoMixIngredients();
            DoBake();
            DoSlice();
        }
    }
}