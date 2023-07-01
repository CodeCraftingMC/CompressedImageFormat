using CIF.Lib;

namespace CIF.Viewer
{
    public partial class Viewer : Form
    {
        public Viewer()
        {
            InitializeComponent();
        }

        public void NewFile()
        {
            
        }

        private void Viewer_Load(object sender, EventArgs e)
        {
            NewFile();
        }
    }
}