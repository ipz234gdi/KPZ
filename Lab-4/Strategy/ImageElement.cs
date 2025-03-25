using ICImageLoader;

namespace CImageElement
{
    public class ImageElement
    {
        private string _href;
        private IImageLoader _loader;

        public ImageElement(string href, IImageLoader loader)
        {
            _href = href;
            _loader = loader;
        }

        public void Display()
        {
            Console.WriteLine($"Rendering <img src=\"{_href}\" />");
            _loader.LoadImage(_href);
        }

        public void SetLoader(IImageLoader loader)
        {
            _loader = loader;
        }
    }

}