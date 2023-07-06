using Shape.Interfaces;

namespace Shape.Implements
{
    public class DrawTriangle : IDrawInterface
    {
        public string Draw(int size, char character = '*')
        {
            string triangle = string.Empty;
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    triangle = triangle + character;
                }

                triangle = triangle + Environment.NewLine;
            }
            return triangle;
        }
    }
}
