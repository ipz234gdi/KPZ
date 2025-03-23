using ICRenderer;

namespace AShape
{
    public abstract class Shape
    {
        protected IRenderer renderer;

        public Shape(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        public abstract string Draw();
    }
}