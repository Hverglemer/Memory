using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Line : IPictureElement            // Nu har interfacet ärvts. Interfaceat är IPictureElement.
    {
        public int X1 { get; set; }         // Det här är properties, inte variabler. 
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public Line(int x1, int y1, int x2, int y2)
        {
            this.X1 = x1; this.Y1 = y1; this.X2 = x2; this.Y2 = y2;
        }
        public void Draw(System.Drawing.Graphics g)
        {
            g.DrawLine(System.Drawing.Pens.Black, X1, Y1, X2, Y2);
        }


    }
}
