using CSupportHandler;

namespace CLevel4Support
{
    public class Level4Support : SupportHandler
    {
        protected override bool CanHandle(string issue)
        {
            return issue.ToLowerInvariant().Contains("complaint") || issue.ToLowerInvariant().Contains("manager");
        }

        protected override void Process(string issue)
        {
            Console.WriteLine("Level 4: Connecting you to a manager.");
        }
    }
}