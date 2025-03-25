using ICImageLoader;

namespace CFileImageLoader
{
    public class FileImageLoader : IImageLoader
    {
        public void LoadImage(string href)
        {
            Console.WriteLine($"[File] Loading image from local path: {href}");
        }
    }

}