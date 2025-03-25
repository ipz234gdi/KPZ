using ICImageLoader;

namespace CNetworkImageLoader
{
    public class NetworkImageLoader : IImageLoader
    {
        public void LoadImage(string href)
        {
            Console.WriteLine($"[Network] Downloading image from: {href}");
        }
    }

}