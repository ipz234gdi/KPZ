using CSupportHandler;

namespace CLevel1Support
{
    public class Level1Support : SupportHandler
    {
        protected override bool CanHandle(string issue)
        {
            return issue.ToLowerInvariant().Contains("internet");
        }

        protected override void Process(string issue)
        {
            Console.WriteLine("Level 1: Resolving internet connectivity issue.");
        }
    }
}