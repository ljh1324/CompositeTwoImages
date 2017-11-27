using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompositeTwoImages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadSrcButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // ref: http://www.vcskicks.com/image-from-file.php
                // Image img = Image.FromFile(dialog.FileName)

                // ref: https://stackoverflow.com/questions/2940558/load-a-bitmap-from-file-in-rgb-format-without-alpha
                Bitmap bitmap = new Bitmap(dialog.FileName);

                srcPictureBox.Image = bitmap;

                // ref: https://stackoverflow.com/questions/4710145/how-can-i-get-scrollbars-on-picturebox
                srcPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        private void loadSubButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // ref: http://www.vcskicks.com/image-from-file.php
                // Image img = Image.FromFile(dialog.FileName)

                // ref: https://stackoverflow.com/questions/2940558/load-a-bitmap-from-file-in-rgb-format-without-alpha
                Bitmap bitmap = new Bitmap(dialog.FileName);

                subPictureBox.Image = bitmap;

                // ref: https://stackoverflow.com/questions/4710145/how-can-i-get-scrollbars-on-picturebox
                subPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        private Bitmap compositeImage(Bitmap src, Bitmap sub, int deltaX, int deltaY)
        {
            Bitmap composite = src.Clone(new Rectangle(0, 0, src.Width, src.Height), src.PixelFormat);
            Color background = Color.White;

            int theta = 50;

            for (int y = 0; y < sub.Height; ++y)
                for (int x = 0; x < sub.Width; ++x)
                {
                    Color color = sub.GetPixel(x, y);
                    
                    if (!(Math.Abs(background.R - color.R) <= theta && Math.Abs(background.G - color.G) <= theta
                                       && Math.Abs(background.B - color.B) <= theta))  // color가 background가 아닐 경우
                    {
                        composite.SetPixel(deltaX + x, deltaY + y, Color.White);
                    }
                }
            return composite;
        }

        private void compositeButton_Click(object sender, EventArgs e)
        {
            Bitmap src = (Bitmap)srcPictureBox.Image;
            Bitmap sub = (Bitmap)subPictureBox.Image;

            Bitmap composite = compositeImage(src, sub, 0, 0);

            resultPictureBox.Image = composite;
            resultPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;

            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                composite.Save(dialog.FileName);
            }
        }
    }
}
