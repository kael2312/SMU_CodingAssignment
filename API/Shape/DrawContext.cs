using Shape.Interfaces;

namespace Shape
{
    public class DrawContext
    {
        private IDrawInterface _drawInterface;

        public void SetDrawType(IDrawInterface drawInterface)
        {
            _drawInterface = drawInterface;
        }

        public string Draw(int size, char character = '*')
        {
            return _drawInterface.Draw(size, character);
        }
    }
}
