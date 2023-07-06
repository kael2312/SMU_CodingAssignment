using System.ComponentModel.DataAnnotations;

namespace Shape.Models
{
    public class DrawRequestModel 
    {
        public string Shape { get; set; }

        public char? Char { get; set; }

        [Range(0, 100)]
        public int Size { get; set; }

    }
}
