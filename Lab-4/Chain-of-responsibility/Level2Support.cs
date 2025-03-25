using CSupportHandler;

namespace CLevel2Support
{
    public class Level2Support : SupportHandler
    {
        protected override bool CanHandle(string issue)
        {
            return issue.ToLowerInvariant().Contains("billing") || issue.ToLowerInvariant().Contains("payment");
        }

        protected override void Process(string issue)
        {
            Console.WriteLine("Level 2: Assisting with billing or payment.");
        }
    }
}