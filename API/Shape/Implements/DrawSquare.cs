using Shape.Interfaces;
using Shape.Models;
using System.Data.Common;

namespace Shape.Implements
{
    public class DrawSquare : IDrawInterface
    {
        public string Draw(int size, char character = '*')
        {
            string square = string.Empty;
            string Result = string.Empty;
            int nxtline = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (nxtline == size)
                    {
                        square = square + Environment.NewLine;
                        nxtline = 0;
                    }
                    square = square + character;
                    nxtline = nxtline + 1;
                }
            }

            Result = square;
            return Result;
        }
    }
}
