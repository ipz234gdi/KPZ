using ICRenderer;

namespace CVectorRenderer
{
    public class VectorRenderer : IRenderer
    {
        public string Render(string shapeName)
        {
            return($"Drawing {shapeName} as vectors");
        }
    }
}