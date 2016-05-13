using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace move_pic
{
    class pic
    {
        public string Name;
        public Form forma;
        public PictureBox picbox;
        public int x, y;
        public enum Direction
        { Right, Left, Up, Down, None };
        Direction direction=Direction.None;
        ////
        public void RotatePicture(PictureBox pictureBox)
        {
            Image flipImage = pictureBox.Image;
            flipImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox.Image = flipImage;
        }
        ///      
        public void gopict(PictureBox pictureBox, Direction direction = Direction.None, int shag1 = 0)
        {
            if (pictureBox.Left <= 0) { direction = Direction.Right; }
            
            if (pictureBox.Left >= forma.Size.Width - pictureBox.Width) { direction = Direction.Left; }
            if (pictureBox.Top <= 0) { direction = Direction.Down; }
            if (pictureBox.Top >= forma.Size.Height - pictureBox.Height) { direction = Direction.Up; }
            switch (direction)
            {
                case Direction.Right: if (x < 0) RotatePicture(pictureBox); x = shag1; break;
                case Direction.Left: if (x > 0) RotatePicture(pictureBox); x = -shag1; break;
                case Direction.Up: y = -shag1; break;
                case Direction.Down: y = shag1; break;
                case Direction.None: break;
            }
            pictureBox.Left += x; pictureBox.Top += y;
        }

        ///
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pic a1=new pic();
            a1.Name = "asd";
            a1.picbox = pictureBox1;
            a1.forma = this;
            
        }
    }
}
