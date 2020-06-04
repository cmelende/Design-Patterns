namespace StatePattern.State
{
    public abstract class ConnectionState
    {
        protected Context.Context _context;

        public void SetContext(Context.Context context)
        {
            _context = context;
        }

        public abstract void Open();

        public abstract void Close();
    }
}
