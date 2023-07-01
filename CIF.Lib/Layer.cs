using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIF.Lib
{
    public class Layer
    {
        public int Width { get; }
        public int Height { get; }
        public string Name { get; set; }
        public LayerSettings Settings { get; set; }

        Color[,] Colors;

        public Layer(int width, int height, Color backgroundColor)
        {
            Width = width;
            Height = height;
            Colors = new Color[Width, Height];
            Settings = new();
            Name = "Unnamed Layer";

            for(int y = 0; y < Height; y++)
            {
                for(int x = 0; x < Width; x++)
                {
                    Colors[x, y] = backgroundColor;
                }
            }
        }

        public void SetPixel(int x, int y, Color color)
        {
            if (x < 0 || x >= Width)
            {
                throw new ArgumentException("Position is out of range", nameof(x));
            }

            if (y < 0 || y >= Height)
            {
                throw new ArgumentException("Position is out of range", nameof(y));
            }

            Colors[x, y] = color;
        }

        public Color GetPixel(int x, int y)
        {
            if (x < 0 || x >= Width)
            {
                throw new ArgumentException("Position is out of range", nameof(x));
            }

            if (y < 0 || y >= Height)
            {
                throw new ArgumentException("Position is out of range", nameof(y));
            }

            return Colors[x, y];
        }
    }
}
