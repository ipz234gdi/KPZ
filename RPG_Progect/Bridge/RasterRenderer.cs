using ICRenderer;

namespace CRasterRenderer
{
    public class RasterRenderer : IRenderer
    {
        public string Render(string shapeName)
        {
            return($"Drawing {shapeName} as pixels");
        }
    }
}