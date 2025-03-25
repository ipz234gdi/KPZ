using CSupportHandler;

namespace CLevel3Support
{
    public class Level3Support : SupportHandler
    {
        protected override bool CanHandle(string issue)
        {
            return issue.ToLowerInvariant().Contains("app") || issue.ToLowerInvariant().Contains("application");
        }

        protected override void Process(string issue)
        {
            Console.WriteLine("Level 3: Assisting with the mobile application.");
        }
    }
}