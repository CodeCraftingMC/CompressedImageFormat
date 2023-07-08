using CIF.Lib;

namespace CIF.Viewer
{
    public partial class Viewer : Form
    {

        public CompressedImage LoadedImage { get; set; }
        public List<Bitmap> UncompressedLayers { get; set; }

        public Viewer()
        {
            LoadedImage = new(800, 600, Color.White);
            UncompressedLayers = new();
            for(int i = 0; i < LoadedImage.Layers.Count; i++)
            {
                Bitmap bmp = new(LoadedImage.Width, LoadedImage.Height);

                for(int y = 0; y < bmp.Height; y++)
                {
                    for(int x = 0; x < bmp.Width; x++)
                    {
                        bmp.SetPixel(x, y, LoadedImage.Layers[i].GetPixel(x, y));
                    }
                }
                UncompressedLayers.Add(bmp);
            }

            InitializeComponent();
        }

        public static Bitmap MergeBitmaps(Bitmap bmp1, Bitmap bmp2)
        {
            Bitmap result = new(Math.Max(bmp1.Width, bmp2.Width),
                             Math.Max(bmp1.Height, bmp2.Height));
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp2, Point.Empty);
                g.DrawImage(bmp1, Point.Empty);
            }
            return result;
        }

        public void NewFile()
        {
            NewFileDialog newFileDialog = new();
            if (newFileDialog.ShowDialog() != DialogResult.OK) return;
            LoadedImage = new(newFileDialog.ImageWidth, newFileDialog.ImageHeight, newFileDialog.ImageBackColor);
        }

        private void Viewer_Load(object sender, EventArgs e)
        {

        }

        private void NewTSMI_Click(object sender, EventArgs e)
        {
            NewFile();
        }
    }
}