using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIF.Viewer
{
    public partial class NewFileDialog : Form
    {
        public int ImageWidth { get; private set; } = 1;
        public int ImageHeight { get; private set; } = 1;
        public Color ImageBackColor { get; private set; } = Color.White;
        public NewFileDialog()
        {
            InitializeComponent();
        }

        private void ColorBtn_Click(object sender, EventArgs e)
        {
            if(BackColorDialog.ShowDialog() != DialogResult.OK) return;

            ColorBtn.BackColor = BackColorDialog.Color;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            WidthNUD.Validate();
            HeightNUD.Validate();

            ImageWidth = (int)WidthNUD.Value;
            ImageHeight = (int)HeightNUD.Value;
            ImageBackColor = BackColorDialog.Color;
        }
    }
}
