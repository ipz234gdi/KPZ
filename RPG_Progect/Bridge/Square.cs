using AShape;
using ICRenderer;

namespace CSquare
{
    public class Square : Shape
    {
        public Square(IRenderer renderer) : base(renderer)
        {
        }

        public override string Draw()
        {
            return renderer.Render("Square");
        }
    }
}
