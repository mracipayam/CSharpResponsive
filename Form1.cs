using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScadaDeneme
{
    public partial class Form1 : Form
    {
        private Size formOriginalSize;
        private Rectangle textBox1OriginalRect;
        private Rectangle btn1OriginalRect;
        private Rectangle btn2OriginalRect;
        private Rectangle btn3OriginalRect;
        private Rectangle btn4OriginalRect;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formOriginalSize = this.Size;

            textBox1OriginalRect = new Rectangle(textBox1.Location.X, textBox1.Location.Y, textBox1.Width, textBox1.Height);
            btn1OriginalRect = new Rectangle(btn1.Location.X, btn1.Location.Y, btn1.Width, btn1.Height);
            btn2OriginalRect = new Rectangle(btn2.Location.X, btn2.Location.Y, btn2.Width, btn2.Height);
            btn3OriginalRect = new Rectangle(btn3.Location.X, btn3.Location.Y, btn3.Width, btn3.Height);
            btn4OriginalRect = new Rectangle(btn4.Location.X, btn4.Location.Y, btn4.Width, btn4.Height);
        }

        private void resizeChildrenControls()
        {
            resizeControl(textBox1OriginalRect, textBox1);
            resizeControl(btn1OriginalRect, btn1);
            resizeControl(btn2OriginalRect, btn2);
            resizeControl(btn3OriginalRect, btn3);
            resizeControl(btn4OriginalRect, btn4);

        }

        private void resizeControl(Rectangle originalControlRect,Control control)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);

            int newX = (int)(originalControlRect.X * xRatio);
            int newY = (int)(originalControlRect.Y * yRatio);
            int newWidth = (int)(originalControlRect.Width * xRatio);
            int newHeight = (int)(originalControlRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
        }
    }
}
