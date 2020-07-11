using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VexRemastered
{
    class Button
    {
        void ButtonDraw(Graphics g, String title, Font font, Brush brush, float x, float y)
        {
            g.DrawString(title, font, brush, x , y);
        }

        void ButtonSelect()
        {

        }

    }
}
