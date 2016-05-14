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
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 /// 
pic a1 = new pic();
pic a2 = new pic();

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "+";
        }
        class pic
        {
            public Form forma;
            public PictureBox pictureBox;
            public int x=10,shag1=10, y=10,mi;
            public enum Direction  { Right, Left, Up, Down, None };
            public Direction direction = Direction.None;
            ////
            public void RotatePicture(PictureBox pictureBox)
            {   Image flipImage = pictureBox.Image;
                flipImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pictureBox.Image = flipImage;}
            ///      
            //public void gopict(PictureBox pictureBox, Direction direction = Direction.None, int shag1 = 10)
            public void gopict(Direction direction = Direction.None)
            {
              
                mi++;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            a1.gopict();
            a2.gopict();
            label1.Text =a1.mi.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            a1.forma = a2.forma=this;
            a1.pictureBox= pictureBox1;
            a2.pictureBox  = pictureBox2;
        
        }
    }
}
