using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Picture : List<IPictureElement>
    {
        public void Draw(System.Drawing.Graphics g)     
        {
            foreach (IPictureElement p in this)
                p.Draw(g);
        }
    }
}
