using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   
   
        class Ellipse : IPictureElement            // Nu har interfacet ärvts. Interfaceat är IPictureElement.
        {
            public int X1 { get; set; }         // Det här är properties, inte variabler. 
            public int Y1 { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
            public Ellipse(int x1, int y1, int width, int height)
            {
                this.X1 = x1; this.Y1 = y1; this.Width = width; this.Height = height;
            }
            public void Draw(System.Drawing.Graphics g)
            {
                g.DrawEllipse(System.Drawing.Pens.Black, X1, Y1, Width, Height);
            }


        
    }
}
