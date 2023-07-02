using System.Drawing;
using System.Text;

namespace CIF.Lib
{
    public class CompressedImage
    {
        /* Format
         * 
         * Header:
         *  0x01, 0x10, "CIF", 0x11
         *  4 Bytes: Version
         * 
         *  4 Bytes: Width
         *  4 Bytes: Height
         * 
         *  4 Bytes: Layer Count
         * 
         *  Layer
         *  {
         *      4 Bytes: Lenght of layer
         *      4 Bytes: Width
         *      4 Bytes: Height
         *      1 Byte:  Layer Name Lenght
         *      x Bytes: Layer Name
         *      1 Byte:  Transparency
         *      4 Bytes Lenght or red values
         *      4 Bytes Lenght or green values
         *      4 Bytes Lenght or blue values
         *      4 Bytes Lenght or alpha values
         *      (
         *          1 Byte: Times same red value
         *          1 Byte: Red Value
         *      )
         *      (
         *          1 Byte: Times same green value
         *          1 Byte: Green Value
         *      )
         *      (
         *          1 Byte: Times same blue value
         *          1 Byte: Blue Value
         *      )
         *      (
         *          1 Byte: Times same alpha value
         *          1 Byte: Alpha Value
         *      )
         *  }
         */


        public int Width { get; }
        public int Height { get; }

        public List<Layer> Layers { get; private set; }

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
            Layers = new();
            byte[] data = rawData.Skip(10).ToArray();
            Width = BitConverter.ToInt32(data.Take(4).ToArray());
            data = data.Skip(4).ToArray();
            Height = BitConverter.ToInt32(data.Take(4).ToArray());
            data = data.Skip(4).ToArray();

            int layerCount = BitConverter.ToInt32(data.Take(4).ToArray());
            data = data.Skip(4).ToArray();

            for(int i = 0; i < layerCount; i++)
            {
                int layerLenght = BitConverter.ToInt32(data.Take(4).ToArray());
                data = data.Skip(4).ToArray();
                int layerWidth = BitConverter.ToInt32(data.Take(4).ToArray());
                data = data.Skip(4).ToArray();
                int layerHeight = BitConverter.ToInt32(data.Take(4).ToArray());
                data = data.Skip(4).ToArray();
                byte layerNameLenght = data.Take(1).ToArray()[0];
                data = data.Skip(1).ToArray();
                string layerName = Encoding.ASCII.GetString(data.Take(layerNameLenght).ToArray());
                data = data.Skip(layerNameLenght).ToArray();
                byte layerTransparency = data.Take(1).ToArray()[0];
                data = data.Skip(1).ToArray();
                int layerRedLenght = BitConverter.ToInt32(data.Take(4).ToArray());
                data = data.Skip(4).ToArray();
                int layerGreenLenght = BitConverter.ToInt32(data.Take(4).ToArray());
                data = data.Skip(4).ToArray();
                int layerBlueLenght = BitConverter.ToInt32(data.Take(4).ToArray());
                data = data.Skip(4).ToArray();
                int layerAlphaLenght = BitConverter.ToInt32(data.Take(4).ToArray());
                data = data.Skip(4).ToArray();

                byte[] redValues = data.Take(layerRedLenght).ToArray();
                data = data.Skip(layerRedLenght).ToArray();
                byte[] greenValues = data.Take(layerGreenLenght).ToArray();
                data = data.Skip(layerGreenLenght).ToArray();
                byte[] blueValues = data.Take(layerBlueLenght).ToArray();
                data = data.Skip(layerBlueLenght).ToArray();
                byte[] alphaValues = data.Take(layerAlphaLenght).ToArray();
                data = data.Skip(layerAlphaLenght).ToArray();
                Layer layer = new(layerWidth, layerHeight, Color.White)
                {
                    Name = layerName,
                    Settings = new() { Transparency = layerTransparency }
                };

                int idx = 0;
                for(int y = 0; y < layerHeight; y++)
                {
                    for(int x = 0; x < layerWidth; x++)
                    {
                        layer.SetPixel(x, y, Color.FromArgb(alphaValues[idx], redValues[idx], greenValues[idx], blueValues[idx]));
                        idx++;
                    }
                }

                Layers.Add(layer);
            }
        }

        public byte[] Compress()
        {
            List<byte> data = new()
            {
                0x01,
                0x10
            };
            data.AddRange(Encoding.ASCII.GetBytes("CIF"));
            data.Add(0x11);
            data.Add(0x01);
            data.AddRange(BitConverter.GetBytes(Width));
            data.AddRange(BitConverter.GetBytes(Height));
            data.AddRange(BitConverter.GetBytes(Layers.Count));

            for(int i = 0; i < Layers.Count; i++)
            {
                List<byte> layer = new();
                layer.AddRange(BitConverter.GetBytes(Layers[i].Width));
                layer.AddRange(BitConverter.GetBytes(Layers[i].Height));
                layer.Add((byte)Layers[i].Name.Length);
                layer.AddRange(Encoding.ASCII.GetBytes(Layers[i].Name));
                layer.Add(Layers[i].Settings.Transparency);

                List<byte> redValues = new();
                List<byte> greenValues = new();
                List<byte> blueValues = new();
                List<byte> alphaValues = new();

                for(int y = 0; y < Layers[i].Height; y++)
                {
                    for (int x = 0; x < Layers[i].Width; x++)
                    {
                        Color color = Layers[i].GetPixel(x, y);
                        redValues.Add((byte)(color.R + (10 - color.R % 10)));
                        greenValues.Add((byte)(color.G + (10 - color.G % 10)));
                        blueValues.Add((byte)(color.B + (10 - color.B % 10)));
                        alphaValues.Add((byte)(color.A + (10 - color.A % 10)));
                    }
                }

                layer.AddRange(Compression.Compress(redValues.ToArray()));
                layer.AddRange(Compression.Compress(greenValues.ToArray()));
                layer.AddRange(Compression.Compress(blueValues.ToArray()));
                layer.AddRange(Compression.Compress(alphaValues.ToArray()));

                data.AddRange(BitConverter.GetBytes(layer.Count));
                data.AddRange(layer);
            }

            return data.ToArray();
        }
    }
}