using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Picture pic;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pic = new Picture();
            pic.Add(new Ellipse(20, 20, 200, 200));
            pic.Add(new Line(20, 110, 220, 110));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            pic.Draw(e.Graphics);
        }
        
    }
}
