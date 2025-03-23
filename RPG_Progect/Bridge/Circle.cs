using AShape;
using ICRenderer;

namespace CCircle
{
    public class Circle : Shape
    {
        public Circle(IRenderer renderer) : base(renderer)
        {
        }

        public override string Draw()
        {
            return renderer.Render("Circle");
        }
    }
}
