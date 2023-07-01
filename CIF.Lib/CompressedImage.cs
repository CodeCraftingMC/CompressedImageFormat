using System.Drawing;

namespace CIF.Lib
{
    public class CompressedImage
    {
        /* Format
         * 
         * Header:
         *  0x01, 0x10, "CIF", 0x11
         * 
         * 4 Bytes: Width
         * 4 Bytes: Height
         * 
         * 
         */


        public int Width { get; }
        public int Height { get; }

        Color[,] Colors;

        public CompressedImage(int width, int height, Color backgroundColor)
        {
            Width = width;
            Height = height;
            Colors = new Color[Width, Height];

            for(int y = 0; y < Height; y++)
            {
                for(int x = 0; x < Width; x++)
                {
                    Colors[x, y] = backgroundColor;
                }
            }
        }

        public byte[] Compress()
        {

        }

        public static CompressedImage Decompress(byte[] rawData)
        {

        }
    }
}