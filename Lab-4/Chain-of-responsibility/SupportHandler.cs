using ICSupportHandler;

namespace CSupportHandler
{
    public abstract class SupportHandler : ISupportHandler
    {
        protected ISupportHandler next = null!;

        public void SetNext(ISupportHandler nextHandler)
        {
            next = nextHandler;
        }

        public bool Handle(string issue)
        {
            if (CanHandle(issue))
            {
                Process(issue);
                return true;
            }

            if (next != null)
                return next.Handle(issue);

            Console.WriteLine("Could not find a solution. Please try again.\n");
            return false;
        }

        protected abstract bool CanHandle(string issue);
        protected abstract void Process(string issue);
    }
}