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

        List<Layer> Layers;

        public CompressedImage(int width, int height, Color backgroundColor)
        {
            Width = width;
            Height = height;
            Layers = new()
            {
                new(width, height, backgroundColor)
            };
        }

        public CompressedImage(byte[] rawData)
        {

        }

        public byte[] Compress()
        {

        }
    }
}