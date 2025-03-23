using AShape;
using ICRenderer;

namespace CTriangle
{
    public class Triangle : Shape
    {
        public Triangle(IRenderer renderer) : base(renderer)
        {
        }

        public override string Draw()
        {
            return renderer.Render("Triangle");
        }
    }
}
