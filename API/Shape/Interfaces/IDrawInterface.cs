using Shape.Models;

namespace Shape.Interfaces
{
    public interface IDrawInterface
    {
        public string Draw(int size, char character = '*');
    }
}
